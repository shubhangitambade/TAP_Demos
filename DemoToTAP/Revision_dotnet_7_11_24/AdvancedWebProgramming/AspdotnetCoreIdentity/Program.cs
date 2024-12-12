using Microsoft.AspNetCore.Authentication.Cookies;

namespace AspdotnetCoreIdentity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            //Step 1 : Add authentication services middleware
            /*In ConfigureServices method of Startup.cs, create an Authentication Middleware Services with the
             * AddAuthentication and AddCookie method. 
             * Authentication scheme passed to AddAuthentication sets to the default authentication scheme for the app.
             * CookieAuthenticationDefaults.AuthenticationScheme provides “Cookies” for the scheme.
             * In AddCookie extension method, set the LoginPath property of CookieAuthenticationOptions
             * to “/account/login”. 
             * CookieAuthenticationOptions class is used to configure the authentication provider options.*/
 

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Account/Login"; // Specify login path
                    options.AccessDeniedPath = "/Account/AccessDenied"; // Access Denied Path
                    options.LogoutPath = "/Account/Logout";
                });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //Step 2 : call UseAuthentication and UseAuthorization method before calling the endpoints.
            //Step 3 : is in Controller
            app.UseAuthentication();
           
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
