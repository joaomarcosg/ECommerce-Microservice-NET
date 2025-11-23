using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infra.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(255);
            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 2).IsRequired();
        }
    }
}