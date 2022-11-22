using WebApiF1.Enums;
using WebApiF1.Models;

namespace WebApiF1.Services
{
    public class BookSet : IBookSet
    {

        private List<Book> books = new List<Book>
            {
                new Book { Id = 1, Title = "Ant medinės lentelės II", Author = "Kristina Pišniukaitė - Šimkienė", Years = 2022, CoverType = ECoverType.Electronic }
                ,new Book { Id = 2, Title = "Kakė Makė ir magiška kelionė", Author = "Lina Žutautė", Years = 2022, CoverType = ECoverType.Electronic}
                ,new Book { Id = 3, Title = "Tolimi krantai", Author = "Santa Montefiore", Years = 2022, CoverType = ECoverType.Electronic}
                ,new Book { Id = 4, Title = "Aštuntas gyvenimas (Brilkai)", Author = "Nino Haratischwili", Years = 2022,CoverType = ECoverType.Electronic }
                ,new Book { Id = 5, Title = "Ant medinės lentelės III", Author = "Kristina Pišniukaitė - Šimkienė", Years = 2022, CoverType = ECoverType.Electronic }
                ,new Book { Id = 6, Title = "Kichotas", Author = "Salman Rushdie", Years = 2020, CoverType = ECoverType.Electronic }
                ,new Book { Id = 7, Title = "Book6", Author = "autor1", Years = 2000,CoverType = ECoverType.Electronic }
                ,new Book { Id = 8, Title = "Book7", Author = "autor1", Years = 2000,CoverType = ECoverType.Electronic }
                ,new Book { Id = 9, Title = "Ant medinės lentelės IIV", Author = "Kristina Pišniukaitė - Šimkienė", Years = 2022, CoverType = ECoverType.Electronic }
                ,new Book { Id = 10, Title = "Book8", Author = "autor1", Years = 2000, CoverType = ECoverType.Electronic }
            };

        public List<Book> Books
        {
            get { return books; }
            set { books = value;}
        }
    }
}
