using P040_InterfacesPolymorphism.Domain.Interfaces;
using P040_InterfacesPolymorphism.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P040_InterfacesPolymorphism
{
    public class Staciakampis : Figura, IGeometrija
    {
        public double Ilgis { get; }
        public double Plotis { get; }

        public Staciakampis(double ilgis, double plotis):base("Staciakampis")
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public double Perimetras()
        {
            return (2*(Ilgis+Plotis));
        }

        public double Plotas()
        {
            return Ilgis*Plotis;
        }
    }
}
