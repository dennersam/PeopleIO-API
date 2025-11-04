namespace PeopleIO.Domain.Entity;

public class Colaborador : Pessoa
{
    public string Cargo { get; set; } = default!;
    public string Departamento { get; set; } = default!;
    public DateTime DataAdmissao { get; set; }
    public DateTime? DataDemissao { get; set; }
    public bool Ativo { get; set; } = true;
}