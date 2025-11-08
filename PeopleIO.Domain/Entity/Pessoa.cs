using PeopleIO.Domain.Entity;

public abstract class Pessoa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = default!;
    public string CPF { get; set; } = default!;
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; } = default!;
    public string Telefone { get; set; } = default!;
    public Endereco Endereco { get; set; } = default!;
    
    public string IdentidadeNumero { get; set; } = default!;
    public string IdentidadeOrgaoEmissor { get; set; } = default!;
    public string IdentidadeUF { get; set; } = default!;
    public DateTime IdentidadeDataEmissao { get; set; }

    public string CTPSNumero { get; set; } = default!;
    public string CTPSSerie { get; set; } = default!;
    public DateTime CTPSDataEmissao { get; set; }
    public string CTPSUF { get; set; } = default!;

    public string TituloEleitor { get; set; } = default!;
    public DateTime TituloDataEmissao { get; set; }
    public string TituloUF { get; set; } = default!;
    public string TituloZona { get; set; } = default!;
    public string TituloSecao { get; set; } = default!;

    public string CNHNumero { get; set; } = default!;
    public string CNHUF { get; set; } = default!;
    public DateTime CNHDataVencimento { get; set; }
    public string CNHOrgaoEmissor { get; set; } = default!;
    public string CNHTipo { get; set; } = default!;

    // Dados demográficos
    public string CorRaca { get; set; } = default!;
    public string Sexo { get; set; } = default!;
    public string Escolaridade { get; set; } = default!;
    public string EstadoCivil { get; set; } = default!;
    public string Naturalidade { get; set; } = default!;
    public string Nacionalidade { get; set; } = default!;
}