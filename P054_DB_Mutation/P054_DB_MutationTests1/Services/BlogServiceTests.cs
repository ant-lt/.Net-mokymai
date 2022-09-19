using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using P054_DB_Mutation.Database.Models;
using P054_DB_Mutation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P054_DB_Mutation.Services.Tests
{
    [TestClass()]
    public class BlogServiceTests
    {
        private Mock<ManageDb> mock_ManageDb = new Mock<ManageDb>();

        [TestMethod()]
        public void GetBlogsTest()
        {
            //ManageDb manageDb = new ManageDb();
            mock_ManageDb.Setup(m => m.GetBlogs()).Returns(
                new List<Blog>
                {
                    new Blog { BlogId = 1, Name = "Kulinarija", Rating = 1 }
                });
            BlogService service = new BlogService(mock_ManageDb.Object);
            var actual = service.GetBlogs();


            Assert.IsTrue(actual.Any(x => x.Name == "Kulinarija"));
        }
    }
}