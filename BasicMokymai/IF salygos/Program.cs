namespace IF_salygos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, If");
            int nelyginisSkaicius = 5;
            int lyginis = 2;
            bool tiesa = true;

            if(nelyginisSkaicius > lyginis)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginis} ");
            }

            if (nelyginisSkaicius < lyginis)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginis} ");
            }

            Console.WriteLine("if - else");

            if (nelyginisSkaicius <= lyginis)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginis} ");
            }
            else
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginis} ");
            }

            Console.WriteLine("if - else if - else");
            if(nelyginisSkaicius < lyginis && tiesa)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginis} ir tiesa yra true");
            }
            else if (nelyginisSkaicius < lyginis && !tiesa)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra mazesnis uz {lyginis} ir tiesa yra false");
            }
            else if (nelyginisSkaicius > lyginis && tiesa)
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginis} ir tiesa yra true");
            }
            else
            {
                Console.WriteLine($"{nelyginisSkaicius} yra didesnis uz {lyginis} ir tiesa yra false");
            }

            Console.WriteLine("---------------------");
            var score = 45;
            int pointNeedToPass = 100;

            bool levelComplete = false;

            if (score >= pointNeedToPass)
            {
                levelComplete = true;

            }
           // else
           // {
            //    levelComplete = true;
           // }

            if (levelComplete)
            {
                Console.WriteLine("Valio, baigete lygi");
            }

            Console.WriteLine(score >= pointNeedToPass ? "Valio, baigete lygi" : "nevalio, turite dar kart");

            Console.WriteLine("---------------");

            Console.WriteLine("if kompozicija, nesting");
            int shield = 1, armor = 2;
            if (shield <= 0 && armor <=0 )
            {
                    Console.WriteLine("Jus mires");
            }
            else if(shield <= 0 && armor > 0)
            {
                Console.WriteLine("Jus dar turite armor");
            }
            else
            {
                Console.WriteLine("Jus dar turite galimybiu");
            }

            Console.WriteLine("-------------");
            Console.WriteLine("null coalecing operator (??)");

            bool? nullableBool = true;
            bool normalBool;

            // normalBool = normalBool; //taip negalima

            normalBool = nullableBool ?? false;
            // --------------------
            nullableBool ??= false;

            Console.WriteLine("--Press any key to continue --");


            //Uzduotis 1
            /*
             * ARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI SKAIČIŲ.
            - JEIGU SKAIČIUS YRA LYGINIS IŠVESTI Į EKRANĄ "SKAIČIUS YRA LYGINIS"
            - JEIGU SKAIČIUS YRA NEIGIAMAS "SKAIČIUS YRA NEIGIAMAS"
            - KITU ATVEJU IŠVESTI PATĮ SKAIČIŲ

                        */

            int skaicius = Convert.ToInt32( Console.ReadLine());

            if ( (skaicius % 2) == 0)
            {
                Console.WriteLine("SKAIČIUS YRA LYGINIS");
            }


            if ( skaicius < 0 )
            {
                Console.WriteLine("SKAIČIUS YRA NEIGIAMAS");
            }

            if ((skaicius % 2) != 0 && skaicius >0 )
            {
                Console.WriteLine("skaicius " + skaicius);
            }


            /*
             * 
             *PARAŠYTI PROGRAMĄ, KURI PAPRAŠO
             *VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
             *JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA „TAI SOLO ATLIKĖJAS“, 
             *JEI NARIŲ KIEKIS 2 --„TAI DUETAS“, 
             *JEI NARIŲ KIEKIS DAUGIAU NEI 2 BET MAŽIAU NEI 10 ––„TAI ANSAMBLIS“, 
             *JEI DAUGIAU NEI 10 ––„TAI KAMERINIS ANSAMBLIS“.
            */

            Console.WriteLine("ĮVESTI GRUPĖS NARIŲ KIEKĮ");
            int nariuSkaicius = Convert.ToInt32(Console.ReadLine());

            if (nariuSkaicius == 1)
                Console.WriteLine("TAI SOLO ATLIKĖJAS");
            else if (nariuSkaicius == 2)
                Console.WriteLine("TAI DUETAS");
            else if (nariuSkaicius > 2 && nariuSkaicius < 10)
                Console.WriteLine("TAI ANSAMBLIS");
            else if (nariuSkaicius > 10)
                Console.WriteLine("TAI KAMERINIS ANSAMBLIS");
            else
            {
                Console.WriteLine("Klaida");
            }

            /*
             * 
             * PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI IŠDIRBTAS VALANDAS.
            JEI VALANDŲ YRA MAŽIAU NEI 160,PROGRAMA TURI PARODYTI, KIEK DAR REIKIA IŠDIRBTI, 
            JEI LYGIAI 160, PARODO, KAD IŠDIRBTAS PILNASETATAS, 
            JEI DAUGIAU PARODO KIEK YRA VIRŠVALANDŽIŲ.
            JEI VARTOTOJAS PADARO ĮVEDIMO KLAIDĄ PRANEŠTI IR UŽBAIGTI DARBĄ
             * 
             */

            Console.WriteLine("ĮVESTI Isdirbtas valandas");
            
            bool arGerasSkaicius = int.TryParse(Console.ReadLine(), out int isdirbtasValandas );

            if (arGerasSkaicius)
            {
                if (isdirbtasValandas < 160)
                    Console.WriteLine("Liko dirbti " + (isdirbtasValandas - 160) + " val.");

                else if (isdirbtasValandas == 160)
                    Console.WriteLine(" IŠDIRBTAS PILNASETATAS");
                else 
                    Console.WriteLine("Virsvalandziai " + (160 - isdirbtasValandas) + " val.");
            }
            else
                Console.WriteLine("Klaida");

        }
    }
}