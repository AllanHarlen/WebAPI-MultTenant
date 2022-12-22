namespace AntaresAPI.Models;

public partial class VwListaPedidovendum
{
    public int Chave { get; set; }

    public string Documento { get; set; } = null!;

    public DateTime? Emissao { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public string? Cnpjcpf { get; set; }

    public decimal? Total { get; set; }

    public DateTime? Cancelado { get; set; }

    public string? Situacao { get; set; }

    public string? Vendedor1 { get; set; }

    public string? Empresa { get; set; }
}
