using BookWebApiRepo_MSSQL_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWebApiRepo_MSSQL_EF.Data
{
    public class BookContext: DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
    }
}
