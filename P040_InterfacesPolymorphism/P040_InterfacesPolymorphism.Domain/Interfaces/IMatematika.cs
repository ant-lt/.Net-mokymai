using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P040_InterfacesPolymorphism.Domain.Interfaces
{
    public interface IMatematika
    {
        //--> metodams bus paduodamas sveikasis skaičius ir bus grąžinama reikšmė
        int Prideti(int skaicius);
        int Atimti(int skaicius);
        int Padauginti(int skaicius);
        int Padalinti(int skaicius);
        //--> metodai grąžina reikšmes
        int PakeltiKvadratu();
        int PakeltiKubu();
    }
}
