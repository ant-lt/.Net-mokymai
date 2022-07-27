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

    internal class Program
    {
        static void Main(string[] args)
        {
            
            char[,,] zmogelis = new char[7, 4, 3]{
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


            //var klausimai = new Dictionary<int, string>;
            var zodziai = new Dictionary<int, string[]>()
             {
                { 1, new string[2] { "VARDAI", "Vitas"} },
                { 2, new string[2] { "VARDAI", "Petras"} }
            };

            foreach (var zodis in zodziai)
            {
                Console.WriteLine(zodis.Key + " "+ zodis.Value[0] + " "+ zodis.Value[1]);
            }

            // zodziai.ContainsValue();

            //Console.WriteLine(zodziai[1].GetValue(0));

            String spejamas_zodis = "Testavimas";
            bool[] atvaizduojamos_raides = new bool[spejamas_zodis.Length];

           

            nupiesti_kartuves(zmogelis,0);

            atvaizduok_zodi(spejamas_zodis, atvaizduojamos_raides);

            atidenk_raide(spejamas_zodis, atvaizduojamos_raides, 'a');

            atvaizduok_zodi(spejamas_zodis, atvaizduojamos_raides);

            Console.WriteLine(atidenktos_visos_raides(atvaizduojamos_raides)); 
            // Console.WriteLine(temos_pasirinkimas()); 
        }

        public static int temos_pasirinkimas()
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

        public static void nupiesti_zmogeli(char[,,] zmogelis, int karimo_stadija)
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

        public static void nupiesti_kartuves(char[,,] zmogelis, int karimo_stadija)
        {
            Console.WriteLine(" - - - - - - |");
            nupiesti_zmogeli(zmogelis, 0);
            nupiesti_zmogeli(zmogelis, 1);
            nupiesti_zmogeli(zmogelis, 2);
            nupiesti_zmogeli(zmogelis, 3);
            nupiesti_zmogeli(zmogelis, 4);
            nupiesti_zmogeli(zmogelis, 5);
            nupiesti_zmogeli(zmogelis, 6);
            Console.WriteLine("|");
            Console.WriteLine("- - - -");
        }

        static void atvaizduok_zodi(string zodis, bool[] mask)
        {
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


        static bool atidenk_raide(string zodis, bool[] mask, char raide)
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

        static bool atidenktos_visos_raides(bool[] mask)
        {
            bool visos_raides = true;
            for (int i = 0; i < mask.Length; i++)
            {
                if (mask[i] == false)
                {
                    visos_raides = false;
                }

            }
            // Console.WriteLine(visos_raides);
            return visos_raides;
        }

    }
}