namespace DllLivre{

    public class Classe1{
        public struct Livre
        {
            private string titre;
            private string auteur;
            private string genre;

            // public string Titre
            // {
            //     get { return titre; }
            //     set { titre = value; }
            // }

            // public string Auteur
            // {
            //     get { return auteur; }
            //     set { auteur = value; }
            // }

            // public string Genre
            // {
            //     get { return genre; }
            //     set { genre = value; }
            // }


            public string Titre { get; set; }
            public string Auteur { get; set; }
            public string Genre { get; set; }
            // public int MyProperty { get; private set; }

            // private int myVar;
            // public int MyProperty
            // {
            //     get { return myVar; }
            //     set { myVar = value; }
            // }
            
        }
    }
}