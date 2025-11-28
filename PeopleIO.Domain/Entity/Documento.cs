namespace PeopleIO.Domain.Entity;

public class Documento
{
    public string NomeArquivo { get; set; } = default!;
    public string Url { get; set; } = default!;
    public DateTime DataUpload { get; set; } = DateTime.UtcNow;
    public string TipoMime { get; set; }
}