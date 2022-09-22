using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P053_QueryingSqliteDb_Namu_darbas.Database;
using P053_QueryingSqliteDb_Namu_darbas.Database.Models;
using P053_QueryingSqliteDb_Namu_darbas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb_Namu_darbas.Database.Tests
{
    [TestClass()]
    public class ShoeShopRepositoryTests
    {
        private ShoeShopContext context; 

        [TestInitialize]
        public void OnInit()
        {
            var options = new DbContextOptionsBuilder<ShoeShopContext>()
                .UseInMemoryDatabase(databaseName: "ShoeShopDB")
                .Options;

            context = new ShoeShopContext(options);
            context.Shoes.AddRange(new Shoes[]
           {
                new Shoes {
                    ShoeId = 1,
                    Name = "Kedai",
                    Type = "Vyriški",
                    Price = 100M,
                },
           });
            context.ShoeSizes.AddRange(new ShoeSize[]
            {
                new ShoeSize { Id = 1, ShoeID = 1, Size = 42, Quantity = 10 },
                new ShoeSize { Id = 2, ShoeID = 1, Size = 43, Quantity = 11 },
                new ShoeSize { Id = 3, ShoeID = 1, Size = 44, Quantity = 12 },
                new ShoeSize { Id = 4, ShoeID = 1, Size = 45, Quantity = 14 },
            });
            context.SaveChanges();
        }


        [TestMethod()]
        public void MakePurchaseAndReduceQuantityTest()
        {
            IShoeShopRepository shoesShop = new ShoeShopRepository(context);
            shoesShop.MakePurchaseAndReduceQuantity(2, 5);

            Assert.AreEqual(6, context.ShoeSizes.Find(2).Quantity); // veikia
            var shoes = context.Sales.Include(ShoeSize => ShoeSize.ShoeSize).First(x => x.ShoeSizeId == 2).Pairs;

          // Assert.AreEqual(5, context.Sales.First(x => x.ShoeSizeId == 2).Pairs); // neveikia
            Assert.AreEqual(5, shoes); // neveikia
         //    Assert.AreEqual(500, context.Sales.First(x => x.ShoeSizeId == 2).PurchaseTotal);// neveikia
        }


    }
}