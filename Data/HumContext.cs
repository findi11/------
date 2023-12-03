using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Курсач.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Runtime.InteropServices;

namespace Курсач.Data
{
    public class HumContext : DbContext
    {
        public HumContext(DbContextOptions<HumContext> options) : base(options)
        {
        }

        public DbSet<Containers> Container { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<NonActiveContainers> NonActiveContainers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Containers>().ToTable("Container");
            modelBuilder.Entity<News>().ToTable("News");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Category>().ToTable("Category"); 
            modelBuilder.Entity<NonActiveContainers>().ToTable("NonActiveContainers");

            modelBuilder.Entity<NonActiveContainers>()
          .HasOne(c => c.Category)
          .WithMany(cat => cat.Containers)
          .HasForeignKey(c => c.CategoryID);
        }

        public DbSet<Курсач.Models.News> News { get; set; }

        public DbSet<Курсач.Models.User> User { get; set; }
    }
}
