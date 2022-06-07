namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Išvedimas ");
            Console.Write("vienoje ");
            Console.Write("eilutėje ");
            Console.WriteLine();
            Console.WriteLine("tekstas kitoje eilutėje ");
            Console.Write("Tekstas");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Išvedimas " + "vienoje " + "eilutėje"); // konkatinacija
            Console.WriteLine("{0} {1} {2}", "Išvedimas", "vienoje", "eilutėje"); // kompozicija
            Console.WriteLine($"{"Išvedimas"} {"vienoje"} { "eilutėje"}"); // interpoliacija
            Console.WriteLine("------------------------------");

            Console.WriteLine("tekstas idedamas i \"kabutes\"");
            Console.WriteLine($"tekstas {Environment.NewLine}idedamas \r\ni \r\n\"kabutes\"");
            Console.WriteLine("tekstas \tidedamas \ti \t\"kabutes\"");

            Console.WriteLine("The \u00c6olean & Hard\", by Samuel Taylor Coleridge ");

            Console.WriteLine("-----Press any key to continue----");

            Console.ReadKey();
            Console.Clear();

            //Console.WriteLine("Įveskite savo vardą, o aš jį pakartosiu:");
            // Console.WriteLine("o štai mano pakartojimas " + Console.ReadLine());
            //Console.WriteLine("o štai mano pakartojimas {0}",  Console.ReadLine());
            //Console.WriteLine($"o štai mano pakartojimas  {Console.ReadLine()}");

            //Console.WriteLine("Įveskite raidę");
            //var key = Console.ReadKey();

            //Console.WriteLine("Ivestas simbolis {0}", key.KeyChar);
            //Console.WriteLine("Ivestas simbolis {0}", key.Key );
            //Console.WriteLine("Ivestas simbolis {0}", (int)key.KeyChar);

            //Console.WriteLine("Ivestas simbolis {0}", Console.ReadKey().KeyChar);
            //Console.WriteLine("Ivestas simbolis {0}", (int)Console.ReadKey().KeyChar);
            /*
            Console.WriteLine("Įveskite savo vardą, o aš atspėsiu pirmą raidę:");
            Console.WriteLine("o štai mano spejimas\"" + Console.ReadLine()[0] + "\"");

            Console.ReadKey();

            Console.WriteLine("eilute 1" + 
                 Environment.NewLine + "eilute 2" +
                 Environment.NewLine + "eilute 3");

            Console.WriteLine(@"eilute 1
              eilute 2
              eilute 3");
       */

            Console.WriteLine("--------");
            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
           "(C) Currency: . . . . . . . . {0:C}\n" +
           "(D) Decimal:. . . . . . . . . {0:D}\n" +
           "(E) Scientific: . . . . . . . {1:E}\n" +
           "(F) Fixed point:. . . . . . . {1:F}\n" +
           "(G) General:. . . . . . . . . {0:G}\n" +
           "    (default):. . . . . . . . {0} (default = 'G')\n" +
           "(N) Number: . . . . . . . . . {0:N}\n" +
           "(P) Percent:. . . . . . . . . {1:P}\n" +
           "(R) Round-trip: . . . . . . . {1:R}\n" +
           "(X) Hexadecimal:. . . . . . . {0:X}\n",
           -123, -123.45f);

            Console.WriteLine("--------");
            Console.WriteLine("Standard DateTime Format Specifiers");
            Console.WriteLine(
                "(d) Short date: . . . . . . . {0:d}\n" +
                "(D) Long date:. . . . . . . . {0:D}\n" +
                "(t) Short time: . . . . . . . {0:t}\n" +
                "(T) Long time:. . . . . . . . {0:T}\n" +
                "(f) Full date/short time: . . {0:f}\n" +
                "(F) Full date/long time:. . . {0:F}\n" +
                "(g) General date/short time:. {0:g}\n" +
                "(G) General date/long time: . {0:G}\n" +
                "    (default):. . . . . . . . {0} (default = 'G')\n" +
                "(M) Month:. . . . . . . . . . {0:M}\n" +
                "(R) RFC1123:. . . . . . . . . {0:R}\n" +
                "(s) Sortable: . . . . . . . . {0:s}\n" +
                "(u) Universal sortable: . . . {0:u} (invariant)\n" +
                "(U) Universal full date/time: {0:U}\n" +
                "(Y) Year: . . . . . . . . . . {0:Y}\n",
                DateTime.Now);

        }
    }
}