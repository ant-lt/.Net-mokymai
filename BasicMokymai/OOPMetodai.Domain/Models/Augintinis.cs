using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
{
    internal class Augintinis
    {
        public Augintinis()
        {
            Vardas = "Nenustatytas";
            GimimoMetai = 0;
            Rusis = "Nenustatyta";
            Budas = "Nenustatyta";
        }

        public Augintinis(string vardas, int gimimoMetai, string rusis, string budas)
        {
            Vardas = vardas;
            GimimoMetai = gimimoMetai;
            Rusis = rusis;
            Budas = budas;
        }

        public Augintinis(Augintinis augintinis)
        {
            Vardas= augintinis.Vardas;
            GimimoMetai = augintinis.GimimoMetai;
            Rusis= augintinis.Rusis;
            Budas= augintinis.Budas;
        }

        public string Vardas { get; set; }
        public int GimimoMetai { get; set; }
        public string Rusis { get; set; }
        public string Budas { get; set; }
    }
}
