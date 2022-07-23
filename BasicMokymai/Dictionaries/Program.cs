namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Dictionaries!");
            //DictionaryPavyzdziai();
            AtspausdintiPirmasKlasesDarba();
        }

        public static void DictionaryPavyzdziai()
        {
            // Zodyno/Dictionary deklaravimas
            Dictionary<string, float> kainuZodynas = new Dictionary<string, float>(3);
            var kainuKintamasisZodynas = new Dictionary<string, float>();
            Dictionary<string, int> miestai = new Dictionary<string, int>
            {
                { "Vilnius", 7 },
                { "Kaunas", 6 },
                { "Siauliai", 8 },
                { "Jonava", 6 }
            };

            Dictionary<string, string> zodziuReiksmes = new Dictionary<string, string>()
            {
                { "Macnus", "Stipraus, astraus skonio" },
                { "Unaravas", "Pasiputes arba arogntiskas" },
                { "Ceckavot", "Smulkiai pjaustyti" },
                { "Bimbineti", "Leisti laika be jokio tikslo" },
                { "Katras", "Kuris is keliu galimu pasirinkimu" }
            };

            var varduZodynas = new Dictionary<int, string>()
            {
                { 1, "Andrius" },
                { 2, "Ieva" },
                { 3, "Aiste" },
                { 4, "Ieva" },
                { 5, "Eugenijus" }
            };

            Dictionary<string, List<int>> zaidejuTaskuZodynas = new Dictionary<string, List<int>>()
            {
                { "Ieva", new List<int>() { 9, 8, 10 } },
                { "Audrius", new List<int>() { 8, 10, 8, 10, 10 } },
                { "Veronika", new List<int>() { 10, 10, 10 } },
            };

            foreach (var zaidejas in zaidejuTaskuZodynas)
            {
                Console.Write(zaidejas.Key + " ");
                foreach (var taskai in zaidejas.Value)
                {
                    Console.Write(taskai + " ");
                }
                Console.WriteLine();
            }


            // Zodyno/Dictionary skaitymas
            Console.WriteLine($"Vilnius:{miestai["Vilnius"]} Kaunas:{miestai["Kaunas"]}");
            var miestoPavadinimoIlgis = miestai["Vilnius"];
            Console.WriteLine($"Kintamojo ilgis: {miestoPavadinimoIlgis}");

            // Zodyno/Dictionary pildymas
            miestai.Add("Klaipeda", 8);
            Console.WriteLine($"Klaipeda:{miestai["Klaipeda"]}");
            miestai["Silute"] = 6;
            Console.WriteLine($"Silute:{miestai["Silute"]}");

            // Zodyno/Dictionary skaitymas
            foreach (KeyValuePair<string, int> miestas in miestai)
            {
                Console.WriteLine(miestas);
            }

            foreach (var miestas in miestai)
            {
                Console.WriteLine(miestas.Key);
            }

            foreach (var miestas in miestai)
            {
                Console.WriteLine(miestas.Value);
            }

            foreach (var miestas in miestai)
            {
                Console.WriteLine("Raktas = {0}, Reiksme = {1}", miestas.Key, miestas.Value);
            }

            for (int i = 1; i <= varduZodynas.Count; i++)
            {
                Console.WriteLine($"{varduZodynas[i]}");
            }

            // Zodyno/Dictionary iraso validavimas
            if (miestai.TryGetValue("Klaipedaa", out int miestoSkaicius))
            {
                Console.WriteLine($"Klaipeda: {miestoSkaicius}");
            }
            else
            {
                Console.WriteLine($"Neradome iraso");
            }

            if (!miestai.ContainsKey("Klaipeda"))
            {
                Console.WriteLine($"Neradome iraso");
            }
            else
            {
                Console.WriteLine($"Klaipeda: {miestoSkaicius}");
            }

            // Zodyno/Dictionary ValueCollection
            Dictionary<string, int>.ValueCollection miestuReiksmes = miestai.Values;

            foreach (int miestoPavadinimoReiksme in miestuReiksmes)
            {
                Console.WriteLine("Reiksme = {0}", miestoPavadinimoReiksme);
            }

            // Zodyno/Dictionary KeyCollection
            Dictionary<string, int>.KeyCollection miestuRaktai = miestai.Keys;
            var miestuRaktaiSuVar = miestai.Keys;

            foreach (string miestoPavadinimoRaktas in miestuRaktai)
            {
                Console.WriteLine("Raktas = {0}", miestoPavadinimoRaktas);
            }

            // Zodyno/Dictionary irasu isemimas
            varduZodynas.Remove(2);

            //for (int i = 1; i <= varduZodynas.Count; i++)
            //{
            //    Console.WriteLine($"{varduZodynas[i]}");
            //}

            foreach (var vardas in varduZodynas)
            {
                Console.WriteLine("Vardas = {0}", vardas.Value);
            }

            if (!varduZodynas.ContainsKey(2))
            {
                Console.WriteLine("Neradome iraso");
            }
            else
            {
                Console.WriteLine($"Vardas: {varduZodynas[2]}");
            }

            // Zodyno/Dictionary isvalymas
            var skaiciuZodynas = new Dictionary<int, int>
            {
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
                { 5, 5 },
            };

            skaiciuZodynas.Clear();

            if (skaiciuZodynas.Count == 0)
            {
                Console.WriteLine("Irasu nerasta");
            }
            else
            {
                Console.WriteLine("Zodynas turi daugiau nei 0 irasu");
            }
        }

        /*
         * KLASES DARBAS 1. ## Parasykite metoda, kuris priima sveikaji skaiciu kaip parametra ir sukuria nauja zodyna - raktas:x, reiksme:x*x formoje. 
         * Pvz: Ivestis-5 1:1 2:4 3:9 4:16 5:25
         * 
         * 
         */
        public static void AtspausdintiPirmasKlasesDarba()
        {
            var zodynas = PastatytiSkaiciausKvadratoZodynas(5);
            foreach (var irasas in zodynas)
            {
                Console.Write($"{irasas.Key}:{irasas.Value} ");
            }

        }


        public static Dictionary<int, int> PastatytiSkaiciausKvadratoZodynas(int skaicius)
        {
            Dictionary<int, int> skaiciuZodynas = new Dictionary<int, int>();

            for (int i = 1; i <= skaicius; i++)
            {
                skaiciuZodynas.Add(i, i * i);
            }
            

            return skaiciuZodynas;
        }

    }
}