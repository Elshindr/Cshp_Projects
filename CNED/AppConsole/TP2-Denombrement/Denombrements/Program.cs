using System;
/**
 * titre : calculs de dénombrements
 * description : permet 3 types de calculs (permutation, arrangement, combinaison)
 * auteur : Elshindr
 * date création : 15/06/2020
 * date dernière modification : 15/10/2020
 */

namespace Denombrements
{
    class Program
    {

        static void Calcul(int choix)
        {
            int nEle, ntotal;
            long r1, r2, res = 0;
            bool corSaisi = false;

            while (corSaisi == false)
            {
                try
                {
                    Console.Write("nombre total d'éléments à gérer = ");
                    ntotal = int.Parse(Console.ReadLine()); // saisir nombre

                    // calcul de Permutation
                    if (choix == 1)
                    {
                        res = 1;
                        for (int k = 1; k <= ntotal; k++)
                            res *= k;
                        Console.WriteLine(ntotal + "! = " + res);
                    }

                    else if (choix == 2 || choix == 3)
                    {
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        nEle = int.Parse(Console.ReadLine()); // saisir le nombre d'élément

                        res = 1;
                        for (int k = (ntotal - nEle + 1); k <= ntotal; k++)
                            res *= k;

                        // calcul de Arrangement
                        if (choix == 2)
                        {
                            Console.WriteLine("A(" + ntotal + "/" + nEle + ") = " + res);
                        }


                        // calcul de Combinaison
                        else
                        { 
                            r2 = 1;
                            for (int k = 1; k <= nEle; k++)
                                r2 *= k;

                            // calcul de r3
                            Console.WriteLine("C(" + ntotal + "/" + nEle + ") = " + res / r2);
                        }
                    }
                    corSaisi = true;
                }

                catch (Exception)
                {
                    Console.WriteLine("Nombre entier attendu ou valeurs trop grandes.");
                }
            }
        }
        static void Main(string[] args)
        {
            int choix = 1;

            bool excep = false;

            while (excep == false || choix != 0)
            {
                excep = false;

                try
                {
                    Console.WriteLine("Permutation ...................... 1");
                    Console.WriteLine("Arrangement ...................... 2");
                    Console.WriteLine("Combinaison ...................... 3");
                    Console.WriteLine("Quitter .......................... 0");
                    Console.Write("Choix :                            ");

                    choix = int.Parse(Console.ReadLine());
                    excep = true;

                    switch (choix)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;

                        case 1:
                            Calcul(1);
                            break;

                        case 2:
                            Calcul(2);
                            break;

                        case 3:
                            Calcul(3);
                            break;

                        default:
                            Console.WriteLine("Choix non valide: Saisir 1, 2, 3 ou 0.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Choix non valide: Saisir 1, 2, 3 ou 0");
                }

            }
            Console.ReadLine();
        }
    }
}
