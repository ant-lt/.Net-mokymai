using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektinisProgramavimas.Models
{
    internal class Mokinys
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int GimimoMetai { get; set; }
        public string MegstamiausiaPamoka { get; set; }
        public List<Knyga> TurimosKnygos { get; set; }
    }
}
