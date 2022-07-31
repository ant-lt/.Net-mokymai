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

using System.Text;

namespace Hangman
{

    public class Program
    {
        public static Dictionary<int, string[]> zodziai = new Dictionary<int, string[]>();
        static string pasirinkta_tema="";

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
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            bool testi = true;

            // inicializuojamas spejamų žodžių sąrašas
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
                
                if (ArYraNepanaudotuZodziuTemoje( pasirinkta_tema ))
                {
                   zaidimas_kartuves( ParinktiAtsitiktiniZodiTemoje( pasirinkta_tema ) );                   
                   if (IvedimasTaipNe("Pakartoti žaidimą T / N ?"))
                    testi = true;
                   else
                    testi = false;
                }
                else
                {
                    Console.WriteLine($"Temoje {pasirinkta_tema} neliko žodžių. Pasirinkite kitą temą.");
                    Console.ReadKey();
                }

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
                "3. VALSTYBĖS\n" +
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

        public static string Nupiesti_zmogeli(int karimo_stadija)
        //suformuojamas žmogelio vaizdas priklausomai nuo karimo stadijos
        {
            var zmogelioVaizdoKonstruktorius = new StringBuilder();
            for (int i = 0; i < zmogelis.GetLength(1); i++)
            {
                zmogelioVaizdoKonstruktorius.Append("|           ");
                for (int ii = 0; ii < zmogelis.GetLength(2); ii++)
                {
                    zmogelioVaizdoKonstruktorius.Append(zmogelis[karimo_stadija, i, ii]);
                }
                zmogelioVaizdoKonstruktorius.AppendLine();
            }
            return zmogelioVaizdoKonstruktorius.ToString();
        }

        public static void Nupiesti_kartuves( int karimo_stadija)
        {
            Console.WriteLine(" - - - - - - |");
            Console.Write(Nupiesti_zmogeli(karimo_stadija));
            Console.WriteLine("|");
            Console.WriteLine("- - - -");
        }

        static public string Atvaizduok_zodi(string zodis, bool[] mask)
        // suformuojamas žodis ir atidengiamos tuos raidės kurios atitinka mask'es
        {
            var zodzioKonstruktorius = new StringBuilder();
            
            for (int i = 0; i < zodis.Length; i++)
            {
                if (mask[i])
                {
                    zodzioKonstruktorius.Append(zodis[i] + " ");
                }
                else
                {
                    zodzioKonstruktorius.Append("_ ");
                }
            }
            return zodzioKonstruktorius.ToString();
        }


        static public bool Atidenk_raide(string zodis, bool[] mask, char raide)
            // maskes masyve yra pazymemos True tuos raides kurios sutapo ir grąžina true jeigu buvo atidengta bent viena raidę
        {
            bool yra_raide = false;
            for (int i = 0; i < zodis.Length; i++)
            {
                if (Char.ToUpper(zodis[i]) == Char.ToUpper(raide))
                {
                    mask[i] = true;
                    yra_raide = true;
                }

            }
            return yra_raide;
        }

        static public bool Atidenktos_visos_raides(bool[] mask)
        // Patikrinama ar atspetos visos raidės žodyje
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
        //inicializuojamas spejamų žodžių sąrašas
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
            pasirinkta_tema = "";
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

            bool testi = true;
            int gyvybiu_likutis = 7;
            bool zodis_atspetas = false;

            String pasirinktas_zodis = zodis;
            bool[] atvaizduojamos_raides = new bool[pasirinktas_zodis.Length];

            List<char> spetos_raides = new List<char>();

            spetos_raides.Clear();


