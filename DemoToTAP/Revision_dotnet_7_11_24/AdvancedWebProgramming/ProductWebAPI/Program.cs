using Microsoft.AspNetCore.Authentication.Cookies;
using ProductWebAPI.Data;

namespace ProductWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Dbcontext service
            builder.Services.AddDbContext<ProductDbContext>();
            var app = builder.Build();

            //Add Cookie Authentication Service :Step 1
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
             .AddCookie(options => 
             {
                 options.LoginPath = "/Account/Login";
                 options.LogoutPath = "/Account/Logout";
                
            });



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();    //Step 2
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
