using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HobisProfesija_Uzduotis5
{
    internal class Profesija
    {
        public Profesija()
        {
            Id = 0;
            TekstasLietuviskai = "Nenurodytas";
            Tekstas = "Nenurodytas";
        }

        public Profesija(int id, string tekstasLietuviskai, string tekstas)
        {
            Id = id;
            TekstasLietuviskai = tekstasLietuviskai;
            Tekstas = tekstas;
        }

        public Profesija(Profesija profesija)
        {
            Id=profesija.Id;
            TekstasLietuviskai = profesija.TekstasLietuviskai;
            Tekstas =profesija.Tekstas;

        }

        public int Id { get;  set; }
        public string TekstasLietuviskai { get; private set; }
        public string Tekstas { get; private set; }
    }
}
