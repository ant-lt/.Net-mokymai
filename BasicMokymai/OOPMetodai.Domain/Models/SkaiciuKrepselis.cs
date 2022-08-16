using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
{
    public class SkaiciuKrepselis
    {
        private List<int> skaiciuSarasas = new List<int>();
        public void PridėtiSkaiciu(int skaicius)
        {
            skaiciuSarasas.Add(skaicius);
        }

        public double ApskaiciuotiVidurki()
        {
            int suma = 0;
            foreach (int i in skaiciuSarasas)
            {
                suma = suma + i;
            }
            return (double)suma/ skaiciuSarasas.Count();
        }

    }
}
