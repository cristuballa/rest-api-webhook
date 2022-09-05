// See https://aka.ms/new-console-template for more information

global using System.Text.Json;
global using FastEndpoints;

using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using RMSRestApiWebHook.Database;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();

var connectionstring = builder.Configuration.GetConnectionString("SqlConnection");

builder.Services.AddSwaggerDoc( setting=>
{
    setting.Title = "My Api";
    setting.Version = "v1";
});


builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionstring));

var app = builder.Build();
app.UseFastEndpoints();
app.UseOpenApi();
app.UseSwaggerUi3(x=>x.ConfigureDefaults());

app.Run();


