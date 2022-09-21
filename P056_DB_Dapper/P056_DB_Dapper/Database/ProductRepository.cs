using Dapper;
using Microsoft.Data.Sqlite;
using P056_DB_Dapper.Database.Dapper;
using P056_DB_Dapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_DB_Dapper.Database
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseConfig _databaseConfig;

        public ProductRepository(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        // CRUD -> Create, Read, Update, Delete
        // Pridedame eilute i lentele
        // INSERT INTO Product (Name, Description) -> Mes norime ideti nauja eilute su 2 reiksmemis: Name, Description
        // VALUES (@Name, @Description) -> Mes norime ideti i paminetus stulpelius sias dvi reiksmes
        public void Create(Product product)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            connection.Execute(@"
                INSERT INTO Product (Name, Description)
                VALUES (@Name, @Description);", product);
        }

        public IEnumerable<Product> Get()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            // SELECT rowid AS Id -> Traukiam rowid, bet pervadinam ir grazinam Id pavadinimu
            // rowid yra SQLite sugebejimas rasti kurioje eiluteje mes randame irasa
            return connection.Query<Product>(@"
                SELECT rowid AS Id, Name, Description
                FROM Product");
        }

        public int Delete(string productName)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            // DELETE -> norim istrinti viska eiluteje/eilutese
            // FROM Product -> Is Product lenteles
            // 
            var affectedRows = connection.Execute(@"
                DELETE
                FROM Product
                WHERE Name = @Name;", new { Name = productName });

            return affectedRows;
        }

    }
}
