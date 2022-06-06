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

            Console.WriteLine("Įveskite savo vardą, o aš atspėsiu pirmą raidę:");
            Console.WriteLine("o štai mano spejimas\"" + Console.ReadLine()[0] + "\"");

            Console.ReadKey();

        }
    }
}