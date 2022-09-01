using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps_data_reading_užduotis.Models
{
    public class Country
    {
        public Country() { }
        public Country(string[] countryData)
        {
            Id = Convert.ToInt32(countryData[0]);
            CountryName = countryData[1];
            Capital = countryData[2];
            IsMarked = Convert.ToInt32(countryData[3]);
        }
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Capital { get; set; }
        public int IsMarked { get; set; }
    }
}
