using System;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Veuillez saisir un texte");
            
            // string texteSaisie = Console.ReadLine();

            // Console.WriteLine("texte saisie ci dessus " + texteSaisie);

            // int x =20;
            // long y = 10;

            // double t = 1243.7;
            // int a = (int)t;

            // Console.WriteLine("x type : " + x.GetType());
            // Console.WriteLine("y type : " + y.GetType());

            référence();

            // double z = 1234.5;
            // int g = (int)z;
            // Console.WriteLine(g);

            // DateTime d = DateTime.Now;
            // Console.WriteLine(d);
//intsruction de lecture pour retrnir la console lorsque l'on utilise le .exe
            Console.Read();
        }

        public static void référence(){
            double z = 1234.5;
            int g = (int)z;
            Console.WriteLine(g);
        }
    }
}
