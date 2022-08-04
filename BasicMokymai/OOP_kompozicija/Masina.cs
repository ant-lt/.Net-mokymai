using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija
{
    internal class Masina
    {
        // Klase aprasome tik public auto-implemented properciais
        public string Gamintojas { get; set; }
        public string Modelis { get; set; }
        public int GamybosMetai { get; set; }
        public bool ArDrausta { get; set; }
        public string SavininkoVardas { get; set; }
        public int DuruKiekis { get; set; }
        public string VariklioTipas { get; set; }
        public double MaksimaliGalia { get; set; }
        public double EmisijuKiekis { get; set; }
        public int DidziausiasGreitis { get; set; }
        public double Pagreitis { get; set; }
        public string Spalva { get; set; }
        public double Aukstis { get; set; }
        public double Plotis { get; set; }
        public double Ilgis { get; set; }
        public int KedziuKiekis { get; set; }

        public ApsaugosSistema ApsaugosSistema { get; set; }

        public Zmogus Savininkas { get; set; }

    }
}
