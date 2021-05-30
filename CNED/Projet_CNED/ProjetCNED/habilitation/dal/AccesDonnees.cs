using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Habilitations.modele;
using Habilitations.connexion;
namespace Habilitations.dal
{
    public class AccesDonnees
    {
        private static string connectionString = "server=localhost;user id=habilitations;password=motdepasseuser;database=habilitations";

        public static List<Developpeur> GetLesDeveloppeurs()
        {
            List<Developpeur> lstDev = new List<Developpeur>();
            string req = "select iddeveloppeur, nom, prenom, tel, mail, idprofil, profil.nom as profil ";
                req += "from developpeur join profil on (developpeur.iddeveloppeur=profil.iddeveloppeur";
            req += "order by nom, prenom";

            //creation connexion à la bdd
            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            // Envoi de la requete select
            curseur.ReqSelect(req);

            while (curseur.Read())
            {
                Developpeur undev = new Developpeur((int)curseur.Field("iddeveloppeur"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("tel"), (string)curseur.Field("mail"), (int)curseur.Field("idprofil"),(string)curseur.Field("profil"));
                lstDev.Add(undev);
            }

            curseur.Close();
            return lstDev;
        }

        public static List<Profil> GetLesProfils()
        {
            List<Profil> lstProfils = new List<Profil>();

            string req = "select idprofil, nom as profil from profil order by nom";

            ConnexionBDD curseur = ConnexionBDD.GetInstance(connectionString);
            curseur.ReqSelect(req);

            while (curseur.Read())
            {
                Profil profil = new Profil((int)curseur.Field("idprofil"), (string)curseur.Field("nom"));
                lstProfils.Add(profil);
            }
            return lstProfils;
        }

        public static void DelDeveloppeur(Developpeur developpeur)
        {
            string req = "delete from developpeur where iddeveloppeur = @iddeveloppeur;";

            Dictionary<string, object> parametre = new Dictionary<string, object>();
            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, parametre);
            
        }

        public static void AddDeveloppeur(Developpeur developpeur)
        {
            string req = "insert into developpeur(nom, prenom, tel, mail, pwd, idprofil)";
            req += "values (@nom, @prenom, @tel, @mail, @pwd, @idprofil";

            Dictionary<string, object> param = new Dictionary<string, object>();
            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, param);
        }

        public static void UpdateDeveloppeur(Developpeur developpeur)
        {
            string req = "update developpeur set nom=@nom, prenom=@prenom, tel=@tel, mail=@mail, idprofil=@idprofil;";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@iddeveloppeur", developpeur.Iddeveloppeur);
            param.Add("@nom", developpeur.Nom);
            param.Add("@prenom", developpeur.Prenom);
            param.Add("@tel", developpeur.Tel);
            param.Add("@mail", developpeur.Mail);
            param.Add("@idprofil", developpeur.Idprofil);

            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, param);
        }

        public static void UpdatePwd(Developpeur developpeur)
        {
            string req = "update developpeur(pwd) set pwd=@pwd where iddeveloppeur=@iddeveloppeur;";

            Dictionary<string, object> param = new Dictionary<string, object>();

            param.Add("@iddeveloppeur", developpeur.Iddeveloppeur);
            param.Add("@pwd", GetStringSha256Hash(developpeur.Pwd));

            ConnexionBDD connexion = ConnexionBDD.GetInstance(connectionString);
            connexion.ReqUpdate(req, param);
        }

        internal static string GetStringSha256Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            using ( var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);

                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }

    }
}
