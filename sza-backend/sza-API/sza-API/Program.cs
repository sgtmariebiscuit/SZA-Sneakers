using sza_API.Models;
using Services.Handlers;
using Repository.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.EntityFramework.Interface;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEntityRepository<Sneaker>, SneakerRepository>();
builder.Services.AddScoped<IHandler<Sneaker,Sneaker>,SneakerHandler>();


builder.Services.AddDbContext<SZADbContext>(options =>
    options.UseSqlServer(@"Data Source=.;Initial Catalog=SZADB;Integrated Security=True;Trust Server Certificate=True"));

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
