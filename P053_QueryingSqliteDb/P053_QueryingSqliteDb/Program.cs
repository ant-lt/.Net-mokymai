using P053_QueryingSqliteDb.Infastrukture.Database;

namespace P053_QueryingSqliteDb
{

    //add-migration InitialMigration - leisti ant Infrastrukturos
    //update-database leisti ant Infrastrukturos
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, QueryingSqliteDb!");
            var manageDb = new ManageDb();

            manageDb.AddBlog("Programavimas");
            manageDb.AddBlog("Knygos");

            manageDb.AddPost("CSharp", 1);
            manageDb.AddPost("C++", 2);

            manageDb.AddAuthor("Petras", "Petrauskas", 1);

            manageDb.GetBlogs_EagerLoading();
            manageDb.GetBlogs_LazyLoading();
        }
    }
}