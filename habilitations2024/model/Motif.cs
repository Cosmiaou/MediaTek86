using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    /// <summary>
    /// Classe correspondant à la table Motif de la BdD
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idmotif">id du motif entre 1 et 4 tel que défini dans la db</param>
        /// <param name="libelle">libelle du motif</param>
        public Motif(int idmotif, string libelle) {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Récupère l'ID du motif
        /// </summary>
        public int Idmotif { get; }
        /// <summary>
        /// Récupère le libellé du motif
        /// </summary>
        public string Libelle { get; }

        /// <summary>
        /// Redéfinie ToString pour toujours renvoyer le nom du motif quand appelé
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
