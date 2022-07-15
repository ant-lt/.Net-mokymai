/*
        * 3. Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima “1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”. Pasirinkus 1 turetu ismesti ”
           1. Sudetis
           2. Atimtis
           3. Daugyba
           4. Dalyba”
           Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius, o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu. Sudeties pvz:
           “1
           15
           45
           Rezultatas: 60
           1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
           Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
           BONUS1: Iskelkite operacijas i metodus
           BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
           BONUS3: Parasyti unit testus uztikrinant operaciju veikima
           BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
       */
namespace Skaiciuotuvas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PagrindinisMeniu();
        }

        public static void PagrindinisMeniu()
        {
            Console.WriteLine($"MENIU:\n" +
                "1. Nauja operacija.\n" +
                "2. Testi su rezultatu\n" +
                "3. Išeiti iš programos\n\n" +
                "Pasirinkite meniu punktą:");

            int veiksmas = Convert.ToInt32(Console.ReadLine());

            switch (veiksmas)
            {
                case 1:
                    NaujaOperacija();
                    break;
                case 2:
                    PagrindinisMeniu();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            };
            
        }

        public static void NaujaOperacija()
        {

            Console.WriteLine($"1. Sudetis\n" +
                "2. Atimtis\n" +
                "3. Daugyba\n" +
                "4. Dalyba\n" +
                "Pasirinkite operaciją:");

            int veiksmas = Convert.ToInt32(Console.ReadLine());

            string skaicius1_text = Console.ReadLine();
            string skaicius2_text = Console.ReadLine();

            Console.WriteLine("Rezultatas: {0}", Skaiciuotuvas(Convert.ToDouble(skaicius1_text), Convert.ToDouble(skaicius2_text), veiksmas)); 

        }


        public static double Sudetis(double skaicius1, double skaicius2) => skaicius1 + skaicius2;
        public static double Atimtis(double skaicius1, double skaicius2) => skaicius1 - skaicius2;
        public static double Daugyba(double skaicius1, double skaicius2) => skaicius1 * skaicius2;
        public static double Dalyba(double skaicius1, double skaicius2) => skaicius1 / skaicius2;
        public static double? Skaiciuotuvas(double skaicius1, double skaicius2, int veiksmas)
        {
            double? rezultatas = null;

            switch (veiksmas)
            {
                case 1:
                    rezultatas = Sudetis(skaicius1, skaicius2);
                    break;
                case 2:
                    rezultatas = Atimtis(skaicius1, skaicius2);
                    break;
                case 3:
                    rezultatas = Daugyba(skaicius1, skaicius2);
                    break;
                case 4:
                    rezultatas = Dalyba(skaicius1, skaicius2);
                    break;

            }

            return rezultatas;
        }

        private static int SkaiciausTikrinimas(string? tekstas) => int.TryParse(tekstas, out int skaicius) ? skaicius : 0;

    }
}