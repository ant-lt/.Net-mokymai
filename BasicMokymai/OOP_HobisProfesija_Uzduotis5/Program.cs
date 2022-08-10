namespace OOP_HobisProfesija_Uzduotis5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, (Savarankiskai)Sukurti klases Hobis ir Profesija!");
            Uzd5();
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


    }
}