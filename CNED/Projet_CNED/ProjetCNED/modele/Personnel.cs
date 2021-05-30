using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCned.modele
{
    public class Personnel
    {
        private int idpersonnel;

        private string nom;

        private string prenom;

        private string tel;

        private string mail;

        private int idservice;

        private string service;

        public int Idpersonnel { get => idpersonnel; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; }
        public string Mail { get => mail;}
        public int Idservice { get => idservice;}
        public string Service { get => service;}


        /// <summary>
        /// Constructeur de la classe Personnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice, string service)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.service = service;
            this.idservice = idservice;
        }
    }
}
