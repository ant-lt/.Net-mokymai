namespace Praktika_Metodai
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
               Parašykite programą kurioje yra vienas metodas priimantis vieną argumentą.
      - Main metode naudotojo paprašome įvesti betkokį tekstą su tarpais
      -Įvestas tekstas metodui perduodamas per parametrus ir grąžina žodžių kiekį
      - Main metode į ekraną išveskite žodžių kiekį
      Pvz:
      > Iveskite teksta:
               _ as mokausi programuoti
               > Zodziu kiekis yra: 3
            */

            Console.WriteLine("Įvestas tekstas");
            string tekstas = Console.ReadLine();

            // 6  užduotis
            // Console.WriteLine($"Zodziu kiekis= {ZodziuKiekis(tekstas)}") ;

            // 7  užduotis
            // Console.WriteLine($"Tarpu kiekis gale = { kiekTarpuGale(tekstas)}");

            // 8  užduotis
            //  Console.WriteLine($"Tarpu kiekis pradzioje = {kiekTarpuPradzioje(tekstas)}");

            // 9 užduotis
            /*
            int pradzioje;
            int pabaigoje;
            Tarpai(tekstas, out pradzioje, out pabaigoje);

            Console.WriteLine($"Pradžioje yra tarpų = {pradzioje} , Gale yra tarpų = {pabaigoje}");
            */
            Console.WriteLine($"a raidziu kiekis = {Araides(tekstas)}");
        }

        public static int kiekTarpuGale(string tekstas)
        {
            //  - Metodas grąžina tarpų kiekį teksto gale
            int pradinisIlgis = tekstas.Length;
            tekstas = tekstas.TrimEnd();

            return pradinisIlgis - tekstas.Length;
        }

        public static int kiekTarpuPradzioje(string tekstas)
        {
            //  - Metodas grąžina tarpų kiekį teksto gale
            int pradinisIlgis = tekstas.Length;
            tekstas = tekstas.TrimStart();

            return pradinisIlgis - tekstas.Length;
        }


        public static int ZodziuKiekis(string tekstas)
        { // 6  užduotis
            int zodziai = 0;
            tekstas = tekstas.Trim();
            string[] split = tekstas.Split(' ');

            zodziai = split.Length;

            return zodziai;
        }

        public static void Tarpai (string tekstas, out int kiekisPradzioje, out int kiekisPabaigoje)
        {
            //Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
            int pradinisIlgis = tekstas.Length;
            kiekisPradzioje = pradinisIlgis - tekstas.TrimStart().Length;
            kiekisPabaigoje = pradinisIlgis - tekstas.TrimEnd().Length;
        }

        public static int Araides(string tekstas)
        {
            //10 užduotis
            // Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina 'a' raidžių kiekį tekste.
            int pradinisIlgis = tekstas.Length;

            tekstas = tekstas.Replace("a", "");
            return pradinisIlgis - tekstas.TrimStart().Length;


        }
    }
}