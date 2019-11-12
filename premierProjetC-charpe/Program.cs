using System;
using MethodeAffichageInfo;

namespace premierProjetC_charpe {
    class Program {
        static void Main (string[] args) {

            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday || (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour < 9)) {
                Message.AfficherBonWeekEnd ();
            }

            if (DateTime.Now.Hour >= 17) {
                Message.AfficherBonsoir ();
            }

            if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 17) {
                Message.AfficherBonjour ();
            }
        }
    }
}