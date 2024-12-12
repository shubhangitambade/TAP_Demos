using Microsoft.AspNetCore.Authentication.Cookies;
using Product_MVCWebApplication.Data;

namespace Product_MVCWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Add Service for CookiesAuthentication
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Account/Login";
                    options.LogoutPath = "/Account/Logout";
                });
                    //Add DbContext Service
                    builder.Services.AddDbContext<ProductDbContext>();

                    var app = builder.Build();

                    // Configure the HTTP request pipeline.
                    if (!app.Environment.IsDevelopment())
                    {
                        app.UseExceptionHandler("/Home/Error");
                    }

                    //When we install BootStrap from Nget Pckage Manager
                    //In order to serve the static files like js, CSS, images, etc
                    //.we need to UseStaticFiles middleware in Configure method.

                    app.UseStaticFiles();

                    app.UseRouting();

                    app.UseAuthentication();

                    app.UseAuthorization();

                    app.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");

                    app.Run();
                }
        }
    }

