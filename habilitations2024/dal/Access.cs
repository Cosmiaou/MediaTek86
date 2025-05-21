using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatek86.bddmanager;

namespace mediatek86.dal
{
    public class Access
    {
        /// <summary>
        /// Chaine de connection à la base de donnée
        /// </summary>
        private static readonly string connectionString = "Server=localhost;Database=mediatek_86;User Id=appmediatek_PC1;Password=7P!qGm#d#8T9#nrb;";
        /// <summary>
        /// Instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Locker pour supporter le multithread - pas forcément nécessaire
        /// </summary>
        private static readonly object locker = new object();

        /// <summary>
        /// Contient une instance de BddManager
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Crée une instance de BddManager, qui initialise la connexion à la BDD
        /// </summary>
        private Access()
        {
            try
            {
                this.Manager = BddManager.getInstance(connectionString);
                instance = this;
            }
            catch {
                MessageBox.Show("E01 : Erreur lors de la connection à la BDD");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création d'une seule instance selon le patron singleton. Appelle si nécessaire le constructeur, qui crée une instance de BddManager, qui initialise la connexion à la BDD
        /// </summary>
        /// <returns></returns>
        public static Access getInstance()
        {
            if (Access.instance == null)
            {
                lock (locker)
                {
                    if (Access.instance == null)
                    {
                        Access.instance = new Access();
                    }
                }
            }
            return Access.instance;
        }
    }
}
