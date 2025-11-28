using Azure.Identity;
using PeapleIO.API.Endpoints;
using PeopleIO.Application;
using PeopleIO.Infrastructure;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var origins = "allowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(origins, policy =>
    {
        policy
            .WithOrigins("http://localhost:5173","https://red-flower-08bf62a0f.3.azurestaticapps.net/")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

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
app.UseCors(origins);
app.MapColaboradorEndpoints();

app.Run();