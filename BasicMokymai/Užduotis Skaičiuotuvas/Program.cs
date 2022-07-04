namespace Užduotis_Skaičiuotuvas
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * UŽDUOTIS 1

     1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
             - Main metode paprašykite įvesti 2 skaičius
             - Kiekvienas matematinis veiksmas turi turėti savo metodą
               metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
             - Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
             - Visų gautų rezultatų sumą atspausdinti Main metode.

     2. Skaičiuotuvas. Naudoti pirmos dalies matematinius metodus.
             - Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
             - Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius ir veiksmą.
             - Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą (naudoti switch)
             - parašyti testus
             - gautą rezultatą atspausdinti į ekraną Main metode.

             * 
             * 
             */
            Console.WriteLine("Iveskite 1  skaičių:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite 2  skaičių:");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());



            /*
            double bendraSuma = 0;
            Console.WriteLine($"Suma {skaicius1} + {skaicius2} = {Suma(skaicius1, skaicius2)}");
            bendraSuma = Suma(skaicius1, skaicius2);

            Console.WriteLine($"Atimtis {skaicius1} - {skaicius2} = {Atimtis(skaicius1, skaicius2)}");
            bendraSuma = bendraSuma + Atimtis(skaicius1, skaicius2);

            Console.WriteLine($"Daugyba {skaicius1} * {skaicius2} = {Daugyba(skaicius1, skaicius2)}");
            bendraSuma = bendraSuma + Daugyba(skaicius1, skaicius2);
            
            Console.WriteLine($"Dalyba {skaicius1} / {skaicius2} = {Dalyba(skaicius1, skaicius2):0.0}");

            bendraSuma = bendraSuma + Dalyba(skaicius1, skaicius2);
            Console.WriteLine($"Visų gautų rezultatų sumą = {bendraSuma:0.0}");
            */

            Console.WriteLine("Iveskite veiksmą:");

            string veiksmas = Console.ReadLine();

            Console.WriteLine($" {Skaiciuotuvas(skaicius1,skaicius2, veiksmas)}" );

        }

        // liamda funkcija
        public static int Suma(int skaicius1, int skaicius2) => skaicius1 + skaicius2;


        public static int Atimtis(int skaicius1, int skaicius2)
        {
            return skaicius1 - skaicius2;
        }
        public static int Daugyba(int skaicius1, int skaicius2)
        {
            return skaicius1 * skaicius2;
        }
        public static double Dalyba(int skaicius1, int skaicius2) => (double)skaicius1 / skaicius2;
  

        public static double? Skaiciuotuvas(int skaicius1, int skaicius2, string veiksmas)
        {
            double? rezultatas = null;

            switch (veiksmas)
               {
                case "+":
                    rezultatas = Suma(skaicius1, skaicius2);
                    break;
                case "-":
                    rezultatas = Atimtis(skaicius1, skaicius2);
                    break;
                case "*":
                    rezultatas = Daugyba(skaicius1, skaicius2);
                    break;
                case "/":
                    rezultatas = Dalyba(skaicius1, skaicius2);
                    break;

            }

            return rezultatas;
            }
    }
}