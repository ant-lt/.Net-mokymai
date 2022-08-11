using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
{
    public class Kalbejimas
    {
        public Kalbejimas(string garsas)
        {
            Garsas = garsas;
        }

        private string Garsas { get; set; }

        public void Kalbeti()
        {
            Console.WriteLine(Garsas);
        }
    }
}
