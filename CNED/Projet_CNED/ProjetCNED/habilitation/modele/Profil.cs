using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations.modele
{
    public class Profil
    {
        private int idprofil;
        private string nom;

        public int Idprofil { get => idprofil; set => idprofil = value; }
        public string Nom { get => nom; set => nom = value; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idprofil"></param>
        /// <param name="nom"></param>
        public Profil(int idprofil, string nom)
        {
            this.idprofil = idprofil;
            this.nom = nom;
        }

        /// <summary>
        /// Definit l'information a afficher ( juste le nom)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nom;
        }
        
    }
}
