using ProjetCned.connexion;
using ProjetCned.modele;
using System;
using System.Collections.Generic;

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
        private static string chaineConnexion = "server=localhost;user id=logresponsable;password=pwd;database=projetcned;SslMode=none";


        /// <summary>
        /// Verifie si les clés de connexion sont valides
        /// </summary>
        /// <param name="log">login</param>
        /// <param name="pwd">mot de passe</param>
        /// <returns>vrai si clés sont valides</returns>
        public static Boolean Authentification(string log, string pwd)
        {
            string req = "select * from responsable r ";
            req += "where r.login = @login and r.pwd = SHA2(@pwd, 256);";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@login", log);
            param.Add("@pwd", pwd);

            ConnexionBDD curs = ConnexionBDD.GetInstance(chaineConnexion);
            curs.ReqSelect(req, param);

            if (curs.Read())
            {


                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }

        /// <summary>
        ///  Récupèrer la liste du personnel provenant de la Base de données
        /// </summary>
        /// <returns>La liste du personnel</returns>
        public static List<Personnel> GetLePersonnel()
        {

            string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, p.idservice as idservice, s.nom as service ";
            req += " from personnel p join service s on (p.idservice = s.idservice)";
            req += "order by p.nom, p.prenom;";

            List<Personnel> lePersonnels = new List<Personnel>();

            ConnexionBDD curs = ConnexionBDD.GetInstance(chaineConnexion);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Personnel unpersonnel = new Personnel((int)curs.Field("idpersonnel"), (string)curs.Field("nom"), (string)curs.Field("prenom"), (string)curs.Field("tel"), (string)curs.Field("mail"), (int)curs.Field("idservice"), (string)curs.Field("service"));
                lePersonnels.Add(unpersonnel);
            }
            curs.Close();

            return lePersonnels;
        }

        /// <summary>
        /// Demander la liste des services
        /// </summary>
        /// <returns></returns>
        public static List<Service> GetService()
        {
            string req = "select idservice as idservice, nom as nom from service order by nom;";

            List<Service> lesservices = new List<Service>();

            ConnexionBDD curs = ConnexionBDD.GetInstance(chaineConnexion);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Service unservice = new Service((int)curs.Field("idservice"), (string)curs.Field("nom"));
                lesservices.Add(unservice);
            }
            curs.Close();

            return lesservices;
        }


        /// <summary>
        /// Afficher la liste des absences d'un personnel sélectionné, dans l'ordre
        /// inverse de la chronologie(la plus récente en premier).
        /// </summary>
        /// <returns></returns>
        public static List<Absence> GetLesAbsences(Personnel unpersonnel)
        {
            string req = "select idpersonnel as idpersonnel, datedebut as datedebut, datefin as datefin, a.idmotif as idmotif , m.libelle as motif";
            req += " from absence a join motif m on (a.idmotif = m.idmotif)";
            req += " where idpersonnel = @idpersonnel";
            req += " order by datedebut DESC, datefin DESC;";

            List<Absence> lesAbsences = new List<Absence>();

            ConnexionBDD curs = ConnexionBDD.GetInstance(chaineConnexion);

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@idpersonnel", unpersonnel.Idpersonnel);
            curs.ReqSelect(req, param);

            while (curs.Read())
            {

                Absence uneabs = new Absence((int)curs.Field("idpersonnel"), (DateTime)curs.Field("datedebut"), (DateTime)curs.Field("datefin"), (string)curs.Field("motif"), (int)curs.Field("idmotif"));
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
            string req = "insert into personnel(idpersonnel, nom, prenom, tel, mail, idservice)";
            req += " values(@idpersonnel, @nom, @prenom, @tel, @mail, @idservice);";

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
        /// Ajouter une absence
        /// </summary>
        /// <param name="uneabs">une absence</param>
        public static void AddAbsence(Absence uneabs)
        {
            string req = "insert into absence(datedebut, datefin, idmotif, idpersonnel)";
            req += " values(@datedebut, @datefin, @idmotif, @idpersonnel);";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@datedebut", uneabs.Datedebut);
            param.Add("@datefin", uneabs.Datefin);
            param.Add("@idmotif", uneabs.Idmotif);
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


            string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
            req += " where idpersonnel = @idpersonnel;";

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
        /// Modifier une absence date de fin ou/et motif
        /// </summary>
        /// <param name="uneabs"> une absence</param>
        public static void ModAbs(Absence uneabs)
        {
            string req = "update absence set datefin = @datefin, idmotif = @idmotif";
            req += " where idpersonnel = @idpersonnel and datedebut = @datedebut;";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@idpersonnel", uneabs.Idpersonnel);
            param.Add("@datefin", uneabs.Datefin);
            param.Add("@datedebut", uneabs.Datedebut);
            param.Add("@idmotif", uneabs.Idmotif);

            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.ReqUpdate(req, param);

        }


        /// <summary>
        /// Modifier une absence date d'entrée en absence
        /// </summary>
        /// <param name="uneabs"> une absence</param>
        public static void ModAbsdebut(Absence uneabs)
        {
            string req = "update absence set datedebut = @datedebut";
            req += " where idpersonnel = @idpersonnel;";
            
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@idpersonnel", uneabs.Idpersonnel);
            
            param.Add("@datedebut", uneabs.Datedebut);
            
            ConnexionBDD connexion = ConnexionBDD.GetInstance(chaineConnexion);
            connexion.ReqUpdate(req, param);

        }

        /// <summary>
        /// Obtenir la liste des motifs d'absence
        /// </summary>
        /// <returns></returns>
        public static List<Motif> GetMotif()
        {
            string req = "select idmotif, libelle from motif order by libelle;";

            List<Motif> lesMotifs = new List<Motif>();

            ConnexionBDD curs = ConnexionBDD.GetInstance(chaineConnexion);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Motif unmotif = new Motif((int)curs.Field("idmotif"), (string)curs.Field("libelle"));
                lesMotifs.Add(unmotif);
            }
            curs.Close();

            return lesMotifs;
        }


    }
}
