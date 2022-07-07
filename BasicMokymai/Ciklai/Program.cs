namespace Ciklai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, While/Do-While Ciklai!");
            // WhileCikloPavyzdys();
            //WhileCikloZaidehuPavyzdys();
            //DoWhileCikloZaidehuPavyzdys();
            // DoWhileUzduotis();
            //DoWhileUzduotis2();
            DoWhileUzduotis3();
        }

        public static void WhileCikloPavyzdys()
        {
            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }
        }
        public static void WhileCikloZaidehuPavyzdys()
        {
            int zaidejuSkaicius = -1;
            while (zaidejuSkaicius < 0 || zaidejuSkaicius > 10)
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());

            }
        }

        public static void DoWhileCikloZaidehuPavyzdys()
        {
            int zaidejuSkaicius = 0;

            do
            {
                Console.WriteLine("Kiek zaideju zais zaidima?");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());

            } while (zaidejuSkaicius < 0 || zaidejuSkaicius > 10);
        }

        /*
         * 
         * * 1.Paprašyti vartotojo įvesti bet kokį skaičių. 
         * Išvesti skaičių sumą nuo 1 iki įvesto skaičiaus.
         */

        public static void DoWhileUzduotis()
        {

            int i = 0;
            int suma = 0;
            Console.WriteLine("Ivesti skaiciu");
            i = Convert.ToInt32(Console.ReadLine());

            while ( i > 0 )
            {
                Console.WriteLine($"{suma}");
                suma = suma + i;
                i--;
            }
            Console.WriteLine(suma);
        }

        /*
         *  * Paprašyti vartotojo įvesti bet kokį skaičių. 
         * Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus, 
         * vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....
         * 
         */

        public static void DoWhileUzduotis2()
        {

            int i = 0;
            int j = 0;

            Console.WriteLine("Ivesti skaiciu");
            i = Convert.ToInt32(Console.ReadLine());

            while (j <= i)
            {
                if ( j % 2 == 0 )
                {
                    Console.WriteLine($"{j}");
                }
                j++;
            }
         
        }

        /*
         * Parasyti programa kuri apskaiciuoja visu ivestu skaiciu suma, 
         * kurie buvo ivesti iki ivesto neigiamo skaiciaus
         * 
         * PVZ
         * 1,23,4,5,7,8,-1
         */
        public static void DoWhileUzduotis3()
        {

            int ivestis = 0;
            int suma = 0;

            
            do
            {
                suma = suma + ivestis;
                Console.WriteLine("Ivesti skaicius");
                ivestis = Convert.ToInt32(Console.ReadLine());
            } while (ivestis > 0 );

            Console.WriteLine($"Suma:{suma}");
        }

        /*
         *   * 4. Parasykite slaptazodzio ivedimo simuliacija. Pirma kompiuteris paprasys, kad nustatytumete slaptazodi tada prasys naudotojo pakartoti slaptazodi. Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. Bandykite dar karta”. 
         * Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.
         * BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa ismestu teksta “Jus uzblokuotas” ir iseitu is ciklo.
         * 
         */
        //--------------------

        public static void MatchRandomPavyzdis()
        {

            var randomObjektas = new Random();
            var ismestaMoneta = randomObjektas.Next(1,2);
            int monetosMetimas = 0;

            while (monetosMetimas < 10)
            {
                monetosMetimas++;
            }

        }

    }
}