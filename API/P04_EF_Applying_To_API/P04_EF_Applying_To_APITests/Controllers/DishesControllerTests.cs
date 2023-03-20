using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using P04_EF_Applying_To_API.Repository.IRepository;
using P04_EF_Applying_To_API.Services.Adapters.IAdapters;
using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using P04_EF_Applying_To_API.Data;
using Microsoft.EntityFrameworkCore;

namespace Tests
{
    [TestClass()]
    public class DishesControllerTests
    {
        [TestMethod()]
        public async Task GetDishesTest_ShouldReturnDishes()
        {
            // Arrange
            var dish_repository_mock = new Mock<IDishRepository>();
            var dish_adapter_mock = new Mock<IDishAdapter>();
            var fakeObj = new List<Dish>
            {
                new Dish {DishId = 1, Name = "First dish", Type = "Test type", SpiceLevel = "Very spicy", Country = "Test country",
                RecipeItems= new List<RecipeItem> ()},
                new Dish {DishId = 2, Name = "Second dish", Type = "Test type", SpiceLevel = "Not spicy", Country = "Test country",
                RecipeItems= new List<RecipeItem> ()},

            };

            var expected = new List<GetDishDTO>
            {
                new GetDishDTO(fakeObj[0]),
                new GetDishDTO(fakeObj[1]),
            };

            dish_repository_mock.Setup(d => d.GetAllAsync(It.IsAny<Expression<Func<Dish, bool>>>()))
                .ReturnsAsync(fakeObj);

            var dishController = new DishesController(dish_repository_mock.Object, dish_adapter_mock.Object);

            // Act
            var sut = await dishController.GetDishes() as OkObjectResult;

            //Assert

            Assert.AreEqual(expected[0].Name, (sut.Value as List<GetDishDTO>)[0].Name);
            Assert.AreEqual(expected[1].Name, (sut.Value as List<GetDishDTO>)[1].Name);
        }

        [TestMethod()]
        public async Task GetDishesTest_ShouldReturnDishes2()
        {
            // Arrange
            var dish_repository_mock = new Mock<IDishRepository>();
            var dish_adapter_mock = new Mock<IDishAdapter>();

            var db_context_mock = new Mock<RestaurantContext>();

            /// cia dar truksta , neveikia setup
            db_context_mock.Setup(d => d.Dishes);

            db_context_mock.Object.Dishes.Count();



            // Act

            //Assert

            Assert.IsNotNull(db_context_mock);
           
        }


    }
}