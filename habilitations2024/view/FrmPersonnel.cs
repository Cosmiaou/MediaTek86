using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using mediatek86.controller;
using mediatek86.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace mediatek86.view
{
    public partial class FrmPersonnel : Form
    {
        private FrmHabilitationsController controller;
        Personnel personnelSelectionne;
        private bool modifPerso = false;
        private bool modifAbsence = false;

        /// <summary>
        /// Constructeur de la classe, initialise les composants
        /// </summary>
        public FrmPersonnel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement du formulaire. Initialise controller, appelle les fonctions pour remplir cmbService et dgwDonnees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new FrmHabilitationsController();
            afficherTout();
            remplirCombo();
        }

        /// <summary>
        /// Rempli cmbService et cmbMotif et place son index à 0
        /// </summary>
        private void remplirCombo()
        {
            cmbMotif.Items.Add("");
            List<Motif> motifs = controller.GetLesMotifs();
            foreach (Motif motif in motifs)
            {
                cmbMotif.Items.Add(motif);
            }
            cmbMotif.SelectedIndex = 0;

            cmbService.Items.Add("");
            List<Service> liste = controller.GetLesServices();
            foreach (Service service in liste)
            {
                cmbService.Items.Add(service);
            }
            cmbService.SelectedIndex = 0;
        }

        /// <summary>
        /// Rempli dgwDonnees via GetLesDeveloppeurs() du controlleur et masque deux colonnes
        /// </summary>
        private void afficherTout()
        {
            List<Personnel> liste = controller.GetLesPerso();
            dgwDonnees.DataSource = liste;
            dgwDonnees.Columns["Idpersonnel"].Visible = false;
        }


        /// <summary>
        /// Reçoit les paramètres nécessaires et demande à modifier l'élement sélectionné dans dgwDonnees.
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="profil"></param>
        private void modifier(string prenom, string nom, string tel, string email, Service service) {
            Personnel objet = (Personnel)dgwDonnees.CurrentRow.DataBoundItem;
            grbPersonnel.Enabled = false;

            if (objet == null) { MessageBox.Show("Merci de sélectionner une ligne !"); } else
            {
                objet.Service = service;
                objet.Prenom = prenom;
                objet.Nom = nom;
                objet.Tel = tel;
                objet.Mail = email;
                controller.UpdatePerso(objet);

                grbPersonnel.Enabled = true;
                grbAjouterPerso.Text = "Ajouter un employé :";
            }
        }

        /// <summary>
        /// Vérifie si les champs du grbAjouterPerso sont vides. Si oui, return false.
        /// </summary>
        /// <returns></returns>
        private void remplissageCase()
        {
            Personnel objet = (Personnel)dgwDonnees.CurrentRow.DataBoundItem;

            txbMail.Text = objet.Mail;
            txbTel.Text = objet.Tel;
            txbNom.Text = objet.Nom;
            txbPrenom.Text = objet.Prenom;
            cmbService.SelectedIndex = objet.Service.Idservice;
        }

        /// <summary>
        /// Vérifie si les champs du grbAjouterPerso sont vides. Si oui, return false.
        /// </summary>
        /// <returns></returns>
        private bool verifierChampsPerso()
        {
            if (txbNom.Text.Equals("") || txbPrenom.Text.Equals("") || txbTel.Text.Equals("") || txbMail.Text.Equals("") || cmbService.SelectedIndex == 0) { 
                   return false; }
            else { return true;  }
        }

        /// <summary>
        /// Récupère l'objet sélectionné dans dgwDonnees et appelle controller.DelDev() pour le supprimer.
        /// Met à jour l'affichage. Si aucun objet n'est supprimé, affiche un message d'erreur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Personnel objet = (Personnel)dgwDonnees.CurrentRow.DataBoundItem;
            if (objet != null)
            {
                controller.DelPerso(objet);
                afficherTout();
            }
            else
            {
                MessageBox.Show("Merci de sélectionner une ligne");
            }
        }

        /// <summary>
        /// Change le booléen modif en true pour btnAjouterDev_Click(). Change le texte de grbAjouterDev
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierItem_Click(object sender, EventArgs e)
        {
            modifPerso = true;
            grbAjouterPerso.Text = "Modifiez un personnel :";
        }

        private void btnAjouterPerso_Click(object sender, EventArgs e)
        {
            if (verifierChampsPerso())
            {
                string prenom = txbPrenom.Text;
                string nom = txbNom.Text;
                string tel = txbTel.Text;
                string email = txbMail.Text;
                Service profil = (Service)cmbService.SelectedItem;

                if (modifPerso)
                {
                    modifier(prenom, nom, tel, email, profil);
                }
                else
                {
                    Personnel dev = new Personnel(0, nom, prenom, tel, email, profil);
                    controller.AddPerso(dev);
                }
                afficherTout();
            }
            else { MessageBox.Show("Veuillez remplir toutes les cases"); }
        }

        private void btnAnnulerPerso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txbPrenom.Text = "";
                txbNom.Text = "";
                txbTel.Text = "";
                txbMail.Text = "";
                cmbService.SelectedIndex = 0;
            }
        }

        private void afficherAbsence(Personnel objet)
        {
            List<Absence> liste = controller.GetLesAbsences(objet);
            grbAbsence.Text = "Absences de " + objet.ToString();
            dgwAbsence.DataSource = liste;
            dgwAbsence.Columns["Idabsence"].Visible = false;
        }

        private void remplirAbsence(Absence absence)
        {
            dtpDebut.Value = absence.DateDebut;
            dtpFin.Value = absence.DateFin;
            cmbMotif.SelectedIndex = absence.Motif.Idmotif;
        }

        private void modifierAbsence()
        {
            Absence objet = (Absence)dgwAbsence.CurrentRow.DataBoundItem;
            grbAbsence.Enabled = false;

            if (objet == null) { MessageBox.Show("Merci de sélectionner une ligne !"); }
            else
            {
                objet.DateDebut = dtpDebut.Value;
                objet.DateFin = dtpFin.Value;
                objet.Motif = (Motif)cmbMotif.SelectedItem;
                objet.Personnel = personnelSelectionne;

                controller.UpdateAbsence(objet);

                modifAbsence = false;
                grbAbsence.Enabled = true;
                grbModifierAbsence.Text = "Ajouter une absence :";
                afficherAbsence(personnelSelectionne);
            }
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            try
            {
                personnelSelectionne = (Personnel)dgwDonnees.CurrentRow.DataBoundItem;
                if (personnelSelectionne != null)
                {
                    afficherAbsence(personnelSelectionne);
                    tbcControl.SelectedTab = tabPage2;
                }
                else
                {
                    MessageBox.Show("Merci de sélectionner une ligne");
                }
            } catch
            {
                MessageBox.Show("Merci de sélectionner une ligne");
            }
        }

        private void dgwDonnees_MouseClick(object sender, MouseEventArgs e)
        {
            remplissageCase();
        }

        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            modifAbsence = true;
            grbModifierAbsence.Text = "Modifier une absence : ";
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            tbcControl.SelectedTab = tabPage1;
        }

        private void dgwAbsence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Absence absence = (Absence)dgwAbsence.CurrentRow.DataBoundItem;
            remplirAbsence(absence);
        }

        private void btnEnregistrerAbsence_Click(object sender, EventArgs e)
        {
            if (modifAbsence)
            {
                modifierAbsence();
            }
            else {
                DateTime datedebut = dtpDebut.Value;
                DateTime datefin = dtpFin.Value;
                Motif motif = cmbMotif.SelectedItem as Motif;

                Absence absence = new Absence(0, datedebut, datefin, motif, personnelSelectionne);

                controller.AddAbsence(absence);
                afficherAbsence(personnelSelectionne);
            }
        }

        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            Absence absence = (Absence)dgwAbsence.CurrentRow.DataBoundItem;
            if (absence != null)
            {
                controller.DelAbsence(absence);
                afficherAbsence(personnelSelectionne);
            }
            else { MessageBox.Show("Merci de choisir une absence à supprimer"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = dtpDebut.Value.ToString();
        }

        private void dgwDonnees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAbsence.Enabled = true;
        }
    }
}



