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

    public async Task<int> RegisterAsync(Colaborador colaborador)
    {
        await _ctx.Colaborador.AddAsync(colaborador);
        return await _ctx.SaveChangesAsync();
    }

    public Task<Colaborador?> GetByIdAsync(Guid id) =>
        _ctx.Colaborador.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);    
    
    public Task<bool> GetByCPFAsync(string cpf) =>
        _ctx.Colaborador.AsNoTracking().AnyAsync(c => c.CPF == cpf);
    
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