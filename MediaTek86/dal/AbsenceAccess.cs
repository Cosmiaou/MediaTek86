using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatek86.model;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe d'accès aux données pour les objets de type Absence
    /// </summary>
    public class AbsenceAccess
    {
        private readonly Access access;

        /// <summary>
        /// Constructeur
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.getInstance();
        }

        /// <summary>
        /// Crée et envoie une requête SQL pour recevoir la liste des absences du personnel correspondant à l'ID indiqué.
        /// </summary>
        /// <returns>Liste des développeurs</returns>
        public List<Absence> GetLesAbsences(Personnel perso)
        {
            List<Absence> liste = new List<Absence>();
            string requete = "SELECT * FROM absence JOIN motif on absence.idmotif = motif.idmotif JOIN personnel ON absence.idpersonnel = personnel.idpersonnel JOIN service ON personnel.idservice = service.idservice WHERE absence.idpersonnel in (@idpersonnel);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@idpersonnel", perso.Idpersonnel);

            try
            {
                List<Object[]> list = access.Manager.reqSelect(requete, parameters);
                Console.WriteLine("Requête correctement exécutée");

                if (list != null && list.Count > 0)
                {
                    foreach (Object[] item in list)
                    {
                        Service service = new Service((int)item[13], (string)item[14]);
                        Personnel personnel = new Personnel((int)item[7], (string)item[8], (string)item[9], (string)item[10], (string)item[11], service);
                        Motif motif = new Motif((int)item[5], (string)item[6]);
                        Absence absence = new Absence((int)item[0], (DateTime)item[1], (DateTime)item[2], motif, personnel);
                        liste.Add(absence);
                    }
                }
                return liste;
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(("E12 : Erreur lors de l'exécution de la requête = " + ex));
                    Environment.Exit(0);
                    return liste = null;
                }
            }
        }

        /// <summary>
        /// Crée et envoie une requête de suppression selon l'id de l'objet Absence reçu
        /// </summary>
        /// <param name="absence"></param>
        public void DelItem (Absence absence) {
            string requete = "DELETE FROM absence WHERE idabsence IN (@idabsence);";
            
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@idabsence", absence.Idabsence);

            try { access.Manager.reqUpdate(requete, parameters); } catch (Exception e) { MessageBox.Show(("E13 : Erreur lors de l'exécution de la requête = " + e)); }

        }

        /// <summary>
        /// Crée et envoie une requête d'ajout grâce à l'objet absence reçu
        /// </summary>
        /// <param name="absence"></param>
        public void AddItem (Absence absence) {
            string requete = "INSERT INTO absence (idabsence, datedebut, datefin, idmotif, idpersonnel) VALUES (@idabsence, @datedebut, @datefin, @idmotif, @idpersonnel);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@idabsence", absence.Idabsence);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            parameters.Add("@idmotif", absence.Motif.Idmotif);
            parameters.Add("@idpersonnel", absence.Personnel.Idpersonnel);

            try { access.Manager.reqUpdate(requete, parameters); } catch (Exception e) { MessageBox.Show(("E14 : Erreur lors de l'exécution de la requête = ") + e); }
        }

        /// <summary>
        /// Crée et envoie une requête de mise à jour du absence envoyé, en se basant sur ses nouveaux paramètres
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateItem (Absence absence) {
            string requete = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif, idpersonnel = @idpersonnel WHERE idabsence IN (@idabsence);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@idabsence", absence.Idabsence);
            parameters.Add("@datedebut", absence.DateDebut);
            parameters.Add("@datefin", absence.DateFin);
            parameters.Add("@idmotif", absence.Motif.Idmotif);
            parameters.Add("@idpersonnel", absence.Personnel.Idpersonnel);

            try { access.Manager.reqUpdate(requete, parameters); } catch (Exception e) { MessageBox.Show(("E15 : Erreur lors de l'exécution de la requête = " + e)); }
        }
    }
}
