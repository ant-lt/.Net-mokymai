namespace Savarankiska_uzduotis_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Termometras
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



            // Sugraduojame skalę, kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių
            // Pažymime skaleje False jeigu temperaturos reikšmė mažiau negu reikšmė skaleje
            // Pažymime skaleje True jeigu temperaturos reikšmė didesne negu reikšmė skaleje
            // Įvesta reikšmė visada bus pažymeta per vidurį ir užpildyta į apačią.
            // Skale min. įvestos temperatūros reikšme  - 40 laipsnių
            // Skale max. įvestos temperatūros reikšme  + 40 laipsnių
            bool skale40 = tempCelsijus >= (tempCelsijus + 40);
            bool skale35 = tempCelsijus >= (tempCelsijus + 35);
            bool skale30 = tempCelsijus >= (tempCelsijus + 30);
            bool skale25 = tempCelsijus >= (tempCelsijus + 25);
            bool skale20 = tempCelsijus >= (tempCelsijus + 20);
            bool skale15 = tempCelsijus >= (tempCelsijus + 15);
            bool skale10 = tempCelsijus >= (tempCelsijus + 10);
            bool skale5 = tempCelsijus >= (tempCelsijus + 5);
            
            bool skale0 = tempCelsijus >= 0 ;

            bool skaleM5 = tempCelsijus >= (tempCelsijus - 5); 
            bool skaleM10 = tempCelsijus >= (tempCelsijus - 10);
            bool skaleM15 = tempCelsijus >= (tempCelsijus - 15);
            bool skaleM20 = tempCelsijus >= (tempCelsijus - 20);
            bool skaleM25 = tempCelsijus >= (tempCelsijus - 25);
            bool skaleM30 = tempCelsijus >= (tempCelsijus - 30);
            bool skaleM35 = tempCelsijus >= (tempCelsijus - 35);
            bool skaleM40 = tempCelsijus >= (tempCelsijus - 40);

            // Nupiešiamas termometras su skale kur Fahrenheitais kairėje ir Celsijomis dešinėje pusėje
            Console.WriteLine($"|----------------------|");
            Console.WriteLine($"|   ^F      _      ^C  |");
            Console.WriteLine($"|   {tempFahr + 40,3}  - |{skale40.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 40,3}  |");
            Console.WriteLine($"|   {tempFahr + 35,3}  - |{skale35.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 35,3}  |");
            Console.WriteLine($"|   {tempFahr + 30,3}  - |{skale30.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 30,3}  |");
            Console.WriteLine($"|   {tempFahr + 25,3}  - |{skale25.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 25,3}  |");
            Console.WriteLine($"|   {tempFahr + 20,3}  - |{skale20.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 20,3}  |");
            Console.WriteLine($"|   {tempFahr + 15,3}  - |{skale15.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 15,3}  |");
            Console.WriteLine($"|   {tempFahr + 10,3}  - |{skale10.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 10,3}  |");
            Console.WriteLine($"|   {tempFahr +  5,3}  - |{skale5.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 5,3}  |");
            Console.WriteLine($"|   {tempFahr + 0,3}  - |{skale0.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus + 0,3}  |");
            Console.WriteLine($"|   {tempFahr - 5,3}  - |{skaleM5.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus - 5,3}  |");
            Console.WriteLine($"|   {tempFahr - 10,3}  - |{skaleM10.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus - 10,3}  |");
            Console.WriteLine($"|   {tempFahr - 15,3}  - |{skaleM15.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus - 15,3}  |");
            Console.WriteLine($"|   {tempFahr - 20,3}  - |{skaleM20.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus - 20,3}  |");
            Console.WriteLine($"|   {tempFahr - 25,3}  - |{skaleM25.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus - 25,3}  |");
            Console.WriteLine($"|   {tempFahr - 30,3}  - |{skaleM30.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus - 30,3}  |");
            Console.WriteLine($"|   {tempFahr - 35,3}  - |{skaleM35.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus - 35,3}  |");
            Console.WriteLine($"|   {tempFahr - 40,3}  - |{skaleM40.ToString().Replace("False", " ").Replace("True", "#")}| -  {tempCelsijus - 40,3}  |");
            Console.WriteLine($"|         '***`        |");
            Console.WriteLine($"|        (*****)       |");
            Console.WriteLine($"|         `---'        |");
            Console.WriteLine($"|______________________|");

            
            Console.WriteLine();
            Console.WriteLine("Paspauskite bet kurią klavišą.");
            Console.ReadKey();


            /*
             *   Užduotis Kelias
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
   viso 100 km
 |--------------------------------------------------------------------------------------------------------------------------------------------|
 0      5     10     15     20      25     30     35     40     45     50     55     60     65     70     75     80     85     90     95    100
 |      |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |
_A______|______|______|______|___V___|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______B_
 |-------------------------------|                                                                                                                                                        
   susitikimo vieta 23,1 km
   susitikimo laikas po 0,87 val.
 | >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>   200 min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>|
 |<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<   60 min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< |

            t=s/(u1+u2) s - atstumas, u1 ir u2 - greitis, t - laikas
             */
            
            Console.Clear();

            Console.WriteLine("ĮVESTI ATSTUMĄ (KILOMENTRAIS) TARP TAŠKŲ A IR B");
            double atstumas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ĮVESTI 1-os TRANSPORTO PRIEMONIŲ GREITĮ(KM / H)");
            double greitis1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ĮVESTI 2-os TRANSPORTO PRIEMONIŲ GREITĮ(KM / H)");
            double greitis2 = Convert.ToDouble(Console.ReadLine());

            double laikas = atstumas/(greitis1 + greitis2);

            double atstumas1 = greitis1 * laikas;
            Console.WriteLine("ATSTUMAS NUO A IKI VIETOS KURIOJE TRASPORTO PRIEMONĖS SUTITIKS {0, 0:0.00} km arba {1, 0:0.00} m", atstumas1 , atstumas1 * 1000);
            Console.WriteLine("LAIKAS KADA TRASPORTO PRIEMONĖS SUSITIKS {0, 0:0.00} h arba {1, 0:0.00} SEKUNDĖS", laikas, laikas *60*60 );
            Console.WriteLine("1-a TRASPORTO PRIEMONE PASIEKS GALIUTINI TAŠKĄ PO {0, 0:0.00} h arba {1, 0:0.00} MINUČIŲ", atstumas / greitis1, (atstumas / greitis1) * 60 );
            Console.WriteLine("2-a TRASPORTO PRIEMONE PASIEKS GALIUTINI TAŠKĄ PO {0, 0:0.00} h arba {1, 0:0.00} MINUČIŲ", atstumas / greitis2, (atstumas / greitis2) * 60);
            Console.WriteLine("ABI TRASPORTO PIEMONĖS KARTU SUDĖJUS IŠSKYRĖ CO2 {0} gramų arba {1, 0:0.00} kg.", 2 * atstumas * 95, (2 * atstumas * 95) / 1000);



            Console.WriteLine();
            Console.WriteLine("ATSAKYMAS GRAFIŠKAI:");
            Console.WriteLine($" viso {atstumas} km");

            // Apskaičiuojame pradinius parametrus.
            double skalesKoeficientas = 1.4; //skales mastelio koeficientas
            int skalesIlgis = Convert.ToInt32(atstumas * skalesKoeficientas);
            int skalesZingsnis = Convert.ToInt32(skalesIlgis / 20);

            // Dėl apvalinimo problemų perskaičiuojame bendra skalės ilgį elementais, kad tiksliai atitikti skalės žingsnį.
            skalesIlgis = skalesZingsnis * 20;

            int skaleK0 = 0;
            int skaleK1 = Convert.ToInt32(atstumas / 20);
            int skaleK2 = Convert.ToInt32(atstumas / 20 * 2);
            int skaleK3 = Convert.ToInt32(atstumas / 20 * 3);
            int skaleK4 = Convert.ToInt32(atstumas / 20 * 4);
            int skaleK5 = Convert.ToInt32(atstumas / 20 * 5);
            int skaleK6 = Convert.ToInt32(atstumas / 20 * 6);
            int skaleK7 = Convert.ToInt32(atstumas / 20 * 7);
            int skaleK8 = Convert.ToInt32(atstumas / 20 * 8);
            int skaleK9 = Convert.ToInt32(atstumas / 20 * 9);
            int skaleK10 = Convert.ToInt32(atstumas / 20 * 10);
            int skaleK11 = Convert.ToInt32(atstumas / 20 * 11);
            int skaleK12 = Convert.ToInt32(atstumas / 20 * 12);
            int skaleK13 = Convert.ToInt32(atstumas / 20 * 13);
            int skaleK14 = Convert.ToInt32(atstumas / 20 * 14);
            int skaleK15 = Convert.ToInt32(atstumas / 20 * 15);
            int skaleK16 = Convert.ToInt32(atstumas / 20 * 16);
            int skaleK17 = Convert.ToInt32(atstumas / 20 * 17);
            int skaleK18 = Convert.ToInt32(atstumas / 20 * 18);
            int skaleK19 = Convert.ToInt32(atstumas / 20 * 19);
            int skaleK20 = Convert.ToInt32(atstumas / 20 * 20);


            //braižom pradžiai liniją 
            Console.WriteLine((" |").PadRight(skalesIlgis, '-') + "|");

            // išvedame skalės skaičius
            Console.WriteLine(
                " " +
                skaleK0 +
                skaleK1.ToString().PadLeft(skalesZingsnis - 1) +
                skaleK2.ToString().PadLeft(skalesZingsnis) +
                skaleK3.ToString().PadLeft(skalesZingsnis) +
                skaleK4.ToString().PadLeft(skalesZingsnis) +
                skaleK5.ToString().PadLeft(skalesZingsnis) +
                skaleK6.ToString().PadLeft(skalesZingsnis) +
                skaleK7.ToString().PadLeft(skalesZingsnis) +
                skaleK8.ToString().PadLeft(skalesZingsnis) +
                skaleK9.ToString().PadLeft(skalesZingsnis) +
                skaleK10.ToString().PadLeft(skalesZingsnis) +
                skaleK11.ToString().PadLeft(skalesZingsnis) +
                skaleK12.ToString().PadLeft(skalesZingsnis) +
                skaleK13.ToString().PadLeft(skalesZingsnis) +
                skaleK14.ToString().PadLeft(skalesZingsnis) +
                skaleK15.ToString().PadLeft(skalesZingsnis) +
                skaleK16.ToString().PadLeft(skalesZingsnis) +
                skaleK17.ToString().PadLeft(skalesZingsnis) +
                skaleK18.ToString().PadLeft(skalesZingsnis) +
                skaleK19.ToString().PadLeft(skalesZingsnis) +
                skaleK20.ToString().PadLeft(skalesZingsnis)
                );

            // braižom skalę
            Console.WriteLine((" |").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') +
                 ("|").PadRight(skalesZingsnis, ' ') 
                );


            // C) PARODYTI KURIAME SEGMENTE TRASPORTO PREMONĖS SUTIKS IR ATSTUMĄ IKI SUSITIKIMO(TAŠKAS V)
            // Suformuojama tusčia skale
            string tusciaSkale =
                ("_A").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("|").PadRight(skalesZingsnis, '_') +
                ("B_")
                ;

            // Apskaičiuojame susitikimo vietą skalėje
            int susitikimoVietaSkaleje = Convert.ToInt32((atstumas1 / atstumas) * skalesIlgis);

            // Skalėje pažymime su "V" susitikimo vietą
            string susitikimoTaskas = tusciaSkale.Substring(0, susitikimoVietaSkaleje ) + "V" + tusciaSkale.Substring(susitikimoVietaSkaleje + 1);
            
            // Parodome skalę su susitikimo vietą
            Console.WriteLine( susitikimoTaskas );


            //B) PARODYTI SEGMENTO ILGĮ KM
            Console.WriteLine($"{(" |").PadRight( susitikimoVietaSkaleje, '-')}|");

            //  Parodyti susitikimo atstumą ir laiką
            Console.WriteLine($" susitikimo vieta {atstumas1,0:0.0} km");
            Console.WriteLine($" susitikimo laikas po {laikas,0:0.00} val.");

            // PARODOME ABIEJŲ TRANSPORTO PRIEMONIŲ VAŽIAVIMO TRUKMĘ
            Console.WriteLine($"{(" | ").PadRight((skalesIlgis / 2) - 10, '>')}{(atstumas / greitis1) * 60,5:0}{(" min ").PadRight((skalesIlgis - ((skalesIlgis / 2) - 10) - 5), '>')}|");
            Console.WriteLine($"{(" |").PadRight((skalesIlgis - ((skalesIlgis / 2) - 10) - 5), '<')}{(atstumas / greitis2) * 60,5:0}{(" min ").PadRight((skalesIlgis / 2) - 11, '<')} |");
            
        }
    }
}