namespace AntaresAPI.Models;

public partial class Historicomatriz
{
    public int Id { get; set; }

    public string? Matriz { get; set; }

    public string? Produto { get; set; }

    public string? Cliente { get; set; }

    public string? Documento { get; set; }

    public decimal? Espessura { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Margemlateral { get; set; }

    public decimal? Margemlateral2 { get; set; }

    public decimal? Margemterminal { get; set; }

    public decimal? Margemterminal2 { get; set; }
}
