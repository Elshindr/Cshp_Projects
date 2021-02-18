using System;
using System.Drawing;

namespace Contacts
{

    /// <summary>
    /// Classe Contact
    /// mémorise les informations du contact
    /// </summary>
    [SerializableAttribute]
    public abstract class Contact : IComparable
    //    public class Contact
    {
        /// <summary>
        /// nom du contact
        /// </summary>
        protected string nom;
        /// <summary>
        /// tel du contact
        /// </summary>
        protected string tel;
        /// <summary>
        /// photo du contact
        /// </summary>
        private Image photo;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">nom</param>
        /// <param name="tel">tel</param>
        /// <param name="photo">photo</param>
        public Contact(string nom, string tel, Image photo)
        {
            this.nom = nom;
            this.tel = tel;
            this.photo = photo;
        }

        /// <summary>
        /// getter sur nom
        /// </summary>
        /// <returns>nom</returns>
        public string getNom()
        {
            return this.nom;
        }

        /// <summary>
        /// getter sur tel
        /// </summary>
        /// <returns>tel</returns>
        public string getTel()
        {
            return this.tel;
        }

        /// <summary>
        /// getter sur photo
        /// </summary>
        /// <returns>photo</returns>
        public Image getPhoto()
        {
            return this.photo;
        }

        /// <summary>
        /// Comparaison des noms pour le tri
        /// </summary>
        /// <param name="obj">Contact à comparer</param>
        /// <returns>comparaison sur le nom</returns>
        public int CompareTo(object obj)
        {
            return nom.CompareTo(((Contact)obj).getNom());
        }
    }


    /// <summary>
    /// Classe Particulier hérite de Contact
    /// </summary>
    [SerializableAttribute]
    public class Particulier : Contact
    {
        private string prenom;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">nom</param>
        /// <param name="prenom">prénom</param>
        /// <param name="tel">téléphone</param>
        /// <param name="photo">photo</param>
        public Particulier(string nom, string prenom, string tel, Image photo) : base(nom, tel, photo)
        {
            this.prenom = prenom;
        }

        /// <summary>
        /// getter sur prenom
        /// </summary>
        /// <returns>prenom</returns>
        public string getPrenom()
        {
            return this.prenom;
        }

        /// <summary>
        /// informations sur le contact
        /// </summary>
        /// <returns>nom + prenom + (tel)</returns>
        public override string ToString()
        {
            return base.nom + " " + this.prenom + " (" + base.tel + ")";
        }
    }


    /// <summary>
    /// Classe Professionnel hérite de Contact
    /// </summary>
    [SerializableAttribute]
    public class Professionnel : Contact
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">nom</param>
        /// <param name="tel">téléphone</param>
        /// <param name="photo">photo</param>
        public Professionnel(string nom, string tel, Image photo) : base(nom, tel, photo) { }

        /// <summary>
        /// informations sur le contact
        /// </summary>
        /// <returns>nom + (tel)</returns>
        public override string ToString()
        {
            return base.nom + " (" + base.tel + ")";
        }
    }

}
