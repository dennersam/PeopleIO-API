using Microsoft.EntityFrameworkCore;
using PeopleIO.Domain.Contract;
using PeopleIO.Domain.Entity;
using PeopleIO.Infrastructure.Context;

namespace PeopleIO.Infrastructure.Repository;

public class ColaboradorRepository : IColaboradorRepository
{
    private readonly PeopleIoContext _ctx;

    public ColaboradorRepository(PeopleIoContext ctx)
    {
        _ctx = ctx;
    }

    public int Register(Colaborador colaborador)
    {
        _ctx.Colaborador.Add(colaborador);
        return _ctx.SaveChanges();
    }

    public Task<Colaborador?> GetByIdAsync(Guid id) =>
        _ctx.Colaborador.FirstOrDefaultAsync(c => c.Id == id);
    


    public IEnumerable<Colaborador> GetAll() =>
        _ctx.Colaborador
            .ToList();
    
    public async Task Update(Colaborador colaborador)
    {
        _ctx.Colaborador.Update(colaborador);
        await _ctx.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var colaborador = await _ctx.Colaborador.FindAsync(id);
        if (colaborador != null)
        {
            _ctx.Colaborador.Remove(colaborador);
            await _ctx.SaveChangesAsync();
        }
    }


}