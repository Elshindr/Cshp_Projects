using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ProjetCned.connexion
{

    /// <summary>
    /// Classe permettant la connexion à la base de données ainsi que l'exécution des requêtes sql
    /// </summary>
    public class ConnexionBDD
    {
        /// <summary>
        /// Instance de la classe
        /// </summary>
        private static ConnexionBDD instance = null;

        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private MySqlConnection connexion;

        /// <summary>
        /// objet executant une requête SQL
        /// </summary>
        private MySqlCommand commande;

        /// <summary>
        /// objet contenant le résultat d'une requête sql de type select (curseur)
        /// </summary>
        private MySqlDataReader curseur;


        /// <summary>
        /// Constructeur privé de ConnexionBDD permettant la création de la connexion ainsi que son ouverture
        /// </summary>
        /// <param name="chaineConnexion">chaine de connexion</param>
        private ConnexionBDD(string chaineConnexion)
        {
            try
            {
                connexion = new MySqlConnection(chaineConnexion);
                connexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// Créer une instance en singleton de la classe ConnexionBDD
        /// </summary>
        /// <param name="chaineConnexion"> chaine de connexion à la base de données </param>
        /// <returns>instance de la classe ConnexionBDD</returns>
        public static ConnexionBDD GetInstance(string chaineConnexion)
        {
            if (instance is null)
            {
                instance = new ConnexionBDD(chaineConnexion);
            }

            return instance;
        }


        /// <summary>
        /// Exécuter une requête sql d'un autre type que select
        /// </summary>
        /// <param name="req">requête sql </param>
        /// <param name="parametres">dictionnaire contenant les différents parametres</param>
        public void ReqUpdate(string req, Dictionary<string, object> parametres)
        {
            try
            {
                commande = new MySqlCommand(req, connexion);
                if (!(parametres is null))
                {
                    foreach (KeyValuePair<string, object> param in parametres)
                    {
                        commande.Parameters.Add(new MySqlParameter(param.Key, param.Value));
                    }
                }
                commande.Prepare();
                commande.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// Exécuter une requête sql de type "select" puis valoriser le curseur
        /// </summary>
        /// <param name="req">requête sql</param>
        /// <param name="parametres">dictionnaire des requetes préparés</param>
        public void ReqSelect(string req, Dictionary<string, object> parametres)
        {
            try
            {
                commande = new MySqlCommand(req, connexion);
                if (!(parametres is null))
                {
                    foreach (KeyValuePair<string, object> param in parametres)
                    {
                        commande.Parameters.Add(new MySqlParameter(param.Key, param.Value));
                    }
                }

                commande.Prepare();
                curseur = commande.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// Lecture du curseur à la ligne suivante s'il n'est pas null
        /// </summary>
        /// <returns>false si fin de curseur atteinte</returns>
        public bool Read()
        {
            if (curseur is null)
            {
                return false;
            }
            try
            {
                return curseur.Read();
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Retourne le contenu d'un champ dont le nom est passé en paramètre
        /// </summary>
        /// <param name="champ">nom du champ</param>
        /// <returns>valeur du champ</returns>
        public object Field(string champ)
        {
            if (curseur is null)
            {
                return null;
            }
            try
            {
                return curseur[champ];
            }
            catch
            {
                return null;
            }
        }


        /// <summary>
        /// Fermeture du curseur
        /// </summary>
        public void Close()
        {
            if (!(curseur is null))
            {
                curseur.Close();
            }
        }
    }
}
