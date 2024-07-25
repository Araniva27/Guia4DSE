using Biblioteca.BL;
using Biblioteca.BL.AutoMapper;
using Biblioteca.BL.Interfaces;
using Biblioteca.Common;
using Biblioteca.DAL;
using Biblioteca.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

builder.Services.AddAutoMapper(typeof(AutomapperProfile));
builder.Services.AddScoped<IDatabaseRepository, DatabaseRepository>(); // Registrar DatabaseRepository
builder.Services.AddScoped<IAutorRepository, AutorRepository>(); // Registrar AutorRepository
builder.Services.AddScoped<IAutorService, AutorService>(); // Registrar AutorService

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
