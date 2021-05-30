using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habilitations.modele
{
    public class Developpeur
    {

        private int iddeveloppeur;
        private int idprofil;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private string pwd;
        private string profil;

        public int Iddeveloppeur { get => iddeveloppeur; set => iddeveloppeur = value; }
        public int Idprofil { get => idprofil; set => idprofil = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Pwd { get => pwd; }
        public string Profil { get => profil; set => profil = value; }

        public Developpeur(int iddeveloppeur, string nom, string prenom, string tel, string mail, int idprofil, string profil)
        {
            this.iddeveloppeur = iddeveloppeur;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idprofil = idprofil;
            this.profil = profil;
        }

        
    }
}
