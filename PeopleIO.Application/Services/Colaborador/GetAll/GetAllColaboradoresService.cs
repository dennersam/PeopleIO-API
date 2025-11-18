using PeopleIO.Application.Results;
using PeopleIO.Domain.Contract;

namespace PeopleIO.Application.Services.Colaborador.GetAll;

public class GetAllColaboradoresService : IGetAllColaboradoresService
{
    private readonly IColaboradorRepository  _colaboradorRepository;

    public GetAllColaboradoresService(IColaboradorRepository colaboradorRepository)
    {
        _colaboradorRepository = colaboradorRepository;
    }

    public Result<IEnumerable<Domain.Entity.Colaborador>> Execute()
    {
        var colaboradores = _colaboradorRepository.GetAll();
        return Result<IEnumerable<Domain.Entity.Colaborador>>.Success(colaboradores);
    }
}