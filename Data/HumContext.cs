using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Курсач.Models;
using Microsoft.EntityFrameworkCore;

namespace Курсач.Data
{
    public class HumContext : DbContext
    {
        public HumContext(DbContextOptions<HumContext> options) : base(options)
        {
        }

        public DbSet<Containers> Container { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NonActiveContainers> NonActiveContainers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Containers>().ToTable("Container");
            modelBuilder.Entity<Category>().ToTable("Category"); // Змінено назву таблиці тут
            modelBuilder.Entity<NonActiveContainers>().ToTable("NonActiveContainers");
        }
    }
}
