using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija
{
    internal class Namas
    {
        public string adresas;

        public int gyventoju;

        public int aukstingumas;

        public double plotas;

        public Zmogus Savininkas { get; set; }
        public Salis Salis { get; set; }
    }
}
