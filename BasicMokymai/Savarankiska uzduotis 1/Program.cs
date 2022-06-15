namespace Savarankiska_uzduotis_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų. 
               - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.
               - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.
               - Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)
               - Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)
               - Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)
               - Nupieškite termometrą pagal Celsijų 
                 a) Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
                   (tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)
                 b) Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
                    <HINT> naudokite .ToString(), palyginimo reliacinius operatorius (==, >, < ir t.t.) ir .Replace(). 
                    if naudoti negalima, ternary operator (?) naudoti negalima.
            rezultatas gali atrodyti taip:
                                        |--------------------|
                                        |   ^F     _    ^C   |
                                        |  100  - | | -  40  |
                                        |   95  - | | -  35  |
                                        |   90  - | | -  30  |
                                        |   80  - | | -  25  |
                                        |   70  - | | -  20  |
                                        |   60  - | | -  15  |
                                        |   50  - |#| -  10  |
                                        |   40  - |#| -   5  |
                                        |   30  - |#| -   0  |
                                        |   20  - |#| -  -5  |
                                        |   10  - |#| - -10  |
                                        |    5  - |#| - -15  |
                                        |    0  - |#| - -20  |
                                        |  -10  - |#| - -25  |
                                        |  -20  - |#| - -30  |
                                        |  -30  - |#| - -35  |
                                        |  -40  - |#| - -40  |
                                        |        '***`       |
                                        |       (*****)      |
                                        |        `---'       |
                                        |____________________|
             */
            Console.WriteLine("Įveskite temperatūrą pagal Celsijų: ");

            var tempCelsijus = Convert.ToInt32(Console.ReadLine());
            //To convert temperatures in degrees Celsius to Fahrenheit, multiply by 1.8(or 9 / 5) and add 32.
            // Example: (30°C x 1.8) +32 = 86°F

            int tempFahr = Convert.ToInt32((tempCelsijus * 1.8) + 32);

            Console.WriteLine($"Fahrenheit = {tempFahr} °F");

            //The temperature T in Kelvin (K) is equal to the temperature T in degrees Celsius (°C) plus 273.15:
            //T(K) = T(°C) + 273.15

            int tempKelvin = Convert.ToInt32(tempCelsijus + 273.15);
            
            Console.WriteLine($"Kelvin = {tempKelvin} K");


            //To convert temperatures in degrees Fahrenheit to Celsius, subtract 32 and multiply by .5556 (or 5/9).
            //Example: (50°F - 32) x .5556 = 10°C
            
            var perskFahrenToCelsius = Convert.ToInt32( (tempFahr - 32) * 0.556 );

            Console.WriteLine($"Perskaičiuota Fahrenheit to Celsius = {perskFahrenToCelsius} °C");
            Console.WriteLine($"ar sutampa su įvestu skaičių ? {perskFahrenToCelsius == tempCelsijus}");
            Console.WriteLine("-----------------");

            var perskKelvinToCelsius = Convert.ToInt32(tempKelvin - 273.15);

            Console.WriteLine($"Perskaičiuota Kelvina to Celsius = {perskKelvinToCelsius} °C");
            Console.WriteLine($"ar sutampa su įvestu skaičių ? {perskKelvinToCelsius == tempCelsijus}");
            Console.WriteLine("-----------------");


            //The temperature T in Kelvin (K) is equal to the temperature T in degrees Fahrenheit (°F) plus 459.67, times 5/9:
            //T(K) = (T(°F) + 459.67)× 5 / 9
            //Example
            //Convert 60 degrees Fahrenheit to degrees Kelvin:

            //T(K) = (60°F + 459.67)× 5 / 9 = 288.71 K

            var perskFahrenToKelvin = Convert.ToInt32(( tempFahr + 459.67) * 5 / 9 );

            Console.WriteLine($"Perskaičiuota Kelvina to Fahrenheit = {perskFahrenToKelvin} K");
            Console.WriteLine($"ar sutampa su įvestu skaičių ? {perskFahrenToKelvin == tempKelvin}");
            Console.WriteLine();


            // Nupieškite termometrą pagal Celsijų 

            bool skale40 = (tempCelsijus - 40 ) > 40;
            bool skale35 = (tempCelsijus - 35 ) > 35;
            bool skale30 = (tempCelsijus - 30 ) > 30;
            bool skale25 = (tempCelsijus - 25 ) > 25;
            bool skale20 = (tempCelsijus - 20 ) > 20;
            bool skale15 = (tempCelsijus - 15 ) > 15;
            bool skale10 = (tempCelsijus - 10 ) > 10 ;
            bool skale5 = (tempCelsijus - 5 ) > 5;
            bool skale0 = (tempCelsijus ) > 0;
            bool skaleM5 = (tempCelsijus + 5 ) > -5;
            bool skaleM10 = (tempCelsijus + 10) > -10;
            bool skaleM15 = (tempCelsijus + 15) > -15;
            bool skaleM20 = (tempCelsijus + 20) > -20;
            bool skaleM25 = (tempCelsijus + 25) > -25;
            bool skaleM30 = (tempCelsijus + 30) > -30;
            bool skaleM35 = (tempCelsijus + 35) > -35;
            bool skaleM40 = (tempCelsijus + 40) > -40;


            Console.WriteLine($"|--------------------|");
            Console.WriteLine($"|   ^F     _    ^C   |");
            Console.WriteLine($"|   {tempFahr + 40}  - |{skale40.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 40}  |");
            Console.WriteLine($"|   {tempFahr + 35}  - |{skale35.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 35}  |");
            Console.WriteLine($"|   {tempFahr + 30}  - |{skale30.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 30}  |");
            Console.WriteLine($"|   {tempFahr + 25}  - |{skale25.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 25}  |");
            Console.WriteLine($"|   {tempFahr + 20}  - |{skale20.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 20}  |");
            Console.WriteLine($"|   {tempFahr + 15}  - |{skale15.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 15}  |");
            Console.WriteLine($"|   {tempFahr + 10}  - |{skale10.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 10}  |");
            Console.WriteLine($"|   {tempFahr +  5}  - |{skale5.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 5}  |");
            Console.WriteLine($"|   {tempFahr + 0}  - |{skale0.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 0}  |");
            Console.WriteLine($"|   {tempFahr - 5}  - |{skaleM5.ToString().Replace("False", " ").Replace("True", "#")}| -   {tempCelsijus - 5}  |");
            Console.WriteLine($"|   {tempFahr - 10}  - |{skaleM10.ToString().Replace("False", " ").Replace("True", "#")}| -   {tempCelsijus - 10}  |");
            Console.WriteLine($"|   {tempFahr - 15}  - |{skaleM15.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus - 15}  |");
            Console.WriteLine($"|   {tempFahr - 20}  - |{skaleM20.ToString().Replace("False", " ").Replace("True", "#")}| - {tempCelsijus - 20}  |");
            Console.WriteLine($"|   {tempFahr - 25}  - |{skaleM25.ToString().Replace("False", " ").Replace("True", "#")}| - {tempCelsijus - 25}  |");
            Console.WriteLine($"|   {tempFahr - 30}  - |{skaleM30.ToString().Replace("False", " ").Replace("True", "#")}| - {tempCelsijus - 30}  |");
            Console.WriteLine($"|   {tempFahr - 35}  - |{skaleM35.ToString().Replace("False", " ").Replace("True", "#")}| - {tempCelsijus - 35}  |");
            Console.WriteLine($"|   {tempFahr - 40}  - |{skaleM40.ToString().Replace("False", " ").Replace("True", "#")}| - {tempCelsijus - 40}  |");
            Console.WriteLine($"|        '***`       |");
            Console.WriteLine($"|       (*****)      |");
            Console.WriteLine($"|        `---'       |");
            Console.WriteLine($"|____________________|");
             











            /*
             PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (KILOMENTRAIS) TARP TAŠKŲ A IR B IR DVIEJŲ TRANSPORTO PRIEMONIŲ GREITĮ (KM/H). 
             VIENA TRANSPORTO PRIEMONĖS PRADEDA VAŽIUOTI IŠ A, KITA IŠ B.STARTUOJA VIENU METU.
              - PASKAIČIUOTI ATSTUMĄ NUO A IKI VIETOS KURIOJE TRASPORTO PRIEMONĖS SUTITIKS METRAIS. 
              - PASKAIČIUOTI LAIKĄ KADA TRASPORTO PRIEMONĖS SUSITIKS SEKUNDĖMIS. 
              - PASKAIČIUOTI LAIKĄ, KADA TRASPORTUO PRIEMONĖS PASIEKS GALIUTINIUS TAŠKUS MINUTĖMIS.
              - PASKAIČIUOTI KIEK GRAMŲ CO2 IŠSKYRĖ ABI TRASPORTO PIEMONĖS KARTU SUDĖJUS. CO2 NORMA YRA 95 g/km.
              - GRAFIŠKAI PAVAIZDUOTI KELIĄ NUO A IKI B SUSKIRSTYTĄ Į 20 LYGIŲ SEGMENTŲ (TARKIME ĮVESTAS ATSTUMAS YRA 100KM, TUOMENT TURĖSIME 20 SEGMENTU PO 5KM).  
                A) PARODYTI VISO KELIO ILGĮ KM
                B) PARODYTI SEGMENTO ILGĮ KM
                C) PARODYTI KURIAME SEGMENTE TRASPORTO PREMONĖS SUTIKS IR ATSTUMĄ IKI SUSITIKIMO (TAŠKAS V)
                D) PARODYTI ABIEJŲ TRANSPORTO PRIEMONIŲ VAŽIAVIMO TRUKMĘ
                REZULTATAS GALI ARTODYTI TAIP:

                | 5km  | 5km  | 5km  | 5km   | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  |
                |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |
               _A______|______|______|___V___|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______B_
                |-----------22km---------|        
                |----------------------------------------------------------------100km-----------------------------------------------------------------------|        
                >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> 90min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< 30min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
             */



        }
    }
}