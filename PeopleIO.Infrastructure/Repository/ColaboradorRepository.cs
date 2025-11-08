using Microsoft.EntityFrameworkCore;
using PeopleIO.Domain.Contract;
using PeopleIO.Domain.Entity;
using PeopleIO.Infrastructure.Context;

namespace PeopleIO.Infrastructure.Repository;

public class ColaboradorRepository(PeopleIOContext ctx) : IColaboradorRepository
{
    private readonly PeopleIOContext _ctx;

    public async Task Register(Colaborador colaborador)
    {
        await _ctx.Colaboradores.AddAsync(colaborador);
        await _ctx.SaveChangesAsync();
    }

    public async Task<Colaborador?> GetById(Guid id)
    {
        return await _ctx.Colaboradores
            .Include(c => c.Endereco)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Colaborador>> GetAll()
    {
        return await _ctx.Colaboradores
            .Include(c => c.Endereco)
            .ToListAsync();
    }

    public async Task Update(Colaborador colaborador)
    {
        _ctx.Colaboradores.Update(colaborador);
        await _ctx.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var colaborador = await _ctx.Colaboradores.FindAsync(id);
        if (colaborador is not null)
        {
            _ctx.Colaboradores.Remove(colaborador);
            await _ctx.SaveChangesAsync();
        }
    }

}