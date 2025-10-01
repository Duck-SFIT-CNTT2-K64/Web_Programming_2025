using System;
using Microsoft.EntityFrameworkCore;
using BHD_231230747_01_10_2025.Data;
using BHD_231230747_01_10_2025.Models;

namespace BHD_231230747_01_10_2025
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(o => o.UseInMemoryDatabase("ShopDb"));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Products}/{action=Index}/{id?}");

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                if (!db.Categories.Any())
                {
                    db.Categories.AddRange(
                        new Category { Name = "Điện tử" },
                        new Category { Name = "Gia dụng" },
                        new Category { Name = "Thời trang" }
                    );
                    db.SaveChanges();
                }
            }

            app.Run();
        }
    }
}
