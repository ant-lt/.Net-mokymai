using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija_namų_darbas
{
    public class Spinta
    {
        public Double Aukstis { get; set; }
        public Double Plotis { get; set; }
        public Double Storis { get; set; }
        public List<Rankena> Rankenos { get; set; } = new List<Rankena>();
        public List<Lentyna> Lentynos { get; set; } = new List<Lentyna>();
    }
}
