namespace Uzduotis_daugiakampis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite taisyklingojo daugiakampio kraštių kiekį (n): ");
            int kraštiu_kiekis = Convert.ToInt32(Console.ReadLine());

            if (kraštiu_kiekis > 2)
            {
                Console.WriteLine("Įveskite taisyklingojo daugiakampio kraštinės ilgį (b): ");
                double kraštiu_ilgis = Convert.ToDouble(Console.ReadLine());

                switch (kraštiu_kiekis)
                {
                    case 3:
                        Console.WriteLine("Įveskite aukšį h: ");
                        Console.WriteLine($"Trikampio plotas = {Trikampio_plotas(kraštiu_ilgis, Convert.ToDouble(Console.ReadLine())),0:0.00}");
                        break;
                    case 4:
                        Console.WriteLine($"Keturkampio plotas = {Keturkampio_plotas(kraštiu_ilgis),0:0.00}");
                        break;
                    default:
                        Console.WriteLine("Įveskite statmenį r: ");
                        Console.WriteLine($"Daugiakampio plotas = {Daugiakampio_plotas(kraštiu_kiekis, kraštiu_ilgis, Convert.ToDouble(Console.ReadLine())),0:0.00}");
                        break;
                }

                Console.WriteLine($"Poligono kampų suma = {Poligono_kampu_suma(kraštiu_kiekis),0:0.00}");
            }

        }

        public static double Trikampio_plotas(double b, double h) => 1 / (double)2 * b * h; // liamda metodas
        public static double Keturkampio_plotas(double b) => b * b;
        public static double Daugiakampio_plotas(int n, double b, double r) => n / (double)2 * b * r;

        public static double Poligono_kampu_suma(int n) => 180 * (double)(n - 2); 

        public static double Poligono_plotas(int n, int b, int h, int r)
        {
            double A = n switch
            {
                3 => Trikampio_plotas(b),
                4 => Keturkampio_plotas(b),
                _ => Daugiakampio_plotas(n, b)
            };
            return A;

        }

    }
}