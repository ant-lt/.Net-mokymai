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

namespace Uzduotis_DNR
{
    public class Program
    {
        //padarom globalus kintamuosios, kad žinoti ar atlikta normalizacija ir/arba validacija
        static bool arGrandineNormalizuota = false;
        static bool arGrandineValidi = false;
        
        static void Main(string[] args)
        {
            
            var txt = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";

            // txt = IvedimasIsKlaviaturos("Įveskite DNR grandinę:");
            pagrindinisMeniu(txt);

        }


        public static void grandinesBusena(string dnr_grandine, bool normalizuota, bool validi)
        // išveda į ekraną dabartine DNR grandinę, normalizacijos ir validacijos būsenas
        {
            Console.Clear();
            Console.WriteLine($"Turime DNR grandine \"{dnr_grandine}\"");
            Console.WriteLine("DNR grandine normalizuota: {0}", normalizuota ? "Taip" : "Ne");
            Console.WriteLine("DNR grandine validi {0}", validi ? "Taip" : "Ne");
        }

        public static void pagrindinisMeniu ( string grandineDNR)
        {
            grandinesBusena(grandineDNR, arGrandineNormalizuota, arGrandineValidi);

            Console.WriteLine($"MENIU:\n" +
                "1. Atlikti DNR grandinės normalizavimo veiksmus.\n" +
                "2. Atlikti grandinės validaciją\n" +
                "3. Atlieka veiksmus su DNR grandine(tik tuo atveju jei grandinė yra normalizuota ir validi).\n" +
                "4. Išeiti iš programos\n\n" +
                "Pasirinkite meniu punktą:");
            
            int veiksmas = Convert.ToInt32(Console.ReadLine());

            switch (veiksmas)
            {
                case 1:
                    grandineDNR = Normalizavimas(grandineDNR);
                    arGrandineNormalizuota = true;
                    pagrindinisMeniu(grandineDNR);
                    break;
                case 2:
                    arGrandineValidi = Validacija(grandineDNR);
                    pagrindinisMeniu(grandineDNR);
                    break;
                case 3:
                    if (arGrandineValidi && !arGrandineNormalizuota)
                        SubMeniuNormalizavimas(grandineDNR);
                    else if (arGrandineValidi && arGrandineNormalizuota)
                        SubMeniuGrandinesVeiksmai(grandineDNR);
                    else pagrindinisMeniu(grandineDNR);
                    break;
                case 4:
                    break;
                default:
                    pagrindinisMeniu(grandineDNR);
                    break;
            };

        }

        public static string Normalizavimas(string dnr_grandine )
        // Atlieka DNR grandinės normalizavimo veiksmus:
        //  -pašalina tarpus.
        //  - visas raides keičia didžiosiomis.
        {
            return dnr_grandine.Replace(" ", "").ToUpper();
        }

        public static bool Validacija(string dnr_grandine)
        //- patikrina ar nėra kitų nei ATCG raidžių
        // - "-" nėra raide todėl yra leistinas grandineje
        {
            string leistiniSimboliai = "ATCG-";
            return dnr_grandine.All(c => leistiniSimboliai.Contains(c));
        }

