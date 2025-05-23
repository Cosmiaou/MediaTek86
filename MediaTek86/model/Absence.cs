using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    /// <summary>
    /// Classe correspondant à la table Absence de la BdD
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idabsence"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        /// <param name="personnel"></param>
        public Absence(int idabsence, DateTime datedebut, DateTime datefin, Motif motif, Personnel personnel) {
            this.Idabsence = idabsence;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.Motif = motif;
            this.Personnel = personnel;
        }

        /// <summary>
        /// ID de l'absence
        /// </summary>
        public int Idabsence { get; }
        /// <summary>
        /// Date de début
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Date de fin
        /// </summary>
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Objet Motif du motif de l'absence
        /// </summary>
        public Motif Motif { get; set; }

        /// <summary>
        /// Objet Personnel du personnel lié à l'absence
        /// </summary>
        public Personnel Personnel { get; set; }

    }
}
