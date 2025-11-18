using PeopleIO.Application.Results;

namespace PeopleIO.Application.Services.Colaborador.GetAll;

public interface IGetAllColaboradoresService
{
    Result<IEnumerable<Domain.Entity.Colaborador>> Execute();
}