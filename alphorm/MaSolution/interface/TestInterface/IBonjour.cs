using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    interface IBonjour // par défaut internal
    {
        void AfficherBonjour();
    }

    //interface IBonsoir // par défaut internal
    //{
    //    void AfficherBonsoir();
    //}

    interface IBonsoir : IBonjour // par défaut internal
    {
        void AfficherBonsoir();
    }
}
