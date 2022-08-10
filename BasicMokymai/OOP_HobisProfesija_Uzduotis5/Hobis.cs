using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HobisProfesija_Uzduotis5
{
    internal class Hobis
    {
        public Hobis()
        {
            Id = 0;
            TekstasLietuviskai = "Nenurodytas";
            Tekstas = "Nenurodytas";
        }

        public Hobis(int id, string tekstasLietuviskai, string tekstas)
        {
            Id = id;
            TekstasLietuviskai = tekstasLietuviskai;
            Tekstas = tekstas;
        }

        public Hobis(Hobis hobis)
        {
            Id=hobis.Id;
            TekstasLietuviskai=hobis.TekstasLietuviskai;
            Tekstas = hobis.Tekstas;

        }

        public int Id { get;  set; }
        public string TekstasLietuviskai { get; private set; }
        public string Tekstas { get; private set; }
    }
}
