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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Containers>().ToTable("Container");
        }
    }
}
