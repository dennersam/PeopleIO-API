using PeopleIO.Domain.Entity;

namespace PeopleIO.Domain.Contract;

public interface IColaboradorRepository
{
    Task<int> RegisterAsync(Colaborador colaborador);
    Task<Colaborador?> GetByIdAsync(Guid id);
    Task<bool> GetByCPFAsync(string cpf);
    IEnumerable<Colaborador> GetAll();
    Task Update(Colaborador colaborador);
    Task DeleteAsync(Guid id);

}