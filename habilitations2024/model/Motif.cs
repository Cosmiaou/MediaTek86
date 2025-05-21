using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    public class Motif
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle) {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// ID du motif
        /// </summary>
        public int Idmotif { get; }
        /// <summary>
        /// Libellé du motif
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
