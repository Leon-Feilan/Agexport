using Factura.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<FacturaDetailContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
//builder.Services.AddDbContext<ProductoDetailContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
//builder.Services.AddDbContext<ConsumidorDetailContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
builder.Services.AddDbContext<MainContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());//useful for accessing API (it solved the issue of the first calling)

app.UseAuthorization();

app.MapControllers();

app.Run();
