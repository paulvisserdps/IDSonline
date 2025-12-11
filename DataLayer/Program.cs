using Microsoft.EntityFrameworkCore;
using DataLayer.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AzureContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();