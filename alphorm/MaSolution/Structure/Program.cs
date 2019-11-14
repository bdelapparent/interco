using System;
using DllLivre;

namespace structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Classe1.Livre l = new Classe1.Livre();
            l.Auteur = "bdl";
            l.Titre = "C#";
            l.Genre = "formation";

            Console.WriteLine("Le Titre est : {0}\nL'auteur est : {1}\nLe genre est : {2}", l.titre, l.auteur, l.genre);

            Console.Read();
        }
    }
}
