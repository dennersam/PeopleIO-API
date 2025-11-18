namespace PeopleIO.Application.Services.Colaborador.GetById;

public interface IGetColaboradorByIdService
{
    Task<Domain.Entity.Colaborador> Execute(Guid id);
}