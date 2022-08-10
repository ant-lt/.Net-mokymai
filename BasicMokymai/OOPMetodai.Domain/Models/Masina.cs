using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
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

        public Masina(string gamintojas, string modelis, int gamybosMetai, bool arDrausta, string savininkoVardas, int duruKiekis, string variklioTipas, double maksimaliGalia, double emisijuKiekis, int didziausiasGreitis, double pagreitis, string spalva, double aukstis, double plotis, double ilgis, int kedziuKiekis, ApsaugosSistema apsaugosSistema) : this(gamintojas, modelis, gamybosMetai, arDrausta, savininkoVardas)
        {
            DuruKiekis = duruKiekis;
            VariklioTipas = variklioTipas;
            MaksimaliGalia = maksimaliGalia;
            EmisijuKiekis = emisijuKiekis;
            DidziausiasGreitis = didziausiasGreitis;
            Pagreitis = pagreitis;
            Spalva = spalva;
            Aukstis = aukstis;
            Plotis = plotis;
            Ilgis = ilgis;
            KedziuKiekis = kedziuKiekis;
            ApsaugosSistema = apsaugosSistema;
        }

        // Klase aprasome tik public auto-implemented properciais
        public string Gamintojas { get; private set; }
        public string Modelis { get; private set; }
        public int GamybosMetai { get; private set; }
        public bool ArDrausta { get; private set; } = false;
        public string SavininkoVardas { get; private set; }
        public int DuruKiekis { get; private set; }
        public string VariklioTipas { get; private set; }
        public double MaksimaliGalia { get; private set; }
        public double EmisijuKiekis { get; private set; }
        public int DidziausiasGreitis { get; private set; }
        public double Pagreitis { get; private set; }
        public string Spalva { get; private set; }
        public double Aukstis { get; private set; }
        public double Plotis { get; private set; }
        public double Ilgis { get; private set; }
        public int KedziuKiekis { get; private set; }
        public ApsaugosSistema ApsaugosSistema { get; private set; } = new ApsaugosSistema();

        public Zmogus Savininkas { get; set; }

    }
}
