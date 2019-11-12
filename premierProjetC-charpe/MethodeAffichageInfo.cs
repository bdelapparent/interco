using System;

namespace MethodeAffichageInfo {

    public class Message {
        public static void AfficherBonWeekEnd () {
            Console.WriteLine ("Bon week-end " + Environment.UserName);
        }

        public static void AfficherBonjour () {
            Console.WriteLine ("Bonjour " + Environment.UserName);
        }

        public static void AfficherBonsoir () {
            Console.WriteLine ("Bonsoir " + Environment.UserName);
        }
    }
}