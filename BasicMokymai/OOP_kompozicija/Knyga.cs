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
            set { _pavadinimas = value; }
        }

        private string _leidykla;

        public string Leidykla
        {
            get { return _leidykla; }
            set { _leidykla = value; }
        }

        private string _autorius;

        public string Autorius
        {
            get { return _autorius; }
            set { _autorius = value; }
        }

        private int _puslapiai;

        public int Puslapiai
        {
            get { return _puslapiai; }
            set { _puslapiai = value; }
        }


    }
}
