namespace Operatoriai_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
        PARAŠYTI PROGRAMĄ KURI DIDELĮ 10 ŽENKLĮ SKAIČIŲ DOUBLE, KONVERTUOJA Į
        INT , SHORT , BYTE
        STEBĖTI REZULTATĄ.

             * 
             */
            double didelisSkaicius = 1_000_000_000_000;
            //double didelisSkaicius = Convert.ToDouble(Console.ReadLine());

            /*
            int skaiciusInt1Cast = (int) skaicius;
            short skaiciusShortCast = (short) skaicius;
            byte skaiciusByteCast = (byte) skaicius;


            int skaiciusIntConvert = Convert.ToInt32(skaicius);
            short skaiciusShortConvert = Convert.ToInt16(skaicius);
            byte skaiciusByteConvert = Convert.ToByte(skaicius);

            */

            Console.WriteLine(" INT {0}", (int)didelisSkaicius);
            Console.WriteLine(" short {0}", (short)didelisSkaicius);
            Console.WriteLine(" byte {0}", (byte)didelisSkaicius);

            /*
             * PARAŠYTI PROGRAMĄ KURI
             * PRAŠO ĮVESTI RUTULIO DIAMETRĄ,
             * O IŠVEDA PLOTĄ IR TŪRĮ
             */

            /*
             Console.WriteLine("Ivesti rutulio diametra:");
             double diametras = double.Parse(Console.ReadLine());

             double radiusas = diametras / 2;

             double pi = 3.14;


             Console.WriteLine("Plotas {0}", 4* pi * radiusas * radiusas);
             Console.WriteLine("Turis {0}",  (4/3)*pi * radiusas * radiusas * radiusas);

         */
            /*
            * PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (METRAIS) IR LAIKĄ (SEKUNDĖMIS),
            - IŠVEDA GREITĮ km/h.
            - IŠVEDA GREITĮ km/s.
            */

            /*
            Console.WriteLine("Ivesti aststuma metrais:");
            double atstumas = double.Parse(Console.ReadLine());

            Console.WriteLine("Ivesti laika sekundemis:");

            double laikas = double.Parse(Console.ReadLine());

            Console.WriteLine("Greitis km/h {0}", (atstumas / 1000) / (laikas/60/60));
            Console.WriteLine("Greitis km/s {0}", (atstumas / 1000) / laikas );
            */
            /*
            Console.WriteLine("Ivesti x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Ivesti y:");

            double y = double.Parse(Console.ReadLine());

            Console.WriteLine( $"{y} + 2*{y} + {x} + 1 = {y + (2 * y) + x + 1}");
            
             */

            /*
             * Išveskite į ekraną funkciją y²+x/2 apskaičiuokite šios funkcijos rezultatą.
            */
            /*
            Console.WriteLine("Ivesti x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Ivesti y:");

            double y = double.Parse(Console.ReadLine());

            
            Console.WriteLine($"{y}^2 + {x}/2 = {y * y + x/2 }");
            */

            /*
            var  d = Console.ReadLine();
            Console.WriteLine($"ar null {d == null}");
            Console.WriteLine($"ar empty {d == String.Empty}");
            */


            /*
             * ARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
                VISUS ĮVESTUS 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
            PVZ BUVO ĮVESTA 12345
            REZULTATAS 2345/2=1172,5
            <HINT> naudokite replace
            */

            //
            //var skaicius = Convert.ToDouble(Console.ReadLine().Replace('1', '0'));

            //Console.WriteLine($"{skaicius} /2 = {skaicius / 2}");

            /*
             *
             *PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
VISUS ĮVESTUS išskyrus 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
PVZ BUVO ĮVESTA 12345
REZULTATAS 10000/2=5000
<HINT> naudokite replace
            */

            /*
            var skaicius = Convert.ToDouble(Console.ReadLine()
                .Replace("2", "0")
                .Replace("3", "0")
                .Replace("4", "0")
                .Replace("5", "0")
                .Replace("6", "0")
                .Replace("7", "0")
                .Replace("8", "0")
                .Replace("9", "0")
                );

            Console.WriteLine($"{skaicius} /2 = {skaicius / 2}");
            */

            
            Console.WriteLine("Iveskite sveika skaiciu:");
            var skaiciusInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rezultatas {0} {1} {2} {3} {4}", ++skaiciusInt, ++skaiciusInt , ++skaiciusInt , ++skaiciusInt, ++skaiciusInt );
            


        }
    }
}