using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PeopleIO.Application.Services;

namespace PeopleIO.Application;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        AddServices(services);
    }
    
    private static void AddServices(this IServiceCollection services)
    {
        services.AddSingleton<BlobStorageService>();

        
    }
}