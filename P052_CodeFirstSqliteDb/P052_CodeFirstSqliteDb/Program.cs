using P052_CodeFirstSqliteDb.Infrastrukture.Database;
using P052_CodeFirstSqliteDb.Infrastrukture.Interfaces;


namespace P052_CodeFirstSqliteDb
{

    // SVARBU!!
    // PAGRINDINES CLI(PACKAGE MANAGER CONSOLE) KOMANDOS:
    // KOMANDOS TURI BUTI LEIDZIAMAS ANT INFRSTRUKTUROS PROJEKTO (Ten kur randasi DbContext)
    // add-migration "*MigrationName*"
    // update-database
    // update-database "*MigrationName*" - cia pavadinimas kaip paaiskinimas kas pasikeicia

    // Pradedi naudoti SQLite turime isirasyti siuos NuGet (Tools->NuGet Package Manager->Manage NuGet...)
    // 1. install-package Microsoft.EntityFrameworkCore.Sqlite
    // 2. install-package Microsoft.EntityFrameworkCore.Proxies
    // 3. install-package Microsoft.EntityFrameworkCore.Tools

    // add-migration naudojame tada kada pasikeicia musu duombazes struktura

    /*
 Uzduotis 1:
    Atnaujinkit Person, kad turetu Weight(double), Biography(string:nullable) atributus  (Nauja migracija turetu tureti tik siuos atnaujinimus). Sukurkite nauja klase Animal, kuri turetu AnimalId(Primary Key), Name, Type, BirthDate atributus.
 */

    internal class Program
    {
        private static IBloggingRepository _bloggingRepository = new BloggingRepository();

        static void Main(string[] args)
        {
            // Technologija, kuria naudosime SQL duombaziu naudojimui: SQLite
            // Technologija komunikacijai su DB: EntityFrameworkCore
            // 3 priejimai kaip galima aktyvuoti duombaziu naudojima kode:
            // 1. Database First
            // 2. Model First
            // 3. Code First

            // Management Studio: https://sqlitebrowser.org/dl/

            // Pradedi naudoti SQLite turime isirasyti siuos NuGet (Tools->NuGet Package Manager->Manage NuGet...)
            // 1. install-package Microsoft.EntityFrameworkCore.Sqlite
            // 2. install-package Microsoft.EntityFrameworkCore.Proxies
            // 3. install-package Microsoft.EntityFrameworkCore.Tools
            Console.WriteLine("Hello, SQLite!");

            while (true)
            {
                Console.WriteLine($"\n1.Add new user\n2.Display all users\n3.Display all users sorted by name\nq.Quit");

                char selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        Console.WriteLine($"\nNew user is being added. Please fill in data:");
                        Console.WriteLine($"\nName:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine($"\nLast name:");
                        string lastName = Console.ReadLine();
                        Console.WriteLine($"\nAge: (Example: 2000/01/01)");
                        DateTime birthDate = DateTime.Parse(Console.ReadLine());
                        _bloggingRepository.AddPerson(firstName, lastName, birthDate);

                        break;
                    case '2':
                        _bloggingRepository.PrintAllPersons();
                        break;
                    case '3':
                        _bloggingRepository.PrintAllPersonsSorted();
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Input incorrect. Please try again.");
                        break;
                }
            }
        }
    }
}