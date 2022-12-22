namespace AntaresAPI.Models;

public partial class Precoespecialcliente
{
    public int Id { get; set; }

    public string? Cliente { get; set; }

    public string? Produto { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? Data { get; set; }

    public string? Descricao { get; set; }
}
