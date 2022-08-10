using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HobisProfesija_Uzduotis5
{
    internal class Bendrabutis
    {
        public Bendrabutis()
        {
            BendrabucioId = 0;
            KambariuSkaicius = 0;
            Kaina = 0;
        }

        public Bendrabutis(int bendrabucioId, int kambariuSkaicius, double kaina, List<Zmogus> zmones)
        {
            BendrabucioId = bendrabucioId;
            KambariuSkaicius = kambariuSkaicius;
            Kaina = kaina;
            Zmones = zmones;
        }

        public Bendrabutis(Bendrabutis bendrabutis)
        {
            BendrabucioId = (int)bendrabutis.BendrabucioId;
            KambariuSkaicius= (int)bendrabutis.KambariuSkaicius;
            Kaina= (int)bendrabutis.Kaina;
            Zmones = (List<Zmogus>)bendrabutis.Zmones;
        }

        public int BendrabucioId { get; set; }
        public int KambariuSkaicius { get; set; }
        public double Kaina { get; set; }
        public List<Zmogus> Zmones { get; set; } = new List<Zmogus>();
    }
}
