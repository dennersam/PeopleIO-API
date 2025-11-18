using PeopleIO.Domain.Entity;

namespace PeopleIO.Domain.Contract;

public interface IColaboradorRepository
{
    int Register(Colaborador colaborador);
    Task<Colaborador?> GetById(Guid id);
    IEnumerable<Colaborador> GetAll();
    Task Update(Colaborador colaborador);
    Task Delete(Guid id);

}