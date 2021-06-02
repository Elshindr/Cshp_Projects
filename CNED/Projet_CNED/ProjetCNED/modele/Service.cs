namespace ProjetCned.modele
{
    /// <summary>
    /// Classe des services du personnel
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Variable identifiant des services
        /// </summary>
        private int idservice;


        /// <summary>
        /// Variable du libelle d'un service
        /// </summary>
        private string nom;


        /// <summary>
        /// Getter d'encapsulation d'idservice
        /// </summary>
        public int Idservice { get => idservice; }


        /// <summary>
        /// Getter d'encapsulation de nom
        /// </summary>
        public string Nom { get => nom; }


        /// <summary>
        /// Constructeur de service et valorise ses propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;

            this.nom = nom;
        }

        /// <summary>
        /// Définir le nom du service n à afficher
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.nom;
        }
    }
}
