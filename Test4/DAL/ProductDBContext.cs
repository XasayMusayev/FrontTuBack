using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test4.Models;

namespace Test4.DAL
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> opt) : base(opt)
        {

        }

        public DbSet<Service> services { get; set; }
    }
}
