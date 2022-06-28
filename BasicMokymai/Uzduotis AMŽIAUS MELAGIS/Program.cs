namespace Uzduotis_AMŽIAUS_MELAGIS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Užduotis amžiaus melagis.
             * Sukurkite programą, kuri pateiktų vartotojo registracijos formą.
             Vartotojas įveda:
              - vardą ir pavardę
              - asmens kodą (11simb.)
              - amžių (sveiką skaičių metais) ir/arba gimimo datą (galima abu, tik kažkurį vieną, ar neįvesti nei vieno)
            Programa į ekraną išveda ataskatą:
             - šiandienos datą
             - Vardas, pavardė
             - Lytis
                <HINT> asmens kodo pirmasis rodo gimimo šimtmetį ir asmens lytį
                (1 – XIX a. gimęs vyras,
                 2 – XIX a. gimusi moteris,
                 3 – XX a. gimęs vyras,
                 4 – XX a. gimusi moteris,
                 5 – XXI a. gimęs vyras,
                 6 – XXI a. gimusi moteris
                 tolesni šeši:
                      metai (du skaitmenys),
                      mėnuo (du skaitmenys),
                      diena (du skaitmenys))    
             - Asmens kodas
                <NEPRIVALOMAS PASUNKINIMAS> asmens kodas validuojamas pagal tokias salygas
                   Paskaičiuojamas Kontrolinis skaičius
                   a) jei kontrolinis skaičius teisingas išvedamas asmens kodas
                   b) jei neteisingas išvedamas tekstas "kodas neteisingas",
                      o laukeAmžiaus patikimumas išvedama "patikimumui trūksta duomenų"
                      <HINT> https://lt.wikipedia.org/wiki/Asmens_kodas
             - Amžius
             - Amžiaus patikimumas - pagal tokias sąlygas:
             -  jei įvestas amžius metais, paskaičiuoti gimimo metus ir sulyginti su įvestu asmens kodu.
                a) jei sutampa išvesti "amžius patikimas"
                b) jei nesutampa išvesti "amžius pameluotas"
             - jei įvesta gimimo data sulyginti su įvestu asmens kodu.
                a) jei sutampa išvesti "amžius patikimas"
                b) jei nesutampa išvesti "amžius pameluotas"
             - jei įvesta ir amžius ir gimimo data sulyginti su įvestu asmens kodu.
                a) jei viskas sutampa išvesti "amžius tikras"
                b) jei asmens kodu sutampa tik vienas įvestų, išvesti "amžius nepatikimas"
                c) jei nesutampa išvesti "amžius pameluotas"
             - jei neįvesta nei amžius nei gimimo data išvesti
                a) "patikimumui trūksta duomenų"
     

