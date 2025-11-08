using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PeopleIO.Infrastructure.Context;

namespace PeopleIO.Infrastructure;

public static class DependencyInjectionExtension
{
    public static void AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDatabase(services, configuration);
        AddRepository(services);
    }

    private static void AddRepository(this IServiceCollection services)
    {
        //services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
        
    }
    private static void AddDatabase(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["PEOPLEIO-CONN-STRING-PGSQL"];
        services.AddDbContext<PeopleIOContext>(opt => opt.UseNpgsql(connectionString));
    }
}