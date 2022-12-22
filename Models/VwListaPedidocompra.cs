namespace AntaresAPI.Models;

public partial class VwListaPedidocompra
{
    public int Chave { get; set; }

    public string? Documento { get; set; }

    public DateTime? Emissao { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public string? Cnpjcpf { get; set; }

    public decimal? Total { get; set; }

    public string? Empresa { get; set; }
}
