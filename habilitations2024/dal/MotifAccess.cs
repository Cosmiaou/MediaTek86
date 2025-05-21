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

    public class MotifAccess
    {
        private readonly Access access;

        /// <summary>
        /// Constructeur
        /// </summary>
        public MotifAccess()
        {
            access = Access.getInstance();
        }

        /// <summary>
        /// Crée et envoie une requête SQL pour demander la liste des motifs
        /// </summary>
        /// <returns>Liste des profils</returns>
        public List<Motif> GetItems()
        {
            List<Motif> liste = new List<Motif>();
            string requete = "SELECT * FROM motif";

            try
            {
                List<Object[]> list = access.Manager.reqSelect(requete);

                if (list != null && list.Count > 0)
                {
                    foreach (Object[] item in list)
                    {
                        Motif motif = new Motif((int)item[0], (string)item[1]);

                        liste.Add(motif);
                    }
                }
                return liste;
            }
            catch
            {
                MessageBox.Show("E11 : Erreur lors de l'exécution de la requête SQL");
                Application.Exit();
                return liste = null;
            }
        }
    }
}
