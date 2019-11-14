using System;

namespace enumeration
{
    class Program
    {

        enum Jours {Lundi = 1 , Mardi = 2, Mercredi = 3, Jeudi = 5, Vendredi= 6, Samedi = 7, Dimanche = 8};
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez tapez un chiffre correspondant au jour de la semainr choisi : ");
            Console.ForegroundColor = (ConsoleColor)10;

            var lectureConsole = Console.ReadLine();
            bool auMoinsUnPassage = false;
        while(lectureConsole != "exit"){
            

            if(auMoinsUnPassage && lectureConsole != "exit"){
                    Console.WriteLine("Veuillez tapez un chiffre correspondant au jour de la semainr choisi : ");
                    lectureConsole = Console.ReadLine();
            }

            if( lectureConsole != "exit"){
                try{               
                int choix = int.Parse(lectureConsole);

                Console.WriteLine((Jours)choix);

                //afficherChoix(choix);
                }catch(FormatException){
                        // Console.ForegroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = (ConsoleColor)12;
                    Console.WriteLine("Veuillez entré un  chiffre aucun autre format ne sera valide");
                        Console.ForegroundColor = (ConsoleColor)10;
                    // Console.ForegroundColor = ConsoleColor.Green;
                }  

                auMoinsUnPassage = true;
            }   
        }
            Console.Read();
        }

        // private static void afficherChoix(int numChoix){
        //     switch (numChoix){
        //         case 1:
        //             Console.WriteLine(Jours.Lundi);
        //         break;
        //         case 2:
        //             Console.WriteLine(Jours.Mardi);
        //         break;
        //         case 3:
        //             Console.WriteLine(Jours.Mercredi);
        //         break;
        //         case 4:
        //             Console.WriteLine(Jours.Jeudi);
        //         break;
        //         case 5:
        //             Console.WriteLine(Jours.Vendredi);
        //         break;
        //         case 6:
        //             Console.WriteLine(Jours.Samedi);
        //         break;
        //         case 7:
        //             Console.WriteLine(Jours.Dimanche);
        //         break;
        //         default:
        //             Console.ForegroundColor = ConsoleColor.Red;
        //             Console.WriteLine("Aucun jour ne correspond à ce chiffre");
        //             Console.ForegroundColor = ConsoleColor.Green;                    
        //         break;
        //     }
        }
    }
}
