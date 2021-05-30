using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCned.modele
{
    public class Absence
    {
        private int idpersonnel;

        private DateTime datedebut;

        private DateTime datefin;

        private string motif;

        private int idmotif;

        public int Idpersonnel { get => idpersonnel; }
        public DateTime Datedebut { get => datedebut;}
        public DateTime Datefin { get => datefin;}
        public string Motif { get => motif;}
        public int Idmotif { get => idmotif;}

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
