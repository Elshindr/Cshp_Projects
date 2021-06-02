using ProjetCned.dal;
using ProjetCned.modele;
using ProjetCned.vue;
using System;
using System.Collections.Generic;

namespace ProjetCned.controleur
{
    /// <summary>
    /// Gestion des interractions entre modèle et vue  
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// fenetre de connexion
        /// </summary>
        private FrmConnexion frmConnexion;


        /// <summary>
        /// Contructeur et ouverture de la fenetre FrmConnexion
        /// </summary>
        public Controle()
        {
            frmConnexion = new FrmConnexion(this);
            frmConnexion.ShowDialog();
        }


        /// <summary>
        /// Methode de vérification de connexion, si vrai,
        /// ouverture de la fenetre FrmGestion
        /// </summary>
        /// <param name="log"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Boolean Authentification(string log, string pwd)
        {
            if (AccesConnexionBDD.Authentification(log, pwd))
            {
                frmConnexion.Hide();
                (new FrmGestion(this)).ShowDialog();

                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Recuperer puis retourner les infos du personnel de la base
        /// de données
        /// </summary>
        /// <returns>Liste et infos sur le personnel</returns>
        public List<Personnel> GetPersonnels()
        {
            return AccesConnexionBDD.GetLePersonnel();
        }


        /// <summary>
        /// Récupérer puis retourner la liste des services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetService()
        {
            return AccesConnexionBDD.GetService();
        }

        /// <summary>
        /// Récupérer puis retourner les infos d'un personnel sur ses absences
        /// </summary>
        /// <returns>Liste des absences</returns>
        public List<Absence> GetAbsences(Personnel unpersonnel)
        {
            return AccesConnexionBDD.GetLesAbsences(unpersonnel);
        }


        /// <summary>
        /// Ajouter un personnel
        /// </summary>
        /// <param name="unpersonnel"></param>
        public void AddPersonnel(Personnel unpersonnel)
        {
            AccesConnexionBDD.AddPersonnel(unpersonnel);
        }


        /// <summary>
        /// Ajouter une absence
        /// </summary>
        /// <param name="uneabs"></param>
        public void AddAbsence(Absence uneabs)
        {
            AccesConnexionBDD.AddAbsence(uneabs);
        }


        /// <summary>
        /// Supprimer un personnel
        /// </summary>
        /// <param name="unpersonnel"></param>
        public void DelPersonnel(Personnel unpersonnel)
        {
            AccesConnexionBDD.DelPersonnel(unpersonnel);
        }


        /// <summary>
        /// Supprimer une absence
        /// </summary>
        /// <param name="uneabs"></param>
        public void DelAbs(Absence uneabs)
        {
            AccesConnexionBDD.DelAbs(uneabs);
        }


        /// <summary>
        /// Modifier les informations d'un personnel
        /// </summary>
        /// <param name="unpersonnel"></param>
        public void ModPersonnel(Personnel unpersonnel)
        {
            AccesConnexionBDD.ModPersonnel(unpersonnel);
        }


        /// <summary>
        /// Modifier la date d'entrée d'une absence
        /// </summary>
        /// <param name="uneabs"></param>
        public void ModAbsdebut(Absence uneabs)
        {
             AccesConnexionBDD.ModAbsdebut(uneabs);
        }


        /// <summary>
        /// Modifier le motif et la date de fin d'une absence 
        /// </summary>
        /// <param name="uneabs"></param>
        public void ModAbs(Absence uneabs)
        {
            AccesConnexionBDD.ModAbs(uneabs);
        }
        

        /// <summary>
        /// Récupérer la liste des motifs d'absence
        /// </summary>
        /// <returns></returns>
        public List<Motif> GetMotifs()
        {
            return AccesConnexionBDD.GetMotif();
        }
    }

}
