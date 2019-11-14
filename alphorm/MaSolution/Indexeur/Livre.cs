namespace Indexeur
{

    struct Livre{

        /**
        * Reference du livre
        */
        public int Reference { get; set; }

        /**
        * Titre du livre
        */
        public string Titre { get; set; }

        /**
        * AUteur du livre
        */
        public string Auteur { get; set; }

        /**
        * Genre du livre
        */
        public string Genre { get; set; }

        /**
        * Maison d'édition du livre
        */
        public string MaisonEdition { get; set; }

        /**
         * Constructeur de la structure livre
         * @param name="auteur"
         * @param name="genre"
         * @param name="maisonEdition"
         * @param name="reference"
         * @param name="titre"
         */
        public Livre(int reference, string titre, string auteur, string genre, string maisonEdition)
        {
            Reference = reference;
            Titre = titre;
            Auteur = auteur;
            Genre = genre;
            MaisonEdition = maisonEdition;
        }
    }

    struct Librairie{
        Livre[] Tab;
        private int compteur;
        public int Compteur
        {
            get { return compteur; }
            set { compteur = value; }
        }

        public Librairie(int i)
        {
            Tab = new Livre[i];
            compteur = 0;
        }

        public Livre this [int j] { 
            get{return Tab[j];} 
            set{Tab[j] = value;} 
        }
        
    }
}