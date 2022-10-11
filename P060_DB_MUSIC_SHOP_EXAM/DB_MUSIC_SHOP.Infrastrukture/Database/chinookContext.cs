﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DB_MUSIC_SHOP.Infrastrukture.Database;
using P060_DB_MUSIC_SHOP_EXAM;

namespace DB_MUSIC_SHOP.Infrastrukture.Database
{
    public partial class chinookContext : DbContext
    {
        public string? ConnectionString { get; }

        public chinookContext()
        {
            // cia dar reikia padirbeti su direktorijomis
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //ConnectionString = Path.Join(path, "chinook.db");

            ConnectionString = "C:\\Project\\CA Mokymai\\P060_DB_MUSIC_SHOP_EXAM\\P060_DB_MUSIC_SHOP_EXAM\\chinook.db";
        }

        public chinookContext(DbContextOptions<chinookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; } = null!;
        public virtual DbSet<Artist> Artists { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; } = null!;
        public virtual DbSet<MediaType> MediaTypes { get; set; } = null!;
        public virtual DbSet<Playlist> Playlists { get; set; } = null!;
        public virtual DbSet<Track> Tracks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={ConnectionString}"); 
                optionsBuilder.UseLazyLoadingProxies(); 

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("albums");

                entity.HasIndex(e => e.ArtistId, "IFK_AlbumArtistId");

                entity.Property(e => e.Title).HasColumnType("NVARCHAR(160)");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("artists");

                entity.Property(e => e.Name).HasColumnType("NVARCHAR(120)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.SupportRepId, "IFK_CustomerSupportRepId");

                entity.Property(e => e.Address).HasColumnType("NVARCHAR(70)");

                entity.Property(e => e.City).HasColumnType("NVARCHAR(40)");

                entity.Property(e => e.Company).HasColumnType("NVARCHAR(80)");

                entity.Property(e => e.Country).HasColumnType("NVARCHAR(40)");

                entity.Property(e => e.Email).HasColumnType("NVARCHAR(60)");

                entity.Property(e => e.Fax).HasColumnType("NVARCHAR(24)");

                entity.Property(e => e.FirstName).HasColumnType("NVARCHAR(40)");

                entity.Property(e => e.LastName).HasColumnType("NVARCHAR(20)");

                entity.Property(e => e.Phone).HasColumnType("NVARCHAR(24)");

                entity.Property(e => e.PostalCode).HasColumnType("NVARCHAR(10)");

                entity.Property(e => e.State).HasColumnType("NVARCHAR(40)");

                entity.HasOne(d => d.SupportRep)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.SupportRepId);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.HasIndex(e => e.ReportsTo, "IFK_EmployeeReportsTo");

                entity.Property(e => e.Address).HasColumnType("NVARCHAR(70)");

                entity.Property(e => e.BirthDate).HasColumnType("DATETIME");

                entity.Property(e => e.City).HasColumnType("NVARCHAR(40)");

                entity.Property(e => e.Country).HasColumnType("NVARCHAR(40)");

                entity.Property(e => e.Email).HasColumnType("NVARCHAR(60)");

                entity.Property(e => e.Fax).HasColumnType("NVARCHAR(24)");

                entity.Property(e => e.FirstName).HasColumnType("NVARCHAR(20)");

                entity.Property(e => e.HireDate).HasColumnType("DATETIME");

                entity.Property(e => e.LastName).HasColumnType("NVARCHAR(20)");

                entity.Property(e => e.Phone).HasColumnType("NVARCHAR(24)");

                entity.Property(e => e.PostalCode).HasColumnType("NVARCHAR(10)");

                entity.Property(e => e.State).HasColumnType("NVARCHAR(40)");

                entity.Property(e => e.Title).HasColumnType("NVARCHAR(30)");

                entity.HasOne(d => d.ReportsToNavigation)
                    .WithMany(p => p.InverseReportsToNavigation)
                    .HasForeignKey(d => d.ReportsTo);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genres");

                entity.Property(e => e.Name).HasColumnType("NVARCHAR(120)");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoices");

                entity.HasIndex(e => e.CustomerId, "IFK_InvoiceCustomerId");

                entity.Property(e => e.BillingAddress).HasColumnType("NVARCHAR(70)");

                entity.Property(e => e.BillingCity).HasColumnType("NVARCHAR(40)");

                entity.Property(e => e.BillingCountry).HasColumnType("NVARCHAR(40)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("NVARCHAR(10)");

                entity.Property(e => e.BillingState).HasColumnType("NVARCHAR(40)");

                entity.Property(e => e.InvoiceDate).HasColumnType("DATETIME");

                entity.Property(e => e.Total).HasColumnType("NUMERIC(10,2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceItem>(entity =>
            {
                entity.HasKey(e => e.InvoiceLineId);

                entity.ToTable("invoice_items");

                entity.HasIndex(e => e.InvoiceId, "IFK_InvoiceLineInvoiceId");

                entity.HasIndex(e => e.TrackId, "IFK_InvoiceLineTrackId");

                entity.Property(e => e.UnitPrice).HasColumnType("NUMERIC(10,2)");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.InvoiceItems)
                    .HasForeignKey(d => d.TrackId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MediaType>(entity =>
            {
                entity.ToTable("media_types");

                entity.Property(e => e.Name).HasColumnType("NVARCHAR(120)");
            });

            modelBuilder.Entity<Playlist>(entity =>
            {
                entity.ToTable("playlists");

                entity.Property(e => e.Name).HasColumnType("NVARCHAR(120)");

                entity.HasMany(d => d.Tracks)
                    .WithMany(p => p.Playlists)
                    .UsingEntity<Dictionary<string, object>>(
                        "PlaylistTrack",
                        l => l.HasOne<Track>().WithMany().HasForeignKey("TrackId").OnDelete(DeleteBehavior.ClientSetNull),
                        r => r.HasOne<Playlist>().WithMany().HasForeignKey("PlaylistId").OnDelete(DeleteBehavior.ClientSetNull),
                        j =>
                        {
                            j.HasKey("PlaylistId", "TrackId");

                            j.ToTable("playlist_track");

                            j.HasIndex(new[] { "TrackId" }, "IFK_PlaylistTrackTrackId");
                        });
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.ToTable("tracks");

                entity.HasIndex(e => e.AlbumId, "IFK_TrackAlbumId");

                entity.HasIndex(e => e.GenreId, "IFK_TrackGenreId");

                entity.HasIndex(e => e.MediaTypeId, "IFK_TrackMediaTypeId");

                entity.Property(e => e.Composer).HasColumnType("NVARCHAR(220)");

                entity.Property(e => e.Name).HasColumnType("NVARCHAR(200)");

                entity.Property(e => e.UnitPrice).HasColumnType("NUMERIC(10,2)");
                entity.Property(e => e.Status).HasColumnType("NVARCHAR(200)")
                .HasDefaultValue("Active");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Tracks)
                    .HasForeignKey(d => d.AlbumId);

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Tracks)
                    .HasForeignKey(d => d.GenreId);

                entity.HasOne(d => d.MediaType)
                    .WithMany(p => p.Tracks)
                    .HasForeignKey(d => d.MediaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}