using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PeopleIO.Application.Mappers;
using PeopleIO.Application.Services;
using PeopleIO.Application.Services.Colaborador.Delete;
using PeopleIO.Application.Services.Colaborador.GetAll;
using PeopleIO.Application.Services.Colaborador.GetById;
using PeopleIO.Application.Services.Colaborador.Register;

namespace PeopleIO.Application;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddServices(services);
    }
    
    private static void AddServices(this IServiceCollection services)
    {
        MapsterConfig.RegisterMappings();
        services.AddSingleton<BlobStorageService>();
        services.AddScoped<IRegisterColaboradorService, RegisterColaboradorService>();
        services.AddScoped<IGetAllColaboradoresService, GetAllColaboradoresService>();
        services.AddScoped<IGetColaboradorByIdService, GetColaboradorByIdService>();
        services.AddScoped<IRemoveColaboradorService, RemoveColaboradorService>();

    }
}