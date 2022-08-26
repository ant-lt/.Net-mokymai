using OOP_kompozicija_namų_darbas;
using OOPMetodai.Domain.Models;
using System.Text;

namespace OOP_Metodai2_NamuDarbas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            Console.WriteLine("Hello, Namų darbas!");

            Uzduotis2();
            Uzduotis3();
            Uzduotis4();
            Uzduotis5();


        }

        public static void Uzduotis2()
        {
            /*
            * 2.	Parasykite klase „Skaiciuoklis“, kuris turetu 1 private property pavadinimu Skaicius ir 3 metodus: 
            *       Didinti (Padidina Skaicius 1), Mazinti(Sumazina Skaicius 1), Atspausdinti():
                a.	Padarykite, kad Mazinti() metodas negaletu sumazinti <Skaicius> maziau 0
                b.	Sukurkite metoda Perkrauti() <Reset>, kuris turetu grazinti <Skaicius> i pradine busena (Perkrauti metodas turetu nepriimti jokiu parametru)
            * 
            */
            Console.WriteLine("2.Parasykite klase „Skaiciuoklis“");

           Console.WriteLine("a. Padarykite, kad Mazinti() metodas negaletu sumazinti < Skaicius > maziau 0)");
            var skaiciuoklis = new Skaiciuoklis(5);

            skaiciuoklis.Atspausdinti();
            skaiciuoklis.Mazinti();
            skaiciuoklis.Mazinti();
            skaiciuoklis.Atspausdinti();
            skaiciuoklis.Mazinti();
            skaiciuoklis.Mazinti();
            skaiciuoklis.Atspausdinti();
            skaiciuoklis.Mazinti();
            skaiciuoklis.Mazinti();
            skaiciuoklis.Atspausdinti();
            Console.WriteLine(" b.	Sukurkite metoda Perkrauti() <Reset>, kuris turetu grazinti <Skaicius> i pradine busena (Perkrauti metodas turetu nepriimti jokiu parametru)");
            skaiciuoklis.Reset();
            skaiciuoklis.Atspausdinti();

            Console.WriteLine();
        }

        public static void Uzduotis3()
        {
            /*
             * 3. Sukurkite „Produktas“ klase, kuri turetu 3 properties su pasleptais seteriais – Kaina, kiekis, pavadinimas. 
             * Sukurkite„Produktas“ metoda void SpausdintiProdukta(), kuris atspausdintu informacija apie produkta tokiu formatu „Kivis kaina 1,50$: 3 vnt“ 4. 
             */

            Console.WriteLine("3. Sukurkite „Produktas“ klase");
            var produktas = new Produktas(1.11d, 10, "Kivi");

            produktas.SpausdintiProdukta();
            Console.WriteLine();

        }

        public static void Uzduotis4()
        {
            /*
             * 4. Pasirašyti klasę <SkaiciuKrepselis>, kuris turėtų <private List<int>> skaiciu sarasa. Skaiciu sąrašui užpildyti sukurkite naują metodą <void PridėtiSkaiciu(int skaicius)>. 
            * Taip pat sukurkitenaują metodą <double ApskaiciuotiVidurki()>, kuris apskaiciuoja visu sarase esanciu skaiciu vidurki. 
            *
            */

            Console.WriteLine("4. Pasirašyti klasę <SkaiciuKrepselis>");

            var vidurkiai = new SkaiciuKrepselis();

            vidurkiai.PridėtiSkaiciu(2);
            vidurkiai.PridėtiSkaiciu(3);
            vidurkiai.PridėtiSkaiciu(5);

            Console.WriteLine($"Vidurkis = {vidurkiai.ApskaiciuotiVidurki():F}");
            Console.WriteLine();

        }

        public static void Uzduotis5()
        {
            /*
             * 5. Parašyti po 1 metoda kiekvienai iš jūsų <Kambarys> namų darbo klasei (~12 klasių). Stenkitės pasipraktuokuoti skirtingus gražinimo duomenų tipus ir gal net vienam ar kitam metodui pridėkite po kokį nors parametrą. 
             * Papildomai galite ~6 klasėms sukurti po konstruktorių, kuris kelis jūsų pasirinktus <private set> properties(Siuo metu visi yra public) inicijuotų per kontruktoriu paduotas reiksmes.
             */
            Console.WriteLine("Uzduotis 5");

            Kambarys manoKambarys = new Kambarys("Didelis kamabaris Nr. 1", 5d, 6d);

            Console.WriteLine($"Kambario plotas {manoKambarys.Plotas()}" );
            manoKambarys.Grindis.Medziaga = "Medis";
            manoKambarys.Grindis.Dizainas = "Klasikinis";
            manoKambarys.Grindis.Ilgis = 2.0d;
            manoKambarys.Grindis.Plotis = 8.0d;
            manoKambarys.Grindis.Storis = 0.02d;

            //---------------------------------
            Duris PagrindinesDurys = new Duris();
            PagrindinesDurys.Pavadinimas = "Įėjimo durys";
            PagrindinesDurys.Medziaga = "Medis";
            PagrindinesDurys.Aukstis = 1.90d;
            PagrindinesDurys.Plotis = 8.0d;
            PagrindinesDurys.Storis = 0.03d;

            PagrindinesDurys.Rankena.Modelis = "EKO 001";
            PagrindinesDurys.Rankena.Medziaga = "Metalas";
            PagrindinesDurys.Rankena.Gamintojas = "Sunlex";
            PagrindinesDurys.Rankena.Spalva = "Juoda";
            PagrindinesDurys.Rankena.Standartas = "ISO 1254";

            //---------------------------------
            Duris BalkonoDurys = new Duris();
            BalkonoDurys.Pavadinimas = "Balkono durys";
            BalkonoDurys.Medziaga = "Plastikas";
            BalkonoDurys.Aukstis = 1.90d;
            BalkonoDurys.Plotis = 8.0d;
            BalkonoDurys.Storis = 0.02d;

            BalkonoDurys.Rankena.Modelis = "BAL 002";
            BalkonoDurys.Rankena.Medziaga = "Plastikas";
            BalkonoDurys.Rankena.Gamintojas = "Sigma";
            BalkonoDurys.Rankena.Spalva = "Balta";
            BalkonoDurys.Rankena.Standartas = "ISO 1255";



            manoKambarys.Durys.Add(PagrindinesDurys);
            manoKambarys.Durys.Add(BalkonoDurys);

            //-------------------------------------------------------------------

            Langas balkonoLangas = new Langas();


            //-------------------------------------------------------------------
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Kambario pavadinimas:{manoKambarys.Pavadinimas}");
            Console.WriteLine($"Kambario plotas:{manoKambarys.Plotas}");
            Console.WriteLine($"Kambario grindų medžiaga:{manoKambarys.Grindis.Medziaga}");
            Console.WriteLine($"Kambario grindų dizainas:{manoKambarys.Grindis.Dizainas}");
            Console.WriteLine($"Kambario grindų ilgis:{manoKambarys.Grindis.Ilgis} m");
            Console.WriteLine($"Kambario grindų plotis:{manoKambarys.Grindis.Plotis} m");
            Console.WriteLine($"Kambario grindų storis:{manoKambarys.Grindis.Storis} m");
            Console.WriteLine("------------------------------------------");
            foreach (var duris in manoKambarys.Durys)
            {
                Console.WriteLine($"Kambario duru pavadinimas:{duris.Pavadinimas} ");
                Console.WriteLine($"Kambario duru medžiaga:{duris.Medziaga} ");
                Console.WriteLine($"Kambario duru auštis:{duris.Aukstis} m");
                Console.WriteLine($"Kambario duru plotis:{duris.Plotis} m");
                Console.WriteLine($"Kambario duru storis:{duris.Storis} m");
                Console.WriteLine();
                Console.WriteLine($"Kambario duru rankenos modelis:{duris.Rankena.Modelis}");
                Console.WriteLine($"Kambario duru rankenos medžiaga:{duris.Rankena.Medziaga}");
                Console.WriteLine($"Kambario duru rankenos gamintojas:{duris.Rankena.Gamintojas}");
                Console.WriteLine($"Kambario duru rankenos spalva:{duris.Rankena.Spalva}");
                Console.WriteLine($"Kambario duru rankenos spalva:{duris.Rankena.Standartas}");
                Console.WriteLine("------------------------------------------");
            }


        }

    }
}