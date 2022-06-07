namespace Užduotis_nr._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*---------------*/
            Console.WriteLine("L\nA\nB\nA\nS\n");
            Console.WriteLine(@"L
A
B
A
S");
            Console.WriteLine("L");
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("A");
            Console.WriteLine("S");

            Console.WriteLine("L" + Environment.NewLine + "A" + Environment.NewLine + "B" + Environment.NewLine + "A" + Environment.NewLine + "S" + Environment.NewLine);


            Console.WriteLine("L\tA\tB\tA\tS\t");


            Console.WriteLine("\"LABAS\"");
            Console.WriteLine("\x0022LABAS\x0022");
            Console.WriteLine("\u0022LABAS\u0022");

            Console.WriteLine((char)0x22 + "LABAS" + (char)0x22);



            Console.WriteLine("Įveskite savo vardą, o aš atspėsiu antrą raidę:");
            Console.WriteLine("o štai mano spejimas\"" + Console.ReadLine()[1] + "\"");

            Console.WriteLine("Įveskite savo vardą, o aš išvesiu raidžių kiekį :");
            Console.WriteLine("o štai raidžių kiekis \"" + Console.ReadLine().Length + "\"");


            
            Console.WriteLine("|    {0} |   {1} |", Console.ReadLine(), Console.ReadLine().Length ); // kompozicija

            Console.WriteLine("\n\n\n{0}", Console.ReadLine());


        }
    }
}