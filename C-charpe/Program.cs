using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Xml;

namespace C_charpe
{
    class Program
    {

        enum Jours {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche

        }
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

            nbComplexe();

            Console.WriteLine(value: Jours.Lundi);

            System.Console.WriteLine(System.DateTime.Now);

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

        static void nbComplexe(){
            Complex c = Complex.One;
            Console.WriteLine(c);
            Console.WriteLine("Partie réelle : " + c.Real);
            Console.WriteLine("Partie imaginaire : " + c.Imaginary);

            Console.WriteLine(Complex.Conjugate(Complex.FromPolarCoordinates(1.0, 45 * Math.PI / 180)));
        }
    }
}