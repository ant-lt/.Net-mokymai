using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Konstruktorius
{
    internal class ApsaugosSistema
    {
        public ApsaugosSistema()
        {
            Lygis = 0;
            Pavadinimas = "Nenurodyta";
            Gamintojas = "Nenurodyta";
            Rusis = "Nenurodyta";
        }

        public ApsaugosSistema(int lygis, string pavadinimas, string gamintojas, string rusis)
        {
            Lygis = lygis;
            Pavadinimas = pavadinimas;
            Gamintojas = gamintojas;
            Rusis = rusis;
        }

        public ApsaugosSistema(ApsaugosSistema apsaugosSistema)
        {
            Lygis = apsaugosSistema.Lygis;
            Pavadinimas = apsaugosSistema.Pavadinimas;
            Gamintojas = apsaugosSistema.Gamintojas;
            Rusis = apsaugosSistema.Rusis;  
        }

        public int Lygis { get; set; }
        public string Pavadinimas { get; set; }
        public string Gamintojas { get; set; }
        public string Rusis { get; set; }
    }
}
