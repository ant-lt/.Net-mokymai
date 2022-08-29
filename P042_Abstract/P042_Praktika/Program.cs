using P042_Praktika.InitialData;
using P042_Praktika.Interface;
using P042_Praktika.Service;

namespace P042_Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Abstract Praktika!");


            IBookHtmlService test = new BookService();

            test.Decode(BookInitialData.DataSeedHtml);


            /*
                Sukurkite abstract klasę Book
                Sukurkite klasę EBook pavaldėtą iš Book klasės.
                Sukurkite klasę AudioBook pavaldėtą iš Book klasės.
                Sukurkite klasę PaperbackBook pavaldėtą iš Book klasės.
                Sukurkite klasę HardcoverBook pavaldėtą iš Book klasės.
                - knygų duomenys pateikiami ir struktūra kaip - BookInitialData.DataSeedHtml
            */

            /*
                sukurkite interface IBookHtmlService kuris aprašo metodus
                - knygų iškodavimo iš html. Metodas <tipas> Decode(string dataSeed).   
                - knygų kodavimo į html. Metodas string Encode(Dictionary of Book key=(enum)BookType value=list of Book).  
            */

            /*
                sukurkite klasę/servisą BookService implementuojantį IBookHtmlService
                -implementuokite IBookHtmlService metodus unit-test
           */
        }
    }
}