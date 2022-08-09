using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Konstruktorius
{
    internal class Masina
    {
        //ctor tab tab -- Code Snippet konstruktoriui
        public Masina()
        {
            Spalva = "Nenurodyta";
            DuruKiekis = 5;
            KedziuKiekis = 5;
            ArDrausta = true;
            SavininkoVardas = "Nenurodyta";

        }

        public Masina(string gamintojas, string modelis, int gamybosMetai, bool arDrausta, string savininkoVardas )
        {
            Gamintojas = gamintojas;
            Modelis = modelis;
            GamybosMetai = gamybosMetai;
            ArDrausta = arDrausta;
            SavininkoVardas = savininkoVardas;
        }
        public Masina(Masina masina)
        {
            Gamintojas = masina.Gamintojas;
            Modelis = masina.Modelis;
            GamybosMetai = masina.GamybosMetai;
            ArDrausta= masina.ArDrausta;
            SavininkoVardas = masina.SavininkoVardas;
        }


        // Klase aprasome tik public auto-implemented properciais
        public string Gamintojas { get; set; }
        public string Modelis { get; set; }
        public int GamybosMetai { get; set; }
        public bool ArDrausta { get; set; } = false;
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

        public ApsaugosSistema ApsaugosSistema { get; set; } = new ApsaugosSistema();

        public Zmogus Savininkas { get; set; }

    }
}
