namespace ProjetCned.modele
{
    /// <summary>
    /// Classe représentant le personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Propriété identifiant du personnel
        /// </summary>
        private int idpersonnel;

        /// <summary>
        /// Propriété du nom d'un personnel
        /// </summary>
        private string nom;

        /// <summary>
        /// Propriété du prenom d'un personnel
        /// </summary>
        private string prenom;

        /// <summary>
        /// Propriété du tel d'un personnel
        /// </summary>
        private string tel;

        /// <summary>
        /// Propriété du mail d'un personnel
        /// </summary>
        private string mail;

        /// <summary>
        /// Propriété de l'identifiant du service d'un personnel
        /// </summary>
        private int idservice;

        /// <summary>
        /// Propriété du service d'un personnel
        /// </summary>
        private string service;

        /// <summary>
        /// Getter sur idpersonnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }

        /// <summary>
        /// Getter sur nom
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Getter sur prenom
        /// </summary>
        public string Prenom { get => prenom; }

        /// <summary>
        /// Getter sur tel
        /// </summary>
        public string Tel { get => tel; }

        /// <summary>
        /// Getter sur mail
        /// </summary>
        public string Mail { get => mail; }

        /// <summary>
        /// Getter sur idservice
        /// </summary>
        public int Idservice { get => idservice; }

        /// <summary>
        /// Getter sur service
        /// </summary>
        public string Service { get => service; }


        /// <summary>
        /// Constructeur de la classe Personnel et valorise ses propriétes
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

            this.idservice = idservice;
            this.service = service;
        }
    }
}
