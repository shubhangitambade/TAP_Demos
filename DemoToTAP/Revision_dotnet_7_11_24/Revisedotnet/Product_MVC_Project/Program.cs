using Microsoft.AspNetCore.Authentication.Cookies;
using Product_MVC_Project.Services;
using Product_MVC_Project.UserDbContext;
using Microsoft.EntityFrameworkCore;

namespace Product_MVC_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //Register the Product Service
            builder.Services.AddScoped<IProductService,ProductService>();
            //Register the User Service
            builder.Services.AddScoped<IUserService,UserService>();
            //Register UserDbContext
            builder.Services.AddDbContext<UserContext>();

            //The registered authentication handlers and their configuration options are called "schemes".
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(
                options =>
                {
                    options.LoginPath = "/Auth/Login";
                    options.LoginPath = "/Auth/Logout";
                }
                );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Auth}/{action=Login}/{id?}");

            app.Run();
        }
    }
}
