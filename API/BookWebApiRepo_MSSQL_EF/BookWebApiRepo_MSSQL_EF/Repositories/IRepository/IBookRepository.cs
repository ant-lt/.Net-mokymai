using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Repositories.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        Book Update(Book book);
    }
}
