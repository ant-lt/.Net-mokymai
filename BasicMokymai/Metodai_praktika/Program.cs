namespace Metodai_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Parašykite programą kurioje yra 2 metodai.
- Pirmas metodas į konsolę išveda "Sveiki visi"
- Antrtas metodas į konsolę išveda "Linkiu jums geros dienos"
            */

            SveikiaVisi();
            GerosDienos();

            /*
             * Parašykite programą kurioje yra 2 metodai.
-
- Pirmas metodas naudotojo paprašo įvesti savo vardą konsolę išveda "Labas tai_kas_ivesta" ir grąžina tai kas ivesta.
- Antras metodas į konsolę išveda "Linkiu jums tai_kas_ivesta geros dienos"
Pvz:
> Iveskite savo Varda:
_ Petras
> Labas Petras
> Linkiu jums Petras geros dienos
            */


            // string tekstas = Labas(Console.ReadLine());


            //  Linkiu();



            /*
             * Parašykite programą kurioje yra vienas metodas priimantis du skaitmeninio tipo argumentus.
            - Main metode naudotojo paprašome įvesti 2 skaičius ir perduokite juos metodui.
            N.B. būtina validacija
            - Į ekraną išveskite argumentų matematinę sumą.
            Pvz:
            > Iveskite pirmą skaičių:
            _ 15
            > Iveskite antrą skaičių:
            _ 16
            > Rezultatas: 31
             * 
             * 
             */

            //int skaicius






            /*
             * Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
            - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
            - Įvestas tekstas metodui perduodamas per parametrus ir grąžina tarpų kiekį
            - Main metode į ekraną išveskite tarpų kiekį
            Pvz:
            > Iveskite teksta:
            _ as mokausi programuoti
            > Tarpu kiekis yra: 2
            */


            Tarpai();



            /*
             * Parašykite programą kurioje vienas metodas.
- Naudotojo paprašome įvesti betkokį tekstą Main metode.
- Metodas į ekraną išveda teksto ilgį be tarpų įvesto teksto pradžioje ir gale
Pvz:
> Iveskite teksta:
_ ' as mokausi '
> Teksto ilgis yra: 10
             * 
             */
            //    TarpuIlgis();

        }
        public static void SveikiaVisi()
        {
            Console.WriteLine("Sveiki visi");
        }

        public static void GerosDienos()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }

        public static string Labas()
        {
            Console.WriteLine("Iveskite savo Varda:");
            var vardas = Console.ReadLine();
            Console.WriteLine($"Labas {vardas}");
            return vardas;
        }
        public static void Linkiu()
        {
            Console.WriteLine($"Linkiu jums {Labas()} geros dienos");

        }

        public static int TarpuKiekis(string tekstas)
        {
            int pradinisIlgis = tekstas.Length;

            tekstas = tekstas.Replace(" ", "");

            return pradinisIlgis - tekstas.Length;
        }

        public static void Tarpai()
        {
            Console.WriteLine(" įvesti betkokį tekstą su tarpais");
            var tekstas = Console.ReadLine();


            Console.WriteLine($"Tarpu kiekis yra:{TarpuKiekis(tekstas)}");


        }




        /*
        public static void TarpuIlgis()
        {
            Console.WriteLine("Iveskite teksta");
            var tekstas = Console.ReadLine();


            Console.WriteLine($"Teksto ilgis yra:{TekstoIlgisBeTarpu(tekstas)}");
        }
        */
        /*
        public static int TekstoIlgisBeTarpu(string tekstas)
        {

            tekstas = tekstas.Replace(" ", "");

            return tekstas.Length;
        }
        */
    }
    }