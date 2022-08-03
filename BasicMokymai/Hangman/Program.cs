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
        static string pasirinktaTema="";
        static int gyvybes = 7;
        static int pradinisKlausimuSkaicius = 0;

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
                switch (TemosPasirinkimas())
                {
                    case 1:
                        pasirinktaTema = "VARDAI"; ;
                        break;
                    case 2:
                        pasirinktaTema = "MIESTAI";
                        break;
                    case 3:
                        pasirinktaTema = "VALSTYBES";
                        break;
                    case 4:
                        pasirinktaTema = "KITA";
                        break;
                }
                
                if (ArYraNepanaudotuZodziuTemoje( pasirinktaTema ))
                {
                   ZaidimasKartuves( ParinktiAtsitiktiniZodiTemoje( pasirinktaTema ) );                   
                   if (IvedimasTaipNe("Pakartoti žaidimą T / N ?"))
                    testi = true;
                   else
                    testi = false;
                }
                else
                {
                    Console.WriteLine($"Temoje {pasirinktaTema} neliko žodžių. Pasirinkite kitą temą.");
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

        public static int TemosPasirinkimas()
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

        public static string NupiestiZmogeli(int karimoStadija)
        //suformuojamas žmogelio vaizdas priklausomai nuo karimo stadijos
        {
            var zmogelioVaizdoKonstruktorius = new StringBuilder();
            for (int i = 0; i < zmogelis.GetLength(1); i++)
            {
                zmogelioVaizdoKonstruktorius.Append("|           ");
                for (int ii = 0; ii < zmogelis.GetLength(2); ii++)
                {
                    zmogelioVaizdoKonstruktorius.Append(zmogelis[karimoStadija, i, ii]);
                }
                zmogelioVaizdoKonstruktorius.AppendLine();
            }
            return zmogelioVaizdoKonstruktorius.ToString();
        }

        public static void NupiestiKartuves( int karimoStadija)
        {
            Console.WriteLine(" - - - - - - |");
            Console.Write(NupiestiZmogeli(karimoStadija));
            Console.WriteLine("|");
            Console.WriteLine("- - - -");
        }

        static public string AtvaizduokZodi(string zodis, bool[] mask)
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


        static public bool AtidenkRaide(string zodis, bool[] mask, char raide)
            // maskes masyve yra pazymemos True tuos raides kurios sutapo ir grąžina true jeigu buvo atidengta bent viena raidę
        {
            bool yraRaide = false;
            for (int i = 0; i < zodis.Length; i++)
            {
                if (Char.ToUpper(zodis[i]) == Char.ToUpper(raide))
                {
                    mask[i] = true;
                    yraRaide = true;
                }

            }
            return yraRaide;
        }

        static public bool AtidenktosVisosRaides(bool[] mask)
        // Patikrinama ar atspetos visos raidės žodyje
        {
            bool visosRaides = true;
            for (int i = 0; i < mask.Length; i++)
            {
                if (mask[i] == false)
                {
                    visosRaides = false;
                }
            }
            return visosRaides;
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
            pasirinktaTema = "";
            pradinisKlausimuSkaicius = zodziai.Count();
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

        static public void ZaidimasKartuves(string zodis)
        {

            bool testi = true;
            int gyvybiuLikutis = gyvybes;
            bool zodisAtspetas = false;

            String pasirinktasZodis = zodis;
            bool[] atvaizduojamosRaides = new bool[pasirinktasZodis.Length];

            List<char> spetosRaides = new List<char>();

            spetosRaides.Clear();


            while (testi)
            {
                Console.Clear();
                Console.WriteLine($"\n   Tema: {pasirinktaTema}");

                NupiestiKartuves(7 - gyvybiuLikutis);

                if (spetosRaides.Count() > 0) Console.WriteLine("Spėtos raidės:" + string.Join(",", spetosRaides.ToArray()));

                Console.WriteLine("Žodis: "+ AtvaizduokZodi(pasirinktasZodis, atvaizduojamosRaides));
                

                String vartotojoIvestis = "";
                if (gyvybiuLikutis > 0 && !zodisAtspetas)
                    vartotojoIvestis = IvedimasIsKlaviaturos("Spėkite raidę ar žodį:");
                else
                {
                    zodisAtspetas = false;
                    Console.WriteLine($":( PRALAIMĖJOTE :(\nŽodis buvo: {zodis}");
                    testi = false;
                }
                

                // tikrinam ar įvesta yra viena raide ar žodis
                if (vartotojoIvestis.Length == 1 && char.IsLetter(vartotojoIvestis[0]) && gyvybiuLikutis >0 && !zodisAtspetas)
                {
                    if (!AtidenkRaide(pasirinktasZodis, atvaizduojamosRaides, vartotojoIvestis[0]))
                    {
                        if (!spetosRaides.Contains(vartotojoIvestis[0])) // patikrinam ar raide buvo jau spėta
                        {
                            gyvybiuLikutis--;// - Ėjimas skaitomas tik jei spėjama dar nespėta raidė
                            spetosRaides.Add(vartotojoIvestis[0]);
                        }
                    }
                }
                // kai lyginama ar žodis atspetas, naudojamos didžiosioses raidės.
                else if (vartotojoIvestis.Length > 1 && vartotojoIvestis.ToUpper().Equals(pasirinktasZodis.ToUpper()))
                {
                    zodisAtspetas = true;
                }
                else if (vartotojoIvestis.Length > 1 && !vartotojoIvestis.ToUpper().Equals(pasirinktasZodis.ToUpper()))
                {
                    zodisAtspetas = false;
                    gyvybiuLikutis = 0;
                    Console.WriteLine($":( PRALAIMĖJOTE :(\nŽodis buvo: {zodis}");
                    testi = false;
                }
                else if (vartotojoIvestis.Length == 0) { }
                else gyvybiuLikutis--;

                if (AtidenktosVisosRaides(atvaizduojamosRaides))
                {
                    zodisAtspetas = true;
                    testi = false;
                }
                if (zodisAtspetas)
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
            int zodzioNr = 0;
            while (ieskoti)
            {
                zodzioNr = AtsitiktinisSkaicius(1, pradinisKlausimuSkaicius + 1);

                //patikrinti ar tokiu numerių yra žodis saraše, jeigu nėra tada generuojamas kitas numeris 
                if (zodziai.ContainsKey(zodzioNr))
                {
                    if (tema.Equals(zodziai[zodzioNr].GetValue(0))) // patikrinama kad surasto žodžio tema sutampa su užduota
                    {
                        rezultatas = zodziai[zodzioNr].GetValue(1)
                                                       .ToString();
                        ieskoti = false;
                        // Surastas žodis iš karto šalinamas iš žodžių sąrašo.
                        // Taip užtikrinama, kad nebūtu duodamas tas pat žodis daugiau kaip 1 kartą per žaidimą
                        zodziai.Remove(zodzioNr);
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