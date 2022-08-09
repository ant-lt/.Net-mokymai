using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Konstruktorius
{
    internal class Namas
    {
        public Namas()
        {
            adresas = "Nenurodytas";
            gyventoju = 0;
            aukstingumas = 0;
            plotas = 0;
            Savininkas = new Zmogus();
            Salis = new Salis();
        }

        public Namas(string adresas, int gyventoju, int aukstingumas, double plotas, Zmogus savininkas, Salis salis)
        {
            this.adresas = adresas;
            this.gyventoju = gyventoju;
            this.aukstingumas = aukstingumas;
            this.plotas = plotas;
            Savininkas = savininkas;
            Salis = salis;
        }

        public Namas(Namas namas)
        {
            adresas=namas.adresas;
            gyventoju=namas.gyventoju;
            aukstingumas=namas.aukstingumas;
            plotas=namas.plotas;
            Savininkas=namas.Savininkas;
            Salis = namas.Salis;
        }

        public string adresas;

        public int gyventoju;

        public int aukstingumas;

        public double plotas;

        public Zmogus Savininkas { get; set; }
        public Salis Salis { get; set; }
    }
}
