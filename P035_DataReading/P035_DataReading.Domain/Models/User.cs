using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Models
{
    public class User
    {
        public User()
        {

        }
        public User(string[] userData)
        {
            Id = Convert.ToInt32(userData[0]);
            Name = userData[1];
        }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
