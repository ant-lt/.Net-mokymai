using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
{
    public class Staciakampis
    {
        public Staciakampis(double ilgis, double plotis)
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        internal double Ilgis { get; set; }
        internal double Plotis { get; set; }

        // Naudojame non-static metoda tam, kad galetume dirbti su konkrecia instancija/objektu
        public double ApskaiciuotiPlota()
        {
            return Ilgis * Plotis;
        }

        public void PakeistiIlgi(double ilgis)
        {
            Ilgis = ilgis;
        }

        public void PakeistiPloti(double plotis)
        {
            Plotis = plotis;
        }

    }
}
