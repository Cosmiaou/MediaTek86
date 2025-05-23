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
    /// Classe d'accès aux données pour les objets de type Personnel
    /// </summary>
    public class PersonnelAccess
    {
        private readonly Access access;

        /// <summary>
        /// Constructeur
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.getInstance();
        }

        /// <summary>
        /// Crée et envoie une requête SQL pour recevoir la liste des développeurs
        /// </summary>
        /// <returns>Liste des développeurs</returns>
        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> liste = new List<Personnel>();
            string requete = "SELECT * FROM personnel JOIN service ON personnel.idservice = service.idservice;"; 

            try
            {
                List<Object[]> list = access.Manager.reqSelect(requete);

                if (list != null && list.Count > 0)
                {
                    foreach (Object[] item in list)
                    {
                        Service service = new Service((int)item[6], (string)item[7]);
                        Personnel perso = new Personnel((int)item[0], (string)item[1], (string)item[2], (string)item[3], (string)item[4], service);
                        liste.Add(perso);
                    }
                } 
                return liste;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(("E02 : Erreur lors de l'exécution de la requête = " + ex));
                Environment.Exit(0);
                return liste = null;
            }
        }

        /// <summary>
        /// Crée et envoie une requête de suppression selon l'id de l'objet perso reçu
        /// </summary>
        /// <param name="perso"></param>
        public void DelItem (Personnel perso) {
            string requete = "DELETE FROM personnel WHERE idpersonnel IN (@idpersonnel);";
            
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@idpersonnel", perso.Idpersonnel);

            try { access.Manager.reqUpdate(requete, parameters); } catch (Exception e) { MessageBox.Show("E03 : Erreur lors de l'exécution de la requête = " + e); }

        }

        /// <summary>
        /// Crée et envoie une requête d'ajout grâce à l'objet perso reçu
        /// </summary>
        /// <param name="perso"></param>
        public void AddItem (Personnel perso) {
            string requete = "INSERT INTO personnel (idpersonnel, prenom, nom, tel, mail, idservice) VALUES (@idpersonnel, @prenom, @nom, @tel, @mail, @idservice);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@idpersonnel", perso.Idpersonnel);
            parameters.Add("@prenom", perso.Prenom);
            parameters.Add("@nom", perso.Nom);
            parameters.Add("@tel", perso.Tel);
            parameters.Add("@mail", perso.Mail);
            parameters.Add("idservice", perso.Service.Idservice);

            try { access.Manager.reqUpdate(requete, parameters); } catch (Exception e) { MessageBox.Show("E04 : Erreur lors de l'exécution de la requête = " + e); }
        }

        /// <summary>
        /// Crée et envoie une requête de mise à jour du perso envoyé, en se basant sur ses nouveaux paramètres
        /// </summary>
        /// <param name="perso"></param>
        public void UpdateItem (Personnel perso) {
            string requete = "UPDATE personnel SET prenom = @prenom, nom = @nom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel IN (@idpersonnel);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@idpersonnel", perso.Idpersonnel);
            parameters.Add("@prenom", perso.Prenom);
            parameters.Add("@nom", perso.Nom);
            parameters.Add("@tel", perso.Tel);
            parameters.Add("@mail", perso.Mail);
            parameters.Add("idservice", perso.Service.Idservice);

            try { access.Manager.reqUpdate(requete, parameters); } catch (Exception e) { MessageBox.Show(("E05 : Erreur lors de l'exécution de la requête = " + e)); }
        }

    }
}
