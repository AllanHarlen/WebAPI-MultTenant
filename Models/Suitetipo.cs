namespace AntaresAPI.Models;

public partial class Suitetipo
{
    public int Id { get; set; }

    /// <summary>
    /// Identificador da suite - específico hospedagem
    /// </summary>
    public int? Idsuite { get; set; }

    /// <summary>
    /// Descrição da suite - específico hospedagem
    /// </summary>
    public string? Descricao { get; set; }

    /// <summary>
    /// Tempo de permanência da suite - específico hospedagem
    /// </summary>
    public DateTime? Tempo { get; set; }

    /// <summary>
    /// Valor padrão da suite - específico hospedagem
    /// </summary>
    public decimal? Valor { get; set; }

    /// <summary>
    /// Valor excedente da suite - específico hospedagem
    /// </summary>
    public decimal? Valorexcedente { get; set; }
}
