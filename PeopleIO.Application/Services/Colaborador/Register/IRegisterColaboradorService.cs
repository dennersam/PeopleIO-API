using PeopleIO.Application.Results;
using PeopleIO.Communication;

namespace PeopleIO.Application.Services.Colaborador.Register;

public interface IRegisterColaboradorService
{
    Result<ColaboradorResponse> Execute(RequestRegisterColaborador request);
}