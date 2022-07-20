using System.Text;

namespace ForEach
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, ForEach!");

            TreciasKlasesUzdavinys();

        }

        #region PERPANAUDOJAMI METODAI
        private static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;
        #endregion

        public static void PavyzdziaiForEachKvietimai()
        {
            int[] taskuMasyvas = new int[10];

            // int taskas = default(int);
            taskuMasyvas[0] = 1;
            foreach (int taskai in taskuMasyvas)
            {
                Console.WriteLine($"{taskai} - Naujas elementas");
            }

            string[] masinos = new string[] { "BMW", "Audi", "Toyota" };

            foreach (string masina in masinos)
            {
                Console.WriteLine($"{masina}");
            }

            List<int> amziai = new List<int> { 19, 20, 21 };

            foreach (var amzius in amziai)
            {
                Console.WriteLine($"Amzius: {amzius}");
            }

            List<string> vardai = new List<string> { "Ieva", "Vitas", "Vardenis" };

            foreach (var vardas in vardai)
            {
                Console.WriteLine($"Vardas: {vardas}");
            }

            foreach (var vardas in vardai)
            {
                foreach (var amzius in amziai)
                {
                    Console.WriteLine($"Vardas {vardas} ir Amzius: {amzius + 5}");
                }

            }

            foreach (var vardas in vardai)
            {
                if (vardas == "Vardenis") break;
                Console.WriteLine($"Vardas: {vardas}");
            }

            string sakinys = "Buvo karta erdve";

            foreach (var raide in sakinys)
            {
                if (raide == 'd') break;
                Console.WriteLine(raide);
            }

            var spalvos = new List<string>();
            spalvos.Add("Melyna");
            spalvos.Add("Zalia");
            spalvos.Add("Geltona");

            foreach (var spalva in spalvos)
            {
                Console.WriteLine($"Spalva: {spalva}");
            }
        }

        /*
         * KLASES DARBAS 1. ## Parasykite programa, kuri apskaiciuotu duoto integer saraso vidurki. 
         */

        public static void PirmasKlasesUzdavinys()
        {
            List<int>  skaiciai = new List<int>()
            {
                1, 5, 8, 9, 8, 5
            };

            var rezultatas = ApskaiciuotiVidurki(skaiciai);
            Console.WriteLine($"Pirmo uzdavinio rezultatas: {rezultatas}");
        }

        public static double ApskaiciuotiVidurki(List<int> skaiciai)
        {
            var vidurkis = 0;
            foreach (var skaicius in skaiciai)
            {
                vidurkis += skaicius;
            }
            return vidurkis/skaiciai.Count;
        }

        /*
         * KLASES DARBAS 2. ## Parasykite metoda, kuris grazina ar skaicius neigiamas ar teigiamas masyve.
         */
        public static void AntrasKlasesUzdavinys()
        {
            List<int> skaiciai = new List<int>()
            {
                1, 5, -8, 9, 8, -5
            };

            List<string> rezultatas = TikrintiSkaiciausTeigiamuma(skaiciai);

            foreach (var skaiciausTeigiamumas in rezultatas)
            {
                Console.WriteLine($"Ar skaicius teigiamas: {skaiciausTeigiamumas}");
            }

            
        }

        public static List<string> TikrintiSkaiciausTeigiamuma(List<int> skaiciai)
        {
            var skaiciuTeigiamumas = new List<string>();


            foreach (var skaicius in skaiciai)
            {
                if (skaicius >= 0)
                    skaiciuTeigiamumas.Add("Teigiamas");
                else
                    skaiciuTeigiamumas.Add("Neigiamas");
            }
            return skaiciuTeigiamumas;
        }

        public static double ApskaiciuotiGPM(List<double> imokos, int gpm)
        {
            var galutinisMokestis = 0d;
            foreach (var imoka in imokos)
            {
                galutinisMokestis += imoka;
            }
            return galutinisMokestis * (gpm/100d);
        }

        /*
         *  Parašyti metodą IstrauktiSkaicius, kuris priima teksta, bet grazina tik skaicius egzistuojancius paciame tekste.
          Isgavus teksta programa turetu naudoti naujai sukurta SurikiuotiSkaiciusIsTeksto metoda, kuris priima "string skaiciaiTekste" ir surikiuoja skaicius
          didejimo tvarka. SurikiuotiSkaiciusIsTeksto privalo panaudoti foreach, kad suformuotumet nauja List<int>:
          PVZ: Ivedame: 1sd512sd5. Programa be rusiavimo grazina mums: 15125. Programa su rusiavimu grazina mums: 11255
         * 
         */
        public static void TreciasKlasesUzdavinys()
        {
     
            Console.WriteLine(IstrauktiSkaicius("1sd512sd5"));
     
        }


        public static string IstrauktiSkaicius(string tekstas)
        {
            var skaiciaiTekste =new StringBuilder();

            foreach (var simbolis in tekstas)
            {
                if (char.IsDigit(simbolis)) skaiciaiTekste.Append(simbolis);
            }
            return skaiciaiTekste.ToString();
        }

        public static List<int> SurikiuotiSkaiciusIsTeksto( string skaiciaiTekste)
        {
            List<int> skaiciai = new List<int>();

            foreach (var skaicius in skaiciaiTekste)
            {
                skaiciai.Add(skaicius);
                // skaiciai.Add(SkaiciausTikrinimas(skaicius.ToString()));
            }

            skaiciai.Sort();

            return skaiciai;
        }

        public static void AtspausdintiSkaicius(List<int> skaiciai)
        {
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius.ToString());
            }
        }

        /*
         *  ///  Parašyti metodą IsmetytiZodzius, kuris priima sakini, bet grazina nauja zodziu List sudaryta tik is zodziu, kurie ilgesni arba lygus 5 raides ir yra surikiuoti abeceles tvarka.
        ///  Tada parasykite metoda, kuris priima 2 zodziu sarasus, juos sujungia i viena kolekcija naudojant ciklus ir atspausdina ekrane.
        ///  PRIMINIMAS: Kad isskirti string i atskirus zodzius naudokite pavyzdinisString.Split(' ')
        ///  PVZ: Ivedame: "Labas as esu Kodelskis ir labai megstu programuoti". 
        ///  Programa be rusiavimo grazina mums: as esu ir Labas Kodelskis labai megstu programuoti
        ///  Programa su rusiavimu grazina mums: as esu ir Kodelskis labai Labas megstu programuoti
         * 
         * 
         */


    }
}