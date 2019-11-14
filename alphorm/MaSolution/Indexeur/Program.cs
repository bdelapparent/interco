using System;

namespace Indexeur
{
    class Program
    {
        static void Main(string[] args)
        {

            Livre l1 = new Livre(1, "Programmation en C#", "B.de Lapparent", "Programmation", "Hachette");
            Livre l2 = new Livre(2, "HTML 5, CSS3 et JS", "B.de Lapparent", "Programmation web", "Hachette");

            Librairie maLibrairie = new Librairie(2);
            maLibrairie[0] = l1;
            maLibrairie.Compteur++;

            maLibrairie[1] = l2;
            maLibrairie.Compteur++;

            AfficherMaLibrairie(maLibrairie);

            Console.Read();
        }
    
    //Afficheage de tous les livre de la livrairie
        public static void AfficherMaLibrairie(Librairie l){

            for(int i = 0; i < l.Compteur; i++){

                Livre livre = l[i];
                Console.WriteLine("Titre: {0}\nAuteur : {1}\nMaison d'édition : {2}\n\n", livre.Titre, livre.Auteur, livre.MaisonEdition);
            }

        }
    
    }
}
