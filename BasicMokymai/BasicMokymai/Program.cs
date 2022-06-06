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


            Console.ReadKey();
        }
    }
}