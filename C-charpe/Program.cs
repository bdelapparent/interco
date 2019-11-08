using System;
using System.Collections.Generic;
using System.Linq;

namespace C_charpe
{
    class Program
    {
        static void Main(string[] args){
            int test = 10;
            string phrase = "test de phrase \"null\"";
            Console.WriteLine(value: phrase);

            if(test > 1){
                Console.WriteLine(value: phrase);
            }

            double valeur = LongueurHypotenuse(1,3);
            Console.WriteLine(valeur);

            for(int i = 0; i < 7; i++){
            Console.WriteLine(trouverJour(i));
            }
        }

        static double LongueurHypotenuse (double a, double b){
            double somme = a*a +b*b;
            double resultat = Math.Sqrt(somme);
            return resultat;
        }

        static string trouverJour(int numJour){
            string[] jours = new string[]{ "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche"};
            return jours[numJour];
        }
    }
}