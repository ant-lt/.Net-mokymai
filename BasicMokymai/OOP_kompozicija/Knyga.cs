using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija
{
    internal class Knyga
    {
        private string _pavadinimas;

        public string Pavadinimas
        {
            get { return _pavadinimas; }
            private set { _pavadinimas = value; }
        }

        private string _leidykla;

        public string Leidykla
        {
            get { return _leidykla; }
            private set { _leidykla = value; }
        }

        private string _autorius;

        public string Autorius
        {
            get { return _autorius; }
            private set { _autorius = value; }
        }

        private int _puslapiai;

        public int Puslapiai
        {
            get { return _puslapiai; }
            private set { _puslapiai = value; }
        }


    }
}
