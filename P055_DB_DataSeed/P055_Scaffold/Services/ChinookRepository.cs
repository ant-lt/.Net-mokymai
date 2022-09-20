using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P055_Scaffold.Database;
using P055_Scaffold.Models;

namespace P055_Scaffold.Services
{
    public class ChinookRepository
    {
        private readonly ChinookContext _context = new ChinookContext();

        public ChinookRepository()
        {

        }

        public IEnumerable<dynamic> GetCustomerByCountry(string country)
        {
            var res = _context.Customers.Where(x => x.Country == country).Select(c => new
            {
                Vardas = c.FirstName,
                KlientoId = c.CustomerId,
                SaliesPavadinimas = c.Country,
            });
            return res;
        }

    }
}
