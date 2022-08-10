using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassLibrarySavarankiskai
{
    internal class Salis
    {
        public Salis()
        {
            Pavadinimas = "Nenurodyta";
            Gyventojai = 0;
            Plotas = 0;
            Sostine = "Nenurodyta";
        }

        public Salis(int gyventojai, double plotas, string sostine): this()
        {
            Gyventojai = gyventojai;
            Plotas = plotas;
            Sostine = sostine;
        }


        public Salis(string pavadinimas, int gyventojai, double plotas, string sostine): this(gyventojai, plotas, sostine)
        {
            Pavadinimas = pavadinimas;
        }

        public Salis( Salis salis)
        {
            Plotas = salis.Plotas;
            Pavadinimas = salis.Pavadinimas;
            Gyventojai = salis.Gyventojai;
            Sostine = salis.Sostine;
        }

        public string Pavadinimas { get; private set; }

        public int Gyventojai { get; private set; }

        public double Plotas{ get; private set; }

        public string Sostine { get; private set; }
    }
}
