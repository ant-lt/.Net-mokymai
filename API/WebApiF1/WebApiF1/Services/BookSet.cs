using WebApiF1.Enums;
using WebApiF1.Models;

namespace WebApiF1.Services
{
    public class BookSet : IBookSet
    {

        private List<Book> books = new List<Book>
            {
                new Book { id = 1, pavadinimas = "Ant medinės lentelės II", autorius = "Kristina Pišniukaitė - Šimkienė", leidybosMetai = 2022, coverType = ECoverType.Electronic }
                ,new Book { id = 2, pavadinimas = "Kakė Makė ir magiška kelionė", autorius = "Lina Žutautė", leidybosMetai = 2022, coverType = ECoverType.Electronic}
                ,new Book { id = 3, pavadinimas = "Tolimi krantai", autorius = "Santa Montefiore", leidybosMetai = 2022, coverType = ECoverType.Electronic}
                ,new Book { id = 4, pavadinimas = "Aštuntas gyvenimas (Brilkai)", autorius = "Nino Haratischwili", leidybosMetai = 2022,coverType = ECoverType.Electronic }
                ,new Book { id = 5, pavadinimas = "Ant medinės lentelės III", autorius = "Kristina Pišniukaitė - Šimkienė", leidybosMetai = 2022, coverType = ECoverType.Electronic }
                ,new Book { id = 6, pavadinimas = "Kichotas", autorius = "Salman Rushdie", leidybosMetai = 2020, coverType = ECoverType.Electronic }
                ,new Book { id = 7, pavadinimas = "Book6", autorius = "autor1", leidybosMetai = 2000,coverType = ECoverType.Electronic }
                ,new Book { id = 8, pavadinimas = "Book7", autorius = "autor1", leidybosMetai = 2000,coverType = ECoverType.Electronic }
                ,new Book { id = 9, pavadinimas = "Ant medinės lentelės IIV", autorius = "Kristina Pišniukaitė - Šimkienė", leidybosMetai = 2022, coverType = ECoverType.Electronic }
                ,new Book { id = 10, pavadinimas = "Book8", autorius = "autor1", leidybosMetai = 2000, coverType = ECoverType.Electronic }
            };

        public List<Book> Books
        {
            get { return books; }
            set { books = value;}
        }
    }
}
