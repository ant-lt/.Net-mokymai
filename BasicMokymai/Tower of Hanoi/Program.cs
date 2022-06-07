namespace Tower_of_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stulp1eilute1 = "    |    ";
            string stulp1eilute2 = "   #|#   ";
            string stulp1eilute3 = "  ##|##  ";
            string stulp1eilute4 = " ###|### ";
            string stulp1eilute5 = "####|####";

            string stulp2eilute1 = "    |    ";
            string stulp2eilute2 = "    |    ";
            string stulp2eilute3 = "    |    ";
            string stulp2eilute4 = "    |    ";
            string stulp2eilute5 = "    |    ";

            string stulp3eilute1 = stulp2eilute1;
            string stulp3eilute2 = stulp2eilute2;
            string stulp3eilute3 = stulp2eilute3;
            string stulp3eilute4 = stulp2eilute4;
            string stulp3eilute5 = stulp2eilute5;





            // 1

            Console.WriteLine($"1eil. {stulp1eilute1}{stulp2eilute1}{stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2}{stulp2eilute2}{stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3}{stulp2eilute3}{stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4}{stulp2eilute4}{stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5}{stulp2eilute5}{stulp3eilute5}");
            Console.WriteLine(" ----1sulp-------2stulp-------3stulp----");

            Console.WriteLine();

            // 2 

            string temp = "";
                
            temp = stulp1eilute1;

            stulp1eilute1 = stulp1eilute5;
            stulp1eilute5 = temp;

            temp = stulp1eilute4;
            stulp1eilute4 = stulp1eilute2;
            stulp1eilute2 = temp;


            Console.WriteLine($"1eil. {stulp1eilute1}{stulp2eilute1}{stulp3eilute1}");
            Console.WriteLine($"2eil. {stulp1eilute2}{stulp2eilute2}{stulp3eilute2}");
            Console.WriteLine($"3eil. {stulp1eilute3}{stulp2eilute3}{stulp3eilute3}");
            Console.WriteLine($"4eil. {stulp1eilute4}{stulp2eilute4}{stulp3eilute4}");
            Console.WriteLine($"5eil. {stulp1eilute5}{stulp2eilute5}{stulp3eilute5}");
            Console.WriteLine(" ----1sulp-------2stulp-------3stulp----");


            Console.WriteLine();

            // 3
           
            Console.WriteLine();

            // 4

    

            // 5 


        }
    }
}