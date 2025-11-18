using Azure.Identity;
using PeapleIO.API.Endpoints;
using PeopleIO.Application;
using PeopleIO.Infrastructure;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureKeyVault(
    new Uri(builder.Configuration["KeyVault:Url"]!),
    new DefaultAzureCredential());

builder.Services.AddInfraestructure(builder.Configuration);
builder.Services.AddApplication();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.MapColaboradorEndpoints();

app.Run();