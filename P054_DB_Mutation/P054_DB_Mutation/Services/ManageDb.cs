using P054_DB_Mutation.Database.Models;
using P054_DB_Mutation.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace P054_DB_Mutation.Services
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
