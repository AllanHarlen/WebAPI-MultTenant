namespace AntaresAPI.Models;

public partial class VwListaVenda
{
    public int Chave { get; set; }

    public string Documento { get; set; } = null!;

    public DateTime? Emissao { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public decimal? Total { get; set; }

    public string? Cnpjcpf { get; set; }

    public string? Cancelado { get; set; }

    public string? Emitido { get; set; }

    public string? Denegada { get; set; }

    public string? Empresa { get; set; }
}
