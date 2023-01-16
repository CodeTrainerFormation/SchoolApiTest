using Dal;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<SchoolContext>(options =>
{
    //options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDb"));
    options.UseInMemoryDatabase("SchoolDbInMemory");
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseStaticFiles();

app.MapControllers();

app.Run();

