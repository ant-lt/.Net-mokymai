using System.Text;

namespace Masyvai_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Uzduotis_1();
            // Uzduotis_2();
            // Uzduotis_3();
            // Uzduotis_4();
            // Uzduotis_5();
            // Uzduotis_6();
            // Uzduotis_7();
            Uzduotis_8();
        }

        /*
         * 1.Parasykite programa, kuri atspausdintu sia figura pvz:
            1
            01
            101
            0101
            10101
        */
        public static void Uzduotis_1()
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
        static public void Uzduotis_2()
        //Isgauti atvirksciai skaiciu
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
-----------------
Petras
Jonas
Edvinas
         * 
         */


        static public void Uzduotis_3()
        {
            bool validu = false;
            int zmoniuSkaicius = 0;

            while (!validu)
            {
                Console.WriteLine("Iveskite kiek zmoniu siandiena atejo i pamoka:");
                if (int.TryParse(Console.ReadLine(), out zmoniuSkaicius))
                {
                    validu = true;
                }
            }

            string[] vardai = new string[zmoniuSkaicius];

            for (int i = 0; i < zmoniuSkaicius; i++)
            {
                Console.WriteLine($"Iveskite {i + 1}-ji varda:");
                string vardas = Console.ReadLine();

                vardai[i] = vardas;
            }

            //atspausdinti visu vardus atvirkstine seka.
            Console.WriteLine("----------------");

            for (int i = zmoniuSkaicius - 1; i >= 0; i--)
            {
                Console.WriteLine(vardai[i]);
            }


        }
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


        static public void Uzduotis_4()
        {
            bool validu = false;
            int zmoniuSkaicius = 0;
            int didziausiasIlgis = 0;

            while (!validu)
            {
                Console.WriteLine("Iveskite kiek zmoniu siandiena atejo i pamoka:");
                if (int.TryParse(Console.ReadLine(), out zmoniuSkaicius))
                {
                    validu = true;
                }
            }

            string[] vardai = new string[zmoniuSkaicius];

            for (int i = 0; i < zmoniuSkaicius; i++)
            {
                int ilgis = 0;
                Console.WriteLine($"Iveskite {i + 1}-ji varda:");
                string vardas = Console.ReadLine();
                ilgis = vardas.Length;
                vardai[i] = vardas;
                if (ilgis > didziausiasIlgis) didziausiasIlgis = ilgis;
            }

            //atspausdinti ilgiausia varda ekrane. Jei vardai yra vienodo ilgio turetu atspausdinti abu vardus.
            Console.WriteLine("----------------");

            for (int i = 0; i < zmoniuSkaicius; i++)
            {
                if (vardai[i].Length == didziausiasIlgis) Console.WriteLine(vardai[i]);
            }

        }




        /*
         * 5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane
         * PVZ: 1,2,2,4,2,7,6,1
         * Pasikartojantys skaiciai: 1, 2
         * 
         */

        static public void Uzduotis_5()
        {
            int[] uzduotasMasyvas = new int[] { 1, 2, 2, 4, 2, 7, 6, 1 };

            string rezultatoEilute = "";

            Console.Write("Užduotas masyvas: ");

            for (int i = 0; i < uzduotasMasyvas.Length; i++)
            {

                int skaicius = uzduotasMasyvas[i];
                int kiekKartojasi = 0;

                //ieskome kiekieviena masyvo elementa ir skaiciuojame kiek kartu kartojasi
                for (int j = 0; j < uzduotasMasyvas.Length; j++)
                {
                    if (uzduotasMasyvas[j] == skaicius) kiekKartojasi++;
                }

                //kad neįdėti dublikatų
                if (kiekKartojasi >= 2 && !rezultatoEilute.Contains(skaicius.ToString()))
                {

                    rezultatoEilute = rezultatoEilute + skaicius.ToString() + ",";
                }
                Console.Write(uzduotasMasyvas[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Pasikartojantys skaiciai: " + rezultatoEilute);
        }

        /*
         * 6. Programa praso ivesti eiluciu ir stulpeliu kieki. 
         * Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir 
         * atspausdintu matrica is pateiktu skaiciu
            PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3
                 1 2
                 2 3
         * 
         */
        static public void Uzduotis_6()
        {

            //ivesti eiluciu ir stulpeliu kieki

            Console.WriteLine("Ivesti eiluciu ir stulpeliu kieki: ");

            int eiluciuKiekis = Convert.ToInt32(Console.ReadLine());

            int stulpeliuKiekis = Convert.ToInt32(Console.ReadLine());

            int[,] masyvas = new int[eiluciuKiekis, stulpeliuKiekis];

            Console.WriteLine("Suveskite masyvo elementus: ");
            for (int i = 0; i < eiluciuKiekis; i++)
            {
                for (int j = 0; j < stulpeliuKiekis; j++)
                {
                    Console.WriteLine($"Eilute {i + 1}, Stulpelis {j + 1}");
                    masyvas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Suvesto masyvo elementai: ");
            for (int i = 0; i < eiluciuKiekis; i++)
            {
                for (int j = 0; j < stulpeliuKiekis; j++)
                {
                    Console.Write($"{masyvas[i, j]}, ");
                }
                Console.WriteLine();
            }
        }


        /*
         *
         *7. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame dvimaciame masyve ir juos atvaizduotu ekrane
         *
         */

        static public void Uzduotis_7()
        {

            int[,] uzduotasMasyvas = new int[3, 2]
            { { 1, 2},
              { 3, 4 },
              { 4, 1 } };

            string rezultatoEilute = "";

            Console.WriteLine("Užduotas masyvas: ");

            for (int i = 0; i < uzduotasMasyvas.GetLength(0); i++)
            {

                //ieskome kiekieviena masyvo elementa ir skaiciuojame kiek kartu kartojasi
                for (int j = 0; j < uzduotasMasyvas.GetLength(1); j++)
                {
                    int skaicius = uzduotasMasyvas[i,j];
                    int kiekKartojasi = 0;

                    for (int ii = 0; ii < uzduotasMasyvas.GetLength(0); ii++)
                    {
                        for (int jj = 0; jj < uzduotasMasyvas.GetLength(1); jj++)
                        {
                            if (uzduotasMasyvas[ii,jj] == skaicius) kiekKartojasi++;
                            //kad neįdėti dublikatų
                            if (kiekKartojasi >= 2 && !rezultatoEilute.Contains(skaicius.ToString()))
                            {
                                rezultatoEilute = rezultatoEilute + skaicius.ToString() + ",";
                            }

                        }
                    }
                    Console.Write(uzduotasMasyvas[i, j] + ",");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pasikartojantys skaiciai: " + rezultatoEilute);
    }

        /*
         * 
         * 8. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane
         * 
         * 
         */

        static public void Uzduotis_8()
        {

            string[,] uzduotasMasyvas = new string[3, 2]
            { { "Vitas", "Petras"},
              { "Albinas", "Vitas" },
              { "Petras", "Jonas" } };

            string rezultatoEilute = "";

            Console.WriteLine("Užduotas masyvas: ");

            for (int i = 0; i < uzduotasMasyvas.GetLength(0); i++)
            {

                //ieskome kiekieviena masyvo elementa ir skaiciuojame kiek kartu kartojasi
                for (int j = 0; j < uzduotasMasyvas.GetLength(1); j++)
                {
                    string vardas = uzduotasMasyvas[i, j];
                    int kiekKartojasi = 0;

                    for (int ii = 0; ii < uzduotasMasyvas.GetLength(0); ii++)
                    {
                        for (int jj = 0; jj < uzduotasMasyvas.GetLength(1); jj++)
                        {
                            if (uzduotasMasyvas[ii, jj] == vardas) kiekKartojasi++;
                            //kad neįdėti dublikatų
                            if (kiekKartojasi >= 2 && !rezultatoEilute.Contains(vardas))
                            {
                                rezultatoEilute = rezultatoEilute + vardas + ",";
                            }
                        }
                    }
                    Console.Write(uzduotasMasyvas[i, j] + ",");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pasikartojantys vardai: " + rezultatoEilute);
        }
    }
}