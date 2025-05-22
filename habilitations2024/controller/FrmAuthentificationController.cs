using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.dal;
using mediatek86.model;

namespace mediatek86.controller
{
    /// <summary>
    /// Controller de la classe d'authentification
    /// </summary>
    internal class FrmAuthentificationController
    {
        /// <summary>
        /// Initialise un profil responsable
        /// </summary>
        private readonly ResponsableAccess Access;

        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmAuthentificationController()
        {
            Access = new ResponsableAccess();
        }

        /// <summary>
        /// Appelle la fonction ControleAuthentification() de la classe ResponsableAccess pour vérifier la validité du mot de passe
        /// </summary>
        /// <param name="admin">Objet de type Admin</param>
        /// <returns>TRUE or FALSE</returns>
        public bool ControleAuthentification(Responsable admin)
        {
            bool reponse = Access.ControleAuthentification(admin);
            return reponse;
        }

    }
}
