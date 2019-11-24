using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions<BlogDBContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }
    }

    public class BlogDBContextFactory : IDesignTimeDbContextFactory<BlogDBContext>
    {
        public BlogDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BlogDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=BlogDB; Trusted_Connection=true;");

            return new BlogDBContext(optionsBuilder.Options);
        }
    }
}