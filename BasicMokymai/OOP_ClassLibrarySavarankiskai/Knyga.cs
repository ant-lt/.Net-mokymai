using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassLibrarySavarankiskai
{
    internal class Knyga
    {
        public Knyga()
        {
        }

        public Knyga(int puslapiai)
        {
            Puslapiai = puslapiai;
        }


        public Knyga(string pavadinimas, string leidykla, string autorius, int puslapiai):this(puslapiai)
        {
            Pavadinimas = pavadinimas;
            Leidykla = leidykla;
            Autorius = autorius;
        }

        public Knyga(Knyga knyga)
        {
            Pavadinimas = knyga.Pavadinimas;
            Leidykla = knyga.Leidykla;
            Autorius = knyga.Autorius;
            Puslapiai = knyga.Puslapiai;
        }

        public string Pavadinimas { get; private set; }
        public string Leidykla { get; private set; }
        public string Autorius { get; private set; }
        public int Puslapiai { get; private set; }

    }
}