        public static void SubMeniuNormalizavimas (string grandineDNR)
        {
            grandinesBusena(grandineDNR, arGrandineNormalizuota, arGrandineValidi);

            Console.WriteLine($"SUBMENIU:\n" +
                "1) Normalizuoti grandinę\n" +
                "2) Išeiti iš programos\n\n" +
                "Pasirinkite meniu punktą:");

            int veiksmas = Convert.ToInt32(Console.ReadLine());

            switch (veiksmas)
            {
                case 1:
                    grandineDNR = Normalizavimas(grandineDNR);
                    arGrandineNormalizuota = true;
                    SubMeniuGrandinesVeiksmai(grandineDNR);
                    break;
                case 2:
                    break;
                default:
                    pagrindinisMeniu(grandineDNR);
                    break;
            };

        }
        public static void SubMeniuGrandinesVeiksmai(string grandineDNR)
        {
            grandinesBusena(grandineDNR, arGrandineNormalizuota, arGrandineValidi);

            Console.WriteLine($"SUBMENIU:\n" +
                "1) GCT pakeis į AGG\n" +
                "2) Išvesti ar yra tekste CAT\n" +
                "3) Išvesti trečia ir penktą grandinės segmentus\n" +
                "4) Išvesti raidžių kiekį tekste\n" +
                "5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas\n" +
                "6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą\n" +
                "7) Iš grandinės pašalinti pasirinką elementą\n" +
                "8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros\n" +
                "9) Gryžti į ankstesnį meniu\n\n" +
                "Pasirinkite meniu punktą:");

            int veiksmas = Convert.ToInt32(Console.ReadLine());
            string ivestasSegmentas = "";

            switch (veiksmas)
            {
                case 1:
                    grandineDNR = pakeiskiAGG(grandineDNR);
                    SubMeniuGrandinesVeiksmai(grandineDNR);
                    break;
                case 2:
                    grandinesBusena(grandineDNR, arGrandineNormalizuota, arGrandineValidi);
                    Console.WriteLine("Ar tekste {0} yra CAT ? - {1}", grandineDNR, ArYraGrandinejeTekstas(grandineDNR,"CAT") ? "Taip" : "Ne");
                    LaukiamPaspaudimo();
                    SubMeniuGrandinesVeiksmai(grandineDNR);
                    break;
                case 3:
                    grandinesBusena(grandineDNR, arGrandineNormalizuota, arGrandineValidi);

                    Console.WriteLine("3-ias segmentas {0}", grandinesSegmentas(grandineDNR, 3));
                    Console.WriteLine("5-ias segmentas {0}", grandinesSegmentas(grandineDNR, 5));

                    LaukiamPaspaudimo();
                    SubMeniuGrandinesVeiksmai(grandineDNR);
                    break;
                case 4:
                    grandinesBusena(grandineDNR, arGrandineNormalizuota, arGrandineValidi);

                    string isvedimasStringComposition = string.Format("Raidžių kiekis {0}", RaidziuKiekis(grandineDNR));
                    Console.WriteLine(isvedimasStringComposition);

                    LaukiamPaspaudimo();
                    SubMeniuGrandinesVeiksmai(grandineDNR);
                    break;
                case 5:
                    ivestasSegmentas = IvedimasIsKlaviaturos("Įveskite segmento kodą(be '-'):");
                    Console.WriteLine("Ar grandineje yra įvestas segmento kodas ? - {0}", ArYraGrandinejeTekstas(grandineDNR, "-" +ivestasSegmentas) ? "Taip" : "Ne");
                    Console.WriteLine($"Įvestas segmento kodas kartojasi {grandineDNR} grandineje {KiekKartojasiSegmentoKodas(grandineDNR, ivestasSegmentas)} kartų.\n");
                    LaukiamPaspaudimo();
                    SubMeniuGrandinesVeiksmai(grandineDNR);
                    break;
                case 6:
                    //Prie grandinės galo pridėti iš klaviatūros įvesta segmentą
                    //(reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
                    ivestasSegmentas = IvedimasIsKlaviaturos("Įveskite segmento kodą(be '-'):");
                    if (Validacija(ivestasSegmentas) && ivestasSegmentas.Length == 3 )
                    {
                        grandineDNR = grandineDNR + "-" + ivestasSegmentas;
                        Console.WriteLine($"Segmento kodas {ivestasSegmentas} yra tinkamas ir pridėtas į grandinės galą.");
                    }
                    else Console.WriteLine($"Klaida. Segmento kodas {ivestasSegmentas} yra netinkamas.");
                    LaukiamPaspaudimo();
                    SubMeniuGrandinesVeiksmai(grandineDNR);
                    break;
                case 7:
                    //Iš grandinės pašalinti pasirinką elementą
                    ivestasSegmentas = IvedimasIsKlaviaturos("Įveskite šalinama elementą:");
                    // darome validacija kaip segmentui(tik ATCG ). Laikome, kad šalinamas elementas yra vienas simbolis .
                    if (Validacija(ivestasSegmentas) && ivestasSegmentas.Length == 1 && ivestasSegmentas != "-")
                    {
                        grandineDNR = grandineDNR.Replace(ivestasSegmentas, "");
                        Console.WriteLine($"Elementas {ivestasSegmentas} yra pašalintas iš grandinės.");
                    }
                    else Console.WriteLine($"Klaida. Įvestas elementas {ivestasSegmentas} pašalinimui yra netinkamas.");
                    LaukiamPaspaudimo();
                    SubMeniuGrandinesVeiksmai(grandineDNR);
                    break;
                case 8:
                    //Pakeisti pasirinkti segmentą įvestu iš klaviatūros
                    //(reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės)
                    ivestasSegmentas = IvedimasIsKlaviaturos("Įveskite keičiamo segmento kodą(be '-'):");

                    if (ArYraGrandinejeTekstas(grandineDNR, ivestasSegmentas))
                    {
                        // jeigu keičiamas segmentas yra grandineje tik tada darome validacija ir keitimą
                        if (Validacija(ivestasSegmentas) && ivestasSegmentas.Length == 3)
                        {
                            // išsaugom atskiram kintamajam keičiama segmentą
                            string keiciamasSegmentas = ivestasSegmentas;
                            ivestasSegmentas = IvedimasIsKlaviaturos("Įveskite naujo segmento kodą(be '-'):");

                            if (Validacija(ivestasSegmentas) && ivestasSegmentas.Length == 3)
                            {
                                grandineDNR = grandineDNR.Replace(keiciamasSegmentas, ivestasSegmentas);
                                Console.WriteLine($"Segmentas {keiciamasSegmentas} yra pakeistas į {ivestasSegmentas}.");
                            }
                            else
                                Console.WriteLine($"Klaida. Įvestas {ivestasSegmentas} segmentas nėra tinkamas pakeitimui.");
                        }
                        else Console.WriteLine($"Klaida. Įvestas {ivestasSegmentas} segmentas nėra tinkamas pakeitimui.");
                    }
                    else
                        Console.WriteLine($"Klaida. Įvesto {ivestasSegmentas} segmento nėra grandineje.");

                    LaukiamPaspaudimo();
                    SubMeniuGrandinesVeiksmai(grandineDNR);
                    break;
                case 9:
                    pagrindinisMeniu(grandineDNR);
                    break;
                default:
                    pagrindinisMeniu(grandineDNR);
                    break;
            };

        }

