using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kompozicija
{
    internal class Dekliukas
    {
        private string gamintojas;

        public string Gamintojas
        {
            get { return gamintojas; }
            set { gamintojas = value; }
        }

        private string medziaga;

        public string Medziaga
        {
            get { return medziaga; }
            set { medziaga = value; }
        }

        private double kaina;

        public double Kaina
        {
            get { return kaina; }
            set { kaina = value; }
        }
    }
}
