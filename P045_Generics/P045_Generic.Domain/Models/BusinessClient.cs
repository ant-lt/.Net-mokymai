using P045_Generic.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Models
{
    public class BusinessClient : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
