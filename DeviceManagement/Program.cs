using Microsoft.EntityFrameworkCore;
using DeviceManagement.Models;
using DeviceManagement.Core.IServices;
using DeviceManagement.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<MobileContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("con"))
    );
builder.Services.AddScoped<IRegistrationService, RegisterService>();
builder.Services.AddScoped<IProductService, ProductService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
