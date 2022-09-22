using Dapper;
using Microsoft.Data.Sqlite;
using P056_Uzduotis1_NoteBook.Database.Dapper;
using P056_Uzduotis1_NoteBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_Uzduotis1_NoteBook.Database
{
    public class NoteBookRepository : INoteBookRepository
    {
        private readonly DatabaseConfig _databaseConfig;

        public NoteBookRepository(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }


        public void Create(NoteBook noteBook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            connection.Execute(@"
                INSERT INTO Notebook (Title, Description, Priority)
                VALUES (@Title, @Description, @Priority);", noteBook);

        }

        public IEnumerable<NoteBook> Get()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            // * - Reiskia, kad norim paimti visus duomenis
            return connection.Query<NoteBook>(@"
                SELECT *
                FROM Notebook;");

        }


        public int Delete(string notebookTitle)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            var affectedRows = connection.Execute(@"
                DELETE
                FROM Notebook
                WHERE Title = @Title;", new { Title = notebookTitle });

            return affectedRows;

        }

        public void Update(NoteBook notebook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            var updateQuery = @"
                UPDATE Notebook
                SET Title = @Title
                ,Description = @Description
                ,Priority = @Priority
                WHERE Id = @Id;";


            connection.Execute(updateQuery, notebook);
        }

        public NoteBook Get(int notebookId)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            return connection.Query<NoteBook>(@"
                SELECT *
                FROM Notebook
                WHERE Id = @Id;", new {Id = notebookId})
                .FirstOrDefault();
        }
    }
}
