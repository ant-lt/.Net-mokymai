namespace Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki kintamieji");
            //Skaičių kintamieji
            //Sveikų skaičių kintamieji
            byte mazasSkaicius = 2; //255
            short trumpasSkaicius = 2; //32767
            int skaicius = 2; //2.147.483.647
            int maksimalusIntSkaitmuo = int.MaxValue;
            int minimalusIntSkaitmuo = int.MinValue;
            Console.WriteLine("  maksimalusIntSkaitmuo={0}\n   minimalusIntSkaitmuo={1}", maksimalusIntSkaitmuo, minimalusIntSkaitmuo);
            long ilgasSkaicius = 2;

            int? skaiciusKurisKagiButiNull;
            skaiciusKurisKagiButiNull = null;
            Nullable<int> skaiciusKurisKagiButiNull2 = null;


            uint tikTeigiamasSkaicius = 2; //4.294.967.295
            //tikTeigiamasSkaicius = -5; taip negalima

            int? skaicius5 = null;
            Console.WriteLine(skaicius5);
            skaicius5 = 5;


            Console.WriteLine("Floating point types");

            float maziausiasTrupmeninis = 8.5f;
            var trupmeninisVar = 8.5f;
            double trupmeninis = 8.5;
            decimal didziausiasTrupmeninis = 8.5m;

            Console.WriteLine("PROBLEMOS SU TIKSLUMU");
            double f1 = 0.09 * 100;
            double f2 = 0.09 * 99.999999;
            Console.WriteLine("ar f1 > f2? {0}", f1 > f2);
            Console.WriteLine("ar f1 < f2? {0}", f1 < f2);
            Console.WriteLine("ar f1 == f2? {0}", f1 == f2);

            Console.WriteLine("ar float 0.99F == 1? {0}", 0.99F == 1);
            Console.WriteLine("ar float 0.999999F == 1? {0}", 0.999999F == 1);
            Console.WriteLine("ar float 0.99999999999999999 == 1? {0}", 0.99999999999999999F == 1);
            Console.WriteLine("ar double 0.99999999 == 1? {0}", 0.99999999 == 1);
            Console.WriteLine("ar double 0.99999999999999999 == 1? {0}", 0.99999999999999999 == 1);
            Console.WriteLine("ar decimal 0.99999999999999999 == 1? {0}", 0.99999999999999999M == 1);


            //patogesni skaičių užrašymai
            double avogadrosNumber = 6.022e23; // taip užrašoma 6.022x10^23.
            double digitSeparator = 522_1_000.000_001; //The Digit Separator

            int trylika = 0b00001101; //13 binariniu (0b) būdu
            int duSimaiPenkesdiasimt = 0xFA; //250 šešioliktainis (0x)

            //Daugybinės deklaracijos            
            int daugDklaracija1, daugDklaracija2, daugDklaracija3;
            daugDklaracija1 = daugDklaracija2 = daugDklaracija3 = 100;// visiem skaičiam bus priskirta reikšmė 100


            Console.WriteLine("Loginiai kintamieji");
            bool teisybe = true; //reprezentuoja reisybę. Gali būti įrašyta true ir false
            bool neteisybe = false;
            bool? nullableLoginis = null;

            Console.WriteLine("char kintamieji");
            char raide = 'n'; //yra sveiko skaitmens tipas, nors atrodo kad talpina raidę.  Char is similar to an integer or ushort
            bool ds = char.IsDigit(raide); //patinkrinimas ar skaicius
            char.IsLetter(raide); //patinkrinimas ar raide
            char.IsLetterOrDigit(raide); //patikrinimas ar raide arba skaicius
            char.IsPunctuation(raide); //patikrinimas ar taskas, kablelis
            //...... ir t.t. F12

            Console.WriteLine("datos kintamieji");
            DateTime siandien = DateTime.Now;

            //implicit "type" var, Type Inference
            var nulis = 0; //int tipas
            var automatinisIlgasSkaicius = 9999999999999999;
            var kazkoksTekstas = " kazkoks tekstas ";
            var kazkokiaData = new DateTime(2022, 06, 07);

            var floatSkaicius = 88.0F;

            var s1 = 2_000_000_000;
            var s2 = 2_000_000_001;
            long s3 = s1 + (long)s2;
            Console.WriteLine(s3);


            KeyValuePair<int, string> raktasIrReiksme = new KeyValuePair<int, string>(10, "Laptop");
            Console.WriteLine(raktasIrReiksme.Key);
            Console.WriteLine(raktasIrReiksme.Value);

            Tuple<int, int, string> tuple = new Tuple<int, int, string>(20, 1500, "Laptop");
            Tuple<int, int, string, string> tuple1 = new Tuple<int, int, string, string>(20, 1500, "Laptop", "Lenovo"); //iki 7 reikšmių


            int a = 5; //į a įrašoma reikšmė 5
            int b = 2; //į b įrašoma reikšmė 2
            b = a;     //nuskaitoma a reikšmė (5) ir padaroma reikšmės kopija. Ši kopija įrašoma į kintamajį b. b tampa lygus 5.
            a = -3;    //į a įrašoma reikšmė -3. Buvusi reikšmė negražinamai sunaikinama. Tačiau kiekaip nepaliečiama reikšmė kuri buvo įrašyta į b, bes ten yra kopija.


        }
    }
}