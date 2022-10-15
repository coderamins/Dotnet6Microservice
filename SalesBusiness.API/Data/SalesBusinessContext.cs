using SalesBusiness.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace SalesBusiness.Api.Data
{
    public class SalesBusinessContext:DbContext
    {
        public SalesBusinessContext(DbContextOptions<SalesBusinessContext> options):base(options)
        {
            
        }
        
        public DbSet<Orders> Orders { get; set; } 
    }
}