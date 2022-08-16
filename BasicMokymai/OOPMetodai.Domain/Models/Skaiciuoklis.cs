using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
{
    public class Skaiciuoklis
    {
        public Skaiciuoklis(int skaicius)
        {
            Skaicius = skaicius;
            PradinisSkaicius = skaicius;
        }

        private int Skaicius { get; set; }
        private int PradinisSkaicius { get; set; }

        public void Didinti()
        {
            Skaicius++;

        }
        public void Mazinti()
        {
            Console.WriteLine("Mažinimas -1");
            if (Skaicius > 0) Skaicius--;
        }

        public void Atspausdinti()
        {
            Console.WriteLine($"Skaicius: {Skaicius}");
        }

        public void Reset()
        {
            Console.WriteLine("Reset()");
            Skaicius = PradinisSkaicius;
        }


    }
}
