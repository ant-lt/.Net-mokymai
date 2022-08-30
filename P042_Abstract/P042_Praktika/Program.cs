using P042_Praktika.InitialData;
using P042_Praktika.Interface;
using P042_Praktika.Models.Abstract;
using P042_Praktika.Models.Concrete;
using P042_Praktika.Service;

namespace P042_Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Abstract Praktika!");


            BookService test = new BookService();

            test.Decode(BookInitialData.DataSeedHtml);

            List<Book> fake = new List<Book>
            {
                new EBook { Genre = "Fantasy", Title = "Harry Potter and the Philosopher's Stone", Author = "JK Rowling", BooksSold = 12000000, Qtty = 5, Price = 10.0  },
                new AudioBook { Genre = "Fantasy", Title = "Harry Potter and the Philosopher's Stone", Author = "JK Rowling", BooksSold = 12000000, Qtty = 5, Price = 15.0  },
                new PaperbackBook { Genre = "Adventure", Title = "The Little Prince", Author = "Antoine de Saint-Exupery", BooksSold = 2000000, Qtty = 5, Price = 13.0  },
                new PaperbackBook { Genre = "Mystery", Title = "The Da Vinci Code", Author = "Dan Brown", BooksSold = 800000, Qtty = 5, Price = 20.0  },
                new HardcoverBook { Genre = "Adventure", Title = "The Little Prince", Author = "Antoine de Saint-Exupery", BooksSold = 2000000, Qtty = 5, Price = 33.0  },

            };

            Console.WriteLine(test.Encode(fake));

            Console.WriteLine("------------------");

            Invoice invoice = new Invoice(null);
            Invoice invoice1 = new Invoice(new List<IInvoiceSenderService>());
            Invoice invoice2 = new Invoice(new List<IInvoiceSenderService>
            {
                new InvoiceSenderSms(),
            });
            Invoice invoice3 = new Invoice(new List<IInvoiceSenderService>
            {
                new InvoiceSenderSms(),
                new InvoiceSenderPost()
            });
            Console.WriteLine("-----------------");
            invoice.Send();
            Console.WriteLine("-----------------");
            invoice1.Send();
            Console.WriteLine("-----------------");
            invoice2.Send();
            Console.WriteLine("-----------------");
            invoice3.Send();
            Console.WriteLine("-----------------");


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
           - knygų kodavimo į html. Metodas string Encode(list of Book). 
           sukurkite klasę/servisą BookService implementuojantį IBookHtmlService
           -implementuokite Decode unit-test 
           -Encode kolkas palikite neimplementuotą            
            */

            /*
            tęskite darbą BookService klasėje
            -naudodami Extension Methods  implementuokite Encode unit-test 
             */

            /*
                sukurkite interface IUniversityBookStore 
               - void metodas Fill(dataSeed)
               - (BONUS) metodas FilterEBooks(string? title) grąžinantis (list of EBook)
               - (BONUS) metodas FilterAudioBooks(string? title) grąžinantis (array of AudioBook)
               - (BONUS) metodas FilterPaperbackBooks(string? title) grąžinantis (IEnumerable of PaperbackBook)
               - (BONUS) metodas FilterHardcoverBooks(string? title) grąžinantis (list of HardcoverBook)
               - metodas Buy(Book book, int qtty) padidantis knygų prekyboje kiekį jei tokia knyga jau yra, arba įtraukiantis naują knygą
               - metodas Sale(Person person, string title, BookType bookType, int qtty) sumažinantis nurodytų knygų prekyboje kiekį
                 ir grąžina tipą Invoce (tai nauja klasė, kurią reikia susigalvoti patiems)
                   <hint> pasižiūrėkite kokie properčiai yra Person ir UniversityBookStore klasėse. 
                   > Invoce klasėje privalo būti pirkimo "šiandien" data
                   > Invoce klasėje privalo būti Send() metodas kuris sąskaitą galės išsiųsti Sms, Email ir Post 
                     (siųsti galima nei vienu, vienu arba visais būdais. nustatoma konstruktoriuje) 
                     (paties siuntimo implementuoti nereikia)
                */
            /*
            sukurkite interface IUniversityBookStoreAccounting
            - metodas Stock() gąžinantis turimų knygų kiekį
            - metodas Genres() gąžinantis list of string (knygų žanrų sąrašą, tik unikalius įrašus)
            - metodas Sales() gąžinantis dictionary key=person, value=list of books (parduotas knygas)
           */
        }
    }
}