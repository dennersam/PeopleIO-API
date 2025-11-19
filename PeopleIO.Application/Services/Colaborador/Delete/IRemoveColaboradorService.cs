namespace PeopleIO.Application.Services.Colaborador.Delete;

public interface IRemoveColaboradorService
{
    Task<bool> Execute(Guid id);
}