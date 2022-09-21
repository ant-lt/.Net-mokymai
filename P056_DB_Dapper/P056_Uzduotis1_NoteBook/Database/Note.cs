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

    public class Note : IDatabaseBootstrap
    {
        private readonly DatabaseConfig _databaseConfig;

        public Note(DatabaseConfig databaseConfig)
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
                    AND name = 'Note';");
            var tableName = table.FirstOrDefault();

            // Tikriname ar turime lentele Note. Jei turime iseiname nieko nedare.
            if (!string.IsNullOrEmpty(tableName) && tableName == "Note")
                return;

            // Kuriame lentele Note, nes sitoje vietoje esame garantuoti, kad Product lentele neegzistuoja paduotoje duomenu bazeje
            connection.Execute(@"
                CREATE TABLE Note (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title varchar NOT NULL,
                Description varchar,
                CreationDatetime DATETIME DEFAULT current_timestamp,
                Priority varchar DEFAULT 0);");

        }
    }
}
