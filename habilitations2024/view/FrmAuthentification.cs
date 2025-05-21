using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatek86.controller;
using mediatek86.model;

namespace mediatek86.view
{
    public partial class FrmAuthentification : Form
    {
        FrmAuthentificationController controller;
        int compteurErreur = 0;
        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Chargement, initialise controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAuthentification_Load(object sender, EventArgs e)
        {
            controller = new FrmAuthentificationController();
            btnConnection.Focus();
        }

        /// <summary>
        /// Lors du clic sur btnConnection, vérifie si tout les champs sont remplis. Si oui, appelle
        /// controller.ControleAuthentification() pour vérifier si le mot de passe est bon. Si oui, lance
        /// le formulaire habilitation normal. Sinon, indique un message d'erreur. Si erreur plus de 5 fois,
        /// ferme l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (txbLogin.Text.Equals("") || txbPwd.Text.Equals(""))
            {
                MessageBox.Show("Merci de remplir toutes les informations.");
            }
            else {
                string login = txbLogin.Text;
                string pwd = txbPwd.Text;

                Responsable responsable = new Responsable(login, pwd);

                if (controller.ControleAuthentification(responsable))
                {
                    FrmPersonnel frmHabilitations = new FrmPersonnel();
                    frmHabilitations.ShowDialog();
                    this.Close();
                } 
                else if (compteurErreur >= 5)
                {
                    MessageBox.Show("Veuillez réessayer plus tard.");
                    Application.Exit();
                }
                else
                {
                    compteurErreur++;
                    lblErreur.Text = "Erreur : mot de passe ou profil incorrect";
                    btnConnection.Focus();
                }
            }
        }

        private void btnProbleme_Click(object sender, EventArgs e)
        {

        }

    }
}
