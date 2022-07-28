/*
- Naudotojas pasirenka iš temų: VARDAI, LIETUVOS MIESTAI, VALSTYBES, KITA. 
  (ne mažiau kaip 10 žodžių kiekvienoje grupėje)
- Žodis iš pasirinktos grupės parenkamas atsitiktine tvarka.
- Užtikrinti kad nebūtu duodamas tas pat žodis daugiau kaip 1 kartą per žaidimą
- Užtikrinti, kad programą nenulūžtu jei vartotojas įveda ne tai ko prašoma
- Ėjimas skaitomas tik jei spėjama dar nespėta raidė
- Jei spėjamas visas žodis ir neatspėjama - iškarto pralaimima
- Parodoma atspėtos raidės vieta žodyje
- Parodomos spėtos, bet neatspėtos raidės

Apribojimai:
- Žodžius saugoti masyvuose  arba žodyne.
- Kodą skaidyti į metodus.
- negalima naudoti OOP ir LINQ
 */

namespace Hangman
{

    public class Program
    {
        static Dictionary<int, string[]> zodziai = new Dictionary<int, string[]>();

        static char[,,] zmogelis = new char[8, 4, 3]{
                {
                {' ',' ',' ' },
                {' ',' ',' ' },
                { ' ',' ',' ' },
                { ' ',' ',' ' }
                },
                {
                {' ','O',' ' },
                {' ',' ',' ' },
                { ' ',' ',' ' },
                { ' ',' ',' ' }
                },
                {
                {' ','O',' ' },
                {' ','|',' ' },
                { ' ',' ',' ' },
                { ' ',' ',' ' }
                },
                {
                {' ','O',' ' },
                {'\\','|',' ' },
                { ' ',' ',' ' },
                { ' ',' ',' ' }
                },
                {
                {' ','O',' ' },
                {'\\','|','/' },
                { ' ',' ',' ' },
                { ' ',' ',' ' }
                },
                {
                {' ','O',' ' },
                {'\\','|','/' },
                { ' ','O',' ' },
                { ' ',' ',' ' }
                },
                {
                {' ','O',' ' },
                {'\\','|','/' },
                { ' ','O',' ' },
                { '/',' ',' ' }
                },
                {
                {' ','O',' ' },
                {'\\','|','/' },
                { ' ','O',' ' },
                { '/',' ','\\' }
                }
            };

        static void Main(string[] args)
        {
            bool testi = true;
            string pasirinkta_tema = "";

            Reset();

            while (testi)
            {
                Console.Clear();
                switch (Temos_pasirinkimas())
                {
                    case 1:
                        pasirinkta_tema = "VARDAI"; ;
                        break;
                    case 2:
                        pasirinkta_tema = "MIESTAI";
                        break;
                    case 3:
                        pasirinkta_tema = "VALSTYBES";
                        break;
                    case 4:
                        pasirinkta_tema = "KITA";
                        break;
                }

                if (ArYraNepanaudotuZodziuTemoje(pasirinkta_tema))
                {

                    zaidimas_kartuves(ParinktiAtsitiktiniZodiTemoje(pasirinkta_tema));
                    testi = true;
                }
                else
                {
                    Console.WriteLine($"Temoje {pasirinkta_tema} neliko žodžių. Pasirinkite kitą temą.");
                    Console.ReadKey();
                }



                Console.WriteLine(zodziai.Count());
                if (zodziai.Count() == 0)
                {
                    testi = false;
                    Console.WriteLine("Visuose temose neliko žodžių. Žaidimas užbaigtas.");
                    Console.ReadKey();
                }
            }
        }

        public static int Temos_pasirinkimas()
        {
            bool testi = true;
            int tema = 0;


            while (testi)
            {
                Console.Clear();
                Console.WriteLine($"Pasirinkite temą:\n" +
                "1. VARDAI\n" +
                "2. LIETUVOS MIESTAI\n" +
                "3. VALSTYBES\n" +
                "4. KITA");
                if (int.TryParse(Console.ReadLine(), out tema) && (tema >= 1 && tema <= 4))
                {
                    testi = false;
                }
                else
                {
                    Console.WriteLine("Pasirinkite tema nuo 1 iki 4.");
                    Console.ReadKey();
                }
            }
            return tema;
        }

