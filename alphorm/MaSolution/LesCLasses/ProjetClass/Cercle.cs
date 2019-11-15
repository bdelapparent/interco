using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetClass
{
    //par défaut les classes sont internal.
    static class Cercle
    {
        public static int rayon;
        //static double pi = Math.PI;

        public static double CalculerAire()
        {
            // pi * rayon * rayon
            return Cercle.rayon * Cercle.rayon * Math.PI;
        }

        static Cercle()
        {
            Cercle.rayon = r;
        }
    }
}
