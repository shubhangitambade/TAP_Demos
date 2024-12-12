
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StudentPortalWebAPI.Data;
using StudentPortalWebAPI.Services;

namespace StudentWebAPI
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

            builder.Services.AddScoped<IStudentService, StudentService>();
            //register the databse with the application in Program.cs file

            builder.Services.AddDbContext<StudentPortalDbContext>(options =>{
                options.UseMySQL(builder.Configuration.GetConnectionString("schoolPortal"));

            });


            builder.Services.AddControllers().AddNewtonsoftJson(delegate (MvcNewtonsoftJsonOptions options)
            {
                options.SerializerSettings.ReferenceLoopHandling = (ReferenceLoopHandling)1;
            });

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
        }
    }
}


/*
 
Due to the one to many relationship of Student and Address classes, 
the List of Address objects are added in the student entity and Student entity is added in the
Address entity. This can leed to a unlimited looping exception. 
To avoid the same add the ‘Microsoft.AspNetCore.Mvc.NewtonsoftJson’ nuget package to the class and 
add the following line of code in the Program.cs file.


builder.Services.AddControllers().AddNewtonsoftJson(delegate(MvcNewtonsoftJsonOptions options)
{
 options.SerializerSettings.ReferenceLoopHandling = (ReferenceLoopHandling)1;
});
 */