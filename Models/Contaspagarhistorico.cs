namespace AntaresAPI.Models;

public partial class Contaspagarhistorico
{
    public int Chave { get; set; }

    public string? Documento { get; set; }

    public string? Fornecedor { get; set; }

    public string? Historico { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? Data { get; set; }

    public string? Responsavel { get; set; }

    public string? Tipo { get; set; }

    public string? Documento2 { get; set; }

    public string? Sincronizado { get; set; }
}