            while (testi)
            {
                Console.Clear();
                Console.WriteLine($"\n   Tema: {pasirinkta_tema}");

                Nupiesti_kartuves(7 - gyvybiu_likutis);

                if (spetos_raides.Count() > 0) Console.WriteLine("Spėtos raidės:" + string.Join(",", spetos_raides.ToArray()));

                Console.WriteLine("Žodis: "+ Atvaizduok_zodi(pasirinktas_zodis, atvaizduojamos_raides));
                

                String vartotojoIvestis = "";
                if (gyvybiu_likutis > 0 && !zodis_atspetas)
                    vartotojoIvestis = IvedimasIsKlaviaturos("Spėkite raidę ar žodį:");
                else
                {
                    zodis_atspetas = false;
                    Console.WriteLine($":( PRALAIMĖJOTE :(\nŽodis buvo: {zodis}");
                    testi = false;
                }
                

                // tikrinam ar įvesta yra viena raide ar žodis
                if (vartotojoIvestis.Length == 1 && char.IsLetter(vartotojoIvestis[0]) && gyvybiu_likutis >0 && !zodis_atspetas)
                {
                    if (!Atidenk_raide(pasirinktas_zodis, atvaizduojamos_raides, vartotojoIvestis[0]))
                    {
                        if (!spetos_raides.Contains(vartotojoIvestis[0])) // patikrinam ar raide buvo jau spėta
                        {
                            gyvybiu_likutis--;// - Ėjimas skaitomas tik jei spėjama dar nespėta raidė
                            spetos_raides.Add(vartotojoIvestis[0]);
                        }
                    }
                }
                // kai lyginama ar žodis atspetas, naudojamos didžiosioses raidės.
                else if (vartotojoIvestis.Length > 1 && vartotojoIvestis.ToUpper().Equals(pasirinktas_zodis.ToUpper()))
                {
                    zodis_atspetas = true;
                }
                else if (vartotojoIvestis.Length > 1 && !vartotojoIvestis.ToUpper().Equals(pasirinktas_zodis.ToUpper()))
                {
                    zodis_atspetas = false;
                    gyvybiu_likutis = 0;
                    Console.WriteLine($":( PRALAIMĖJOTE :(\nŽodis buvo: {zodis}");
                    testi = false;
                }
                else if (vartotojoIvestis.Length == 0) { }
                else gyvybiu_likutis--;

                if (Atidenktos_visos_raides(atvaizduojamos_raides))
                {
                    zodis_atspetas = true;
                    testi = false;
                }
                if (zodis_atspetas)
                {
                    testi = false;
                    Console.WriteLine($"!!!SVEIKINIMAI!!!\n:) ŽODIS {zodis} TEISINGAS :)");
                }
            }

        }


        public static int AtsitiktinisSkaicius(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static string ParinktiAtsitiktiniZodiTemoje(string tema)
        {
            //Parenka atsitiktini žodį pagal užduota temą ir jeigu parenkamas žodis, jis iš karto pašalinamas iš sąrašo galimų žodžių
            string rezultatas = "";

            bool ieskoti = true;
            int zodzio_nr = 0;
            while (ieskoti)
            {
                zodzio_nr = AtsitiktinisSkaicius(1, 40 + 1);

                //patikrinti ar tokiu numerių yra žodis saraše, jeigu nėra tada generuojamas kitas numeris 
                if (zodziai.ContainsKey(zodzio_nr))
                {
                    if (tema.Equals(zodziai[zodzio_nr].GetValue(0))) // patikrinama kad surasto žodžio tema sutampa su užduota
                    {
                        rezultatas = zodziai[zodzio_nr].GetValue(1)
                                                       .ToString();
                        ieskoti = false;
                        // Surastas žodis iš karto šalinamas iš žodžių sąrašo.
                        // Taip užtikrinama, kad nebūtu duodamas tas pat žodis daugiau kaip 1 kartą per žaidimą
                        zodziai.Remove(zodzio_nr);
                    }
                }
                else if (zodziai.Count() == 0) // jeigu baigesi visi žodžiai tada nutraukiam paieška
                    ieskoti = false;

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

        public static bool IvedimasTaipNe(string aprasymas)
            // Laukia ivedimo tik T arba N , veiks kol nebus ivesta T arba N
        {
            bool atsakymas = false;
            bool laukti = true;

            string ivedimas = "";

            while (laukti)
            {
                ivedimas= IvedimasIsKlaviaturos(aprasymas);
                if (ivedimas.Length == 1 && char.ToUpper(ivedimas[0]) == 'T')
                {
                    atsakymas = true;
                    laukti = false;
                }
                else if (ivedimas.Length == 1 && char.ToUpper(ivedimas[0]) == 'N')
                {
                    atsakymas = false;
                    laukti = false;
                }
                else laukti = true;
            }
            return atsakymas;
        }

    }
}