﻿// <auto-generated />
using System;
using BookWebApiRepo_MSSQL_EF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookWebApiRepoMSSQLEF.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20221227153708_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoverType")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("OwnedQty")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Years")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Kristina Pišniukaitė - Šimkienė",
                            CoverType = 0,
                            GenreId = 1,
                            OwnedQty = 1,
                            Title = "Ant medinės lentelės II",
                            Years = 2022
                        },
                        new
                        {
                            Id = 2,
                            Author = "Lina Žutautė",
                            CoverType = 1,
                            GenreId = 1,
                            OwnedQty = 2,
                            Title = "Kakė Makė ir magiška kelionė",
                            Years = 2022
                        },
                        new
                        {
                            Id = 3,
                            Author = "Santa Montefiore",
                            CoverType = 2,
                            GenreId = 1,
                            OwnedQty = 3,
                            Title = "Tolimi krantai",
                            Years = 2022
                        },
                        new
                        {
                            Id = 4,
                            Author = "Nino Haratischwili",
                            CoverType = 2,
                            GenreId = 2,
                            OwnedQty = 1,
                            Title = "Aštuntas gyvenimas (Brilkai)",
                            Years = 2022
                        },
                        new
                        {
                            Id = 5,
                            Author = "Kristina Pišniukaitė - Šimkienė",
                            CoverType = 2,
                            GenreId = 3,
                            OwnedQty = 2,
                            Title = "Ant medinės lentelės III",
                            Years = 2022
                        },
                        new
                        {
                            Id = 6,
                            Author = "Salman Rushdie",
                            CoverType = 1,
                            GenreId = 4,
                            OwnedQty = 3,
                            Title = "Kichotas",
                            Years = 2020
                        },
                        new
                        {
                            Id = 7,
                            Author = "Kristina Pišniukaitė - Šimkienė",
                            CoverType = 2,
                            GenreId = 5,
                            OwnedQty = 1,
                            Title = "Ant medinės lentelės IIV",
                            Years = 2022
                        });
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Fine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("FineAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("FineDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoanId")
                        .HasColumnType("int");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoanId");

                    b.HasIndex("LocalUserId");

                    b.ToTable("Fines");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pasaka"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Legenda"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Romanas"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fantastika"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("LocalUserId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserLevelId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserLevelId")
                        .IsUnique();

                    b.ToTable("LocalUsers");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("LocalUserId");

                    b.HasIndex("ReservationStatusId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.ReservationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReservationStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = "Active"
                        },
                        new
                        {
                            Id = 2,
                            Status = "Returned"
                        },
                        new
                        {
                            Id = 3,
                            Status = "Canceled"
                        });
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Secretary"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Librarian"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Reader"
                        });
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.UserLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PointsLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pradinukas",
                            PointsLevel = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Megejas",
                            PointsLevel = 2000
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ekspertas",
                            PointsLevel = 10000
                        },
                        new
                        {
                            Id = 4,
                            Name = "Guru",
                            PointsLevel = 25000
                        });
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Wishbook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("LocalUserId");

                    b.ToTable("Wishbooks");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Book", b =>
                {
                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.Genre", "Genres")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Fine", b =>
                {
                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.Loan", "Loan")
                        .WithMany()
                        .HasForeignKey("LoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.LocalUser", "LocalUser")
                        .WithMany()
                        .HasForeignKey("LocalUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loan");

                    b.Navigation("LocalUser");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Loan", b =>
                {
                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.Book", "Book")
                        .WithMany("Loans")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.LocalUser", "LocalUser")
                        .WithMany()
                        .HasForeignKey("LocalUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("LocalUser");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.LocalUser", b =>
                {
                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.UserLevel", "UserLevel")
                        .WithOne("LocalUser")
                        .HasForeignKey("BookWebApiRepo_MSSQL_EF.Models.LocalUser", "UserLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("UserLevel");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Reservation", b =>
                {
                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.Book", "Book")
                        .WithMany("Reservations")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.LocalUser", "LocalUser")
                        .WithMany()
                        .HasForeignKey("LocalUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.ReservationStatus", "ReservationStatus")
                        .WithMany("Reservations")
                        .HasForeignKey("ReservationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("LocalUser");

                    b.Navigation("ReservationStatus");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Wishbook", b =>
                {
                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookWebApiRepo_MSSQL_EF.Models.LocalUser", "LocalUser")
                        .WithMany()
                        .HasForeignKey("LocalUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("LocalUser");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Book", b =>
                {
                    b.Navigation("Loans");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.ReservationStatus", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("BookWebApiRepo_MSSQL_EF.Models.UserLevel", b =>
                {
                    b.Navigation("LocalUser")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}