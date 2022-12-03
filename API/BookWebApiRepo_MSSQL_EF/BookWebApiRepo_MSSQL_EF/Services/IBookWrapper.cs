using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;

namespace BookWebApiRepo_MSSQL_EF.Services
{
    public interface IBookWrapper
    {
        public GetBookDto Bind(Book book);
        public Book Bind(CreateBookDto book);
        public Book Bind(UpdateBookDto book);
    }
}
