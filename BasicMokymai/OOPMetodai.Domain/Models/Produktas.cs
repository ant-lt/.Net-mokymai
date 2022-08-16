using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
{
    public class Produktas
    {
        public Double Kaina { get; private set; }
        public int Kiekis { get; private set; }
        public string Pavadinimas { get; private set; }
        public Produktas(double kaina, int kiekis, string pavadinimas)
        {
            Kaina = kaina;
            Kiekis = kiekis;
            Pavadinimas = pavadinimas;
        }

        public void SpausdintiProdukta()
        {
            Console.WriteLine($"{Pavadinimas} kaina {Kaina:C}:{Kiekis} vnt.");
        }
    }
}
