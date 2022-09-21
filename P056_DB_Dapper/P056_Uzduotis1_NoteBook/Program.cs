using P056_Uzduotis1_NoteBook.Database;
using P056_Uzduotis1_NoteBook.Database.Dapper;

namespace P056_Uzduotis1_NoteBook
{
    internal class Program
    {
        /*
         * Uzduotis 1: Parašykite programą NoteBook, kuri naudotų Dapper. Jūsų programa turėtų turėti klasę Note ir lentele, kuri savyje turėtų šiuos properties:
            Id [INT IDENTITY(1,1) PRIMARY KEY]
            Title [varchar]
            Description [varchar]
            CreationDatetime [datetime default current_timestamp]
            Priority [varchar]
         * 
         * Uzduoties papildymas:
         *  Užtikrinkite, kad jūsų programa teisingai veikia sukurdami NoteBookWritter service klasę, kuri galėtų pridėti įrašus, ištrinti įrašus ir juos atspausdinti. Grafinėje sąsajoje vartotojas turėtų turėti galimybę tęsti veiksmus programoje tol kol pasirinks Quit funkciją.
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Notebook!");
           
            Console.WriteLine("Fetching connection string..");
            var dbConfig = new DatabaseConfig();
            Console.WriteLine("Starting up Database check..");
            IDatabaseBootstrap databaseBootstrap = new Note(dbConfig);
            databaseBootstrap.Setup();
            Console.WriteLine("Database check complete");
        }


    }
}