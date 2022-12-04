using BookWebApiRepo_MSSQL_EF.Data;
using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BookWebApiRepo_MSSQL_EF.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly BookContext _db;

        public BookRepository(BookContext db) : base(db)
        {
            _db = db;
        }

        public async Task<List<Book>> Filter(Book book)
        {
            var books =  _db.Books.Where(e => e.Title == book.Title && e.Author == book.Author && e.CoverType == book.CoverType).ToListAsync();
          
            return await books;
        }

        public async Task<Book> Update(Book book)
        {
            _db.Books.Update(book);
            await _db.SaveChangesAsync();

            return book;

        }
    }
}
