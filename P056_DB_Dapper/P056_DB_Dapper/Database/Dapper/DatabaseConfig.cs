using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_DB_Dapper.Database.Dapper
{
    public class DatabaseConfig
    {
        public DatabaseConfig()
        {
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            ConnString = "Data Source=" + Path.Join(path,"ProductDapper.db");
        }

        public string ConnString { get; }
    }
}
