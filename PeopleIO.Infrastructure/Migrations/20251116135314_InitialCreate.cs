using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleIO.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "colaborador",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Cargo = table.Column<string>(type: "text", nullable: true),
                    Departamento = table.Column<string>(type: "text", nullable: true),
                    DataAdmissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataDemissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ArquivoRGNome = table.Column<string>(type: "text", nullable: true),
                    ArquivoRGURL = table.Column<string>(type: "text", nullable: true),
                    ArquivoRGDataUpload = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ArquivoRGTipoMime = table.Column<string>(type: "text", nullable: true),
                    ArquivoCNHNome = table.Column<string>(type: "text", nullable: true),
                    ArquivoCNHURL = table.Column<string>(type: "text", nullable: true),
                    ArquivoCNHDataUpload = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ArquivoCNHTipoMime = table.Column<string>(type: "text", nullable: true),
                    ArquivoCPFNome = table.Column<string>(type: "text", nullable: true),
                    ArquivoCPFURL = table.Column<string>(type: "text", nullable: true),
                    ArquivoCPFDataUpload = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ArquivoCPFTipoMime = table.Column<string>(type: "text", nullable: true),
                    ArquivoResidenciaNome = table.Column<string>(type: "text", nullable: true),
                    ArquivoResidenciaURL = table.Column<string>(type: "text", nullable: true),
                    ArquivoResidenciaDataUpload = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ArquivoResidenciaTipoMime = table.Column<string>(type: "text", nullable: true),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false),
                    Rua = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Bairro = table.Column<string>(type: "text", nullable: false),
                    Cidade = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    CEP = table.Column<string>(type: "text", nullable: false),
                    IdentidadeNumero = table.Column<string>(type: "text", nullable: false),
                    IdentidadeOrgaoEmissor = table.Column<string>(type: "text", nullable: false),
                    IdentidadeUF = table.Column<string>(type: "text", nullable: false),
                    IdentidadeDataEmissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CTPSNumero = table.Column<string>(type: "text", nullable: false),
                    CTPSSerie = table.Column<string>(type: "text", nullable: false),
                    CTPSDataEmissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CTPSUF = table.Column<string>(type: "text", nullable: false),
                    TituloEleitor = table.Column<string>(type: "text", nullable: false),
                    TituloDataEmissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TituloUF = table.Column<string>(type: "text", nullable: false),
                    TituloZona = table.Column<string>(type: "text", nullable: false),
                    TituloSecao = table.Column<string>(type: "text", nullable: false),
                    CNHNumero = table.Column<string>(type: "text", nullable: true),
                    CNHUF = table.Column<string>(type: "text", nullable: true),
                    CNHDataVencimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CNHOrgaoEmissor = table.Column<string>(type: "text", nullable: true),
                    CNHTipo = table.Column<string>(type: "text", nullable: true),
                    CorRaca = table.Column<string>(type: "text", nullable: false),
                    Sexo = table.Column<string>(type: "text", nullable: false),
                    Escolaridade = table.Column<string>(type: "text", nullable: false),
                    EstadoCivil = table.Column<string>(type: "text", nullable: false),
                    Naturalidade = table.Column<string>(type: "text", nullable: false),
                    Nacionalidade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colaborador", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "colaborador");
        }
    }
}
