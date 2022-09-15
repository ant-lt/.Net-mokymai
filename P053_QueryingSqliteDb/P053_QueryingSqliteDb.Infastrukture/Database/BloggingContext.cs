using Microsoft.EntityFrameworkCore;
using P053_QueryingSqliteDb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb.Infastrukture.Database
{
    // Naudokite [CTRL + .] shortcut
    public class BloggingContext : DbContext
    {
        // Code snippet: ctor + tab + tab
        public BloggingContext()
        {
            // %LOCALAPPDATA%
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            ConnectionString = Path.Join(path, "QueryingBloggingDb.db");
        }

        // Registruojame lenteles
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBlog> AuthorBlogs { get; set; }

        public string ConnectionString { get; }

        // Tam, kad code snippet panaudoti parasykite:
        // override OnConf + Enter
        // Tokiu budu jums IDE sugeneruos visa reikalinga code blocka
        // Cia konfiguruojama kodo ir duombazes bendravimas, general settingai, kokiu budu bus prisijungta, prie ko bus prisijungta etc
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={ConnectionString}"); // Nustatome, kad norime naudoti SQLite kaip musu DB tipa
            optionsBuilder.UseLazyLoadingProxies(); // Ijungiame konfiguracijos pagalba Lazy Loading
        }

        // Cia konfiguruojama modeliu struktura, relationships, taisykles
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Statome kompozicini primary rakta (Primary key), kuris bus sudarytas is AuthorId ir BlogId
            modelBuilder.Entity<AuthorBlog>()
                .HasKey(ab => new { ab.AuthorId, ab.BlogId });

            modelBuilder.Entity<AuthorBlog>()
                .HasOne<Author>(ab => ab.Author)
                .WithMany(ab => ab.AuthorBlogs)
                .HasForeignKey(ab => ab.AuthorId);

            modelBuilder.Entity<AuthorBlog>()
                .HasOne<Blog>(ab => ab.Blog)
                .WithMany(ab => ab.AuthorBlogs)
                .HasForeignKey(ab => ab.BlogId);
        }
    }
}
