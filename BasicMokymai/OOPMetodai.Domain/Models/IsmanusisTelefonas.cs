using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
{
    internal class IsmanusisTelefonas
    {
        public IsmanusisTelefonas()
        {
            Dimensija = "Nenurodyta";
            Stiklas = "Nenurodyta";
            Rezoliucija = "Nenurodyta";
            Modelis = "Nenurodyta";
        }

        public IsmanusisTelefonas(string operacineSistema) : this()
        {
            OperacineSistema = operacineSistema;
        }

        public IsmanusisTelefonas(string kamera, string operacineSistema) : this(operacineSistema)
        {
            Kamera = kamera;
        }

        public IsmanusisTelefonas(double svoris, double atmintis, int baterija, Dekliukas dekliukas)
        {
            Svoris = svoris;
            Atmintis = atmintis;
            Baterija = baterija;
            Dekliukas = dekliukas;
        }

        public IsmanusisTelefonas(IsmanusisTelefonas ismanusisTelefonas) : this(ismanusisTelefonas.kamera, ismanusisTelefonas.operacineSistema)
        {
            Svoris = ismanusisTelefonas.Svoris;
            Atmintis = ismanusisTelefonas.Atmintis;
            Baterija = ismanusisTelefonas.Baterija;
            Dekliukas = ismanusisTelefonas.Dekliukas;
        }

        public IsmanusisTelefonas(string dimensija, double svoris, string stiklas, string rezoliucija, double atmintis, string modelis, string operacineSistema, int baterija, string kamera, string gamintojas, Dekliukas dekliukas) : this(operacineSistema)
        {
            Svoris = svoris;
            Stiklas = stiklas;
            Rezoliucija = rezoliucija;
            Atmintis = atmintis;
            Modelis = modelis;
            Dimensija = dimensija;
            Baterija = baterija;
            Kamera = kamera;
            Gamintojas = gamintojas;
            Dekliukas = dekliukas;
        }

    private string dimensija;

        public string Dimensija
        {
            get => dimensija;
            set => dimensija = value; 
        }

        private double svoris;

        public double Svoris
        {
            get { return svoris; }
            set { svoris = value; }
        }

        private string stiklas;

        public string Stiklas
        {
            get { return stiklas; }
            set { stiklas = value; }
        }

        private string rezoliucija;

        public string Rezoliucija
        {
            get { return rezoliucija; }
            set { rezoliucija = value; }
        }

        private double atmintis;

        public double Atmintis
        {
            get { return atmintis; }
            set { atmintis = value; }
        }

        private string modelis;

        public string Modelis
        {
            get { return modelis; }
            set { modelis = value; }
        }

        private string operacineSistema;

        public string OperacineSistema
        {
            get { return operacineSistema; }
            set { operacineSistema = value; }
        }

        private int baterija;

        public int Baterija
        {
            get { return baterija; }
            set { baterija = value; }
        }

        private string kamera;

        public string Kamera
        {
            get { return kamera; }
            set { kamera = value; }
        }

        private string gamintojas;

        public string Gamintojas
        {
            get { return gamintojas; }
            set { gamintojas = value; }
        }

        private Dekliukas dekliukas; // Field

        public Dekliukas Dekliukas   // Property
        {
            get { return dekliukas; }
            set { dekliukas = value; }
        }
    }
}
