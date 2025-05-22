using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    /// <summary>
    /// Classe correspondant à la table Service de la BdD
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Constructeur qui crée un service
        /// </summary>
        /// <param name="idservice">id du service, entre 1 et 3, comme indiqué dans la BDD</param>
        /// <param name="nom">nom du service, lié à un id dans la BDD</param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Retourne l'idservice
        /// </summary>
        public int Idservice { get; }
        /// <summary>
        /// Retourne le nom du service
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Redéfinie ToString pour toujours renvoyer le nom du service quand appelé
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
