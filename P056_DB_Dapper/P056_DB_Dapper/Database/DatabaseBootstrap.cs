using Dapper;
using Microsoft.Data.Sqlite;
using P056_DB_Dapper.Database.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_DB_Dapper.Database
{
    // Bootstrap -> Paruostukas, tam, kad galetumet dirbti su funkcionalumu negalvojant apie pradzia
    public class DatabaseBootstrap : IDatabaseBootstrap
    {
        private readonly DatabaseConfig _databaseConfig;

        public DatabaseBootstrap(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        /// <summary>
        /// DatabaseBootstraper.Setup() reikalingas tam, kad uztikrintume
        /// jog duombaze ir lenteles pradineje stadijoje buna numatytos
        /// strukturos
        /// </summary>
        public void Setup()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            // Lentele pavadinimu "master" privalo visada egzistuoti kiekvienoje duomenu bazeje
            // SQLite atveju si lentele vadinasi sqlite_master
            // sqlite_master lentele saugo informacija apie visas kitas lenteles
            // sqlite_master.type -> saugomas resurso tipas
            // sqlite_master.name -> type nurodyto resurso pavadinimas

            // SQL struktura
            // SELECT fieldName1, fieldName2 -> Yra naudojama patikslinti, kuriu duomenu mums reikia is lenteles
            // FROM sqlite_master -> Nurodome is kurios lenteles, sie duomenys turetu buti traukiami
            // WHERE columnName1 = 'SampleValue' -> Filtruoja duomenis taip, kad istrauktume tik irasus kur columnName1 turi savo reiksme priskirta kaip 'SampleValue'
            var table = connection.Query<string>(@"
                SELECT name
                FROM sqlite_master
                WHERE type = 'table'
                    AND name = 'Product';");
            var tableName = table.FirstOrDefault();

            // Tikriname ar turime lentele Product. Jei turime iseiname nieko nedare.
            if (!string.IsNullOrEmpty(tableName) && tableName == "Product")
                return;

            // Kuriame lentele Product, nes sitoje vietoje esame garantuoti, kad Product lentele neegzistuoja paduotoje duomenu bazeje
            connection.Execute(@"
                CREATE TABLE Product (
                Name VARCHAR(100) NOT NULL,
                Description VARCHAR(1000) NULL);");

            // ALTER TABLE -> Jei norima pakeisti lenteles struktura.
        }
    }
}
