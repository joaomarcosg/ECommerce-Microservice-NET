using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StockService.Infrastructure.Data
{
    public class StockServiceContext : DbContext
    {
        public StockServiceContext(DbContextOptions<StockServiceContext>options) : base(options)
        {
            
        }
        
        public DbSet<StockService.Domain.Entities.Product> Products { get; set; }
        
    }
}