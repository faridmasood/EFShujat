using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class DBInitializer
    {
        public static void SeedData(BlogDBContext dbContext)
        {
            if (!dbContext.Blog.Any())
            {
                dbContext.Blog.Add(new Entities.Blog
                {
                    Posts = new List<Entities.Post>() {
                    new Entities.Post
                    {
                      Title="Post One",
                      Descption="DESC",
                      Likes=0
                    },
                    new Entities.Post
                    {
                          Title="Post Two",
                      Descption="DESC",
                      Likes=0
                    }
                }
                });

                dbContext.SaveChanges();
            }
        }
    }
}