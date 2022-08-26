using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija
{
    internal class Namas
    {
        public string Adresas { get; private set; }

        public int Gyventoju { get; private set; }

        public int Aukstingumas { get; private set; }

        public double Plotas { get; private set; }

        public Zmogus Savininkas { get; private set; }
        public Salis Salis { get; private set; }
    }
}
