using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P040_InterfacesPolymorphism
{
    public class Skaicius: IMatematika
    {
        public Skaicius()
        {
            Reiksme = 0;
        }

        public Skaicius(int pradineReiksme)
        {
            Reiksme = pradineReiksme;
        }

        public int Reiksme { get; }

        public int Atimti(int skaicius)
        {
            return Reiksme - skaicius;
        }

        public int Padalinti(int skaicius)
        {
            return Reiksme/skaicius;
        }

        public int Padauginti(int skaicius)
        {
            return Reiksme * skaicius;
        }

        public int PakeltiKubu()
        {
            return Reiksme*Reiksme*Reiksme;
        }

        public int PakeltiKvadratu()
        {
            return Reiksme * Reiksme;
        }

        public int Prideti(int skaicius)
        {
            return Reiksme + skaicius;
        }
    }
}