Rezultatas gali atrodyti taip:
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      2022-06-20       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓     Vardas, pavardė ▓ Vardenis Pavardenis                 ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓               Lytis ▓ Vyras                               ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓        Asmens kodas ▓ 44012029286                         ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓              Amžius ▓ 82                                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓         Gimimo data ▓ 1980-06-20                          ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓ Amžiaus patikimumas ▓ amžius nepatikimas                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
             * 
             * 
             */

          
            DateTime siandien = DateTime.Today;

            Console.WriteLine("Įveskite vartotojo vardą ir pavardę");
            string vartotojoVardasPavarde = Console.ReadLine();
            
            // pašalinam iš karto galimus tarpus
            vartotojoVardasPavarde = vartotojoVardasPavarde.Trim();

            Console.WriteLine("Įveskite vartotojo asmens kodą");
            string vartotojoAsmKodasTxt = Console.ReadLine();
            
                // pašalinam iš karto galimus tarpus
            vartotojoAsmKodasTxt = vartotojoAsmKodasTxt.Trim();

            bool arIvestasVartotojoAsmKodas = long.TryParse(vartotojoAsmKodasTxt, out _) ;

            bool arTeisingasKontrolinisSkaicius = false;

            if (arIvestasVartotojoAsmKodas && vartotojoAsmKodasTxt.Length == 11)
             {
                    // skaičiuojame kontrolinio skaičiau sumos
                    long suma1 = ((Convert.ToInt32(vartotojoAsmKodasTxt[0].ToString()) * 1) + (Convert.ToInt32(vartotojoAsmKodasTxt[1].ToString()) * 2) + (Convert.ToInt32(vartotojoAsmKodasTxt[2].ToString()) * 3) + (Convert.ToInt32(vartotojoAsmKodasTxt[3].ToString()) * 4) + (Convert.ToInt32(vartotojoAsmKodasTxt[4].ToString()) * 5) + (Convert.ToInt32(vartotojoAsmKodasTxt[5].ToString()) * 6) + (Convert.ToInt32(vartotojoAsmKodasTxt[6].ToString()) * 7) + (Convert.ToInt32(vartotojoAsmKodasTxt[7].ToString()) * 8) + (Convert.ToInt32(vartotojoAsmKodasTxt[8].ToString()) * 9) + (Convert.ToInt32(vartotojoAsmKodasTxt[9].ToString()) * 1)) % 11;
                    long suma2 = ((Convert.ToInt32(vartotojoAsmKodasTxt[0].ToString()) * 3) + (Convert.ToInt32(vartotojoAsmKodasTxt[1].ToString()) * 4) + (Convert.ToInt32(vartotojoAsmKodasTxt[2].ToString()) * 5) + (Convert.ToInt32(vartotojoAsmKodasTxt[3].ToString()) * 6) + (Convert.ToInt32(vartotojoAsmKodasTxt[4].ToString()) * 7) + (Convert.ToInt32(vartotojoAsmKodasTxt[5].ToString()) * 8) + (Convert.ToInt32(vartotojoAsmKodasTxt[6].ToString()) * 9) + (Convert.ToInt32(vartotojoAsmKodasTxt[7].ToString()) * 1) + (Convert.ToInt32(vartotojoAsmKodasTxt[8].ToString()) * 2) + (Convert.ToInt32(vartotojoAsmKodasTxt[9].ToString()) * 3)) % 11;
                    long kontrolinisSkaicius;

                    if ( suma1 == 10  )
                    {
                        kontrolinisSkaicius = suma2 == 10 ? 0 : suma2;
                    }
                    else
                    {
                        kontrolinisSkaicius = suma1;
                    }

                    // sutikrinam ar apskaičiuotas kontrolinis skaičius sutampa su nurodytu asmens kode
                    arTeisingasKontrolinisSkaicius = kontrolinisSkaicius == Convert.ToInt32(vartotojoAsmKodasTxt[10].ToString());
             }

            // nustatomi ar visi asmens kodo parametrai teisingi: įvestas skaičius, ilgis ir atitinka kontrolinis skaičius 
            bool arVartotojoAsmKodasTeisingas = arIvestasVartotojoAsmKodas && vartotojoAsmKodasTxt.Length == 11 && arTeisingasKontrolinisSkaicius;

            
            Console.WriteLine("Įveskite vartotojo amžių (sveiką skaičių metais):");
            string vartotojoAmziusTxt = Console.ReadLine();
            int vartotojoAmziusIvestas;
            bool arIvestasVartotojoAmzius= int.TryParse(vartotojoAmziusTxt.Trim(), out vartotojoAmziusIvestas);


            Console.WriteLine("Įveskite vartotojo gimimo datą (YYYY-MM-DD):");
            string gimimoDataTxt = Console.ReadLine();
            DateTime gimimoDataIvesta;
            bool ArIvestaData = DateTime.TryParse(gimimoDataTxt.Trim(), out gimimoDataIvesta);
            if (!ArIvestaData)
             {
                    //jeigu data neteisinga , tada ivestos datos neatvaizduojame , kad nerodyti nesamoninga datą
                    gimimoDataTxt = "";
             }

             string lytis ="";
             string amziausPatekimumasTxt = "";

             if (!arVartotojoAsmKodasTeisingas)
             {
                // įvestas neteisingas asmens kodas
                vartotojoAsmKodasTxt = "kodas neteisingas";
                amziausPatekimumasTxt = "patikimumui trūksta duomenų";
             }
             else
             {
                // įvestas teisingas asmens kodas
                int gimimoMetaiIsAsmKodo;

                // priskiriam Vyras/Moteris pagal asmens kodą ir suskaičiojame metus iš asmens kodo
                switch (vartotojoAsmKodasTxt[0])
                 {
                        case '1':
                            lytis = "Vyras";
                            gimimoMetaiIsAsmKodo = 1800 + Convert.ToInt32(vartotojoAsmKodasTxt.Substring(1,2));
                            break;
                        case '3':
                            lytis = "Vyras";
                            gimimoMetaiIsAsmKodo = 1900 + Convert.ToInt32(vartotojoAsmKodasTxt.Substring(1, 2));
                            break;
                        case '5':
                            lytis = "Vyras";
                            gimimoMetaiIsAsmKodo = 2000 + Convert.ToInt32(vartotojoAsmKodasTxt.Substring(1, 2));
                            break;
                        case '2':
                            lytis = "Moteris";
                            gimimoMetaiIsAsmKodo = 1800 + Convert.ToInt32(vartotojoAsmKodasTxt.Substring(1, 2));
                            break;
                        case '4':
                            lytis = "Moteris";
                            gimimoMetaiIsAsmKodo = 1900 + Convert.ToInt32(vartotojoAsmKodasTxt.Substring(1, 2));
                            break;
                        case '6':
                            lytis = "Moteris";
                            gimimoMetaiIsAsmKodo = 2000 + Convert.ToInt32(vartotojoAsmKodasTxt.Substring(1, 2));
                            break;
                        default:
                            lytis = "";
                            gimimoMetaiIsAsmKodo = 0;
                            break;
                 }

                // Amžiaus patikimumo tikrinimas
                // jei įvesta ir amžius ir gimimo data
                if (arIvestasVartotojoAmzius && ArIvestaData && ((siandien.Year - vartotojoAmziusIvestas) == gimimoMetaiIsAsmKodo && (gimimoDataIvesta.Year) == gimimoMetaiIsAsmKodo) )
                {
                    amziausPatekimumasTxt = "amžius tikras";
                }
                // jei asmens kodu sutampa tik vienas įvestų amžius arba gimimo data
                else if (arIvestasVartotojoAmzius && ArIvestaData && ((siandien.Year - vartotojoAmziusIvestas) == gimimoMetaiIsAsmKodo || (gimimoDataIvesta.Year) == gimimoMetaiIsAsmKodo))
                {
                    amziausPatekimumasTxt = "amžius nepatikimas";
                }
                //jei įvestas amžius metais, paskaičiuoti gimimo metus ir sulyginti su įvestu asmens kodu, jei įvesta gimimo data sulyginti su įvestu asmens kodu
                else if ((arIvestasVartotojoAmzius && ((siandien.Year - vartotojoAmziusIvestas) == gimimoMetaiIsAsmKodo)) || (ArIvestaData && ((gimimoDataIvesta.Year) == gimimoMetaiIsAsmKodo)))
                {
                    amziausPatekimumasTxt = "amžius patikimas";
                }

                // jei neįvesta nei amžius nei gimimo data
                else if (!arIvestasVartotojoAmzius && !ArIvestaData)
                {
                    amziausPatekimumasTxt = "patikimumui trūksta duomenų";
                }
                else
                {
                    amziausPatekimumasTxt = "amžius pameluotas";
                }
              }

             // parodome vartotojo formą / ataskaitą 
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      {siandien.ToShortDateString(),-10}       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine($"▓     Vardas, pavardė ▓ {vartotojoVardasPavarde,-36}▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine($"▓               Lytis ▓ {lytis,-36}▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine($"▓        Asmens kodas ▓ {vartotojoAsmKodasTxt,-36}▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine($"▓              Amžius ▓ {vartotojoAmziusTxt,-36}▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine($"▓         Gimimo data ▓ {gimimoDataTxt,-36}▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine($"▓ Amžiaus patikimumas ▓ {amziausPatekimumasTxt,-36}▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
             Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
        }
    }
}