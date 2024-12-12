using DotnetCoreWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Register OurHeroService service in the Program.cs file as a Singleton.

builder.Services.AddSingleton<IOurHeroService, OurHeroService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
1. AddSingleton: a single object present across the application(In multiple controller same Object is shared)

2. AddScoped: One request for one instance (if we are injecting the same service more than once, then it will share the same instance.)

3. AddTransient: always create a new instance (if we are injecting the same service more than once, then it will provide a new instance every time.)
*/