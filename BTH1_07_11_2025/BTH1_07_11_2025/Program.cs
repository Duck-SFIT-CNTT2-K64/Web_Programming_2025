namespace BTH1_07_11_2025
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
                name: "AdminStudentList",
                pattern: "Admin/Student/List",
                defaults: new { controller = "Student", action = "Index" }
               );

            app.MapControllerRoute(
                name: "AdminStudentAdd", 
                pattern: "Admin/Student/Add",
                defaults: new { controller = "Student", action = "Create" }
            );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
