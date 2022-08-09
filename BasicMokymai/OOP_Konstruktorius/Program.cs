using PavyzdineKlaseBiblioteka;

namespace OOP_Konstruktorius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, OOP Konstruktorius!");
            //KonstruktoriuPavyzdziuPaleidimas();

            KonstruktoriuPavyzdziusUzduotis3();
        }

        private static void KonstruktoriuPavyzdziuPaleidimas()
        {
            var klientoVardoTekstas = "Kliento vardas";
            var klientas1 = new Customer("Albertas");
            Console.WriteLine($"1 {klientoVardoTekstas}: {klientas1.Vardas}"); // Stiuartas
            klientas1.Vardas = "Benas";
            Console.WriteLine($"1 {klientoVardoTekstas}: {klientas1.Vardas}"); // Benas

            Customer klientas2 = new Customer()
            {
                Vardas = "Ieva"
            };

            var klientas3 = new Customer("Aiste");
            Console.WriteLine($"3 {klientoVardoTekstas}: {klientas3.Vardas}");

            var masina = new Masina();

        }

        /*
         * Uzduotis 3: Aprasykite kiekvienai is klasiu aprasytu 1 uzduotyje po 3 konstruktorius
         */
        private static void KonstruktoriuPavyzdziusUzduotis3()
        {
            var Zmogus1 = new Zmogus();
            var Zmogus2 = new Zmogus("Petras", "Petrauskas", 1990, "Vyras", "Lietuva");

            var Zmogus3 = new Zmogus(Zmogus2)
            {
                vardas = "Jonas"
            };

            var masina1 = new Masina();
            var masina2 = new Masina("Toyota", "Yaris", 2012, true, "Jaroslavas");
            var masina3 = new Masina(masina2)
            {
                Gamintojas = "Audi",
                Modelis = "A4",
                GamybosMetai = 2000
            };

            var ismanusisTelefonas1 = new IsmanusisTelefonas();
            var ismanusisTelefonas2 = new IsmanusisTelefonas(50, 64, 4800, new Dekliukas() { Gamintojas = "Tokai", Kaina = 9.99, Medziaga = "Guminis" })
            {
                Dimensija = "4/3",
                Stiklas = "Grudintas",
                Modelis = "iProdus",
                Rezoliucija = "1080x800"
            };
            var ismanusisTelefonas3 = new IsmanusisTelefonas(ismanusisTelefonas2);

            var dekliukas4 = new Dekliukas()
            {
                Gamintojas = "Tokai",
                Kaina = 9.99,
                Medziaga = "Guminis"
            };

            var ismanusisTelefonas4 = new IsmanusisTelefonas(new IsmanusisTelefonas(50, 64, 4800, dekliukas4));


            var salis = new Salis();
            var salis2 = new Salis("Lietuva", 2000000, 125455, "Vilnius");
            var salis3 = new Salis(salis2);


            var namas1 = new Namas();            
            var namas2 = new Namas("Adresas", 10, 2, 400d, Zmogus3, salis);
            var namas3 = new Namas(namas2);


            var apsaugosSistema1 = new ApsaugosSistema();
            var apsaugosSistema2 = new ApsaugosSistema(1, "Kobra", "SANS", "Automobiliui");
            var apsaugosSistem3 = new ApsaugosSistema(apsaugosSistema2);


            var augintinis1 = new Augintinis();
            var augintinis2 = new Augintinis("Aras", 1990, "Aviganis", "Geras");
            var augintinis3 = new Augintinis(augintinis2);


            var prieinamumoPavyzdys = new PrieinamumoPavyzdineKlase("Privati pavarde");
            prieinamumoPavyzdys.vardas = "Prieinamas";
            Console.WriteLine($"Vardas: {prieinamumoPavyzdys.vardas}\nPavarde: {prieinamumoPavyzdys.Pavarde}");

        }
    }
}