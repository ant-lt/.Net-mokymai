using P056_DB_Dapper.Database;
using P056_DB_Dapper.Database.Dapper;
using P056_DB_Dapper.Services;

namespace P056_DB_Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dapper yra EntityFramework alternatyva
            // EFCore -> Fullscale ORM (Object–relational mapping)
            // Dapper -> Micro ORM
            // %LOCALAPPDATA%

            // Kodel naudoti Dapperi?
            // Del labai didelio greicio
            // Labai patinka rasyti raw SQL
            // Esate arciau "gelezies"

            // Reikalingi paketai
            // install-package Dapper
            Console.WriteLine("Hello, Dapper!");
            Console.WriteLine("Fetching connection string..");
            var dbConfig = new DatabaseConfig();
            Console.WriteLine("Starting up Database check..");
            IDatabaseBootstrap databaseBootstrap = new DatabaseBootstrap(dbConfig);
            databaseBootstrap.Setup();
            Console.WriteLine("Database check complete");

            IProductService productService = new ProductService();
            productService.Run();
        }
    }
}