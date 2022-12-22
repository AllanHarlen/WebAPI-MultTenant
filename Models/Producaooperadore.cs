namespace AntaresAPI.Models;

public partial class Producaooperadore
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string? Tempoinicial { get; set; }

    public string? Tempointervalo { get; set; }

    public string? Horafim { get; set; }

    public string? Totalhoras { get; set; }

    public string? Operador { get; set; }

    public string? Documento { get; set; }

    public decimal? Producaohora { get; set; }

    public string? Meta { get; set; }

    public string? Temperaturaforno { get; set; }

    public string? Observacao { get; set; }

    public decimal? Producao { get; set; }
}
