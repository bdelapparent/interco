using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    class Test : IBonsoir
    {
        //public void AfficherBonjour()
        //{
        //    Console.WriteLine("dans la méthode bonjour");
        //}

        //void IBonsoir.AfficherBonsoir()
        //{
        //    throw new NotImplementedException();
        //}

        //public void AfficherBonsoir()
        //{
        //    Console.WriteLine("dans la méthode bonsoir");
        //}

        public static void Main()
        {
            Test t = new Test();
            t.AfficherBonjour();
            //t.AfficherBonsoir();

            //IBonsoir b = new Test();
            //b.AfficherBonsoir();
            ((IBonsoir)t).AfficherBonsoir();

            Console.Read();
        }

        public void AfficherBonjour()
        {
            throw new NotImplementedException();
        }

        public void AfficherBonsoir()
        {
            throw new NotImplementedException();
        }
    }
}
