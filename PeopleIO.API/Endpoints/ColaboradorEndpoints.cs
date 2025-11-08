using PeopleIO.Communication;
using PeopleIO.Domain.Entity;

namespace PeapleIO.API.Endpoints;

public static class ColaboradorEndpoints
{
    public static void MapColaboradorEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/colaboradores")
            .WithTags("Colaboradores");

        group.MapGet("/", () => Results.Ok("Lista de colaboradores"));
        group.MapGet("/{id:int}", (int id) => Results.Ok($"Colaborador {id}"));
        group.MapPost("/", (CreateColaboradorRequest request) =>
            {
                var endereco = new Endereco(
                    request.Endereco.Rua,
                    request.Endereco.Numero,
                    request.Endereco.Bairro,
                    request.Endereco.Cidade,
                    request.Endereco.Estado,
                    request.Endereco.Cep
                );

                var colaborador = new Colaborador
                {
                    Nome = request.Nome,
                    CPF = request.CPF,
                    DataNascimento = request.DataNascimento,
                    Email = request.Email,
                    Telefone = request.Telefone,
                    Cargo = request.Cargo,
                    Departamento = request.Departamento,
                    DataAdmissao = request.DataAdmissao,
                    Endereco = endereco
                };

                // Aqui você inseriria no banco
                // ex: _service.Add(colaborador);

                var response = new ColaboradorResponse(
                    colaborador.Id,
                    colaborador.Nome,
                    colaborador.Email,
                    colaborador.Cargo,
                    colaborador.Departamento,
                    colaborador.Ativo
                );

                return Results.Created($"/colaboradores/{colaborador.Id}", response);
            })
            .WithName("CreateColaborador");
    }
}