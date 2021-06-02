namespace ProjetCned.modele
{
    /// <summary>
    /// Classe représentant les motifs d'absence d'un personnel
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Propriété d'identifiant d'un motif
        /// </summary>
        private int idmotif;

        /// <summary>
        /// Propriété de libellé d'un motif
        /// </summary>
        private string libelle;


        /// <summary>
        /// Getter sur idmotif
        /// </summary>
        public int Idmotif { get => idmotif; }

        /// <summary>
        /// Getter sur libelle
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// Constructeur de Motif et valorise ses propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Définir le libelle à afficher
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
