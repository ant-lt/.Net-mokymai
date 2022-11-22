using System.ComponentModel;
using WebApiF1.Enums;
using WebApiF1.Models;

namespace WebApiF1.Services
{
    public class BookWrapper : IBookWrapper
    {
        public GetBookDto Bind(Book book)
        {
            return new GetBookDto { 
                Id = book.Id,
                PavadinimasIrAutorius = $"{book.Title} {book.Author}",
                LeidybosMetai = book.Years
            };
        }

        public Book Bind(CreateBookDto book)
        {
            return new Book
            {
                Title = book.Pavadinimas,
                Author = book.Autorius,
                Years = book.Isleista.Year,
                CoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
            };
        }

        public Book Bind(UpdateBookDto book)
        {
            return new Book
            {
                Title = book.Pavadinimas,
                Author = book.Autorius,
                Years = book.Isleista.Year,
                CoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
            };

        }
    }
}
