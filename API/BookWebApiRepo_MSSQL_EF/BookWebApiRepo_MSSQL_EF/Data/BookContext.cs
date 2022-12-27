using BookWebApiRepo_MSSQL_EF.Data.InitialData;
using BookWebApiRepo_MSSQL_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWebApiRepo_MSSQL_EF.Data
{
    public class BookContext: DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<LocalUser> LocalUsers { get; set; }
        public virtual DbSet<Fine> Fines { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationStatus> ReservationStatus { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserLevel> UserLevels { get; set; }
        public virtual DbSet<Wishbook> Wishbooks { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Role>().HasData(RoleInitialData.rolesInitialDataSeed);
            modelBuilder.Entity<Genre>().HasData(GenreInitialData.genreInitialDataSeed);
            modelBuilder.Entity<Book>().HasData(BookInitialData.booksInitialDataSeed);
            modelBuilder.Entity<ReservationStatus>().HasData(ReservationStatusInitialData.reservationStatusInitialDataSeed);
            modelBuilder.Entity<UserLevel>().HasData(UserLevelInitialData.userLevelInitialDataSeed);
            
        }
    }
}