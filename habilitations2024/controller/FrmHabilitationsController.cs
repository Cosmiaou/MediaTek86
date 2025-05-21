using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.dal;
using mediatek86.model;
using Mysqlx.Crud;

namespace mediatek86.controller
{
    public class FrmHabilitationsController
    {
        private readonly PersonnelAccess persoAccess;
        private readonly ServiceAccess serviceAccess;
        private readonly MotifAccess motifAccess;
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// Constructeur
        /// </summary>
        public FrmHabilitationsController()
        {
            serviceAccess = new ServiceAccess();
            persoAccess = new PersonnelAccess();
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Reçoit la liste du personnel
        /// </summary>
        /// <returns>List Developpeur</returns>
        public List<Personnel> GetLesPerso()
        {
            return persoAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Reçoit la liste des services
        /// </summary>
        /// <returns>List Service</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetItems();
        }

        /// <summary>
        /// Reçoit la liste des absences
        /// </summary>
        /// <returns>List Absence</returns>
        public List<Absence> GetLesAbsences(Personnel perso)
        {
            return absenceAccess.GetLesAbsences(perso);
        }

        /// <summary>
        /// Reçoit la liste des motifs d'absence
        /// </summary>
        /// <returns>list Motif</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetItems();
        }

        /// <summary>
        /// Appelle la fonction de suppression d'un personnel
        /// </summary>
        /// <param name="perso">Object de type Personnel</param>
        public void DelPerso (Personnel perso) {
            persoAccess.DelItem(perso);
        }

        /// <summary>
        /// Appelle la fonction d'ajout d'un personnel
        /// </summary>
        /// <param name="perso">Objet personnel</param>
        public void AddPerso (Personnel perso) {
            persoAccess.AddItem(perso);
        }

        /// <summary>
        /// Appelle la fonction de MàJ d'un personnel
        /// </summary>
        /// <param name="perso">Objet Personnel</param>
        public void UpdatePerso (Personnel perso) {
            persoAccess.UpdateItem(perso);
        }

        /// <summary>
        /// Appelle la fonction de suppression d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelItem(absence);
        }

        /// <summary>
        /// Appelle la fonction d'ajout d'une absence
        /// </summary>
        /// <param name="absence">Objet absence</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddItem(absence);
        }

        /// <summary>
        /// Appelle la fonction de MàJ d'une absence
        /// </summary>
        /// <param name="absence">Objet absence</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateItem(absence);
        }
    }
}
