namespace Tipu_mokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Tipu konversijos!");

            int skaiciusInt = 100;
            long skaiciusLong = 100;
            long castingLong = (long)skaiciusInt;
            long castingLong1 = skaiciusInt;

            var castingLong2 = (long)skaiciusInt;

            byte skaiciusByte = 200;
            int skaiciusInt2 = skaiciusByte;
            long skaiciusLong2 = skaiciusByte;
            long skaiciusLong3 = skaiciusInt2;
            float skaiciusFloat = skaiciusByte;
            float skaiciusFloat1 = skaiciusInt2;
            float skaiciusFloat2 = skaiciusLong2;
            double skaiciusDouble = skaiciusByte;
            double skaiciusDouble1 = skaiciusInt2;
            double skaiciusDouble2 = skaiciusLong2;
            double skaiciusDouble3 = skaiciusFloat2;
            decimal skaiciusDecimal = skaiciusByte;

            // Explicit casting
            int castingInt = (int)skaiciusLong;
            // decima - > double -> float -> long -> int -> char
            float f1 = 5.6f;
            int castingint1 = (int)f1;
            Console.WriteLine(" i = {0}", castingint1);

            char skaiciusRaide = 'a';
            int castintasInt2 = skaiciusRaide;

            Console.WriteLine($" castintasInt2= {castintasInt2}");
            long castinLong3 = skaiciusRaide;

            // char -> ushort - > int -> uint -> long -> ulong -> float - double - > decimal

            long skaiciusLongDidesnis = 3_000_000_000;
            int castintasInt4 = (int)skaiciusLongDidesnis;

            Console.WriteLine($" castintasInt4= {castintasInt4}");

            long skaicusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)skaiciusLongDidesnis;

            Console.WriteLine($" castinintasInt5= {castintasInt5}");

            // *** Type conversion Methods

            string konvertuotasString = Convert.ToString(skaiciusInt);
            string konvertuotasString1 = skaiciusInt.ToString();

            long konvertuotasLong = Convert.ToInt64(skaiciusInt);
            double konvertuotasDouble = Convert.ToDouble(skaiciusInt);

            // int konvertuotasInt = Convert.ToInt32(skaiciusLongDidesnis); // luzta nes netelpa

            // darbas su nullable tipais
            int? skaiciusIntNull = null;
            // long castintasLong5 = (long)skaiciusIntNull; // luzta

            long konvertuoasLong1 = Convert.ToInt64(skaiciusIntNull); // programa neluzta, o grazina long tipo default reiksme 0

            Console.WriteLine($" konvertuotasLong1= {konvertuoasLong1}");

            // parsinimas
            string skaiciusString = "100";
            string skaiciusDidelisString = "9999999999999999999999";
            string tekstas = "tekstas";
            int skaiciusIntParsintas = int.Parse(skaiciusString);

            Console.WriteLine($" skaiciusString + 1 = {skaiciusString + 1}");
            Console.WriteLine($" skaiciusIntParsintas + 1 = {skaiciusIntParsintas + 1}");

            // int skaiciusDoubleParsintas = int.Parse(skaiciusDidelisString); // luzta

            // int tekstasIntParsintas = int.Parse(tekstas); // luzta



        }
    }
}