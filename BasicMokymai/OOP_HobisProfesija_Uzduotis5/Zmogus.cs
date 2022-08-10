using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HobisProfesija_Uzduotis5
{

    internal class Zmogus
    {
        public Zmogus() 
        {
            Vardas = "Nenustatytas";
            Pavarde = "Nenustatytas";
        }

        public Zmogus(string pavarde)
        {
            Pavarde = pavarde;
        }

        public Zmogus(string vardas, string pavarde) : this(pavarde)
        {
            Vardas = vardas;
        }

        public string Vardas { get;  set; }
        public string Pavarde { get;  set; }
        public Bendrabutis Bendrabutis { get; set; }
    }
}
