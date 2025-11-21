using Microsoft.EntityFrameworkCore;
using BuiHaiDuc_231230747_de02.Data;

namespace BuiHaiDuc_231230747_de02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString("BhdConn");

            // Use the actual DbContext type (not the namespace)
            builder.Services.AddDbContext<BuiHaiDuc_231230747_de02Context>(options =>
                options.UseSqlServer(connectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=BhdHome}/{action=BhdIndex}/{id?}");

            app.Run();
        }
    }
}
