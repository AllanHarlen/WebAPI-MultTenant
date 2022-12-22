namespace AntaresAPI.Models;

public partial class VwListaCompra
{
    public int Chave { get; set; }

    /// <summary>
    /// Guarda documento de compra
    /// </summary>
    public string? Documento { get; set; }

    public DateTime? Emissao { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public decimal? Total { get; set; }

    public string? Cnpjcpf { get; set; }

    public string? Cancelado { get; set; }

    public string? Emitido { get; set; }

    public decimal? Denegada { get; set; }

    public string? Empresa { get; set; }
}
