using PeopleIO.Domain.Contract;

namespace PeopleIO.Application.Services.Colaborador.Delete;

public class RemoveColaboradorService : IRemoveColaboradorService
{
    private readonly IColaboradorRepository _colaboradorRepository;
    public RemoveColaboradorService(IColaboradorRepository colaboradorRepository)
    {
        _colaboradorRepository = colaboradorRepository;
    }

    public async Task<bool> Execute(Guid id)
    {
        var colaborador = await _colaboradorRepository.GetByIdAsync(id);
        if (colaborador is null)
            return false;

        await _colaboradorRepository.DeleteAsync(id);
        return true;

    }
}