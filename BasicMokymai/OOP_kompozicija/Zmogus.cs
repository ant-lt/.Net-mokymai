using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija
{
    // "class Zmogus" yra tas pats kas "internal class Zmogus"
    // "Klase" yra tas pats kas "Modelis"
    internal class Zmogus
    {
        // Klase aprasome tik public fieldais
        public string vardas;
        public string pavarde;
        public int gimimoMetai;
        public string pareigos;
        public string asmenybesTipas;
        public string akiuSpalva;
        public string lytis;
        public string gimimoSalis;
        public string megstamiausiasHobis;
        public double pinigai;
        public string issilavinimas;
        public List<string> masinos;
        public Augintinis augintinis;
        public Salis salis;
    }
}
