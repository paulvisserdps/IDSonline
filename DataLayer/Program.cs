using Microsoft.EntityFrameworkCore;
using DataLayer.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AzureContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();