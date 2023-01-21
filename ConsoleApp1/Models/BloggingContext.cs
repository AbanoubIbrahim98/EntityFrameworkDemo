using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{

  // Databse config
    internal class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet <Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=Bebo-98\BEBO;Database=EF-ORM-LINQ;Trusted_Connection=True");
        }
    }
}
