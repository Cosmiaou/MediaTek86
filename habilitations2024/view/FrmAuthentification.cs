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
    /// <summary>
    /// Form permettant l'authentification de l'utilisateur avant l'accès aux données
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        FrmAuthentificationController controller;
        /// <summary>
        /// Compteur permettant de stocker le nombre d'erreur durant la connexion
        /// </summary>
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
        /// Lors du clic sur btnConnection, vérifie si tout les champs sont remplis. Si oui, appelle controller.ControleAuthentification() pour vérifier si le mot de passe est bon. Si oui, lance le formulaire habilitation normal. Sinon, indique un message d'erreur. Si erreur plus de 5 fois, ferme l'application
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

        /// <summary>
        /// Permettrait de rajouter dans l'avenir la possibilité de signaler un problème ou de changer le mot de passe. Affiche actuellement un message d'erreur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProbleme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonctionnalité n'est pas disponible pour le moment. \n Veuillez contacter vos responsables pour plus de renseignements.", "Erreur");
        }

        /// <summary>
        /// Affiche les crédits du logiciel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code par L. 'Cosmiaou' D. \n Logo : Réseau Trente et + \n \n MIT License\r\n\r\nCopyright (c) 2025 'Cosmiaou'\r\n\r\nPermission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the \"Software\"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:\r\n\r\nThe above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.\n THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.", "Crédits");
        }
    }
}
