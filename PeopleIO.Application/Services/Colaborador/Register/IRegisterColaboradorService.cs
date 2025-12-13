using PeopleIO.Application.Results;
using PeopleIO.Communication;

namespace PeopleIO.Application.Services.Colaborador.Register;

public interface IRegisterColaboradorService
{
    Task<Result<ColaboradorResponse>> ExecuteAsync(RequestRegisterColaborador request);
}