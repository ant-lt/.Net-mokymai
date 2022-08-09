using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Konstruktorius
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

        public Salis(string pavadinimas, int gyventojai, double plotas, string sostine)
        {
            Pavadinimas = pavadinimas;
            Gyventojai = gyventojai;
            Plotas = plotas;
            Sostine = sostine;
        }

        public Salis( Salis salis)
        {
            Plotas = salis.Plotas;
            Pavadinimas = salis.Pavadinimas;
            Gyventojai = salis.Gyventojai;
            Sostine = salis.Sostine;
        }

        public string Pavadinimas { get; set; }

        public int Gyventojai { get; set; }

        public double Plotas{ get; set; }

        public string Sostine { get; set; }
    }
}
