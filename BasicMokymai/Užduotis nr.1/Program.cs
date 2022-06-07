namespace Užduotis_nr._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1 −Išveskite į konsolę savo vardą
            Console.Clear();
            Console.WriteLine("Užduotis 1.1 −Išveskite į konsolę savo vardą");
            Console.WriteLine("Vitas!");
            Console.WriteLine("---------------------------------------------------------------------------");

            //1.2 −Nuskaitykite iš klaviatūros savo vardą ir išveskite į konsolę
            //Console.Clear();
            Console.WriteLine("Užduotis 1.2 −Nuskaitykite iš klaviatūros savo vardą ir išveskite į konsolę");
            Console.WriteLine("Iveskite savo vardą:");
            Console.WriteLine("Jusu vardas:{0}", Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------");

            //1.3 −Nuskaitykite iš klaviatūros savo vardo pirmąją raidę ir išveskite į konsolę jos ASCII kodą
            //Console.Clear();

            Console.WriteLine("Užduotis 1.3 −Nuskaitykite iš klaviatūros savo vardo pirmąją raidę ir išveskite į konsolę jos ASCII kodą");
            Console.WriteLine("Iveskite savo vardo pirmąją raidę:");
            Console.WriteLine("Pirmos raides ASCII kodas \"{0}\"", (int)Console.ReadKey().KeyChar);
            Console.WriteLine("---------------------------------------------------------------------------");

            //1.4 - Nuskaitykite iš klaviatūros savo vardo pirmąją raidę, tada nuskaitykite bet kokį skaičių ir išveskite į konsolę sumą.
            //Pabandykite šį skaičių išvesti įvairiais formatais
            // Console.Clear();
          
            Console.WriteLine("Užduotis 1.4 - Nuskaitykite iš klaviatūros savo vardo pirmąją raidę, tada nuskaitykite bet kokį skaičių ir išveskite į konsolę sumą");
            Console.WriteLine("Iveskite savo vardo pirmąją raidę:");
            var vardo_raides_kodas = (int)Console.ReadKey().KeyChar;

            Console.WriteLine("Iveskite bet kokį skaičių:");

            var skaicius = Console.ReadLine();

            int skaicius2;
            skaicius2 = Convert.ToInt32(skaicius);

            var suma = vardo_raides_kodas + skaicius2;
            Console.WriteLine(
            "Pirmos raides ASCII kodas: ...........{0:G}\n" +
            "Skaičius:. . . . . . . . .............{1} (default = 'G')\n" +
            "Suma {0} + {1} =  {3} be konvertavimo \n" +
            "Suma {0} + {1} =  {2:C} formatas (C) Currency\n" +
            "Suma {0} + {1} =  {2:D} formatas (D) Decimal\n" +
            "Suma {0} + {1} =  {2:G} formatas (G) General\n" +
            "Suma {0} + {1} =  {2:N} formatas (N) Number\n",
            vardo_raides_kodas, skaicius, suma, vardo_raides_kodas + skaicius);
            Console.WriteLine("---------------------------------------------------------------------------");

            //1.5 - Padarykite konsolės meniu skirtingose eilutėse (1) Pirkti, (2) Parduoti, (3) Likučiai. Išveskite pasirinktą meniu punktą.
            // Console.Clear();
            Console.WriteLine("Užduotis 1.5 - Padarykite konsolės meniu skirtingose eilutėse (1) Pirkti, (2) Parduoti, (3) Likučiai. Išveskite pasirinktą meniu punktą.");

            Console.WriteLine("(1)\nPirkti(2)\nParduoti\n(3) Likučiai");

            var pasirinktas_meniu = Console.ReadKey().KeyChar;

            Console.WriteLine("\"Pasirinktas yra:" + pasirinktas_meniu + "\"");
            Console.WriteLine("\"Pasirinktas yra:{0}\"", pasirinktas_meniu) ;
            Console.WriteLine($"\"Pasirinktas yra:{pasirinktas_meniu}\"");



        }
    }
}