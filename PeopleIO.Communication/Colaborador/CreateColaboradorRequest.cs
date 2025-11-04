namespace PeopleIO.Communication;

public record CreateColaboradorRequest(
    string Nome,
    string CPF,
    DateTime DataNascimento,
    string Email,
    string Telefone,
    EnderecoRequest Endereco,
    string Cargo,
    string Departamento,
    DateTime DataAdmissao
);