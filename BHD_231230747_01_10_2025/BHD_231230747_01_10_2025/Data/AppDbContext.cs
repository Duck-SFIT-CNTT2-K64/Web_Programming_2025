using System.Collections.Generic;
using BHD_231230747_01_10_2025.Models;
using Microsoft.EntityFrameworkCore;

namespace BHD_231230747_01_10_2025.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();
    }
}
