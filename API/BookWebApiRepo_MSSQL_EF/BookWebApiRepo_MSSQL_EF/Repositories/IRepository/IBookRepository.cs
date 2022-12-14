using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Repositories.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book> UpdateAsync(Book book);
        Task<List<Book>> Filter(Book book);
    }
}
