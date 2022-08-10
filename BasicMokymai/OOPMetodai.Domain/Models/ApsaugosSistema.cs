using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
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


        public ApsaugosSistema(string pavadinimas): this()
        {
            Pavadinimas = pavadinimas;
        }

        public ApsaugosSistema(int lygis, string pavadinimas, string gamintojas, string rusis) : this(pavadinimas)
        {
            Lygis = lygis;
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

        public int Lygis { get; private set; }
        public string Pavadinimas { get; private set; }
        public string Gamintojas { get; private set; }
        public string Rusis { get; private set; }
    }
}
