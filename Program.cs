using Microsoft.EntityFrameworkCore;
using TodoList.Models;
using TodoList.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

// Inyección de dependencias
builder.Services.AddScoped<ITareaService, TareasServicesInMemory>();

// Entity Framework
// Inyección de contexto de base de datos
builder.Services.AddDbContext<TareasContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TareasConnection"));
});

builder.Services.AddOpenApi();
// Añadir el servicio Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
