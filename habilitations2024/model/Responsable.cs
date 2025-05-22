using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    /// <summary>
    /// Classe correspondant à la table Responsable de la BdD. Sert exclusivement à la connexion. Aucune modification possible dans l'app en l'état.
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="login">identifiant</param>
        /// <param name="pwd">mot de passe</param>
        public Responsable(string login, string pwd) {
            this.Login = login;
            this.Pwd = pwd;
        }

        /// <summary>
        /// Récupère le login de l'admin
        /// </summary>
        public string Login { get; }
        /// <summary>
        /// Récupère le mot de passe de l'admin
        /// </summary>
        public string Pwd { get; }

    }
}
