namespace AntaresAPI.Models;

public partial class VwSomaestoque
{
    public decimal Estoque { get; set; }

    public string? Empresa { get; set; }

    public string? Produto { get; set; }

    public DateTime? Data { get; set; }
}
