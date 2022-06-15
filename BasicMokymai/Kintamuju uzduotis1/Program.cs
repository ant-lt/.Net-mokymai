namespace Kintamuju_uzduotis1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS.PROGRAMA TURI IŠVESTI
            • SKAIČIŲ SUMĄ
            • SKAIČIŲ SKIRTUMĄ
            • SANDAUGĄ
            • DALYBĄ
            */
            Console.WriteLine("Pirmas skaicius");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antras skaicius");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"suma = {skaicius1} + {skaicius2} = {skaicius1 + skaicius2} ");
            Console.WriteLine($"skirtumas = {skaicius1} + {skaicius2} = {skaicius1 - skaicius2} ");
            Console.WriteLine($"daugyba  = {skaicius1} + {skaicius2} = {skaicius1 * skaicius2} ");
            Console.WriteLine($"dalyba  = {skaicius1} / {skaicius2} = {(double)skaicius1 / skaicius2} ");

            /* 
             * PARAŠYTI PROGRAMĄ, 3 SKAIČIUS. PROGRAMA TURI IŠVESTI ŠIŲ SKAIČIŲ VIDURKĮ
             * */
            Console.WriteLine("Pirmas skaicius");
            skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antras skaicius");
            skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Trecias skaicius");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"vidurkis = {skaicius1}, {skaicius2}, {skaicius3}  = {((double)(skaicius1 + skaicius2 + skaicius3) /3)} ");


            /*
            sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
            sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
            - padalinkite didesnį skaičių iš mažesnio
            - iš rezultato atimkite maksimalų long skaičių
            - ir pridėkite maksimalų int skaičių
               */

            long kintLong = long.MaxValue;
            short kintShort = short.MaxValue;

            double rezultas3 = (double)kintLong / kintShort;

            Console.WriteLine("padalinkite didesnį skaičių iš mažesnio {0}", rezultas3 );
            
            double rezultatas31 = rezultas3 - long.MaxValue; 
            Console.WriteLine("iš rezultato atimkite maksimalų long skaičių {0}", rezultatas31 );

            Console.WriteLine("ir pridėkite maksimalų int skaičių {0}", rezultatas31 + int.MaxValue);


        }

    }
}