namespace AntaresAPI.Models;

public partial class VwListaOrdemservico
{
    public int Chave { get; set; }

    public string? Documento { get; set; }

    public DateTime? Entrada { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public string? Cnpjcpf { get; set; }

    public decimal? Total { get; set; }

    public string? Finalizada { get; set; }

    public string? Faturado { get; set; }

    public string? Status { get; set; }
}
