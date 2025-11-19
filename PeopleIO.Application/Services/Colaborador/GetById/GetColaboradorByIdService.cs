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
        if (id == Guid.Empty)
            throw new ArgumentException("ID inválido.");

        var colaborador = await _repository.GetByIdAsync(id);
        if (colaborador is null)
            throw new KeyNotFoundException($"Colaborador com ID {id} não encontrado.");

        return colaborador;

    }
}