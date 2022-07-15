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

        /*
         * 1.Parasykite programa, kuri atspausdintu sia figura pvz:
            1
            01
            101
            0101
            10101
        */
        public static void uzduotis1()
        {

            Console.WriteLine("Kiek norite eiluciu: ");

            int eilutes = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
         
            for (int i = 1; i <= eilutes; i++)
                Console.WriteLine(sb.Insert(0, i % 2).ToString());
        }

        /*
         * 2. Parasykite programa, kuri paprasytu ivesti skaiciu ir ivesta skaiciu atspausdintu atvirkstine seka. Naudoti tik ciklus ir matematines operacijas.
Visi kintamieji yra integer tipo. Pvz:
            Ivedam- 12345 (int)
            Rezultatas-54321 (int)
         * 
         */
        static public void IsgautiAtvirksciaSkaiciu()
        {
            int skaicius = 0,
                likutis,
                rezultatas = 0;
            bool validu = false;

            while (!validu)
            {
                Console.WriteLine("Iveskite skaicius:");
                if (int.TryParse(Console.ReadLine(), out skaicius))
                {
                    validu = true;
                }
            }
            while (skaicius != 0)
            {
                likutis = skaicius % 10;
                Console.WriteLine($"Likutis: {likutis}");
                rezultatas = rezultatas * 10 + likutis;
                Console.WriteLine($"Rezultatas: {rezultatas}");
                skaicius = skaicius / 10;
                Console.WriteLine($"Skaicius: {skaicius}");
            }
            Console.WriteLine($"Rezultatas: {rezultatas}");
        }

        /*
         * 3. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. Kada visi vardai buna ivesti programa turetu atspausdinti visu vardus atvirkstine seka.
Pvz: 
3
Edvinas
Jonas
Petras
Petras
Jonas
Edvinas
         * 
         */

        /*
         * 4. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. Kada visi vardai buna ivesti programa turetu atspausdinti ilgiausia varda ekrane. Jei vardai yra vienodo ilgio turetu atspausdinti abu vardus.
            Pvz: 
            3
            Edvinas
            Jonas
            Petras
---------------------
            Edvinas
         * 
         */




        /*
         * 5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane
         * PVZ: 1,2,2,4,2,7,6,1
         * Pasikartojantys skaiciai: 1, 2
         * 
         */

        /*
         * 6. Programa praso ivesti eiluciu ir stulpeliu kieki. Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir atspausdintu matrica is pateiktu skaiciu
            PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3
                 1 2
                 2 3
         * 
         */


        /*
         *
         *7. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame dvimaciame masyve ir juos atvaizduotu ekrane
         *
         */

        /*
         * 
         * 8. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane
         * 
         * 
         */




    }
}