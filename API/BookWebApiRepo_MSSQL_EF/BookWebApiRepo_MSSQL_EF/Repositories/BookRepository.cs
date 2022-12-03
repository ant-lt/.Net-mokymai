using BookWebApiRepo_MSSQL_EF.Data;
using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;

namespace BookWebApiRepo_MSSQL_EF.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly BookContext _db;

        public BookRepository(BookContext db) : base(db)
        {
            _db = db;
        }

        public Book Update(Book book)
        {
            _db.Books.Update(book);
            _db.SaveChanges();

            return book;

        }
    }
}
