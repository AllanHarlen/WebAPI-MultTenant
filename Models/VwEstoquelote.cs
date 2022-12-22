namespace AntaresAPI.Models;

public partial class VwEstoquelote
{
    public int Id { get; set; }

    public string? Produto { get; set; }

    public string? Descricao { get; set; }

    public decimal? Quantidade { get; set; }

    public string? Lote { get; set; }

    public string? Localizacao { get; set; }

    public DateTime? Validade { get; set; }

    public DateTime? Fabricacao { get; set; }

    public string? Cancelado { get; set; }

    public string? Movimentaestoque { get; set; }

    public string? Empresa { get; set; }
}
