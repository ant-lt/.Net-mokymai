using System.Text;

namespace OOP_HobisProfesija_Uzduotis5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            Console.WriteLine("Hello, Užduotis 5 ir Užduotis 6!");
            // Uzd5();
            // Uzd6();
            Uzd6_Destytojas();
        }

        /*
Uzduotis 5:(Savarankiskai)Sukurti klases Hobis ir Profesija 
Klasės interfeise turi būti properčiai: Id (int), TekstasLietuviskai(string) ir Tekstas(string) 
Sukurti tuscia konstruktorių.
Sukurti konstruktorių, kuris inicializuoja duotas reikšmes.
Kintamieji gali būti tik pasiekiami iš išorės, bet reikšmės gali būti nustatomos tik klasės viduje.
Sukurkite po 3 skirtingus hobius ir profesijas
        (Panaudoti visus 3 ismoktus deklaravimo ir priskyrimo budus. 
        1. Konstruktoriaus pagalba 
        2. Tuscio objekto sukurimas ir pildymas eigoje
        3. Deklaravimo metu priskirti reiksmes)
           */

        static void Uzd5()
        {
            var hobis1 = new Hobis();
            hobis1.Id = 2;
            var hobis2 = new Hobis(1,"tekstas1", "testas2");
            var hobis3 = new Hobis(hobis2);

            var hobis4 = new Hobis()
            {
                Id = 3
            };

            var profesija1 = new Profesija();

            var profesija2 = new Profesija(1,"Profesija1", "tekstas3");
            var profersija3 = new Profesija(profesija2);

        }

        /*
         *
         Uzduotis 6: (Savarankiskai)Sukurkite klasę “Bendrabutis”. 
        Klasės kontraktas/interfeisas turėtų turėti šiuos atributus:       
        BendrabucioId       KambariuSkaicius       Kaina 
        Sujunkite/sukomponuokite klases “Zmogus” ir “Bendrabutis” taip, 
        kad kiekviename bendrabutyje galėtų gyventi daug žmonių, 
        tačiau vienas žmogus galėtų gyventi tik viename bendrabutyje.

         * 
         * 
         */

        static void Uzd6()
        {
            Zmogus zmogus1 = new Zmogus();
            zmogus1.Vardas = "Vardas1";
            zmogus1.Pavarde = "Pavardenis1";

            Zmogus zmogus2 = new Zmogus();
            zmogus2.Vardas = "Vardas2";
            zmogus2.Pavarde = "Pavardenis2";


            Bendrabutis bendrabutis = new Bendrabutis();
            bendrabutis.BendrabucioId = 1;
            bendrabutis.Kaina = 100;
            bendrabutis.KambariuSkaicius = 10;
            //bendrabutis.Zmones.Add(zmogus1);
            //bendrabutis.Zmones.Add(zmogus2);

            zmogus1.GyvenamojiVieta = bendrabutis;
            zmogus2.GyvenamojiVieta = bendrabutis;

            
            //foreach (var zmogus in bendrabutis.Zmones)
            //{
            //    Console.WriteLine($"Bendrabučio nr:{zmogus.GyvenamojiVieta.BendrabucioId} -> Žmogus: {zmogus.Vardas}, {zmogus.Pavarde} Moka kaina: {zmogus.GyvenamojiVieta.Kaina}");

            //}

        }

        private static void Uzd6_Destytojas()
        {
            var gyventojai = new List<Zmogus>()
            {
                new Zmogus("Petras"),
                new Zmogus("Ieva"),
                new Zmogus("Jonas"),
            };

            var bendrabutis2 = new Bendrabutis(3);

            var gyventojoPavyzdys = new Zmogus(new Bendrabutis(2));
            var zmogus3 = new Zmogus("Benas", bendrabutis2);
            var zmogus4 = new Zmogus("Piteris", bendrabutis2);
            var zmogus5 = new Zmogus("Aiste", bendrabutis2);

            foreach (var bendrabutis2Gyventojas in zmogus3.GyvenamojiVieta.Gyventojai)
            {
                Console.WriteLine($"Gyventojas {bendrabutis2Gyventojas.Vardas} gyvena {bendrabutis2Gyventojas.GyvenamojiVieta.BendrabucioId} bendrabutyje");
            }

            // Mes inicializuojame bendrabuti naudodami konstruktoriu, kuris priima gyventoju <Zmogus> sarasa.
            // Tam, kad kiekvienam gyventojui priskirti naujai sukurta bendrabuti, mes naudojame zodi "this"
            // tam, kad galetume referuoti pati bendrabuti kiekvieno "gyventojo" viduje
            var bendrabutis = new Bendrabutis(gyventojai) // <----- this (new Bendrabutis)
            {
                BendrabucioId = 1,
                Kaina = 200,
                KambariuSkaicius = 50
            };

            foreach (var gyventojas in bendrabutis.Gyventojai)
            {
                Console.WriteLine($"Gyventojas {gyventojas.Vardas} gyvena bendrabutyje identifikaciniu numeriu: {gyventojas.GyvenamojiVieta.BendrabucioId}");
            }
        }

    }
}