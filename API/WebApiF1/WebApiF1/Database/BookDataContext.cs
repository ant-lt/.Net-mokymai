global using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApiF1.Models;

namespace WebApiF1.Database
{
    public class BookDataContext: DbContext
    {
        public BookDataContext(DbContextOptions<BookDataContext> options) : base(options) 
        {

        }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=booksdb;Trusted_Connection=True;TrustServerCertificate=true;");
            optionsBuilder.UseSqlServer(GetConnectionString("DefaultSQLConnection"));
        }
        */
        public DbSet<Book> Books { get; set; }
    }
}
