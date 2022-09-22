using P057_DB_TransactionChangeTracking.Services;

namespace P057_DB_TransactionChangeTracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Db TransactionChangeTracking!");

            var manageDb = new ManageDb();


            manageDb.AddBlog("Programavimas");
            manageDb.AddBlog("Knygos");
            manageDb.AddPost("CSharp", 3);
            manageDb.AddPost("SQL", 3);
            manageDb.UpdateBlog(1, "Programavimas2");
            manageDb.UpdatePost(2, "T-SQL");
            //manageDb.DeletePost(3);
            manageDb.GetBlogs_EagerLoading();

            manageDb.UpdateBlogToVipBlog();
        }

        /*
         * 
         * https://www.sqlitetutorial.net/sqlite-cheat-sheet/
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
         * 
         * ------------------------
         * Sukurkite nauja programa WarehouseRental, kuri turi 4 lenteles:
            - Customer
                Id
                Name (required, 150 symbols)
                InventorySize
            - Sale
                Id
                Price
                CreationDate
                Reikalingi laukai apjungti Customer ir SalesPerson (MtM)
                LAUKAI, KURIE TURETU NEATSIRASTI DUOMBAZEJE: RevenuePerRentedSquare, AverageWarehouseRevenuePerCustomer
            - SalesPerson
                Id
                Name (required, 150 symbols)
                SalesRegion (required, 75 symbols)
            - Warehouse
                Id
                Location (required, 50 symbols)
                ProductionType (required, 150 symbols) // Kam buvo sandelys iprastai naudojamas
                CurrentInventoryCapacity
                MaxInventoryCapacity
                LAUKAI, KURIE TURETU NEATSIRASTI DUOMBAZEJE: 
                    AvailableInventoryCapacity
            Siame kontekste Customer ir SalesPerson gali tureti daug Sales(MtM),
            Customer gali tureti 1 registruota Warehouse, o Warehouse gali tureti daug registruotu Customer.
            
            Sukurkite DbContext ir ji naudokite DbManager klaseje.
            DbManager turi paveldeti is IDbManager:
                List<SalesPerson> GetSalesPeople();
                List<Customer> GetCustomers();
                List<Warehouse> GetWarehouses();
                void RegisterWareHouseRent(int customerId, int salePersonId, int inventorySize, decimal price);
            Naudokite DataSeed funkcija (Initial data sumaitinima per Fluent API)
            Failai, kurie turi jums reikalingus duomenis:
                CustomerInitialData
                SalesPersonInitialData
                WarehouseInitialData
            Sukurkite WarehouseAdministration klase, kurioje turetumete tureti metodus:
            void Begin() // Uzklausia vartotojo ka noretu daryti
            void RegisterRent() // Turetu isvesti visus SalesPeople ir Customers, kur turetumete pasirinkti, besinomuojanti Customer
                ir jam priskirti agenta, kuris uzbaigs pardavima. Metodo
                eigoje vartotojas turetu buti uzklausimas Inventory dydzio
                pagal kuri programa nustatys, kuri sandeli priskirti vartotojui.
            void PrintStatistics() turetu atspausdinti visus SalesPerson ir 
                pasirinkus viena is ju turetu isvesti jam priskirtus
                Customer su jiems priskirtais Warehouses
         * 
         */
    }
}