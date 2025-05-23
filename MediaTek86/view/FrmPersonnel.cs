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
using System.Diagnostics.Eventing.Reader;


namespace mediatek86.view
{
    /// <summary>
    /// Classe du form contenant deux onglets : Personnels avec la liste du personnels, et Absence avec la liste des absences
    /// </summary>
    public partial class FrmPersonnel : Form
    {
        private FrmPersonnelsController controller;
        /// <summary>
        /// Objet de type Personnel représentant le personnel sélectionné dans dgwDonnees, afin d'être utilisé dans plusieurs fonctions de l'onglet Absence
        /// </summary>
        Personnel personnelSelectionne;
        /// <summary>
        /// Booléen de contrôle afin de vérifier si nous en sommes modification ou en ajout du personnel
        /// </summary>
        private bool modifPerso = false;
        /// <summary>
        /// Booléen de contrôle afin de vérifier si nous en sommes modification ou en ajout d'une absence
        /// </summary>
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
            controller = new FrmPersonnelsController();
            afficherTout();
            remplirCombo();
        }

        /// <summary>
        /// Rempli cmbService et cmbMotif et place leur index à 0
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
        /// Rempli dgwDonnees via GetLesPerso() du controlleur et masque une colonne
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
        /// <param name="service"></param>
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
        /// Vide les champs du grbAjouterPerso
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
            else { return true; }
        }

        /// <summary>
        /// Récupère l'objet sélectionné dans dgwDonnees et appelle controller.DelPerso() pour le supprimer. Met à jour l'affichage. Si aucun objet n'est sélectionné, affiche un message d'erreur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Personnel objet = (Personnel)dgwDonnees.CurrentRow.DataBoundItem;
            if (objet != null)
            {
                var result = MessageBox.Show("Êtes vous sûr de vouloir confirmer la suppression de cet item ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    controller.DelPerso(objet);
                    afficherTout();
                }
            }
            else
            {
                MessageBox.Show("Merci de sélectionner une ligne");
            }
        }

        /// <summary>
        /// Change le booléen modif en true pour btnAjouterPerso_Click(). Change le texte de grbAjouterPerso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierItem_Click(object sender, EventArgs e)
        {
            Personnel objet = (Personnel)dgwDonnees.CurrentRow.DataBoundItem;
            grbPersonnel.Enabled = false;
            grbAjouterPerso.Enabled = true;
            string name = objet.ToString();
            modifPerso = true;
            grbAjouterPerso.Text = "Modifiez " + name;

        }

        /// <summary>
        /// Appelle la vérification des informations remplies, affiche une boite de confirmation. Si oui, appelle la fonction qui enverra une demande pour créer/modifiier un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPerso_Click(object sender, EventArgs e)
        {
            if (verifierChampsPerso())
            {
                string prenom = txbPrenom.Text;
                string nom = txbNom.Text;
                string tel = txbTel.Text;
                string email = txbMail.Text;
                Service profil = (Service)cmbService.SelectedItem;

                if (MessageBox.Show("Voulez-vous vraiment confirmer ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    grbPersonnel.Enabled = true;
                    grbAjouterPerso.Enabled = false;

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
                    viderChamps();
                }
            }
            else { MessageBox.Show("Veuillez remplir toutes les cases"); }
        }

        /// <summary>
        /// Demande confirmation pour annuler les modifications en cours. Appelle la fonction viderChamps()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerPerso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                viderChamps();
                grbAjouterPerso.Enabled = false;
                grbPersonnel.Enabled = true;
            }
        }

        /// <summary>
        /// Vide les champs de grbAjouterPersonnel
        /// </summary>
        private void viderChamps()
        {
            grbAjouterPerso.Text = "Ajouter un personnel : ";
            txbPrenom.Text = "";
            txbNom.Text = "";
            txbTel.Text = "";
            txbMail.Text = "";
            cmbService.SelectedIndex = 0;
        }

        /// <summary>
        /// Permet d'afficher les absences de l'utilisateur sélectionné. /!\ ne vérifie pas si l'utilisateur existe, peut donc causer un crash si appelée sans précaution
        /// </summary>
        /// <param name="objet"></param>
        private void afficherAbsence(Personnel objet)
        {
            List<Absence> liste = controller.GetLesAbsences(objet);
            grbAbsence.Text = "Absences de " + objet.ToString();
            dgwAbsence.DataSource = liste;
            dgwAbsence.Columns["Idabsence"].Visible = false;
        }

        /// <summary>
        /// Permet de remplir les champs de grbModifierAbsence par les infos de l'item sélectionné
        /// </summary>
        /// <param name="absence"></param>
        private void remplirAbsence(Absence absence)
        {
            dtpDebut.Value = absence.DateDebut;
            dtpFin.Value = absence.DateFin;
            cmbMotif.SelectedIndex = absence.Motif.Idmotif;
        }

        /// <summary>
        /// Crée un objet de type Absence avec les données indiquées par l'utilisateur. Les envois pour mettre à jour la BdD
        /// </summary>
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

                PasserAjoutAbsence();
                afficherAbsence(personnelSelectionne);
            }
        }

        /// <summary>
        /// Vérifie si un personnel est sélectionné. Si oui, passe sur l'onglet Absence. De fait, la vérification ne marche pas. Si aucun élement n'est sélectionné, un crash aura lieu. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// En cas de clic sur le tableau, appelle la fonction de remplissage de champs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwDonnees_MouseClick(object sender, MouseEventArgs e)
        {
            remplissageCase();
        }

        /// <summary>
        /// Appelle la fonction PasserModifAbsence()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            PasserModifAbsence();
        }

        /// <summary>
        /// Retourne sur l'onglet Personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            tbcControl.SelectedTab = tabPage1;
        }

        /// <summary>
        /// Active les boutons Supprimer et ModifierAbsence, bloqués par défaut pour éviter des crashs. Rempli les cases avec l'élément sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwAbsence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifierAbsence.Enabled = true;
            btnSupprimerAbsence.Enabled = true;
            Absence absence = (Absence)dgwAbsence.CurrentRow.DataBoundItem;
            remplirAbsence(absence);
        }

        /// <summary>
        /// Après avoir appelé les fonctions de vérifications nécessaires et demander la confirmation, , crée un objet de type Absence et l'envoi se faire ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerAbsence_Click(object sender, EventArgs e)
        {
            if (verifierAbsence())
            {
                if (MessageBox.Show("Voulez-vous confirmer les modifications ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (modifAbsence)
                    {
                        modifierAbsence();
                    }
                    else
                    {
                        DateTime datedebut = dtpDebut.Value;
                        DateTime datefin = dtpFin.Value;
                        Motif motif = cmbMotif.SelectedItem as Motif;

                        Absence absence = new Absence(0, datedebut, datefin, motif, personnelSelectionne);

                        controller.AddAbsence(absence);
                        afficherAbsence(personnelSelectionne);
                    }
                    PasserAjoutAbsence();
                }
            }
        }

        /// <summary>
        /// Charge l'objet sélectionné de type Absence depuis dgwAbsence. S'il n'est pas nul, le supprime après avoir demandé confirmation. S'il est nul, erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            Absence absence = (Absence)dgwAbsence.CurrentRow.DataBoundItem;
            if (absence != null)
            {
                var result = MessageBox.Show("Êtes vous sûr de vouloir confirmer la suppression de cet item ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    afficherAbsence(personnelSelectionne);
                    dgwAbsence_CellContentClick(null, null);
                }
            }
            else { MessageBox.Show("Merci de choisir une absence à supprimer"); }
        }

        /// <summary>
        /// Active 3 boutons désactivés pour empêcher un possible crash dans le cas où aucune case n'est sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwDonnees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAbsence.Enabled = true;
            btnModifierItem.Enabled = true;
            btnSupprimer.Enabled = true;
        }

        /// <summary>
        /// Ouvre la possibilité d'ajouter un personnel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            viderChamps();
            grbAjouterPerso.Enabled = true;
            grbAjouterPerso.Text = "Ajouter un personnel : ";
        }

        /// <summary>
        /// Réinitialise les champs de grbModificationAbsence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            cmbMotif.SelectedIndex = 0;
            dtpDebut.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;

            PasserAjoutAbsence();
        }

        /// <summary>
        /// Change l'apparence du second onglet de l'app pour passer en mode modification. Passe modifAbsence en false
        /// </summary>
        private void PasserAjoutAbsence()
        {
            grbModifierAbsence.Text = "Ajouter une absence :";
            modifAbsence = false;
        }

        /// <summary>
        /// Change l'apparence du second onglet de l'app pour passer en mode modification. Passe modifAbsence en true
        /// </summary>
        private void PasserModifAbsence()
        {
            grbModifierAbsence.Text = "Modifier une absence :";
            modifAbsence = true;
        }

        /// <summary>
        /// Booléen qui vérifie si tout les champs pour une modification ou un ajout d'absence sont valide. Ne fais qu'appeler les fonctions et afficher un message d'erreur.
        /// </summary>
        /// <returns></returns>
        private bool verifierAbsence()
        {
            if (verifierChampsAbsence())
            {
                if (verifierDateExistante())
                {
                    if (verifierDate())
                    {
                        return true;
                    } else {
                        MessageBox.Show("La date de fin ne peut pas être avant la date de début.");
                        return false; }
                } else { 
                    MessageBox.Show("D'autres absences existent déjà entre ces dates. Merci de les modifier, de les supprimer, ou de changer les dates indiquées.");
                    return false;
                }
            } else {
                MessageBox.Show("Merci de remplir tout les champs.");
                return false; 
            }
        }
        /// <summary>
        /// Vérifie si les champs de grbModifierAbsence sont vide. Si non, renvoie True
        /// </summary>
        /// <returns></returns>
        private bool verifierChampsAbsence()
        {
            if (dtpFin.Value != null && dtpDebut.Value != null && cmbMotif.SelectedIndex != 0) {
                return true;
            } else  { return false; }
        }

        /// <summary>
        /// Vérifie si dtpFin est inférieur à dtpDebut. Si non, renvoie True
        /// </summary>
        /// <returns>bool</returns>
        private bool verifierDate()
        {
            if (dtpFin.Value < dtpDebut.Value) {
                return false;
            }  else { return true; }
        }

        /// <summary>
        /// Vérifie chaque absence de personnelSelectionne. Si une absence (autre que l'absence sélectionnée si c'est une modification) est déjà programmée entre les deux dates indiquées dans grbModifierAbsence, renvoie false.
        /// </summary>
        /// <returns></returns>
        private bool verifierDateExistante()
        {            
            List<Absence> absences = controller.GetLesAbsences(personnelSelectionne);
            foreach (Absence absence in absences)
            {

             if (absence.DateDebut < dtpFin.Value && absence.DateFin >= dtpDebut.Value)
             {
                    if (modifAbsence)
                    {
                        Absence absenceSelectionnee = (Absence)dgwAbsence.CurrentRow.DataBoundItem;
                        if (absence.Idabsence != absenceSelectionnee.Idabsence)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    }
            } 
            return true;
        }
    }
}



