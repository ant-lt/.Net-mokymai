using Microsoft.EntityFrameworkCore;
using P052_CodeFirstSqliteDb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P052_CodeFirstSqliteDb.Infrastrukture.Database
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            // Daugiau apie SpecialFolders - https://en.wikipedia.org/wiki/Special_folder
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "CodeFirstBlogging.db");
        }

        // Registruojame nauja lentele savo duombazeje
        public DbSet<Person> Persons { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public string DbPath { get; } // ConnectionString

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQL Server Configuration example
            // Server == Data Source
            // Database == Initial Catalog
            // optionsBuilder.UseSqlServer($"Server=(localdb)\\SqlServerDb; Database");

            // base.OnConfiguring(optionsBuilder);
            // DbPath == ConnectionString
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
            // Needs: Microsoft.EntityFrameworkCore.Proxies

            // Kuo skiriasi LazyLoading nuo EagerLoading
            optionsBuilder.UseLazyLoadingProxies();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Animal>()
                .HasKey(a => a.AnimalId);
        }
    }
}
