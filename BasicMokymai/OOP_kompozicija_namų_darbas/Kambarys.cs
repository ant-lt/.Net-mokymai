using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija_namų_darbas
{
    public class Kambarys
    {
        public Kambarys(string pavadinimas, double ilgis, double plotis)
        {
            Pavadinimas = pavadinimas;
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public String Pavadinimas { get; private set; }
        public Double Plotas() => Ilgis * Plotis;
        public Double Ilgis { get; private set; }
        public Double Plotis { get; private set; }
        public List<Duris> Durys { get; set; } = new List<Duris>();
        public Grindis Grindis { get; set; } = new Grindis();
        public List<Langas> Langai { get; set; } = new List<Langas>();
        public Sviestuvas Sviestuvas { get; set; } = new Sviestuvas();
        public Stalas Stalas { get; set; } = new Stalas();
        public Spinta Spinta { get; set; } = new Spinta();
        public Lova Lova { get; set; } = new Lova();
        public Kilimas Kilimas { get; set; } = new Kilimas();
        public List<Kede> Kedes { get; set; } = new List<Kede>();
        public List<Jungiklis> Jungiklis { get; set; } = new List<Jungiklis>();
    }
}
