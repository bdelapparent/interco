namespace Humain{

    public class Personne{
        
        public string Name { get; private set; }
       private string alias;
        public string  Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        
        

        public Personne(string name)
        {
            Name = name;
        }
    }
}