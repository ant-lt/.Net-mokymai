using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavyzdineKlaseBiblioteka
{


    /*
     * 
     * public: Tipą ar narį galima pasiekti naudojant bet kurį kitą kodą tame pačiame assembly kode ar kitame assembly, kuris jį referuoja.
     * private: Tipą ar narį galima pasiekti tik pagal kodą toje pačioje klasėje ar struktūroje.
     * internal: Tipą ar narį galima pasiekti naudojant bet kurį kodą tame pačiame assembly kode, bet ne iš kito assembly kodo.
     * protected: tipą arba narį galima pasiekti tik pagal kodą toje pačioje klasėje arba klasėje, kuri yra išvesta iš tos klasės(Paveldėta).
     * 
     */

    public class PrieinamumoPavyzdineKlase
    {
        protected PrieinamumoPavyzdineKlase() { }

        public PrieinamumoPavyzdineKlase(string pavarde) : this()
        {
            Pavarde = pavarde;
        }

        public string vardas;
        public string Pavarde { get; private set; }
        public int PavyzdineAutoImplementedProp { get; set; }

        // Auto-implemented property yra naudojamas dazniausiai.
        // Kontruktoriai yra taikomi pagal individualias situacijas. Privalu moketi deklaruoti kontruktoriu.
        // Konstruktorius naudojam aprasant butinus duomenis pradiniai objekto busenai.
    }

}