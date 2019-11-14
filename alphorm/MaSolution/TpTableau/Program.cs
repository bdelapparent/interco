using System;

namespace tpTableau {
    class Program {
        static void Main (string[] args) {
            //Tableau unidimensionnel
            // int[] montableau = new int[5];

            // for(int i = 0; i < montableau.Length; i++){

            //     var randomNumber = new Random();

            //     montableau[i] = randomNumber.Next();
            // }

            // for(int i = 0; i < montableau.Length; i++){

            //     int numeroCase = i + 1;
            //     Console.WriteLine("Case numéro " + numeroCase + " : " + montableau[i]);
            // }

            //tableau multidimensionnel
            // int[, ] tabM = new int[7, 5];

            // for (int i = 0; i < tabM.GetLength (0); i++) {

            //     for (int n = 0; n < tabM.GetLength (1); n++) {
            //         var random = new Random ();
            //         tabM [i, n] = random.Next ();
            //     }

            // }

            // for (int i = 0; i < tabM.GetLength (0); i++) {

            //     for (int n = 0; n < tabM.GetLength (1); n++) {
            //         int ligne = i + 1;
            //         int colonne = n + 1;

            //         Console.WriteLine ("ligne " + ligne + ", colonne " + colonne + " : " + tabM[i, n]);
            //     }

            // }

            //Tableau en escalier
            int [][] tableauEnEscalier = new int[3][];

            for(int i =0; i < tableauEnEscalier.GetLength(0); i++){
                
                var random = new Random();

                if ((i % 2) == 0)
                {
                    tableauEnEscalier[i] = new int[] {random.Next(), random.Next() , random.Next() , random.Next()};
                }else{
                    tableauEnEscalier[i] = new int[] {random.Next(), random.Next(), random.Next(), random.Next(), random.Next(), random.Next()};
                }
            }
            Console.Read ();
        }
    }
}