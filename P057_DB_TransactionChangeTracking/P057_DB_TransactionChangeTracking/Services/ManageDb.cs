using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P057_DB_TransactionChangeTracking.Database.Models;
using P057_DB_TransactionChangeTracking.Database;

namespace P057_DB_TransactionChangeTracking.Services
{
    public class ManageDb
    {
        public ManageDb()
        {
            using (var context = new BloggingContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public List<Blog> GetBlogsNoTracking()
        {
            using (var context = new BloggingContext())
            {
                // Kada trackinam irasus mums nebereikia rasyti context.Update, nes visi pokyciai atsiranda automatiskai
                var postsHighRate = context.Posts
                        .Include(p => p.Blog) // Eager Loading
                        .Where(p => p.Blog.Rating >= 5);

                var firstBlog = postsHighRate.FirstOrDefault();
                firstBlog.Title = "Unknown"; // Sis irasas yra tracked

                context.SaveChanges();

                // Isjungiam tracking'a ir padarom uzklausa labai greita
                var blogsNoTrackings = context.Blogs
                    .Include(b => b.Posts)
                    .AsNoTracking();

                var firstBlogNoTracking = blogsNoTrackings.FirstOrDefault();
                firstBlogNoTracking.Name = "Unknown"; // Sis irasas yra tracked

                // context.Update() // Reikia tureti Update jei nebenaudojam tracking

                context.SaveChanges();

                return blogsNoTrackings.ToList();
            }
        }


        public void UpdateBlogToVipBlog()
        {
            using (var context = new BloggingContext())
            {

                // Pradedame scoped tranzakcija
                // Scoped transaction -> reikalinga tada kada norime uztikrinti, kad keli is eiles einantys metodai
                // Turetu savo transakcija ir jei nors vienas is ju fail'intu mes galetume grizti i pradine busena
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    // ExecuteSqlRaw yra atliekamas iskart (Po panaudojimo pats call'ina context.SaveChanges())
                    context.Database.ExecuteSqlRaw(
                        @"UPDATE Blogs
                      SET Rating = 5
                      WHERE Name LIKE 'Programavimas'");

                    var postsHighRate = context.Posts
                        .Include(p => p.Blog) // Eager Loading
                        .Where(p => p.Blog.Rating >= 5);

                    foreach (var post in postsHighRate)
                    {
                        post.Title += "[PREMIUM]";
                    }

                    context.SaveChanges();

                    dbContextTransaction.Commit();
                }

            }
                
        }



        public void GetBlogs_EagerLoading()
        {
            using (var context = new BloggingContext())
            {
                var blogs = context.Blogs.Include(b => b.Posts);
                foreach (var blog in blogs)
                {
                    System.Console.WriteLine($"** {blog.BlogId} {blog.Name}");
                    foreach (var post in blog.Posts)
                    {
                        System.Console.WriteLine($"-{post.PostId}. {post.Title}");
                    }
                }
            }
        }

        // testuojamas metodas turi buti virtualus
        public virtual List<Blog> GetBlogs()
        {
            using (var context = new BloggingContext())
            {
                var blogs = context.Blogs.Include(b => b.Posts);
                return blogs.ToList();
            }

        }



        public void AddBlog(string name)
        {
            using (var context = new BloggingContext())
            {
                context.Blogs.Add(new Blog { Name = name });
                context.SaveChanges();
            }
        }

        public void UpdateBlog(int blogId, string name)
        {
            using (var context = new BloggingContext())
            {
                var blog = context.Blogs.Find(blogId);
                blog.Name = name;
                context.SaveChanges();
            }
        }


        public void UpdatePost(int postId, string title)
        {
            using (var context = new BloggingContext())
            {
                var post = context.Posts.Find(postId);
                post.Title = title;
                context.SaveChanges();
            }
        }
        public void DeletePost(int postId)
        {
            using (var context = new BloggingContext())
            {
                var post = context.Posts.Find(postId);
                context.Posts.Remove(post);
                context.SaveChanges();
            }
        }



        public void AddPost(string title, int blogId)
        {
            using (var context = new BloggingContext())
            {
                var blog = context.Blogs.Find(blogId);
                blog.Posts.Add(new Post { Title = title, Content = "", BlogId = blogId });
                context.SaveChanges();
            }
        }

    }
}
