using BuiHaiDuc_231230747_de02.Models;
using Microsoft.EntityFrameworkCore;

namespace BuiHaiDuc_231230747_de02.Data
{
    public class BuiHaiDuc_231230747_de02Context : DbContext
    {
        public BuiHaiDuc_231230747_de02Context(DbContextOptions<BuiHaiDuc_231230747_de02Context> options) : base(options)
        {

        }

        public DbSet<BhdCatalog> bhdCatalog { get; set; }
    }
}
