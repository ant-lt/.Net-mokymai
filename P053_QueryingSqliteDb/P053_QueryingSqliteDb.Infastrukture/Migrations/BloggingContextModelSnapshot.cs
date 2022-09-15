﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P053_QueryingSqliteDb.Infastrukture.Database;

#nullable disable

namespace P053_QueryingSqliteDb.Infastrukture.Migrations
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("P053_QueryingSqliteDb.Domain.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("P053_QueryingSqliteDb.Domain.Models.AuthorBlog", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthorId", "BlogId");

                    b.HasIndex("BlogId");

                    b.ToTable("AuthorBlogs");
                });

            modelBuilder.Entity("P053_QueryingSqliteDb.Domain.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("BlogName")
                        .HasColumnOrder(1);

                    b.Property<decimal>("Rating")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.HasKey("BlogId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("P053_QueryingSqliteDb.Domain.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("P053_QueryingSqliteDb.Domain.Models.AuthorBlog", b =>
                {
                    b.HasOne("P053_QueryingSqliteDb.Domain.Models.Author", "Author")
                        .WithMany("AuthorBlogs")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P053_QueryingSqliteDb.Domain.Models.Blog", "Blog")
                        .WithMany("AuthorBlogs")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("P053_QueryingSqliteDb.Domain.Models.Post", b =>
                {
                    b.HasOne("P053_QueryingSqliteDb.Domain.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("P053_QueryingSqliteDb.Domain.Models.Author", b =>
                {
                    b.Navigation("AuthorBlogs");
                });

            modelBuilder.Entity("P053_QueryingSqliteDb.Domain.Models.Blog", b =>
                {
                    b.Navigation("AuthorBlogs");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
