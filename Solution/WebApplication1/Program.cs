using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication1.Application.Services;
using WebApplication1.Domain.Interfaces;
using WebApplication1.Infrastructure.Context;
using WebApplication1.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Entity Framework Conection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Repositories and services
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<IActorRepository, ActorRepository>();
builder.Services.AddScoped<ActorService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<MovieService>();

// Configuracion de servicios
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin() // Permitir cualquier origen
               .AllowAnyMethod() // Permitir cualquier metodo (GET, POST, etc.)
               .AllowAnyHeader(); // Permitir cualquier encabezado
    });
});

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
