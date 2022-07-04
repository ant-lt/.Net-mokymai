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
            // Console.WriteLine($"a raidziu kiekis = {Araides(tekstas)}");
            Console.WriteLine($"ar mokausi = {ArMokausi(tekstas)}");

            Console.WriteLine($"pirmos a vieta = {PirmosAvieta(tekstas)}");

        }


        public static int TekstoIlgisBeTarpu(string tekstas)
        {
            // 5 uzduotis
            //  - Metodas grąžina tarpų kiekį teksto gale
            int pradinisIlgis = tekstas.Length;
            tekstas = tekstas.TrimEnd();

            return tekstas.Trim().Length;
        }

        public static int kiekTarpuGale(string tekstas)
        {
            // 6 uzduotis
            //  - Metodas grąžina tarpų kiekį teksto gale
            int pradinisIlgis = tekstas.Length;
            tekstas = tekstas.TrimEnd();

            return pradinisIlgis - tekstas.Length;
        }

        public static int kiekTarpuPradzioje(string tekstas)
        {
            // 8 uzduotis
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
            // 9 uzduotis
            //Metodas grąžina dvi reikšmes pirmoji - tarpų kiekį teksto pradžioje, antroji - tarpų kiekį teksto gale
            int pradinisIlgis = tekstas.Length;
            kiekisPradzioje = pradinisIlgis - tekstas.TrimStart().Length;
            kiekisPabaigoje = pradinisIlgis - tekstas.TrimEnd().Length;
        }

        public static int Araides(string tekstas)
        {
            //10 užduotis
            // Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina 'a' raidžių kiekį tekste.
            
            return tekstas.Length - tekstas.Replace("a", "").Length;
        }

        public static string ArMokausi(string tekstas)
        {
            //- Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. N.B.grąžinama string, o ne bool.
            //-  Išvesti rezultatą Main metode.
            return  tekstas.Contains("mokausi")? "Taip" : "Ne";
        }

        public static int PirmosAvieta(string tekstas)
        {
            //- Įvestas teikstas kaip argumentas perduodamas metodui. Metodas grąžina pirmos 'a' raidės vietą tekste.
            //-  Išvesti rezultatą Main metode.
            return tekstas.IndexOf('a');
        }

        public static string ArMokausi2(string tekstas)
        {
            // 11 uzduotis
            //- Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. N.B.grąžinama string, o ne bool.
            //-  Išvesti rezultatą Main metode.
/*    - Metodas grąžina žodžius Taip arba Ne ar tekste rado žodį 'mokausi'. 
Bet tik tuo atveju jei žodis 'mokausi' nesulipęs su kitu žodžiu.
N.B. grąžinama string, o ne bool.
-  Išvesti rezultatą Main metode.
Pvz: 
> Iveskite teksta:
_ ' as labai mokausi programuoti     '
> Ar yra mokausi: Taip

Pvz: 
> Iveskite teksta:
_ ' as_labai_mokausi_programuoti     '
> Ar yra mokausi: Ne
            */
//return tekstas.ToLower.Contains("mokausi") ? "Taip" : "Ne";

return tekstas.Contains("mokausi", StringComparison.OrdinalIgnoreCase) ? "Taip" : "Ne";
}




}
}