using System;
using System.Text;

namespace LesChainesDeCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {

            // string str1 = "programation C#";
            // Console.WriteLine(str1[1]);
            // Console.WriteLine(str1);


            // string str2 = string.Empty;
            // Console.WriteLine(str2);

            // char[] tab = {'P','r','o','g','C','#'};
            // string str3 = new string(tab);
            // Console.WriteLine(str3);

            //Bienvenu en progrmmation C#

            string st1 = "bienvenue ";
            string st2 = "en ";
            string st3 = "programmation ";
            string st4 = "C#";

            StringBuilder builder1 = new StringBuilder();
            builder1.Append("bienvenue ");
            builder1.Append("en ");
            builder1.Append("programmation ");
            builder1.Append("C#");

            StringBuilder builder2 = new StringBuilder();
            builder2.Append(st1);
            builder2.Append(st2);
            builder2.Append(st3);
            builder2.Append(st4);

            string concatener = String.Concat(st1, st2, st3, st4);

            string st5 = "nico";
            string st6 = string.Format(@"Bienvenu en progrmmation C# {0} \", st5);

            Console.WriteLine("builder1 : " + builder1);
            Console.WriteLine("builder2 : " + builder2);
            Console.WriteLine("concatener : " + concatener);

            Console.Read();
        }
    }
}
