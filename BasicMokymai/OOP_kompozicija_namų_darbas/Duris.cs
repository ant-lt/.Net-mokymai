using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija_namų_darbas
{
    internal class Duris
    {
        public String Pavadinimas { get; set; }
        public String Medziaga { get; set; }
        public String NaudojimoSalygos { get; set; }
        public Double Aukstis { get; set; }
        public Double Plotis { get; set; }
        public Double Storis { get; set; }
        public Rankena Rankena { get; set; } = new Rankena();
    }
}
