using Microsoft.EntityFrameworkCore;
using P053_QueryingSqliteDb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P053_QueryingSqliteDb.Infastrukture.Database
{
    public class ManageDb
    {
        public ManageDb()
        {
            using var context = new BloggingContext();
            context.Database.EnsureCreated();
        }

        public void AddBlog(string name)
        {
            using var context = new BloggingContext();
            context.Blogs.Add(new Blog { Name = name });
            context.SaveChanges();
        }

        public void AddPost(string title, int blogId)
        {
            using var context = new BloggingContext();
            var blog = context.Blogs.Find(blogId);
            blog.Posts.Add(new Post { Title = title });
            context.SaveChanges();
        }

        public void AddAuthor(string firstName, string lastName, int blogId)
        {
            using var context = new BloggingContext();
            context.AuthorBlogs.Add(
                new AuthorBlog
                {
                    Author = new Author
                    {
                        FirstName = firstName,
                        LastName = lastName
                    },
                    BlogId = blogId
                });

            context.SaveChanges();
        }

        public void GetBlogs_EagerLoading()
        {
            using var context = new BloggingContext();
            var blogs = context.Blogs
                .Include(b => b.Posts); // EagerLoading yra naudojamas pridedant zodi Include() ir jo viduje nurodome navigacine property
            foreach (var blog in blogs)
            {
                Console.WriteLine($"** {blog.BlogId} {blog.Name}");
                foreach (var post in blog.Posts)
                {
                    Console.WriteLine($"- {post.PostId} {post.Title}");
                }
            }
        }

        public void GetBlogs_LazyLoading()
        {
            using var context = new BloggingContext();
            var blogs = context.Blogs
                .ToList(); // Lazy Loading automatiskai isgaudo visus priklausancius objektus kartu su isgaunamu objektu/irasu
            foreach (var blog in blogs)
            {
                Console.WriteLine($"** {blog.BlogId} {blog.Name}");
                foreach (var post in blog.Posts)
                {
                    Console.WriteLine($"- {post.PostId} {post.Title}");
                }
            }
        }
    }
}
