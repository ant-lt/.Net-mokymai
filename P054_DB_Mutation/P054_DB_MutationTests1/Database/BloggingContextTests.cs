using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P054_DB_Mutation.Database;
using P054_DB_Mutation.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P054_DB_Mutation.Database.Tests
{


    [TestClass()]
    public class BloggingContextTests
    {
        private BloggingContext context;

        [TestInitialize]
        public void OnInit()
        {
            var options = new DbContextOptionsBuilder<BloggingContext>()
                .UseInMemoryDatabase(databaseName: "Blogging")
                .Options;
            context = new BloggingContext(options);
            context.Blogs.Add(new Blog { BlogId = 1, Name = "Programavimas", Rating = 1 });
            context.Blogs.Add(new Blog { BlogId = 2, Name = "Knygos", Rating = 0 });
            context.Posts.Add(new Post { PostId = 1, BlogId = 1, Title = "CSharp", Content = "Tektas" });
            context.Posts.Add(new Post { PostId = 2, BlogId = 1, Title = "SQL", Content = "Tektas" });
            context.SaveChanges();
        }



        [TestMethod()]
        public void AddBlogTest()
        {
            var post = context.Posts.Find(2);
            post.Title = "SQL Server";
            context.SaveChanges();

            Assert.IsTrue(context.Posts.Any(x => x.Title == "CSharp"));
            Assert.IsTrue(context.Posts.Any(x => x.Title == "SQL Server"));
            Assert.IsFalse(context.Posts.Any(x => x.Title == "SQL"));
        }
    }
}