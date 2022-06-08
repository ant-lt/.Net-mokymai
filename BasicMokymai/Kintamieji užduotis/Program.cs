namespace Kintamieji_užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 užduotis
            /*UŽDUOTIS
       ************************************************************************************************************************
      PARAŠYTI PROGRAMĄ KURIOJE SAUGOME :
       • MOKYKLOS PAVADINIMĄ
       • KURSO PAVADINIMĄ
       • STUDENTŲ SKAIČIŲ
       • ŠIANDIENOS DATĄ
       • VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ
       */
            var mokyklosPavadinimas = "CodeAcademy";
            var kursoPavadinimas = "CA.NET2";
            var studentuSkaicius = 19;
            var siandienosData= DateTime.Now;

            Console.WriteLine("MOKYKLOS PAVADINIMAS:{0}", mokyklosPavadinimas);
            Console.WriteLine("KURSO PAVADINIMAS: {0}", kursoPavadinimas);
            Console.WriteLine("STUDENTŲ SKAIČIUS: {0}", studentuSkaicius);
            Console.WriteLine("ŠIANDIENOS DATA: {0:d}", siandienosData);

            Console.WriteLine("kursoPavadinimas-{0}\nkursoPavadinimas-{1}\nstudentuSkaicius-{2}\nsiandienosData-{3}",
             mokyklosPavadinimas,
             kursoPavadinimas,
             studentuSkaicius,
             siandienosData.ToShortDateString());
            Console.WriteLine($"mokyklosPavadinimas - {mokyklosPavadinimas} \n " +
                $"kursoPavadinimas - {kursoPavadinimas} \n " +
                $"studentuSkaicius - {studentuSkaicius} \n " +
                $"siandienosData - {siandienosData}");




            // 2 užduotis
            /*UŽDUOTIS
                       ************************************************************************************************************************
                      PAPILDYTI PROGRAMĄ IR PRIDĖTI:
                       • KURSO PRADŽIOS DATĄ
                       • KURSO PABAIGOS DATĄ
                       • Sužinoti skirtumą tarp kurso pradžios ir dabartinės datos (dienomis)
                       • VISUS KINTAMUOSIUS IŠVESTI Į EKRANĄ
                       */

            var kursoPradziosData = new DateTime(2022, 05, 30);
            var kursoPabaigosData = kursoPradziosData.AddMonths(7);

            var kursoTrukme = DateTime.Now - kursoPradziosData;

            Console.WriteLine("KURSO PRADŽIOS DATĄ:{0:d}", kursoPradziosData);
            Console.WriteLine("KURSO PABAIGOS DATĄ: {0:d}", kursoPabaigosData);
            Console.WriteLine("skirtumą tarp pradžios ir dabartinės datos (dienomis): {0}", kursoTrukme.Days);

            // 3 užduotis
            /*UŽDUOTIS
************************************************************************************************************************
Sukurkite tris kintamuosius. tekstinio, sveiko skaitmens ir loginio tipo. 
Parašykite programą kuri į konsolę visus aprašytus kintamuosius vienoje eilutėje atskiriant tarpu
*/
            var tekstinisKintamas = "Testas";
            var intKintamasis = 10;
            var loginisKintamas = true;


            Console.WriteLine("{0} {1} {2}", tekstinisKintamas, intKintamasis, loginisKintamas);// kompozicija
            Console.WriteLine($"{tekstinisKintamas} {intKintamasis} {loginisKintamas}"); // interpoliacija

            Console.WriteLine("{0}\n{1}\n{2}",
            kursoPradziosData.ToShortDateString(),
            kursoPabaigosData.ToShortDateString(),
            kursoTrukme.Days);

         // 4 užduotis
            /* UŽDUOTIS
          ************************************************************************************************************************
          Sukurkite tris sveikojo skaitmens tipo kintamuosius.
          Parašykite programą kuri į konsolę visus aprašytus kintamuosius atskiriant tarpu
          - panaudokite konkatinacija
          - panaudokite kompoziciją
          - panaudokite interpociacija
          */

            var intKintamasis1 = 10;
            var intKintamasis2 = 20;
            var intKintamasis3 = 30;
            
            Console.WriteLine( intKintamasis1 + " " + intKintamasis2 + " " + intKintamasis3);// konkatinacija
            Console.WriteLine("{0} {1} {2}", intKintamasis1, intKintamasis2, intKintamasis3);// kompozicija
            Console.WriteLine($"{intKintamasis1} {intKintamasis2} {intKintamasis3}"); // interpoliacija


        }
    }
}