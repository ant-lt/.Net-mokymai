using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassLibrarySavarankiskai
{
    public class Namas
    {
        public Namas()
        {
            Console.WriteLine("public Namas()");
            ZmoniuVardai = new List<string>();
            YraDarzas = true;
            Zmones = new List<Zmogus>()
            {
                new Zmogus("Petras", "Jonaitis"),
                new Zmogus("Ieva", "Baikrutyte"),
                new Zmogus("Jonas", "Petraitis"),
            };

            foreach (var zmogus in Zmones)
            {
                ZmoniuVardai.Add(zmogus.Vardas);
            }
        }

        private Namas(string adresas) : this()
        {
            Console.WriteLine("private Namas(string adresas) : this()");
            Adresas = adresas;
        }

        internal Namas(int kambariuSkaicius) : this()
        {
            KambariuSkaicius = kambariuSkaicius;
        }

        public Namas(int kambariuSkaicius, string adresas) : this(adresas)
        {
            Console.WriteLine("public Namas(int kambariuSkaicius, string adresas) : this(adresas)");
            KambariuSkaicius = kambariuSkaicius;
        }

        internal List<Zmogus> Zmones { get; set; }
        private List<string> zmoniuVardai;

        public List<string> ZmoniuVardai
        {
            get { return zmoniuVardai; }
            set { zmoniuVardai = value; }
        }

        public int KambariuSkaicius { get; private set; }
        public string Adresas { get; private set; }
        public bool YraDarzas { get; internal set; }
    }
}
