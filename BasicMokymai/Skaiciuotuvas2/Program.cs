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
    public class Program
    {
        static void Main(string[] args)
        {
            PagrindinisMeniu();
        }

        public static void PagrindinisMeniu()
        {
            bool testi = true;
            double? rezultatas = null;
            string skaicius1_text = string.Empty;
            string skaicius2_text = string.Empty;

            while (testi)
            { 
                Console.WriteLine($"\n" + "1. Nauja operacija. " + "2. Testi su rezultatu. " + "3. Išeiti iš programos\n" +"Pasirinkite meniu punktą:");
            
                int veiksmas = Convert.ToInt32(Console.ReadLine());

                switch (veiksmas)
                {
                case 1:
                        veiksmas = Operacija();
                        if (veiksmas == 6)
                        {
                            //jeigu kvadratines saknies traukimas tai tik vienas skaicius reikalingas
                            Console.WriteLine("Įveskite 1 skaičiu:");
                            skaicius1_text = Console.ReadLine();
                            rezultatas = Skaiciuotuvas(DoubleSkaiciausTikrinimas(skaicius1_text), 0, veiksmas);
                        }
                        else
                        {
                            Console.WriteLine("Įveskite du skaičius:");
                            skaicius1_text = Console.ReadLine();
                            skaicius2_text = Console.ReadLine();
                            rezultatas = Skaiciuotuvas(DoubleSkaiciausTikrinimas(skaicius1_text), DoubleSkaiciausTikrinimas(skaicius2_text), veiksmas);
                        }                        
                        break;                        
                case 2:
                        veiksmas = Operacija();
                      
                        if (veiksmas != 6)
                        {
                            //jeigu kvadratines saknies traukimas tai panaudojame esama rezultata.
                            Console.WriteLine("Įveskite skaičiu:");
                            skaicius2_text = Console.ReadLine();
                        }
                        rezultatas = Skaiciuotuvas((double)rezultatas, DoubleSkaiciausTikrinimas(skaicius2_text), veiksmas);
                        break;
                case 3:
                        testi = false;
                        rezultatas = null;
                    break;
                default:
                        Console.Clear();
                    break;
            };
                if (rezultatas != null) Console.WriteLine("Rezultatas: {0}", rezultatas);          
            }
        }

        public static int Operacija()
        {
            Console.WriteLine($"1. Sudetis\n" +
                "2. Atimtis\n" +
                "3. Daugyba\n" +
                "4. Dalyba\n" +
                "5. Laipsnio pakelimas\n"+
                "6. Kvadratines šaknies traukimas\n"+
                "Pasirinkite operaciją:");

            return Convert.ToInt32(Console.ReadLine());
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
                case 5:
                    rezultatas = Math.Pow(skaicius1, skaicius2);
                    break;
                case 6:
                    rezultatas = Math.Sqrt(skaicius1);
                    break;
            }
            return rezultatas;
        }

      private static double DoubleSkaiciausTikrinimas(string? tekstas) => double.TryParse(tekstas, out double skaicius) ? skaicius : 0;
    }
}