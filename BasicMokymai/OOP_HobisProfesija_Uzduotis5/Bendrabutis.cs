using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HobisProfesija_Uzduotis5
{
    internal class Bendrabutis
    {
        public Bendrabutis() { }
        public Bendrabutis(int bendrabucioId)
        {
            BendrabucioId = bendrabucioId;
        }
        // Konstruktorius, kuris priima zmoniu sarasa (List<Zmogus> gyventojai)
        public Bendrabutis(List<Zmogus> gyventojai)
        {
            Gyventojai = gyventojai;
            // Kiekvienam perduotam gyventojui suteikiam gyvenamaja vieta
            foreach (Zmogus gyventojas in Gyventojai)
            {
                // <this> yra Bendrabucio objekto adresas
                gyventojas.GyvenamojiVieta = this; // Sitoje vietoje mes priskiriam "gyventojui" gyvenamaja vieta perduodami save (Bendrabucio objekta )
            }
        }

        public int BendrabucioId { get; set; }
        public int KambariuSkaicius { get; set; }
        public double Kaina { get; set; }
        // Saraso inicializavimas isvengiant "null exception"
        public List<Zmogus> Gyventojai { get; set; } = new List<Zmogus>();
    }
}
