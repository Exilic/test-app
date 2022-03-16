using System;
using Microsoft.EntityFrameworkCore;
using ReactBackend.Models;

namespace ReactBackend.Data
{
    public class ReactDbContext : DbContext
    {
        public ReactDbContext(DbContextOptions<ReactDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<SalesProduct> SalesProducts { get; set; }

    }
}
