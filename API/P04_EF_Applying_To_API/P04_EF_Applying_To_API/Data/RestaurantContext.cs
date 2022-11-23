using Microsoft.EntityFrameworkCore;
using P04_EF_Applying_To_API.Models;

namespace P04_EF_Applying_To_API.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {

        }
        // registruojamos lenteles
        // Prop pavadinimas = lenteles pavadinimas
        public DbSet<Disch> Disches { get; set; }
        public DbSet<RecipeItem> RecipeItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Dish>()
                .HasKey(d => d.DishId);
            modelBuilder.Entity<RecipeItem>()
                .HasKey(rc => rc.DishId);
            */

            // Data-seading
            modelBuilder.Entity<RecipeItem>()
                .HasData(
                    new Disch(1, "Fried Bread Sticks", "Snacks", "Mild", "Lithuanian", "gg", DateTime.Now),
                    new Disch(2, "Potato dumplings", "Main dish", "Low", "Lithuanian", "gg", DateTime.Now),
                    new Disch(3, "Kibinai", "Street food", "Low", "Lithuanian", "gg", DateTime.Now)
                    );

            modelBuilder.Entity<RecipeItem>()
                .HasData(
                    new RecipeItem(1, "Bread", 150, 1),
                    new RecipeItem(2, "Cheese", 300, 1),
                    new RecipeItem(3, "Mayo", 300, 1),
                    new RecipeItem(4, "Garlic", 50, 1),
                    new RecipeItem(5, "Potatoes", 400, 2),
                    new RecipeItem(6, "Meat", 400, 2),
                    new RecipeItem(7, "Sour Cream", 300, 2),
                    new RecipeItem(8, "Dough", 300, 3),
                    new RecipeItem(9, "Meat", 200, 3),
                    new RecipeItem(10, "Salt", 150, 3)
                );
        }


    }
}
