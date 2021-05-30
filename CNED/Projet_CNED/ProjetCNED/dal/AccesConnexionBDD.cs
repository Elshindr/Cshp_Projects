using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCned.connexion;
using ProjetCned.modele;

namespace ProjetCned.dal
{
    /// <summary>
    /// Classe permettant la gestion des demandes sql
    /// </summary>
    public class AccesConnexionBDD
    {
        /// <summary>
        /// Chaine de connexion à la base de donnée
        /// </summary>
        private static string chaineConnexion = "server=localhost;user id=logresponsable;password=2*6le_pwd;database=projetcned;SslMode=none";

        /// <summary>
        ///  Récupèrer la liste du personnel provenant de la Base de données
        /// </summary>
        /// <returns>La liste du personnel</returns>
        public static List<Personnel> GetLePersonnel()
        {
            string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, p.service as service";
            req += "from personnel;";

            List<Personnel> lePersonnels = new List<Personnel>();

            ConnexionBDD curs = ConnexionBDD.GetInstance(chaineConnexion);
            curs.ReqSelect(req);

            while (curs.Read())
            {
                Personnel unpersonnel= new Personnel((int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("tel"), (string)curs.Field("prenom"), (string)curs.Field("mail"),(int)curs.Field("idservice") ,(string)curs.Field("service"));
                lePersonnels.Add(unpersonnel);
            }
            curs.Close();

            return lePersonnels;
        }

        /// <summary>
        /// Afficher la liste des absences d'un personnel sélectionné, dans l'ordre
        /// inverse de la chronologie(la plus récente en premier).
        /// </summary>
        /// <returns></returns>
        public static List<Absence> GetLesAbsences()
        {
            string req = "select a.datedebut as debut, a.datefin as fin, a.motif as motif ";
            req += " from absence a join personnel p on (a.idpersonnel = p.idpersonnel)";
            req += "where a.idpersonnel = @idpersonnel";
            req += "order by a.datedebut ASC, a.datefin ASC;";

            List<Absence> lesAbsences = new List<Absence>();

            ConnexionBDD curs = ConnexionBDD.GetInstance(chaineConnexion);
            curs.ReqSelect(req);

            while (curs.Read())
            {
                
                Absence uneabs = new Absence((int)curs.Field("idpersonne"), (DateTime)curs.Field("datedebut"), (DateTime)curs.Field("datefin"), (string)curs.Field("motif"), (int)curs.Field("idmotif"));
                lesAbsences.Add(uneabs);
            }

            curs.Close();

            return lesAbsences;
        }


        /// <summary>
        /// Ajouter un personnel
        /// </summary>
        /// <param name="unpersonnel">un personnel</param>
        public static void AddPersonnel(Personnel unpersonnel)
        {
            string req = "insert into personnel(nom, prenom, tel, mail, idservice)";
            req += "values(@nom, @prenom, @tel, @mail, @idservice);";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@nom", unpersonnel.Nom);
            param.Add("@prenom", unpersonnel.Prenom);
            param.Add("@tel", unpersonnel.Tel);
            param.Add("@mail", unpersonnel.Mail);
            param.Add("idservice", unpersonnel.Idservice);

            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.ReqUpdate(req, param);
        }


        /// <summary>
        /// Ajouter une absence
        /// </summary>
        /// <param name="uneabs">une absence</param>
        public static void AddAbsence(Absence uneabs)
        {
            string req = "insert into absence(datedebut, datefin, motif, idpersonnel)";
            req += "values(@datedebut, @datefin, @motif, @idpersonnel;";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@datedebut", uneabs.Datedebut);
            param.Add("@datefin", uneabs.Datefin);
            param.Add("@motif", uneabs.Motif);
            param.Add("@idpersonnel", uneabs.Idpersonnel);

            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.ReqUpdate(req, param);
        }


        /// <summary>
        /// Supprimer un personnel
        /// </summary>
        /// <param name="unpersonnel">le personnel</param>
        public static void DelPersonnel(Personnel unpersonnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@idpersonnel", unpersonnel.Idpersonnel);

            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.ReqUpdate(req, param);
        }


        /// <summary>
        /// Supprimer une absence d'un personnel
        /// </summary>
        /// <param name="uneabs">une absence</param>
        public static void DelAbs(Absence uneabs)
        {
            string req = "delete from absence where datedebut = @datedebut AND idpersonnel = @idpersonnel and datefin = @datefin;";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@idpersonnel", uneabs.Idpersonnel);
            param.Add("@datedebut", uneabs.Datedebut);
            param.Add("@datefin", uneabs.Datefin);

            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.ReqUpdate(req, param);
        }


        /// <summary>
        /// Modifier un personnel
        /// </summary>
        /// <param name="unpersonnel"> un personnel</param>
        public static void ModPersonnel(Personnel unpersonnel)
        {
            string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice";
            req += "where idpersonnel = @idpersonnel;";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@idpersonnel", unpersonnel.Idpersonnel);
            param.Add("@nom", unpersonnel.Nom);
            param.Add("@prenom", unpersonnel.Prenom);
            param.Add("@tel", unpersonnel.Tel);
            param.Add("@mail", unpersonnel.Mail);
            param.Add("@idservice", unpersonnel.Idservice);

            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.ReqUpdate(req, param);
        }


        /// <summary>
        /// Modifier une absence
        /// </summary>
        /// <param name="uneabs"> une absence</param>
        public static void ModAbs(Absence uneabs)
        {
            string req = "update absence set datefin = @datefin, datedebut = @datedebut, idmotif= @idmotif, idpersonnel = @idpersonnel";
            req += "where idpersonnel = @idpersonnel and datefin=@datefin and datedebut = @datedebut;";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@idpersonnel", uneabs.Idpersonnel);
            param.Add("@datefin", uneabs.Datefin);
            param.Add("@datedebut", uneabs.Datedebut);
            param.Add("@idmotif", uneabs.Idmotif);

            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.ReqUpdate(req, param);

        }


        /// <summary>
        /// Transformation d'une chaîne avec SHA256 (pour le pwd)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static string GetStringSha256Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}
