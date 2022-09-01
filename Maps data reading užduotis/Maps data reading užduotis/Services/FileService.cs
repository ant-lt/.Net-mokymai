using Maps_data_reading_užduotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps_data_reading_užduotis.Services
{
    public class FileService
    {
        readonly string _filePath;

        public FileService(string filePath)
        {
            _filePath = filePath;
        }

        public List<Country> FetchCountriesFromCsv()
        {
            int countryColumnCount = 4;
            List<Country> countryList = new List<Country>();

            using StreamReader sr = new StreamReader(_filePath);

            string countryLine;
            string headers = sr.ReadLine();

            while ((countryLine = sr.ReadLine()) != null)
            {
                string[] countryData = countryLine.Split(',');

                if (countryData.Length != countryColumnCount)
                {
                    break;
                }

                Country country = new Country(countryData);
                countryList.Add(country);
            }

            return countryList;
        }
    }
}
