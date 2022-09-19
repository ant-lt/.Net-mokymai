using P054_DB_Mutation.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P054_DB_Mutation.Services
{
    public class BlogService
    {
        private readonly ManageDb _manageDb;

        public BlogService(ManageDb manageDb)
        {
            _manageDb = manageDb;
        }

        public List<Blog> GetBlogs()
        {
            var res = _manageDb.GetBlogs();
            //sakykime cia kazkokia logika
            return res;
        }
    }
}
