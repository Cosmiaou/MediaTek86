﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.model;
using mediatek86.bddmanager;
using System.Windows.Forms;

namespace mediatek86.dal
{

    public class ResponsableAccess
    {
        private readonly Access access;

        /// <summary>
        /// Constructeur
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.getInstance();
        }

        /// <summary>
        /// Crée et envoie une requête afin de vérifier si le profil de l'objet dev envoyé est un admin ou non. Return true si vrai
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool ControleAuthentification(Responsable responsable)
        {
            string requete = "SELECT login, pwd FROM responsable WHERE login = @login AND pwd = SHA2(@pwd, 256);";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@login", responsable.Login);
            parameters.Add("pwd", responsable.Pwd);

            try
            {
                List<Object[]> retour = access.Manager.reqSelect(requete, parameters);

                if (retour.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                MessageBox.Show("E09 : Erreur lors de l'exécution de la requête");
                Environment.Exit(0);
                return false;
            }
        }
    }
}
