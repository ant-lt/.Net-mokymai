using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P040_InterfacesPolymorphism.Domain.Models
{
    public class Figura
    {
        public string Pavadinimas { get; }

        public Figura(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }
    }
}
