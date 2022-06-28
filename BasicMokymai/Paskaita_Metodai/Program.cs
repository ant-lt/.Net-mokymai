namespace Paskaita_Metodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Metodai!");

            Console.WriteLine("Sukuriame pirma savo metoda");

            
            IsveskKazkaEkrane();// metodo kvietimas 

            Console.WriteLine("---------");

            float kazkoksSkaicus = GautiAtsitiktiniSkaiciu();

            Console.WriteLine($"kazkoksskaicius = {kazkoksSkaicus}"); 
            Console.WriteLine("--------------");

            int a = 2;
            IsveskKazkaEkrane(a); // metodas su vienu parametru
            Console.WriteLine($"a is Main= {a}");

            int sk1 = 2;
            int sk2 = 2;
            int sudaugintiDuSkaiciai = DaugintiSkaicius(sk1, sk2);

            Console.WriteLine($"sudauginti du skaiciai =  {sudaugintiDuSkaiciai}"); // metodas su dviems parametrais grazina ju daugyba int

            Console.WriteLine("--------------");

            int sudaugintiTrysSkaiciai = DaugintiSkaicius(sk1, sk2, 2);

            Console.WriteLine($"sudauginti trys skaiciai = {sudaugintiTrysSkaiciai}"); // metodo overloadinimas, metodas priima 3 argumentus ir grazina int
            Console.WriteLine("--------------");

            double sk1d = 2;
            double sk2d = 2.1;
            double sudaugintiDoubleSkaiciai = DaugintiSkaicius(sk1d, sk2d);

            Console.WriteLine($"sudauginti du double skaiciai =  {sudaugintiDoubleSkaiciai}"); // metodas su dviems parametrais grazina ju daugyba int

            double sudaugintiDoubleSkaiciai1 = DaugintiSkaicius((double)sk1, sk2d);

            Console.WriteLine($"sudauginti du double skaiciai =  {sudaugintiDoubleSkaiciai1}"); // metodas su dviems parametrais grazina ju daugyba int

            Console.WriteLine("--------------");

            IsveskTekstaEkranan();
            IsveskTekstaEkranan("kazkoks tekstas");


            Console.WriteLine("--------------");
            IsveskSkaiciuIrTekstaEkranan(1);
            IsveskSkaiciuIrTekstaEkranan(1, "kazkoks tesktas");

            Console.WriteLine("-----------------");

            int patikrintasSkaicius =  SkaiciausPatikrinimas(20, 50, 100);

            Console.WriteLine($"patikrintasSkaicius = {patikrintasSkaicius}");
            

            Console.WriteLine("-----------------");


            int patikrintasSkaicius1 = SkaiciausPatikrinimas(max: 100, min: 50, skaicius: 51);

            Console.WriteLine($"patikrintasSkaicius1 = {patikrintasSkaicius1}");


            Console.WriteLine("-----------------");


            Console.WriteLine("vidurkis " + Vidurkis(2,3) );
            Console.WriteLine("vidurkis " + Vidurkis(2, 3, 8));
            Console.WriteLine("vidurkis " + Vidurkis(2, 3, 8, 10));

            Console.WriteLine("-----------------");

            GautiSkaiciu(out int gautasSkaicius);
            Console.WriteLine($"gautas skaicius = {gautasSkaicius}");

            Console.WriteLine("-----------------");


            int rsk = 2;
            Console.WriteLine($"rsk = {rsk}");
            ReferenceSkaicius(ref rsk); // reksmes perdavimas per reference keicia reiksme kvieciantiame metode

            Console.WriteLine($"po reference skaicius rsk = {rsk}");
            Console.WriteLine("-----------------");


            // lokalios funkcijos
            int Add( int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Add(2,2));

            Console.WriteLine("-----------------");

        }

        public static void ReferenceSkaicius ( ref int skaicius)
        {
            skaicius = 900;
        }
        public static void GautiSkaiciu(out int skaicius)
        {
            skaicius = 2;
        }

        public static double Vidurkis(params int[] skaiciai)
        {
            double total =0;
            foreach (var skaicius in skaiciai)
            {
                total += skaicius;
            }
            return total / skaiciai.Length;
        }

        public static int SkaiciausPatikrinimas(int skaicius, int min, int max)
        {
            if (skaicius < min)
            {
                return min;
            }
            if (skaicius > max)
            {
                return max;
            }

            return skaicius;
        }

        public static void IsveskTekstaEkranan(string tekstas = "tekstas neivestas")
        {
            Console.WriteLine("tekstas " + tekstas);
        }

        public static void IsveskSkaiciuIrTekstaEkranan( int skaicius, string tekstas = "tekstas neivestas")
        {
            Console.WriteLine($"skaicius - {skaicius}, tekstas {tekstas}");
        }

        public static double DaugintiSkaicius(double sk1d, double sk2d)
        {
            return sk1d * sk2d;
        }

        public static int DaugintiSkaicius(int sk1, int sk2, int sk3)
        {
            return sk1 * sk2 * sk3;
            
        }

        public static int DaugintiSkaicius(int sk1, int sk2)
        {
            return sk1 * sk2;

        }

        public static void IsveskKazkaEkrane(int a)
        {
            a = a + 8;
            Console.WriteLine($"skaicius yra {a}");
        }

        public static float GautiAtsitiktiniSkaiciu()
        {
            Console.WriteLine("Isvedu kazka");
            return 4.6655f;
        }

        public static void IsveskKazkaEkrane()
        {
            Console.WriteLine("Isvedu kazka");

        }
    }
}