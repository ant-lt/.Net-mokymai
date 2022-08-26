using System.Text;

namespace OOP_kompozicija_namų_darbas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            Console.WriteLine("Hello, OOP kompozicija namų darbas!");
            DarbasSuUzduotimi();
        }
        public static void DarbasSuUzduotimi()
        {
            Kambarys manoKambarys = new Kambarys("Didelis kamabaris Nr. 1", 10d, 9d);

           
            //manoKambarys.Plotas = 15.5;
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
            PagrindinesDurys.Rankena.Spalva= "Juoda";
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