using System;

namespace ProjetCned.modele
{
    /// <summary>
    /// Classe représentant les absences d'un personnel
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Propriété d'identifiant d'un personnel absent
        /// </summary>
        private int idpersonnel;

        /// <summary>
        /// Propriété date de début de l'absence
        /// </summary>
        private DateTime datedebut;

        /// <summary>
        /// Propriété date de fin de l'absence
        /// </summary>
        private DateTime datefin;

        /// <summary>
        /// Propriété du motif de l'absence
        /// </summary>
        private string motif;

        /// <summary>
        /// Propriété de l'identifiant du motif de l'absence
        /// </summary>
        private int idmotif;

        /// <summary>
        /// Getter sur idpersonnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }

        /// <summary>
        /// Getter sur datadebut
        /// </summary>
        public DateTime Datedebut { get => datedebut; }

        /// <summary>
        /// Getter sur datefin
        /// </summary>
        public DateTime Datefin { get => datefin; }

        /// <summary>
        /// Getter sur motif
        /// </summary>
        public string Motif { get => motif; }

        /// <summary>
        /// Getter sur idmotif
        /// </summary>
        public int Idmotif { get => idmotif; }

        /// <summary>
        /// Constructeur d'Absence et valorise ses propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        /// <param name="idmotif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, string motif, int idmotif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.motif = motif;
            this.idmotif = idmotif;
        }
    }
}
