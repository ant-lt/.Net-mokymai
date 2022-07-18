using System.Text;

namespace Masyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvai!");
            //deklaravimas

            var pazymiai = new int[10];
            int[] skaiciai = { 100, 95, 28 };
            //string[] dienos = new[7] { "Pirmadienis", "Antradienis" ....};


            //tuscio masyvo deklaravimas
            int[] skaiciai2;


            // vietos isskyrimas
            int[] skaiciai3 = new int[10];
            string[] zodziai = new string[3];
            double[] realusSkaiciai = new double[3];

            // reiksmiu irasymas
            skaiciai3[0] = 2;
            skaiciai3[1] = 3;
            skaiciai3[2] = 4;

            int[] intMasyvas = new int[] {100, 25, 92};

            int[,] dvimatisMasivas = new int[4, 5];
            int[][] dvimatisMasivas2 = new int[4][];
            int[,] dvimatisMasivas3 = new int[,] 
            { {1,2 }, 
            { 3,4 } };

            for (int i = 0; i < dvimatisMasivas3.GetLength(0); i++)
            {
                for (int j = 0; j < dvimatisMasivas3.GetLength(1); j++)
                {
                    Console.Write(dvimatisMasivas3[i,j]);
                }
                Console.WriteLine();
            }


            string[] dienos = { "Pirmadienis", "Antradienis", "Treciadienis"};
            for (int i = 0; i < dienos.Length; i++)
            {
                Console.WriteLine(dienos[i]);
            }

            // uzduotis1();
            //IsgautiAtvirksciaSkaiciu();
        }
    }
}