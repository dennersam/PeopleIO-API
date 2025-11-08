using Microsoft.EntityFrameworkCore;
using PeopleIO.Domain.Entity;

namespace PeopleIO.Infrastructure.Context;

public class PeopleIOContext : DbContext
{
    public PeopleIOContext(DbContextOptions<PeopleIOContext> options)
        : base(options) { }

    public DbSet<Colaborador> Colaboradores { get; set; }

}