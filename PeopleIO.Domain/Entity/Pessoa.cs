namespace PeopleIO.Domain.Entity;

public abstract class Pessoa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = default!;
    public string CPF { get; set; } = default!; 
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; } = default!;
    public string Telefone { get; set; } = default!;
    public Endereco Endereco { get; set; } = default!;
}