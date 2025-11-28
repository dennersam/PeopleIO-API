using Mapster;
using PeopleIO.Application.Results;
using PeopleIO.Communication;
using PeopleIO.Domain.Contract;

namespace PeopleIO.Application.Services.Colaborador.Register;

public class RegisterColaboradorService : IRegisterColaboradorService
{
    private readonly IColaboradorRepository _colaboradorRepository;

    public RegisterColaboradorService(IColaboradorRepository colaboradorRepository)
    {
        _colaboradorRepository = colaboradorRepository;
    }

    public Result<ColaboradorResponse> Execute(RequestRegisterColaborador request)
    {
        Validate(request);
        var colaborador = request.Adapt<Domain.Entity.Colaborador>();
        
        _colaboradorRepository.Register(colaborador);
        
        var response = new ColaboradorResponse(
            colaborador.Id, 
            colaborador.Nome, 
            colaborador.Email);
        
        return Result<ColaboradorResponse>.Success(response);
    }

    private void Validate(RequestRegisterColaborador request)
    {
        var validate = new RegisterColaboradorValidator();
        var result = validate.Validate(request);
        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
            throw new ApplicationException(string.Join(Environment.NewLine, errorMessages));
        }
    }
}