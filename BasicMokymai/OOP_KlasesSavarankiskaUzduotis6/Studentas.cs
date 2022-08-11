using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KlasesSavarankiskaUzduotis7
{
    internal class Studentas
    {
        public string Vardas { get; set; }
        public PazymiuKnygele PazymiuKnygele { get; set; }
        public List<Mokytojas> Mokytojai { get; set; }
    }       
}
