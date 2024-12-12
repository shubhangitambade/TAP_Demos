using Microsoft.EntityFrameworkCore;

using MySql.Data;
//using MySql.EntityFrameworkCore;

namespace Code_First_Approach_EF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString("UsersDbConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySQL(connectionString);    //,ServerVersion.AutoDetect(connectionString));
            });

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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}


/*
  Finally, Add Migrations and create the database

In the console run the following command to create the migrations file and also create the database.

dotnet ef migrations add init
dotnet ef database update
You will see that a folder named “Migrations” will be created, which is for initially setting up the database and tables.

*/