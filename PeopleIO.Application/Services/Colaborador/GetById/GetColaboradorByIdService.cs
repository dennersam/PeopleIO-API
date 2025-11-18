using PeopleIO.Application.Services.Colaborador.GetAll;
using PeopleIO.Domain.Contract;

namespace PeopleIO.Application.Services.Colaborador.GetById;

public class GetColaboradorByIdService : IGetColaboradorByIdService
{
    private readonly IColaboradorRepository _repository;
    public GetColaboradorByIdService(IColaboradorRepository repository)
    {
        _repository =  repository;
    }

    public async Task<Domain.Entity.Colaborador> Execute(Guid id)
    {
        var colaborador = await _repository.GetById(id);
        return colaborador;
    }
}