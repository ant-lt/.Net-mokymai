using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija
{
    internal class IsmanusisTelefonas
    {
        // Klase aprasome tik public fully described properciais
        private string dimensija;

        public string Dimensija
        {
            get { return dimensija; }
            set { dimensija = value; }
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

        private Dekliukas dekliukas;

        public Dekliukas Dekliukas
        {
            get { return dekliukas; }
            set { dekliukas = value; }
        }
    }
}
