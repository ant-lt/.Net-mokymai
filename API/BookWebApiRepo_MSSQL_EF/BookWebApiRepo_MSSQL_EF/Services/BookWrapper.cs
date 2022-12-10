using BookWebApiRepo_MSSQL_EF.Enums;
using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Services
{
    public class BookWrapper : IBookWrapper
    {
        public GetBookDto Bind(Book book)
        {
            return new GetBookDto
            {
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
                OwnedQty = book.GautasKiekis,
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

        public Book Bind(FilterBookRequest bookFilter)
        {
            return new Book
            {
                Title = bookFilter.Pavadinimas,
                Author = bookFilter.Autorius,               
                CoverType = (ECoverType)Enum.Parse(typeof(ECoverType), bookFilter.KnygosTipas),
            };

        }
    }
}
