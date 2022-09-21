using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P056_Uzduotis1_NoteBook.Database.Dapper
{
    public class DatabaseConfig
    {
        public DatabaseConfig()
        {
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            ConnString = "Data Source=" + Path.Join(path, "Notebook.db");
        }

        public string ConnString { get; }
    }
}
