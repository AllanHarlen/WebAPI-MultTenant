namespace AntaresAPI.Models;

public partial class Contatosfornecedore
{
    public int Codigo { get; set; }

    public string Codigofornecedor { get; set; } = null!;

    public string? Nome { get; set; }

    public string? Cargo { get; set; }

    public string? Fone { get; set; }

    public string? Email { get; set; }

    public string? Sincronizado { get; set; }
}
