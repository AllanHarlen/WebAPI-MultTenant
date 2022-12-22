namespace AntaresAPI.Models;

public partial class VwSomaordemservico
{
    public decimal Estoque { get; set; }

    /// <summary>
    /// Guarda código do produto na Ordem de Serviço
    /// </summary>
    public string? Produto { get; set; }

    public DateTime? Data { get; set; }
}
