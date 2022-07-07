using System.Diagnostics;

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

            //Console.WriteLine("Iveskite 1  skaičių:");
            //int skaicius1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite 2  skaičių:");
            //int skaicius2 = Convert.ToInt32(Console.ReadLine());



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


            /*
             *
            1.Naudodami method overloading sukurkite metodus Suma, Atimtis, Daugyba, Dalyba kurie priima du double tipo parametrus.
                (prieštai sukurtų metodų ištrinti negalima)
            2. Naudotojui įvedus skaičius nustatykite ar buvo įvestas skaičius su kableliu ar be ir duomenis nukreipkite reikiamiems metodams. 
                (Informaciją apie tai, koks metodas buvo panaudotas išveskite į debug konsolę)
            3. Matematinius metodus palildykite kėlimu kvadratu (^2) ir kėlimu kūbu ( ^3).
            4.Padarykite meniu, kur naudotojui leis pasirinkti koks matematinis veiksmas bus atliekamas 
                (gali parinkti arba veiksmą, arba veiksmo numerį meniu. Abiem atvejais bus atliekama matematinė operacija) 
            (Pasirinkimams panaudoti switch sakinį)
                1) +
                2) -
                3) *
                4) /
                5) a^2
                6) a^3

             * 
             * 
             */

            Console.WriteLine("Iveskite 1  skaičių:");
            string skaicius1_text = Console.ReadLine();

            Console.WriteLine("Iveskite 2  skaičių:");
            string skaicius2_text = Console.ReadLine();



            Console.WriteLine("Veiksmai:");
            Console.WriteLine(" 1) +");
            Console.WriteLine(" 2) -");
            Console.WriteLine(" 3) *");
            Console.WriteLine(" 4) /");
            Console.WriteLine(" 5) ^2");
            Console.WriteLine(" 6) ^3");

            Console.WriteLine("Iveskite veiksmą:");

            string veiksmas = Console.ReadLine();

            double? rezultatas = 0;
            if (skaicius1_text.Contains(',')  || skaicius2_text.Contains(',') )
            {
                rezultatas = Skaiciuotuvas(Convert.ToDouble(skaicius1_text), Convert.ToDouble(skaicius2_text), veiksmas); 
            }
            else rezultatas = Skaiciuotuvas(Convert.ToInt32(skaicius1_text), Convert.ToInt32(skaicius2_text), veiksmas);

            Console.WriteLine($" Rezultatas {rezultatas}" );

        }

        // liamda funkcija
        public static double Suma(int skaicius1, int skaicius2) => skaicius1 + skaicius2;
        public static double Suma(double skaicius1, double skaicius2) => skaicius1 + skaicius2;

        public static double Atimtis(int skaicius1, int skaicius2) => skaicius1 - skaicius2;
        public static double Atimtis(double skaicius1, double skaicius2) => skaicius1 - skaicius2;

        public static double Daugyba(int skaicius1, int skaicius2) => skaicius1 * skaicius2;
        public static double Daugyba(double skaicius1, double skaicius2) => skaicius1 * skaicius2;
        
        public static double Dalyba(int skaicius1, int skaicius2) => (double)skaicius1 / skaicius2;
        public static double Dalyba(double skaicius1, double skaicius2) => skaicius1 / skaicius2;

       // public static double Kelimas2(int skaicius1) => skaicius1 * skaicius1;
        public static double Kelimas2(double skaicius1) => skaicius1 * skaicius1;

        //public static double Kelimas2(int skaicius1) => skaicius1 * skaicius1 * skaicius1;
        public static double Kelimas3(double skaicius1) => skaicius1 * skaicius1 * skaicius1;



        public static double? Skaiciuotuvas(int skaicius1, int skaicius2, string veiksmas)
        {
            double? rezultatas = null;

            Debug.WriteLine("Naudojamas INT Skaičiuotuvas");

            switch (veiksmas)
               {
                case "+":
                case "1":
                    rezultatas = Suma(skaicius1, skaicius2);
                    break;
                case "-":
                case "2":
                    rezultatas = Atimtis(skaicius1, skaicius2);
                    break;
                case "*":
                case "3":
                    rezultatas = Daugyba(skaicius1, skaicius2);
                    break;
                case "/":
                case "4":
                    rezultatas = Dalyba(skaicius1, skaicius2);
                    break;
                case "^2":
                case "5":
                    rezultatas = Kelimas2((double)skaicius1);
                    break;
                case "^3":
                case "6":
                    rezultatas = Kelimas3((double)skaicius1);
                    break;
            }

            return rezultatas;
            }

        public static double? Skaiciuotuvas(double skaicius1, double skaicius2, string veiksmas)
        {
            double? rezultatas = null;

            Debug.WriteLine("Naudojamas Double Skaičiuotuvas");
            switch (veiksmas)
            {
                case "+":
                case "1":
                    rezultatas = Suma(skaicius1, skaicius2);
                    break;
                case "-":
                case "2":
                    rezultatas = Atimtis(skaicius1, skaicius2);
                    break;
                case "*":
                case "3":
                    rezultatas = Daugyba(skaicius1, skaicius2);
                    break;
                case "/":
                case "4":
                    rezultatas = Dalyba(skaicius1, skaicius2);
                    break;
                case "^2":
                case "5":
                    rezultatas = Kelimas2(skaicius1);
                    break;
                case "^3":
                case "6":
                    rezultatas = Kelimas3(skaicius1);
                    break;

            }

            return rezultatas;
        }



    }
}