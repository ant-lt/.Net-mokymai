using Microsoft.EntityFrameworkCore;
using P053_QueryingSqliteDb_Namu_darbas.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb_Namu_darbas.Database
{
    public class ShoeShopContext : DbContext
    {
        public ShoeShopContext()
        {
        }

        public ShoeShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Shoes> Shoes { get; set; }
        public DbSet<ShoeSize> ShoeSizes { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=ShoeShop.db");
                optionsBuilder.UseLazyLoadingProxies();
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoeSize>().HasKey(k => k.Id);
            modelBuilder.Entity<ShoeSize>().Property(p => p.Id).HasColumnName("ShoeSizeId");

            modelBuilder.Entity<ShoeSize>()
                .HasOne(o => o.Shoe)
                .WithMany(m => m.ShoeSizes)
                .HasForeignKey(f => f.ShoeID);

            // tas pats kas virsuje tik atvirksciai
            //modelBuilder.Entity<Shoes>()
            //    .HasMany(m => m.ShoeSize)
            //    .WithOne(o => o.Shoes)
            //    .HasForeignKey(f => f.ShoesId);

            modelBuilder.Entity<Sale>()
                .HasOne(o => o.ShoeSize)
                .WithMany()
                .HasForeignKey(f => f.ShoeSizeId);

//            modelBuilder.Entity<Shoes>().HasData(BatasInitialData.DataSeed);
//            modelBuilder.Entity<BatuDydis>().HasData(BatuDydisInitialData.DataSeed);


        }

    }
}
