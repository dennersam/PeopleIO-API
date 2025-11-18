using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PeopleIO.Infrastructure.Context;

public class PeopleIOContextFactory : IDesignTimeDbContextFactory<PeopleIoContext>
{
    public PeopleIoContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PeopleIoContext>();

        // Use a mesma string de conexão do seu appsettings ou variável de ambiente
        var connectionString = "Host=ep-fancy-mode-afzf8sqo-pooler.c-2.us-west-2.aws.neon.tech; Database=neondb; Username=neondb_owner; Password=npg_QFNgw98UvifA; SSL Mode=VerifyFull; Channel Binding=Require;";

        optionsBuilder.UseNpgsql(connectionString);

        return new PeopleIoContext(optionsBuilder.Options);
    }
}
