using P055_Scaffold.Services;

namespace P055_Scaffold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // pasirinkit default projekta
            // jeigu nesibildina ir yra kitas projektas ant neaktyvau projekto desine klavisa ir padaryti "unload project"
            //Scaffold-DbContext "DataSource=...\DB\P055_DB_DataSeed\P055_Scaffold\chinook.db" Microsoft.EntityFrameworkCore.Sqlite

            var db = new ChinookRepository();

            var customers = db.GetCustomerByCountry("Brazil");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.KlientoId);
                Console.WriteLine(customer.Vardas);
                Console.WriteLine(customer.SaliesPavadinimas);

            }

        }


        /*
           Naudokite Chinook DB https://www.sqlitetutorial.net/sqlite-sample-database/
          1. Pagal duomenų bazės struktūrą modelius ir DbContext
          2. Prašykite metodą, kuris pagal pateiktą 'Country' grąžintų visus 'customers' iš tos šalies 
             (vardą, kliento id ir šalies pavadinimą)
          3. Prašykite metodą, kuris pagal pateiktą kliento 'Country' grąžintų visus 'invoice' iš tos šalies 
             (kliento pilnas vardas, sąskaitos id, sąskaitos data, sąskaitos šalis)
          4. Prašykite metodą, kuris darbuotojus 'employees' grąžina sugrupuotus paga pavadinimą 'Title'
          5. Prašykite metodą, kuris grąžina tik unikalius šalių pavadinimus iš 'customers' lentelės
          6. Prašykite metodą, kuris grąžina tik tas sąskaitas už kurias atsakingi 'Sales Support Agent'. 
             (darbuotojo pilnas vardas, sąskaitos id, sąskaitos data, sąskaitos šalis, suma)
          7. Prašykite metodą, kuris grąžina kiek sąskaitų buvo išrašyta už metus
          8. Prašykite metodą, kuris grąžina kiek prekių (invoice_items) buvo parduota su kiekviena sąskaita 
          9. Prašykite metodą, kuris grąžina kiek kiekvienoje kliento valstybėje buvo išrašyta sąskaitų 
          10. Prašykite metodą, kuris grąžina kiek prekių (invoice_items) buvo parduota su kiekvienoje kliento valstybėje 
          11. Prašykite metodą, kuris grąžina nupirko (invoice_items) 'track' pavadinimą ir 'artist' vardą
          12. Prašykite metodą, kuris grąžina kiek 'tracks' yra kiekviename 'playlist' 
              (playlist pavadinimas, kiekis)
          13. Prašykite metodą, kuris grąžina kurie metai buvo patys pelningiausi
          14. Prašykite metodą, kuris grąžina top 5 parduodamus 'tracks'
          15. Prašykite metodą, kuris grąžina top 3 parduodamus 'artists'
          16. Prašykite metodą, kuris grąžina top 2 parduodamus 'genres'
          17. Prašykite metodą, kuris grąžina top 1 parduodamą 'media_types'
          18. Prašykite metodą, kuris grąžina kiekvienoje šalyje yra klientų


           */

    }
}