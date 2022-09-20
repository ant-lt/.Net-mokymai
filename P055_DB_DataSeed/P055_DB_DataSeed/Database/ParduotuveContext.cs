using Microsoft.EntityFrameworkCore;
using P055_DB_DataSeed.Database.InitialData;
using P055_DB_DataSeed.Models;

namespace P055_DB_DataSeed.Database
{
    public class ParduotuveContext : DbContext
    {
        public ParduotuveContext()
        {
        }
        public ParduotuveContext(DbContextOptions options) : base(options)
        {
        }



        public DbSet<Batas> Batai { get; set; }
        public DbSet<BatuDydis> BatuDydziai { get; set; }
        public DbSet<Pardavimas> Pardavimai { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=C:\\PLAYGROUND\\ProgramavimoMokykla\\CA.NET2\\DB\\P055_DB_DataSeed\\P055_DB_DataSeed\\Parduotuve.db");
                optionsBuilder.UseLazyLoadingProxies();
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BatuDydis>().HasKey(k => k.Id);
            modelBuilder.Entity<BatuDydis>().Property(p => p.Id).HasColumnName("BatuDydisId");

            modelBuilder.Entity<BatuDydis>()
                .HasOne(o => o.Batas)
                .WithMany(m => m.Dydziai)
                .HasForeignKey(f => f.BatasId);

            modelBuilder.Entity<Pardavimas>()
                .HasOne(o => o.BatuDydis)
                .WithMany()
                .HasForeignKey(f => f.BatuDydisId);

            modelBuilder.Entity<Batas>().HasData(BatasInitialData.DataSeed);
            modelBuilder.Entity<BatuDydis>().HasData(BatuDydisInitialData.DataSeed);
        }


    }



}