        public static void Nupiesti_zmogeli(char[,,] zmogelis, int karimo_stadija)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("|           ");
                for (int ii = 0; ii < 3; ii++)
                {
                    Console.Write(zmogelis[karimo_stadija, i, ii]);
                }
                Console.WriteLine();
            }
        }

        public static void Nupiesti_kartuves(char[,,] zmogelis, int karimo_stadija)
        {
            Console.WriteLine(" - - - - - - |");
            Nupiesti_zmogeli(zmogelis, karimo_stadija);
            Console.WriteLine("|");
            Console.WriteLine("- - - -");
        }

        static void Atvaizduok_zodi(string zodis, bool[] mask)
        {
            Console.Write("Žodis: ");
            for (int i = 0; i < zodis.Length; i++)
            {
                if (mask[i])
                {
                    Console.Write(zodis[i]);
                }
                else
                {
                    Console.Write("- ");
                }


            }
            Console.WriteLine();
        }


        static bool Atidenk_raide(string zodis, bool[] mask, char raide)
        {
            bool yra_raide = false;
            for (int i = 0; i < zodis.Length; i++)
            {
                if (zodis[i] == raide)
                {
                    mask[i] = true;
                    yra_raide = true;
                }

            }
            return yra_raide;
        }

        static public bool Atidenktos_visos_raides(bool[] mask)
        {
            bool visos_raides = true;
            for (int i = 0; i < mask.Length; i++)
            {
                if (mask[i] == false)
                {
                    visos_raides = false;
                }

            }
            return visos_raides;
        }

        static public void Reset()
        {

            zodziai.Clear();
            zodziai = new Dictionary<int, string[]>()
             {
                { 1, new string[2] { "VARDAI", "Vitas"} },
                { 2, new string[2] { "VARDAI", "Petras"} },
                { 3, new string[2] { "VARDAI", "Jonas"} },
                { 4, new string[2] { "VARDAI", "Rasa"} },
                { 5, new string[2] { "VARDAI", "Alfredas" } },
                { 6, new string[2] { "VARDAI", "Egidijus" } },
                { 7, new string[2] { "VARDAI", "Anastasija"} },
                { 8, new string[2] { "VARDAI", "Viktorija" } },
                { 9, new string[2] { "VARDAI", "Aldona" } },
                { 10, new string[2] { "VARDAI", "Monika" } },
                { 11, new string[2] { "MIESTAI", "Vilnius" } },
                { 12, new string[2] { "MIESTAI", "Kaunas" } },
                { 13, new string[2] { "MIESTAI", "Jonava" } },
                { 14, new string[2] { "MIESTAI", "Alytus" } },
                { 15, new string[2] { "MIESTAI", "Ariogala"} },
                { 16, new string[2] { "MIESTAI", "Druskininkai"} },
                { 17, new string[2] { "MIESTAI", "Dusetos"} },
                { 18, new string[2] { "MIESTAI", "Garliava" } },
                { 19, new string[2] { "MIESTAI", "Ignalina" } },
                { 20, new string[2] { "MIESTAI", "Jurbarkas" } },
                { 21, new string[2] { "VALSTYBES", "Lietuva" } },
                { 22, new string[2] { "VALSTYBES", "Latvija" } },
                { 23, new string[2] { "VALSTYBES", "Estija" } },
                { 24, new string[2] { "VALSTYBES", "Lenkija" } },
                { 25, new string[2] { "VALSTYBES", "Ukraina" } },
                { 26, new string[2] { "VALSTYBES", "Airija" } },
                { 27, new string[2] { "VALSTYBES", "Japonija" } },
                { 28, new string[2] { "VALSTYBES", "Panama" } },
                { 29, new string[2] { "VALSTYBES", "Belgija" } },
                { 30, new string[2] { "VALSTYBES", "Rumunija" } },
                { 31, new string[2] { "KITA", "Laris" } },
                { 32, new string[2] { "KITA", "Euras" } },
                { 33, new string[2] { "KITA", "Microsoft" } },
                { 34, new string[2] { "KITA", "Kodas" } },
                { 35, new string[2] { "KITA", "Mokymai" } },
                { 36, new string[2] { "KITA", "Programa"} },
                { 37, new string[2] { "KITA", "Projektas" } },
                { 38, new string[2] { "KITA", "Programuotojas" } },
                { 39, new string[2] { "KITA", "Praktika", } },
                { 40, new string[2] { "KITA", "Forumas" } }
            };

        }

        static public bool ArYraNepanaudotuZodziuTemoje(string tema)
        {
            bool rezultatas = false;
            foreach (var zodis in zodziai)
            {
                if (zodis.Value[0] == tema)
                {
                    rezultatas = true;
                    break;
                }
            }

            return rezultatas;
        }

        static public void zaidimas_kartuves(string zodis)
        {

            int gyvybiu_likutis = 7;
            bool zodis_atspetas = false;

            String pasirinktas_zodis = zodis;
            bool[] atvaizduojamos_raides = new bool[pasirinktas_zodis.Length];

            List<char> spetos_raides = new List<char>();

            spetos_raides.Clear();


            while (gyvybiu_likutis > 0 && !zodis_atspetas)
            {

                Console.Clear();
                Nupiesti_kartuves(zmogelis, 7 - gyvybiu_likutis);

                if (spetos_raides.Count() > 0) Console.WriteLine("Spėtos raidės:" + string.Join(",", spetos_raides.ToArray()));

                Atvaizduok_zodi(pasirinktas_zodis, atvaizduojamos_raides);


                String vartotojoIvestis = IvedimasIsKlaviaturos("Spėkite raidę ar žodį:");


                if (vartotojoIvestis.Length == 1)
                {
                    if (!Atidenk_raide(pasirinktas_zodis, atvaizduojamos_raides, vartotojoIvestis[0]))
                    {
                        gyvybiu_likutis--;
                        spetos_raides.Add(vartotojoIvestis[0]);
                    }
                }
                else if (vartotojoIvestis.Equals(pasirinktas_zodis))
                {
                    zodis_atspetas = true;
                }
                else gyvybiu_likutis--;



                if (Atidenktos_visos_raides(atvaizduojamos_raides))
                {
                    zodis_atspetas = true;

                }
                else Console.WriteLine("Bandymu likutis: " + gyvybiu_likutis);
                if (zodis_atspetas)
                {
                    Console.WriteLine(pasirinktas_zodis);
                    Console.WriteLine("Žodis atspetas.");
                }
            }

        }


        static int AtsitiktinisSkaicius(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static string ParinktiAtsitiktiniZodiTemoje(string tema)
        {
            string rezultatas = "";

            bool ieskoti = true;
            int zodzio_nr = 0;
            while (ieskoti)
            {
                zodzio_nr = AtsitiktinisSkaicius(1, 40 + 1);

                //patikrinti ar tokiu numeriu yra zodis sarase, jeigu nera tada generuojamas kitas numeris 
                if (zodziai.ContainsKey(zodzio_nr))
                {
                    if (zodziai[zodzio_nr].GetValue(0) == tema)
                    {
                        rezultatas = zodziai[zodzio_nr].GetValue(1).ToString();
                        ieskoti = false;
                        // surasta zodis is karto salinamas is zodziu saraso
                        zodziai.Remove(zodzio_nr);
                    }
                }
            }

            return rezultatas;
        }

        public static string IvedimasIsKlaviaturos(string aprasymas)
        // Įvedimas iš klaviaturos su pilnu aprašymu atvaizdavimu.
        // Grąžinamas string kuris yra įvestas.
        {
            Console.WriteLine(aprasymas);
            string ivestasTekstas = Console.ReadLine();
            return ivestasTekstas;
        }
    }
 }