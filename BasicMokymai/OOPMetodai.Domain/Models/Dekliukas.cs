using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMetodai.Domain.Models
{
    internal class Dekliukas
    {
        public Dekliukas()
        {
            gamintojas = "Nenurodytas";
            medziaga = "Nenurodytas";
            kaina = 0d;
        }


        public Dekliukas(string gamintojas, string medziaga, double kaina)
        {
            this.gamintojas = gamintojas;
            this.medziaga = medziaga;            
            this.kaina = kaina;
        }

        public Dekliukas(Dekliukas dekliukas)
        {
            gamintojas = dekliukas.gamintojas;
            medziaga = dekliukas.medziaga;  
            kaina = dekliukas.kaina;
        }

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
