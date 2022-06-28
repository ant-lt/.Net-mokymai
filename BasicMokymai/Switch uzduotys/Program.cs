namespace Switch_uzduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * PAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI
      EGZAMINO PAŽYMĮ. IŠVESTI:
      0 - 4: NEPATEKINAMAI
      5: SILPNAI
      6: PATENKINAMAI
      7: VIDUTINIŠKAI
      8: GERAI
      9: LABAI GERAI
      10: PUIKIAI
              * 
              * */


            /*
            Console.WriteLine("Iveskite egzamino pazymi: ");
            int pazymis = Convert.ToInt32(Console.ReadLine());

            if (pazymis >= 0 && pazymis <= 4)
                Console.WriteLine("NEPATEKINAMAI");
            else if (pazymis == 5)
                Console.WriteLine("SILPNAI");
            else if (pazymis == 6)
                Console.WriteLine("PATENKINAMAI");
            else if (pazymis == 7)
                Console.WriteLine("VIDUTINIŠKAI");
            else if (pazymis == 8)
                Console.WriteLine("GERAI");
            else if (pazymis == 9)
                Console.WriteLine("LABAI GERAI");
            else if (pazymis == 10)
                Console.WriteLine("PUIKIAI");

            switch (pazymis)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("NEPATEKINAMAI");
                    break;
                case 5:
                    Console.WriteLine("SILPNAI");
                    break;
                case 6:
                    Console.WriteLine("PATENKINAMAI");
                    break;
                case 7:
                    Console.WriteLine("VIDUTINIŠKAI");
                    break;
                case 8:
                    Console.WriteLine("GERAI");
                    break;
                case 9:
                    Console.WriteLine("LABAI GERAI");
                    break;
                case 10:
                    Console.WriteLine("PUIKIAI");
                    break;
            }

            var isvedamasRezultatas = pazymis switch
            {
                0 or 1 or 2 or 3 or 4 => "NEPATEKINAMAI",
                5 => "SILPNAI",
                6 => "PATENKINAMAI",
                7 => "VIDUTINIŠKAI",
                8 => "GERAI",
                9 => "LABAI GERAI",
                10 => "PUIKIAI",
                _ => null

            };


            Console.WriteLine(isvedamasRezultatas);
            // -----------------
            Console.WriteLine(pazymis switch
            {
                0 or 1 or 2 or 3 or 4 => "NEPATEKINAMAI",
                5 => "SILPNAI",
                6 => "PATENKINAMAI",
                7 => "VIDUTINIŠKAI",
                8 => "GERAI",
                9 => "LABAI GERAI",
                10 => "PUIKIAI",
                _ => null

            });

            */
            /*
             * ** Nemokama kava **
Aprašykite int kintamajį kuriame nurodysite kiek puodelių kavos perkama. (tarkim 7)
Kas 3 puodelis nemokamas. Paskaičiuokite ir išveskite į ekraną ar pirkėjui priklauso nemokama kava
- Pavyzdžio atsakymas: "pirkėjui priklauso 2 nemokami puodeliai"
- Alternatyvus atsakymas: "Pirkėjui nepriklauso nemokama kava"
             * 
             */


            /*
            Console.WriteLine("Iveskite perkamos kavos podeliu kieki: ");
            int podeliu = Convert.ToInt32(Console.ReadLine());

            // ------------------------
            Console.WriteLine("Kavos podeliu " + podeliu);

            if ( (podeliu / 3) > 0)
                Console.WriteLine("Priklauso "+ (podeliu / 3) + " nemokami puodeliai");
            else if (podeliu <3)
                Console.WriteLine("Pirkėjui nepriklauso nemokama kava");


            // -----------------
            var kava = podeliu / 3;
            Console.WriteLine( kava == 0 ?
                "Pirkėjui nepriklauso nemokama kava" :
                $"pirkėjui priklauso {kava} nemokami puodeliai");

            */

            /*
             * ** Piešingi skaičiai **
Naudotojas įveda betkokius 4 sveikus skaicius (tarkim 5; 15; -25; 0;)
- Parašykite programą kuri į ekraną išves neigiamą/teigiamą skaičiaus reikšmę
- Pavyzdžio atsakymas 5 -> -5; 15 -> -15; -25 -> 25; 0 -> N/A;
             * 
             * 
             */

            /*
            Console.WriteLine("Iveskite 1 skaiciu: ");
            int skaicius1 =  Convert.ToInt32(Console.ReadLine()) ;

     
            
            Console.WriteLine("Iveskite 2 skaiciu: ");
            int skaicius2 =  Convert.ToInt32(Console.ReadLine() );
            Console.WriteLine("Iveskite 3 skaiciu: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite 4 skaiciu: ");
            int skaicius4 =  Convert.ToInt32(Console.ReadLine());


            Console.WriteLine( skaicius1 != 0 ?  $"{skaicius1} -> {skaicius1*-1}" : $"0 = > N/A" );
            Console.WriteLine(skaicius1 != 0 ? $"{skaicius2} -> {skaicius2 * -1}" : $"0 = > N/A");
            Console.WriteLine(skaicius1 != 0 ? $"{skaicius3} -> {skaicius3 * -1}" : $"0 = > N/A");
            Console.WriteLine(skaicius1 != 0 ? $"{skaicius4} -> {skaicius4 * -1}" : $"0 = > N/A");
            
            */

            /*
             * ŽAIDIMAS ATSPĖK SKAIČIŲ
- ĮHARDKODINAMAS BETKOKS SKAIČIUS NUO 1 IKI 20
- NAUDOTOJAS 6 KARTUS PRAŠOMAS ĮVESTI SKAIČIŲ NUO 1 IKI 20
- JEI NAUDOTOJAS ĮVEDĖ TEISINGAI - IŠVEDAMAS SVEIKINIMAS "TEISINGAI" IR PROGRAMA STABDOMA
- JEI NAUDOTOJAS ĮVEDĖ PER MAŽĄ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA DIDESNIS"
- JEI NAUDOTOJAS ĮVEDĖ PER DIDELĮ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA MAŽESNIS"
nutraukiant programos vykdymą Environment.Exit(0) ar pan. naudoti negalima. Naudoti if.
             * 
             */

            /*
            int atspeti = 10;
            bool atspeta = false;


            Console.WriteLine("Iveskite skaiciu 1 karta: ");
            int skaicius1z = Convert.ToInt32(Console.ReadLine());

            if (skaicius1z == atspeti)
            {
                Console.WriteLine("TEISINGAI");
                atspeta = true;
            }
            else if (skaicius1z > atspeti)
            {
                Console.WriteLine("SKAIČIUS YRA DIDESNIS");
            }
            else
            {
                Console.WriteLine("SKAIČIUS YRA MAŽESNIS");
            }

            if (!atspeta)
            {
                Console.WriteLine("Iveskite skaiciu 2 karta: ");
                int skaicius2z = Convert.ToInt32(Console.ReadLine());

                if (skaicius2z == atspeti)
                {
                    Console.WriteLine("TEISINGAI");
                    atspeta = true;
                }
                else if (skaicius2z > atspeti )
                {
                    Console.WriteLine("SKAIČIUS YRA DIDESNIS");
                }
                else
                {
                    Console.WriteLine("SKAIČIUS YRA MAŽESNIS");
                }

            }

            if (!atspeta)
            {
                Console.WriteLine("Iveskite skaiciu 3 karta: ");
                int skaicius3z = Convert.ToInt32(Console.ReadLine());

                if (skaicius3z == atspeti)
                {
                    Console.WriteLine("TEISINGAI");
                    atspeta = true;
                }
                else if (skaicius3z > atspeti)
                {
                    Console.WriteLine("SKAIČIUS YRA DIDESNIS");
                }
                else
                {
                    Console.WriteLine("SKAIČIUS YRA MAŽESNIS");
                }

            }

            if (!atspeta)
            {
                Console.WriteLine("Iveskite skaiciu 4 karta: ");
                int skaicius4z = Convert.ToInt32(Console.ReadLine());

                if (skaicius4z == atspeti)
                {
                    Console.WriteLine("TEISINGAI");
                    atspeta = true;
                }
                else if (skaicius4z > atspeti)
                {
                    Console.WriteLine("SKAIČIUS YRA DIDESNIS");
                }
                else
                {
                    Console.WriteLine("SKAIČIUS YRA MAŽESNIS");
                }

            }

            if (!atspeta)
            {
                Console.WriteLine("Iveskite skaiciu 5 karta: ");
                int skaicius5z = Convert.ToInt32(Console.ReadLine());

                if (skaicius5z == atspeti)
                {
                    Console.WriteLine("TEISINGAI");
                    atspeta = true;
                }
                else if (skaicius5z > atspeti)
                {
                    Console.WriteLine("SKAIČIUS YRA DIDESNIS");
                }
                else
                {
                    Console.WriteLine("SKAIČIUS YRA MAŽESNIS");
                }

            }

            if (!atspeta)
            {
                Console.WriteLine("Iveskite skaiciu 6 karta: ");
                int skaicius6z = Convert.ToInt32(Console.ReadLine());

                if (skaicius6z == atspeti)
                {
                    Console.WriteLine("TEISINGAI");
                    atspeta = true;
                }
                else if (skaicius6z > atspeti)
                {
                    Console.WriteLine("SKAIČIUS YRA DIDESNIS");
                }
                else
                {
                    Console.WriteLine("SKAIČIUS YRA MAŽESNIS");
                }
                */

            /*
            *SKAIČIUOTUVAS *
Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją(+, -, *arba / )
- Parašykite programą kuri į ekraną išves skaičių rezultatą
- naudokite if
-naudokite switch
            */

            /*
            Console.WriteLine("Iveskite 1 skaiciu: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite 2 skaiciu: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite  matematinę operaciją(+, -, * arba / )" );
            var operacija = Console.ReadLine();

            Console.WriteLine();

            if (operacija == '+')
                Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1+skaicius2}");

            */


            /*
             * 
             * * Trys draugai *
- Sukurti metodą, kuris paprašytų vartotojo įvesti tris jo draugų vardus bei kiekvieno amžių.
- Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.
- Atspausdinti draugų amžiaus vidurkį
- Surasti ir atspausdinti jauniausią draugą (vardą ir amžių).
- Surasti ir atspausdinti vyriausią draugą (vardą ir amžių).
<Hint> ieškant jauniausio, seniausio naudoti if sąlygos sakinius ir naudoti tik elementus ir
konstrukcijas kurias iki šiol išėjome.
             * 
             */

            /*
            int jauniausiasAmzius;
            int vyriausiasAmzius;

            string jauniausiasVardas;
            string vyriausiasVardas;

            Console.WriteLine("Iveskite 1 draugo varda: ");
            var vardas1 = Console.ReadLine();

            Console.WriteLine("Iveskite 1 draugo amziu ");
            int amzius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite 2 draugo varda: ");
            var vardas2 = Console.ReadLine();

            Console.WriteLine("Iveskite 2 draugo amziu ");
            int amzius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite 3 draugo varda: ");
            var vardas3 = Console.ReadLine();

            Console.WriteLine("Iveskite 3 draugo amziu ");
            int amzius3 = Convert.ToInt32(Console.ReadLine());


            // Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.

            Console.WriteLine($"1 draugo vardas-> {vardas1} ; Amzius -> {amzius1}");
            Console.WriteLine($"2 draugo vardas-> {vardas2} ; Amzius -> {amzius2}");
            Console.WriteLine($"3 draugo vardas-> {vardas3} ; Amzius -> {amzius3}");

            // -Atspausdinti draugų amžiaus vidurkį

            Console.WriteLine($" draugų amžiaus vidurkis -> {(double)(amzius1 + amzius2 + amzius3)/3}");

            // -Surasti ir atspausdinti jauniausią draugą(vardą ir amžių).

            if (amzius1 < amzius2 && amzius1 < amzius3)
            {
                Console.WriteLine($"Draugas {vardas1} jauniusias jam {amzius1} m");

            }
            else if (amzius2 < amzius1 && amzius2 < amzius3 )
                Console.WriteLine($"Draugas {vardas2} jauniusias jam {amzius2} m");

            else if (amzius3 < amzius1 && amzius3 < amzius2)
            {
                Console.WriteLine($"Draugas {vardas3} jauniusias jam {amzius3} m");
            }

            if (amzius1 > amzius2 && amzius1 > amzius3)
            {
                Console.WriteLine($"Draugas {vardas1} vyriausias jam {amzius1} m");

            }
            else if (amzius2 > amzius1 && amzius2 > amzius3)
                Console.WriteLine($"Draugas {vardas2} vyriausias jam {amzius2} m");

            else if (amzius3 > amzius1 && amzius3 > amzius2)
            {
                Console.WriteLine($"Draugas {vardas3} vyriausias jam {amzius3} m");
            }

            */
            /*
             * 
             * ** Kalėdų sausainiai **
- Paprašykite vartotojo įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)
- Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos (gruodžio 24).
- Ir jei yra kalėdų data, išveda - "Jums priklauso nemokami kalėdiniai sausainiai"
- Jei nėra išveda - "Palaukite kalėdų"
Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
<Hint> metodai data.Month ir data.Day
             * 
             */

           // Console.WriteLine("Iveskite 1 data ");
           // var data1 = Convert.ToDateTime( Console.ReadLine());

            Console.WriteLine("Iveskite 4 metus atskirdams enter (formatas yyyy-mm ) ");
            var data1 = DateTime.Parse(Console.ReadLine());
            var data2 = DateTime.Parse(Console.ReadLine());
           var data3 = DateTime.Parse(Console.ReadLine());
            var data4 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Ivesta {data1.ToShortDateString()}, {data2.ToString("yyyy-MM-dd")}");

            if (data1.Month == 12 && data1.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalėdiniai sausainiai");
            else if (data2.Month == 12 && data2.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalėdiniai sausainiai");
            if (data3.Month == 12 && data3.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalėdiniai sausainiai");
            else if (data4.Month == 12 && data4.Day == 24)
                Console.WriteLine("Jums priklauso nemokami kalėdiniai sausainiai");
            else 
                Console.WriteLine("Palaukite kalėdų");


        }
    }
}