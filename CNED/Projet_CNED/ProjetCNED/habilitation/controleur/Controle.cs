using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Habilitations.vue;
using Habilitations.modele;
using Habilitations.dal;

namespace Habilitations.controleur
{
    public class Controle
    {

        /// <summary>
        /// Constructeur de controle et ouverture de la fenetre habilitation
        /// </summary>
        public Controle()
        {
            (new FrmHabilitations(this)).ShowDialog();
        }

        public List<Developpeur> GetLesDeveloppeurs() 
        {
            return AccesDonnees.GetLesDeveloppeurs();
        }

        public List<Profil> GetLesProfils() 
        {
            return AccesDonnees.GetLesProfils();
        }

        public void DelDeveloppeur(Developpeur developpeur)
        {
             AccesDonnees.DelDeveloppeur(developpeur);
        }

        public void AddDeveloppeur(Developpeur developpeur)
        {
            AccesDonnees.AddDeveloppeur(developpeur);
        }

        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            AccesDonnees.UpdateDeveloppeur(developpeur);
        }

        public void UpdatePwd(Developpeur developpeur)
        {
            AccesDonnees.UpdatePwd(developpeur);
        }
    }
}
