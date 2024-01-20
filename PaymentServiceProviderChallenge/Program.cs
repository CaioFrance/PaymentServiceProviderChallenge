using Microsoft.EntityFrameworkCore;
using PaymentServiceProviderChallenge.Infra.Contexts;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;
var Services = builder.Services;

// Add services to the container.
Services.AddDbContext<TransactionContext>(
    options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
    opt => opt.MigrationsHistoryTable("_EfMirations", Configuration.GetSection("Schema").GetSection("DatabaseSchema").Value)));

Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
Services.AddEndpointsApiExplorer();
Services.AddSwaggerGen();


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
