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
        }

        private int Skaicius { get; set; }

        public void Didinti()
        {
            Skaicius++;

        }
        public void Mazinti()
        {
            Skaicius--;
        }

        public void Atspausdinti()
        {
            Console.WriteLine($"Skaicius: {Skaicius}");
        }

    }
}
