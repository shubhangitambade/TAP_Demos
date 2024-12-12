using StateManagement.Services;
using StateManagement.Helper;

namespace StateManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Register FlowerService
            builder.Services.AddTransient<IFlowerService, FlowerService>();

            builder.Services.AddDistributedMemoryCache();
            //setting session state enviornment at starup level
            builder.Services.AddSession(options => {
                options.Cookie.Name = ".Transflower.Session";
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            //ilder.Services.AddSession();  //Step 1: to set session management


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSession();   // Step 2:Add Session middleware to existing HTTP pipeline

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
