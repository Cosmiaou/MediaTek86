using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.model;
using mediatek86.bddmanager;
using System.Windows.Forms;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe d'accès aux données pour les objets de type Service
    /// </summary>
    public class ServiceAccess
    {
        private readonly Access access;

        /// <summary>
        /// Constructeur
        /// </summary>
        public ServiceAccess()
        {
            access = Access.getInstance();
        }

        /// <summary>
        /// Crée et envoie une requête SQL pour demander la liste des services
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetItems()
        {
            List<Service> liste = new List<Service>();
            string requete = "SELECT * FROM service";

            try
            {
                List<Object[]> list = access.Manager.reqSelect(requete);

                if (list != null && list.Count > 0)
                {
                    foreach (Object[] item in list)
                    {
                        Service service = new Service((int)item[0], (string)item[1]);

                        liste.Add(service);
                    }
                }
                return liste;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("E07 : Erreur lors de l'exécution de la requête SQL = " + ex.ToString());
                Application.Exit();
                return liste = null;
            }
        }
    }
}
