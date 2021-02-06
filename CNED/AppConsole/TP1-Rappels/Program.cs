using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Rappels
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbCache;
            System.Random rand = new System.Random();
            // Interface Nombre Random
            nbCache = rand.Next(101);//100 est exclus, donc on met 101
            Console.Clear();

            // Interface Joureur 2
            int nbSaisi = -1;
            int i = 1;
       
            while (nbSaisi != nbCache)
            {
                
                // Nombre au bon format, int entre 1e et 100
                while (nbSaisi <= 0 || nbSaisi > 100)
                {
                    Console.WriteLine("Saisir nombre entier 0 et 100");
                    nbSaisi = int.Parse(Console.ReadLine());
                }

                if (nbSaisi > nbCache)
                {
                    Console.WriteLine("c'est Moins");
                    nbSaisi = -1;
                    i++;
                }
                else if (nbSaisi < nbCache)
                {
                    Console.WriteLine("c'est plus!");
                    nbSaisi = -1;
                    i++;
                }
                    
                
            }
            // On affiche
            Console.WriteLine("gagné en \"{0}\" tentative", i);
            Console.ReadLine();
        }
        
     }
}

