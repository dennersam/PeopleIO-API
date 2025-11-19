using PeopleIO.Application.Services.Colaborador.Delete;
using PeopleIO.Application.Services.Colaborador.GetAll;
using PeopleIO.Application.Services.Colaborador.GetById;
using PeopleIO.Application.Services.Colaborador.Register;
using PeopleIO.Communication;
using PeopleIO.Domain.Entity;

namespace PeapleIO.API.Endpoints;

public static class ColaboradorEndpoints
{
    public static void MapColaboradorEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/v1/colaboradores")
            .WithTags("Colaboradores");

        group.MapGet("", (IGetAllColaboradoresService service) => Results.Ok(service.Execute()));
        group.MapGet("/{id:guid}", async (Guid id, IGetColaboradorByIdService service) =>
        {
            var colaborador = await service.Execute(id);
            return colaborador is null
                ? Results.NotFound()
                : Results.Ok(colaborador);
        });
        group.MapPost("", (RequestRegisterColaborador request, IRegisterColaboradorService service) =>
        {
            var result = service.Execute(request);
            return Results.Created($"/colaboradores/{result.Value.Id}", result);
        })
        .WithName("CreateColaborador");
        group.MapDelete("/{id:guid}", async (Guid id, IRemoveColaboradorService service) =>
        {
            try
            {
                var success = await service.Execute(id);
                return success ? Results.NoContent() : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem("Erro ao remover colaborador: " + ex.Message);
            }
        })
        .WithName("DeleteColaborador");

    }
}