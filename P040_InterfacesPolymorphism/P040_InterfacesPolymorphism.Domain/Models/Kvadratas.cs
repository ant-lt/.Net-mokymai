using P040_InterfacesPolymorphism.Domain.Interfaces;
using P040_InterfacesPolymorphism.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P040_InterfacesPolymorphism
{
    public class Kvadratas : Figura, IGeometrija
    {
        public double Krastine { get; }

        public Kvadratas(double krastine):base("Kvadratas")
        {
            Krastine = krastine;
        }

        public double Perimetras()
        {
            return 4 * Krastine;
        }

        public double Plotas()
        {
            return Krastine * Krastine;
        }
    }
}
