using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    /// <summary>
    /// Classe correspondant à la table Personnel de la BdD
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Crée un objet de type personnel
        /// </summary>
        /// <param name="idpersonnel">id du personnel, définie automatiquement dans la DB. Quand on appelle la fonction pour créer un personnel, il faut mettre "0" pour laisser le SGBDD autoincrémenter la fonction</param>
        /// <param name="nom">nom du personnel</param>
        /// <param name="prenom">prénom du personnel</param>
        /// <param name="tel">N° de téléphone du personnel</param>
        /// <param name="mail">adresse email du personnel</param>
        /// <param name="service">Objet de type service</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service) { 
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;   
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        /// <summary>
        /// Retourne l'id de l'employé. Pas modifiable
        /// </summary>
        public int Idpersonnel { get;  }
        /// <summary>
        /// Nom de l'employé
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Prenom de l'employé
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// N° de tel de l'employé
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Adresse email de l'employé
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Objet de type service associé à l'employé
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Renvoi une string contenant prenom, nom, et service, prêt à être utilisé
        /// </summary>
        /// <returns>string nom</returns>
        public override string ToString()
        {
            return this.Prenom + " " + this.Nom + " de " + this.Service;
        }
    }
}
