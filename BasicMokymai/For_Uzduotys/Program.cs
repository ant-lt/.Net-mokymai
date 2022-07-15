using System.Text;

namespace For_Uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Ivestas skaicius {0}", PakeltiLaipsniu(2, 3));
            // Console.WriteLine(SkaiciuTrikampis() );
            //  Console.WriteLine(SkaiciuPiramide());
            //Console.WriteLine(DidejanciuSkaiciuStatusTrikampis());
            //Console.WriteLine(DidejanciuSkaiciuPiramide());
            //SkaiciuEile("1",5);
            DaugybosLentele();
        }

        /*
         *  UŽDUOTIS 1.
      Sukurti metodą ReadIntNumber,
      kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
      Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
      įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
      neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
      (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.
         */
        public static int ReadIntNumber()
        {
            int result = 0;
            bool skaiciusGeras = false;

            while (!skaiciusGeras)
            {
                Console.WriteLine("Įvesti sveikąjį skaičių:");
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    skaiciusGeras = true;
                    
                }
                else { 
                    skaiciusGeras = false;
                    Console.WriteLine("Įvestas blogas skaičius.");
                }
            } 
            return result;
        }

        public static string IntegerToBinary(int skaicius)
            /*
             * Sukurti metodą IntegerToBinary,
        kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
        2 --> 10
        7 --> 111
        45 --> 101101
            */
        {

            string binSk = "";
            while (skaicius > 0)
            {
                binSk = skaicius % 2 + binSk;

                skaicius /= 2;
            }
            return binSk;
        }

        /*
         * Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
      laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
      kelsime, antras laipsnis, kuriuo pakelti.
      NB! kai skaičius 0 o laipsnis > 0 gąžinama 1
      NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
      NB! kai laipsnis = 1 gąžinamas tas pats skaičius
        */
        public static int PakeltiLaipsniu (int skaicius, int laipsnis)
        {
            int rezultas = skaicius;

            if (laipsnis == 0 && skaicius > 0 )
            {
                return 0;
            }
            if (skaicius == 0 && laipsnis > 0 )
                return 1;

            if (laipsnis == 1)
                return skaicius;

            for (int i = 1; i < laipsnis; i++)
            {
                rezultas = rezultas * skaicius;
            }

            return rezultas;
        }

        /*
         * Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą).
        Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
        5
        55
        555
        5555
        55555
         */
        public static string SkaiciuTrikampis()
        {
            int skaicius = ReadIntNumber();
            StringBuilder sb = new StringBuilder();

            bool skaiciusGeras = false;

            while (!skaiciusGeras)
            {
                if (skaicius >= 1 && skaicius <= 9)
                {
                    for (int i = 0; i <= skaicius; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            sb.Append(skaicius);
                        }
                        sb.AppendLine();
                    }
                    
                    skaiciusGeras = true;
                }
                else Console.WriteLine("Klaida");
            }
            return sb.ToString();
        }
        
        /*
         * 
         * 
         * Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
       jeigu įveda netinkamą skaičių
       prašo įvesti vėl, kol įves tinkamą Programa turi atspausdinti atitinkamą lygiašonį trikampį.
        7
        77
        777
        7777
        77777
        777777
        7777777
        777777
        77777
        7777
        777
        77
        7
         * 
         */
        public static string SkaiciuPiramide()
        {
            int skaicius = ReadIntNumber();
            StringBuilder sb = new StringBuilder();

            bool skaiciusGeras = false;

            while (!skaiciusGeras)
            {
                if (skaicius >= 1 && skaicius <= 9)
                {
                    
                    for (int i = 0; i <= skaicius; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            sb.Append(skaicius);
                        }
                        sb.AppendLine();
                    }
                    
                 
                    for (int i = 0; i <= skaicius; i++)
                    {
                        for (int j = i; j < skaicius-1; j++)
                        {
                            sb.Append(skaicius);
                        }
                        sb.AppendLine();
                    }
                    
                    skaiciusGeras = true;
                    
                }
                else Console.WriteLine("Klaida");
            }
            return sb.ToString();
        }

        /*
        DidejanciuSkaiciuStatusTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
       (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )).
       Programa turi grąžinti atitinkamą statųjį trikampį.
       1
       22
       333
       4444
       55555
        */
        public static string DidejanciuSkaiciuStatusTrikampis()
        {
            int skaicius = ReadIntNumber();
            StringBuilder sb = new StringBuilder();

            bool skaiciusGeras = false;

            while (!skaiciusGeras)
            {
                if (skaicius >= 1 && skaicius <= 9)
                {

                    for (int i = 0; i <= skaicius; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            sb.Append(i);
                        }
                        sb.AppendLine();
                    }

                    skaiciusGeras = true;

                }
                else Console.WriteLine("Klaida");
            }
            return sb.ToString();
        }



        /*
         * Sukurti metodą DidejanciuSkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )).
        Metodas turi grąžinti atitinkamą lygiašonį trikampį (ivestas skaičius 4).
        1
        22
        333
        4444
        333
        22
        1
        */

        public static string DidejanciuSkaiciuPiramide()
        {
            int skaicius = ReadIntNumber();
            StringBuilder sb = new StringBuilder();

            bool skaiciusGeras = false;

            while (!skaiciusGeras)
            {
                if (skaicius >= 1 && skaicius <= 9)
                {

                    for (int i = 0; i <= skaicius; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            sb.Append(i);
                        }
                        sb.AppendLine();
                    }


                    for (int i = 1; i <= skaicius+1; i++)
                    {
                        for (int j = i; j < skaicius; j++)
                        {
                            sb.Append(skaicius-i);
                        }
                        sb.AppendLine();
                    }

                    skaiciusGeras = true;

                }
                else Console.WriteLine("Klaida");
            }
            return sb.ToString();
        }

        private static int SkaiciausTikrinimas(string? txt) => int.TryParse(txt, out int num) == false ? 0 : num;


        /*
        * 1. Uzduotis:
        * Parašykite metodą SkaiciuEile kuri išvestu vienoje eilutėje skaičių grupes tokiu principu: -> 1 -> 11 -> 111 -> 1111 -> 11111 -> .......
           programa turi paprašyti nurodyti skaičių ir grupių kiekį naudokite for ir StringBuilder
        */

        private static void SkaiciuEile(string input, int kiek)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < kiek; i++)
            {
                Console.Write("->");
                sb.Append(input);
                Console.Write(sb);
            }
        }

        /*
 * 2. Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu. Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele. Pvz
    15 X 1 = 15                                                                                                   
    15 X 2 = 30                                                                                                   
    15 X 3 = 45                                                                                                   
    15 X 4 = 60                                                                                                   
    15 X 5 = 75                                                                                                   
    15 X 6 = 90                                                                                                   
    15 X 7 = 105                                                                                                  
    15 X 8 = 120                                                                                                  
    15 X 9 = 135                                                                                                  
    15 X 10 = 150
 */
        public static void DaugybosLentele()
        {
            int skaicius = ReadIntNumber();
            var sb = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                sb.Append(skaicius).Append(" X ").Append(i).Append(" = ").Append(skaicius * i);
                Console.WriteLine(sb);
                sb.Clear();
            }
        }

       
        /*
         * 4. Sukurkite programa, kuri atspausdintu sia forma:
                *
               *** 
              *****
             *******
            ********* 
             *******
              *****
               ***
                * 
        */


    }
}