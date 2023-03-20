﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P04_EF_Applying_To_API.Data;

#nullable disable

namespace P04EFApplyingToAPI.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("P04_EF_Applying_To_API.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpiceLevel")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("DishId");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            Country = "Lithuanian",
                            CreateDateTime = new DateTime(2022, 12, 21, 18, 21, 16, 955, DateTimeKind.Local).AddTicks(1216),
                            ImagePath = "gg",
                            Name = "Fried Bread Sticks",
                            SpiceLevel = "Mild",
                            Type = "Snacks",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DishId = 2,
                            Country = "Lithuanian",
                            CreateDateTime = new DateTime(2022, 12, 21, 18, 21, 16, 955, DateTimeKind.Local).AddTicks(1254),
                            ImagePath = "gg",
                            Name = "Potato dumplings",
                            SpiceLevel = "Low",
                            Type = "Main dish",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DishId = 3,
                            Country = "Lithuanian",
                            CreateDateTime = new DateTime(2022, 12, 21, 18, 21, 16, 955, DateTimeKind.Local).AddTicks(1256),
                            ImagePath = "gg",
                            Name = "Kibinai",
                            SpiceLevel = "Low",
                            Type = "Street food",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("P04_EF_Applying_To_API.Models.DishOrder", b =>
                {
                    b.Property<int>("DishOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DishId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DishOrderId");

                    b.HasIndex("DishId");

                    b.HasIndex("LocalUserId");

                    b.ToTable("DishOrders");
                });

            modelBuilder.Entity("P04_EF_Applying_To_API.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");
                });

            modelBuilder.Entity("P04_EF_Applying_To_API.Models.RecipeItem", b =>
                {
                    b.Property<int>("RecipeItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Calories")
                        .HasColumnType("REAL");

                    b.Property<int>("DishId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RecipeItemId");

                    b.HasIndex("DishId");

                    b.ToTable("RecipeItems");

                    b.HasData(
                        new
                        {
                            RecipeItemId = 1,
                            Calories = 150.0,
                            DishId = 1,
                            Name = "Bread"
                        },
                        new
                        {
                            RecipeItemId = 2,
                            Calories = 300.0,
                            DishId = 1,
                            Name = "Cheese"
                        },
                        new
                        {
                            RecipeItemId = 3,
                            Calories = 300.0,
                            DishId = 1,
                            Name = "Mayo"
                        },
                        new
                        {
                            RecipeItemId = 4,
                            Calories = 50.0,
                            DishId = 1,
                            Name = "Garlic"
                        },
                        new
                        {
                            RecipeItemId = 5,
                            Calories = 400.0,
                            DishId = 2,
                            Name = "Potatoes"
                        },
                        new
                        {
                            RecipeItemId = 6,
                            Calories = 400.0,
                            DishId = 2,
                            Name = "Meat"
                        },
                        new
                        {
                            RecipeItemId = 7,
                            Calories = 300.0,
                            DishId = 2,
                            Name = "Sour Cream"
                        },
                        new
                        {
                            RecipeItemId = 8,
                            Calories = 300.0,
                            DishId = 3,
                            Name = "Dough"
                        },
                        new
                        {
                            RecipeItemId = 9,
                            Calories = 200.0,
                            DishId = 3,
                            Name = "Meat"
                        },
                        new
                        {
                            RecipeItemId = 10,
                            Calories = 150.0,
                            DishId = 3,
                            Name = "Salt"
                        });
                });

            modelBuilder.Entity("P04_EF_Applying_To_API.Models.DishOrder", b =>
                {
                    b.HasOne("P04_EF_Applying_To_API.Models.Dish", "Dish")
                        .WithMany("DishOrders")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("P04_EF_Applying_To_API.Models.LocalUser", "LocalUser")
                        .WithMany("DishOrders")
                        .HasForeignKey("LocalUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("LocalUser");
                });

            modelBuilder.Entity("P04_EF_Applying_To_API.Models.RecipeItem", b =>
                {
                    b.HasOne("P04_EF_Applying_To_API.Models.Dish", "Dish")
                        .WithMany("RecipeItems")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("P04_EF_Applying_To_API.Models.Dish", b =>
                {
                    b.Navigation("DishOrders");

                    b.Navigation("RecipeItems");
                });

            modelBuilder.Entity("P04_EF_Applying_To_API.Models.LocalUser", b =>
                {
                    b.Navigation("DishOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
