namespace Uzduotis_DNR
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tarkime turime DNR grandinę užkoduotą tekstu var txt =" T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
       Galimos bazės: Adenine, Thymine, Cytosine, Guanine
         Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
         1. Atlikti DNR grandinės normalizavimo veiksmus:
            - pašalina tarpus.
            - visas raides keičia didžiosiomis.
         2. Atlikti grandinės validaciją
            - patikrina ar nėra kitų nei ATCG raidžių
         3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). Nuspaudus 3 įeinama į sub-meniu
             - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui
             1) normalizuoti grandinę
             2) išeiti iš programos
             - jei grandinė normalizuota arba kai buvo atlikta normalizacija
             1) GCT pakeis į AGG
             2) Išvesti ar yra tekste CAT
             3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
             4) Išvesti raidžių kiekį tekste (naudoti string composition)
             5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas
             6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą
                 (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
             7) Iš grandinės pašalinti pasirinką elementą
             8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros
                 (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
             9) Gryžti į ankstesnį meniu
       Visoms operacijoms reikalingi testai.
             * 
             * 
             */

            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";


            Console.WriteLine($"MENIU:\n" +
                "1. Atlikti DNR grandinės normalizavimo veiksmus.\n" +
                "2. Atlikti grandinės validaciją\n" +
                "3. Atlieka veiksmus su DNR grandine(tik tuo atveju jei grandinė yra normalizuota ir validi).");

            string veiksmas = Console.ReadLine();

            veiksmas switch
            {
                1 => Normalizavimas(txt),
                2 => Validacija(txt),
                _ => Daugiakampio_plotas(n, b)
            };
            

        }
        public static void Normalizavimas(string dnr_grandine)
            {
            Console.WriteLine(dnr_grandine);
            }

        public static void Validacija(string dnr_grandine)
        {
            Console.WriteLine(dnr_grandine);
        }
    }
}