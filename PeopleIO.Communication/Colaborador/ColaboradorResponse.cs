namespace PeopleIO.Communication;

public record ColaboradorResponse(
    Guid Id,
    string Nome,
    string Email,
    string Cargo,
    string Departamento,
    bool Ativo
)
{
    
}