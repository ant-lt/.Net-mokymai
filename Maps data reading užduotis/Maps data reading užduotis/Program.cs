using Maps_data_reading_užduotis.Models;
using Maps_data_reading_užduotis.Services;

namespace Maps_data_reading_užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, File Maps reading!");

            FileService fileService = new FileService(Environment.CurrentDirectory + "\\InitialData\\CountriesAndCapitals1.csv");

            Maps map = new Maps();
            map.Countries = fileService.FetchCountriesFromCsv();

            foreach (Country country in map.Countries)
            {
                Console.WriteLine($"{country.CountryName}");
            }
        }
        /*
         * 
         * Sukurkite klases <Map>, <Country>, <Traveler>, klases.
            <Map> klase turetu tureti sarasa visu saliu. <Map> turi paveldeti is <IMap>, kuris turi savyje siuos atributus: void PrintAllCountries(), void PrintAllCapitals, void MarkCountry(int countryId), void MarkCountry(string countryName), List<Country> FetchVisitedCountries(), void PrintVisitedCountries().
            Sukuriant nauja <Map> objekta turetu buti uzpildytos visos salys is CSV failo.
            <Country> sarasas turetu buti uzpildytas duomenimis gautais is CountriesAndCapitals1.csv
            <Traveler> turetu paveldeti is <IHuman>, kuris turi siuos atributus: property Map Map get;set; property int Id get;set; property string Name get;set; void Travel(string countryName)
            Main() metode sukurkite nauja Traveler objekta ir „aplankykite“ bent 5 salis.
         * 
         * 
         */


    }
}