using PeopleIO.Domain.Entity;

namespace PeopleIO.Domain.Contract;

public interface IColaboradorRepository
{
    Task Register(Colaborador colaborador);
    Task<Colaborador?> GetById(Guid id);
    Task<IEnumerable<Colaborador>> GetAll();
    Task Update(Colaborador colaborador);
    Task Delete(Guid id);

}