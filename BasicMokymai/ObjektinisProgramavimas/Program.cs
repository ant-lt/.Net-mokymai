using ObjektinisProgramavimas.Models;

namespace ObjektinisProgramavimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZaistiSuPirmaisOopPavyzdziais();
        }

        public static void ReferuotoTipuPavyzdziai()
        {
            Console.WriteLine("Hello Objektinis Programavimas!");

            // Deklaruojam nauja objektyva naudodami Zmogus kaip klase
            var zmogus = new Zmogus(); // zmogus = Sugeneruoja Nauja Adresa (#JN5415DFDG)
            zmogus.Vardas = "Andrius";
            Console.WriteLine($"zmogus.Vardas: {zmogus.Vardas}");

            var zmogus2 = zmogus; // zmogus2 = #JN5415DFDG
            Console.WriteLine($"zmogus2.Vardas: {zmogus2.Vardas}");

            if (zmogus == zmogus2)
            {
                Console.WriteLine($"zmogus == zmogus2: {zmogus == zmogus2}");
            }

            var zmogus3 = new Zmogus();
            zmogus3.Vardas = "Andrius";

            if (zmogus != zmogus3)
            {
                Console.WriteLine($"zmogus == zmogus3: {zmogus == zmogus3}");
            }

            zmogus2.Vardas = "Antanas";
            Console.WriteLine($"zmogus.Vardas: {zmogus.Vardas}");

            int skaicius = 42;
            int skaicius2 = skaicius;
            skaicius2 = 10;

            var zmogus4 = new Zmogus(); // #ASFSDGSEG
            var zmogus5 = zmogus4; // #ASFSDGSEG
            zmogus4.Vardas = "Ieva";
            Console.WriteLine($"zmogus4.Vardas: {zmogus4.Vardas}");
            zmogus4 = zmogus; // #JN5415DFDG
            zmogus = zmogus4; // #JN5415DFDG
            Console.WriteLine($"Pasikeites zmogus4.Vardas: {zmogus4.Vardas}");
            Console.WriteLine($"Pasikeites zmogus5.Vardas: {zmogus5.Vardas}");
            // Garbage Collector surenka ir isvalo musu duomenis #ASFSDGSEG. Sitoj vietoj jau nebegalime pasiekti zmogus4 inicijuoto objekto.
            zmogus5 = new Zmogus();
            var zmones = new List<Zmogus>();

            // 1kb * 1000000 = 1000000kb
            // Ideti laikmati/timer
            for (int i = 0; i < 1000000; i++)
            {
                //int megstamiausiasSkaicius = 17;
                var naujasZmogus = new Zmogus(); // 1kb
                naujasZmogus.Vardas = "Terminatorius" + i;
                naujasZmogus.Pavarde = "Terminatorius" + i * 2;
                zmones.Add(naujasZmogus);
                //megstamiausiasSkaicius++;
                //Console.WriteLine($"megstamiausiasSkaicius: {megstamiausiasSkaicius}");
            }

            //foreach (var homosapiens in zmones)
            //{
            //    Console.WriteLine($"homosapiens vardas: {homosapiens.Vardas}");
            //}

            //var skaiciukas1 = 12;
            //for (int i = 0; i < 3; i++)
            //{
            //    var skaiciukas2 = 15;
            //    skaiciukas1++;
            //    skaiciukas2++;
            //    Console.WriteLine($"skaiciukas1:{skaiciukas1}\nskaiciukas2: {skaiciukas2}");
            //}

            var zmogus6 = new Zmogus()
            {
                Vardas = "Alfonsas",
                Pavarde = "Azuolinis"
            };

            var pilnasZmogusVardas = zmogus6.GrazintiVarda();
            var asd = zmogus6.GrazintiVarda();
            var pilnasZmogusSventasVardas = zmogus6.GrazintiVarda("Kazimieras");
            var pavyzdysPilnovardo = zmogus6.GrazintiVarda();
            Console.WriteLine($"pilnasZmogusVardas: {pilnasZmogusVardas}");
            Console.WriteLine($"pilnasZmogusSventasVardas: {pilnasZmogusSventasVardas}");

            var zmogus7 = new Zmogus("Petras", "Blobulis");
            zmogus7.Amzius = 99;
            Console.WriteLine($"zmogus7.Amzius: {zmogus7.Amzius}");
        }

        public static void ZaistiSuPirmaisOopPavyzdziais()
        {
            var suo = new Suo("Debeselis", 3);
            var zmones = new List<Zmogus>()
            {
                new Zmogus("Petras"),
                new Zmogus("Antanina"),
                new Zmogus("Janina"),
                new Zmogus("Jonas"),
                new Zmogus("Ieva")
            };

            foreach (var zmogus in zmones)
            {
                suo.SusipazintiSuZmogumi(zmogus);
            }

            foreach (var pazintasZmogus in suo.pazintiZmones)
            {
                Console.WriteLine($"{suo.vardas} pazista {pazintasZmogus.GrazintiVarda()}");
            }

            var sunys = new List<Suo>()
            {
                new Suo("Pilkius", 5),
                new Suo("Bubzis", 5),
                new Suo("Litas", 5)
            };

            var seimininkas = new Seimininkas("Andrius", sunys);

            foreach (var seimininkoSunys in seimininkas.Sunys)
            {
                Console.WriteLine(seimininkoSunys.Kalbeti());
            }

            var figura1 = new Figura();
            figura1.kampuKiekis = 4;
            figura1.plotis = 5;
            figura1.aukstis = 5;

            var figura2 = new Figura();
            figura2.kampuKiekis = 5;
            figura2.plotis = 5;
            figura2.aukstis = 5;

            var arFiguraKvadratas1 = ArFiguraKvadratas(figura1);
            var arFiguraKvadratas2 = ArFiguraKvadratas(figura2);

            Console.WriteLine($"Ar figura1 yra kvadratas: {arFiguraKvadratas1}");
            Console.WriteLine($"Ar figura2 yra kvadratas: {arFiguraKvadratas2}");

            var trikampis = new Trikampis();

            var mokinys = new Mokinys();
        }

        public static bool ArFiguraKvadratas(Figura figura)
        {
            return figura.plotis == figura.aukstis
                && figura.kampuKiekis == 4;
        }
    }

    class Knyga
    {
        public string Pavadinimas { get; set; }
    }

    class Suo
    {
        public string vardas;
        public int amzius;
        public List<Zmogus> pazintiZmones = new List<Zmogus>();

        public Suo(string vardas, int amzius)
        {
            this.vardas = vardas;
            this.amzius = amzius;
        }

        public string Kalbeti()
        {
            return $"{vardas} sako 'Au'";
        }

        public int SusipazintiSuZmogumi(Zmogus zmogus)
        {
            Console.WriteLine($"Suniukas {vardas} susipazino su {zmogus.Vardas}");
            pazintiZmones.Add(zmogus);

            return pazintiZmones.Count;
        }
    }

    class Seimininkas
    {
        public Seimininkas()
        {
            Sunys = new List<Suo>();
        }
        public Seimininkas(string vardas, List<Suo> sunys)
        {
            Vardas = vardas;
            Sunys = sunys;
        }
        public string Vardas { get; set; }
        public List<Suo> Sunys { get; set; }
    }

    class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        //private string _pavarde;

        //public string Pavarde
        //{
        //    get { return _pavarde; }
        //    set { _pavarde = value; }
        //}

        // propfull
        // prop
        // ctor

        private string zodiakoZenklas;


        private int _amzius;

        public int Amzius
        {
            get
            {
                var rezultatas = _amzius;
                if (rezultatas > 10)
                {
                    rezultatas += 100;
                }
                else
                {
                    rezultatas += 999;
                }
                return rezultatas;
            }
            set { if (value > 10) _amzius = value; }
        }


        public Zmogus() { }
        public Zmogus(string vardas)
        {
            Vardas = vardas;
        }

        public Zmogus(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }
        public Zmogus(string vardas, string pavarde, string zodiakoZenklas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            this.zodiakoZenklas = zodiakoZenklas;
        }

        public Zmogus(List<string> vardasPavarde)
        {
            if (vardasPavarde.Count == 2)
            {
                Vardas = vardasPavarde[0];
                Vardas = vardasPavarde[1];
            }
            else
            {
                throw new Exception();
            }
        }

        public Zmogus SukurtiZmogu(Zmogus zmogus)
        {
            this.Vardas = zmogus.Vardas;
            this.Pavarde = zmogus.Pavarde;

            return this;
        }

        public void UzstatytiVarda(string vardas)
        {
            this.Vardas = vardas;
        }

        /// <summary>
        /// Grazina varda sujungta su pavarde
        /// </summary>
        /// <returns>Grazina varda sujungta su pavarde</returns>
        public string GrazintiVarda()
        {
            return Vardas + " " + Pavarde;
        }

        /// <summary>
        /// Grazina varda sujungta su pavarde ir sventuoju vardu
        /// </summary>
        /// <param name="sventasVardas">Sventasis zmogaus vardas</param>
        /// <returns>Grazina varda sujungta su pavarde ir sventuoju vardu</returns>
        public string GrazintiVarda(string sventasVardas)
        {
            return Vardas + " " + sventasVardas + " " + Pavarde;
        }

        public string GrazintiVarda(string sventasVardas, string papidomasVardas, int amzius)
        {
            return Vardas + " " + sventasVardas + " " + Pavarde;
        }

        public string GrazintiVarda(Zmogus zmogus)
        {
            return zmogus.Vardas + " " + zmogus.Pavarde;
        }

        public void AtspausdintiVarda()
        {
            var pilnasVardas = GrazintiVarda(this);
            Console.WriteLine(pilnasVardas);
        }

        public List<Zmogus> IstrauktiDuomenis()
        {
            return new List<Zmogus>();
        }

        public Zmogus IstrauktiDuomenis(int zmogusId)
        {
            return new Zmogus();
        }

        public Zmogus IstrauktiDuomenis(Zmogus zmogus)
        {
            return zmogus;
        }
    }
}