using EmployeeWebAPI;
using EmployeeWebAPI.Services;
using Microsoft.EntityFrameworkCore;
using System.Data;
//using EmployeeWebAPI.EmployeeDbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IEmployeeService, EmployeeService>();
//builder.Services.AddDbContext<EmployeeDbContext>(db => db.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<EmployeeDbContext>();
//builder.Services.AddDbContext<OurHeroDbContext>(db => db.UseSqlServer(builder.Configuration.GetConnectionString("OurHeroConnectionString")), ServiceLifetime.Singleton);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
