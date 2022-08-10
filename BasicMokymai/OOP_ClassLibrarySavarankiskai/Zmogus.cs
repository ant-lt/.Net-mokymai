using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassLibrarySavarankiskai
{
    // "class Zmogus" yra tas pats kas "internal class Zmogus"
    // "Klase" yra tas pats kas "Modelis"
    internal class Zmogus
    {
        public Zmogus() { }
        public Zmogus(int zmogausNamoKambariuSkaicius)
        {
            Namas = new Namas(zmogausNamoKambariuSkaicius)
            {
                YraDarzas = true
            };
        }

        public Zmogus(string pavarde)
        {
            Pavarde = pavarde;
        }

        public Zmogus(string vardas, string pavarde) : this(pavarde)
        {
            Vardas = vardas;
        }

        public Zmogus(string vardas, Namas namas, string pavarde) : this(pavarde)
        {
            Namas = namas;
            Vardas = vardas;
        }

        public string Vardas { get; private set; }
        public Namas Namas { get; private set; }
        public string Pavarde { get; private set; }

    }
}
