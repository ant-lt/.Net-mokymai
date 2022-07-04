using System.Diagnostics;
using System.Globalization;

namespace P014_Debug
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Debug!");
            //Pinigas();
            Console.WriteLine(DecimalHour(Console.ReadLine()));
        }

        #region UŽDUOTIS "LAIKO APSKAITA"
        /*
         Įveskite darbo laiką valandomis ir minutėmis hh.mm arba valandomis, minutėmis ir sekundėmis hh.mm.ss 
         - Konvertuokite išdirbtą laiką į dešimtainę išlaišką
         - Suapvalinkite iki 4 skaičių po kablelio 
        
        Testai:
        DecimalHour("30.30") => "Decimal hour: 30.5"
        DecimalHour("20.30.30") => "Decimal hour: 20.5083"
        DecimalHour("20") => "Invalid time"
        DecimalHour("-20.50") => "Invalid hours"
        DecimalHour("a5.20.20") => "Invalid hours"
        DecimalHour("20.a5") => "Invalid minutes"
        DecimalHour("20.90") => "Invalid minutes"
        DecimalHour("20.30.90") => "Invalid seconds"
        DecimalHour("20.30.a5") => "Invalid seconds"
      
        */
        #endregion

        public static string DecimalHour(string input)
        {
            var isInputValid = IsDecimalHourInputValid(input, out string? msg);
            if (!isInputValid)
                return msg!;


            var a = input.Split(".");
            var dec = Convert.ToDecimal(a[0]) +      //valandos
                      (Convert.ToDecimal(a[1]) / 60) + //pridedame minutes
                      (a.Length > 2 ? (Convert.ToDecimal(a[2]) / 3600) : 0);

            return $"Decimal hour: {dec:0.0000}";
        }

        private static bool IsDecimalHourInputValid(string input, out string? msg)
        {
            msg = null;
            var a = input.Split(".");
            if (IsInputTimeInValid(a))
            {
                msg = "Invalid time";
                return false;
            }
            if (IsInputHourInValid(a))
            {
                msg = "Invalid hours";
                return false;
            }
            if (IsInputMinuteInValid(a))
            {
                msg = "Invalid minutes";
                return false;
            }
            if (IsInputSecondsInValid(a))
            {
                msg = "Invalid seconds";
                return false;
            }

            return true;
        }
        private static bool IsInputTimeInValid(string[] a) => a.Length < 2;
        private static bool IsInputHourInValid(string[] a) => !int.TryParse(a[0], out int hour) || hour < 0;
        private static bool IsInputMinuteInValid(string[] a) => !int.TryParse(a[1], out int minute) || minute < 0 || minute > 60;
        private static bool IsInputSecondsInValid(string[] a) => a.Length > 2 && (!int.TryParse(a[2], out int sec) || sec < 0 || sec > 60);


        public static void Pinigas()
        {
            Console.WriteLine("Iveskite pinigu suma");
            var suma = Console.ReadLine();
            var kursas = 5.6;
            Debug.WriteLine("LABAS");
            //var rezultatas = Convert.ToInt32(suma) * kursas; //reikalinga korekcija del didelio skaiciaus pvz 8888888888
            //var rezultatas = Convert.ToInt64(suma) * kursas; //reikalinga korekcija del trupmeninio skaiciaus pvz 20,4
            //var rezultatas = Convert.ToDouble(suma) * kursas; //reikalinga korekcija del trupmeninio skaiciaus su tasku pvz 20.4

            var decimalSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
            var goupSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberGroupSeparator;

            suma = suma.Replace(decimalSeparator, goupSeparator);

            var rezultatas = Convert.ToDouble(suma) * kursas;
            Console.WriteLine("Jus turite rankoje {0} pinigus", rezultatas);
            Debug.WriteLine("Jus turite rankoje {0} pinigus", rezultatas);
            Console.ReadKey();

        }

    }
}