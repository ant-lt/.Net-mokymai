using Dapper;
using Microsoft.Data.Sqlite;
using P056_Uzduotis1_NoteBook.Database.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_Uzduotis1_NoteBook.Database
{

    public class DatabaseBootstrap : IDatabaseBootstrap
    {
        private readonly DatabaseConfig _databaseConfig;

        public DatabaseBootstrap(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        public void Setup()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            var table = connection.Query<string>(@"
                SELECT name
                FROM sqlite_master
                WHERE type = 'table'
                    AND name = 'Notebook';");
            var tableName = table.FirstOrDefault();

            // Tikriname ar turime lentele Note. Jei turime iseiname nieko nedare.
            if (!string.IsNullOrEmpty(tableName) && tableName == "Notebook")
                return;

            // AUTOINCREMENT - (SQLite) Kada turime si atributa mums reiksme apskaiciuoja ir priskiria pati duomenu baze.
            // SQLite generuoja nuo 1 iki X. Kiekviena eilute gauna vis didesni ID.
            // Identity(1,1) == AUTOINCREMENT. Identity yra naudojamas SQL Server.
            // PRIMARY KEY - Pagrindinis lenteles raktas, kuris yra unikalus yra tampa nebe istrinimas (non-nullable)
            connection.Execute(@"
                CREATE TABLE Notebook (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title VARCHAR(100) NOT NULL,
                CreationDatetime DATETIME DEFAULT current_timestamp,
                Description VARCHAR(1000) NULL,
                Priority VARCHAR(100) DEFAULT 0);");

        }
    }
}
