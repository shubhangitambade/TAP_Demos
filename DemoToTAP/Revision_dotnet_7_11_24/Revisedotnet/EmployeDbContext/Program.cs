using Microsoft.EntityFrameworkCore;
using EmployeDbContext.DbContex;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using EmployeDbContext.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<EmployeeDBContext>();  //(db => db.UseMySQL(builder.Configuration.GetConnectionString("conString")), ServiceLifetime.Singleton);
builder.Services.AddAuthentication();
builder.Services.AddSingleton<UserService>();

//The registered authentication handlers and their configuration options are called "schemes".
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
  .AddCookie(
    options =>
    {
        options.LoginPath = "/login/LogIn";
        options.LoginPath = "/login/LogOut";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=LogIn}/{id?}");

app.Run();