        public static void LaukiamPaspaudimo()
        {
            Console.WriteLine("\nPaspauskite bet kurią klavišą.");
            Console.ReadKey();
        }
        

        public static string pakeiskiAGG(string grandineDNR)
        //GCT pakeičia į AGG
        {
            return grandineDNR.Replace("GCT", "AGG");
        }

        public static string grandinesSegmentas(string grandineDNR, int segmentoNr)
        {
            string[] split = grandineDNR.Split('-');

            if ((split.Length -1) >= segmentoNr ) 
                return split[segmentoNr - 1];
            else return "";
        }

        public static int RaidziuKiekis(string grandineDNR)
        //- grąžina raidžių kiekį (skaičiuojamos ir didelės ir mažosios raidės )
        {
            string abecele = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return grandineDNR.ToCharArray().Count(c => abecele.Contains(c));
        }

        public static bool ArYraGrandinejeTekstas(string grandineDNR, string tekstas)
        {
            return grandineDNR.Contains(tekstas);
        }

        public static string IvedimasIsKlaviaturos(string aprasymas)
            // Įvedimas iš klaviaturos su pilnu aprašymu atvaizdavimu.
            // Grąžinamas string kuris yra įvestas.
        {
            Console.Clear();
            Console.WriteLine(aprasymas);
            string ivestasTekstas = Console.ReadLine();
            return ivestasTekstas;
        }

        public static int KiekKartojasiSegmentoKodas(string grandineDNR, string segmentoKodas)
            // grąžinomas INT kiek kartojasi grandineje pateikto segmento kodas
            // simbolį '-' laikome, kad yra segmento skyriklis
        {
            string[] split = grandineDNR.Split('-'+segmentoKodas);
            return split.Length - 1;
        }
    }
}