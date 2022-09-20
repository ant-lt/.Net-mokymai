using P055_DB_DataSeed.Database;
using P055_DB_DataSeed.Services;

namespace P055_DB_DataSeed
{
    internal class Program
    {
         /*
             ** 1 Užduotis **
             Sukurti duomenų bazę, kurioje būtų Blogs ir Posts lentelės.
             Sukurti 3 blogus ir kiekvienam po 3 postus.
            
             ** 2 Užduotis **
             
            1. Sukurti programą Batų parduotuvė.
                
                Sukurti reikiamą duomenų bazę saugoti informacijai. Lentelės: 
                - Batai (Id , Batu pavadinimas, Tipas (Moteriski Vyriski, Vaikiski) , Kaina
                - BatuDydziai Id , dydis, kiekis, Batas)
                - Pardavimai ( Id , koks BatuDydis nupirktas, Kiek poru nupirkta, kiek pinigų išleista.)
                
                Sukurti metodus, kurie: 
                1. fiksuoja pirkimą 
                - vartotojas pasirenka kokius batus perka, kokio dydžio, kiek porų
                - programa išsaugo pasikeitusius duomenis lentelėse BatuDydziai (kiekis sumažėja), 
                - lentelėje Pardavimai užfiksuojamas pardavimas
               
                Programa turi bendrauti su pirkėju, atitinkamai siūlydama pasirinkimus. 
                Paklausia ar nori dar pirkti ir vėl procedūra kartojasi.
                Sugeneruoti duomenų bazėje duomenų, prieš pradedant pardavinėti
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Batu parduotuve!");
            using (var ctx = new ParduotuveContext())
            {
                //ctx.Database.EnsureCreated();
                var repository = new ParduotuveRepository(ctx);
                IBatuParduotuve parduotuve = new BatuParduotuve(repository);
                parduotuve.Begin();
            }
            
        }
    }
}