namespace AntaresAPI.Models;

public partial class Inutilizacaonumeracao
{
    public int Id { get; set; }

    public string? Numeracao { get; set; }

    public string? Justificativa { get; set; }

    public DateTime? Data { get; set; }

    public string? Empresa { get; set; }

    public string? Serie { get; set; }

    public string? Sincronizado { get; set; }
}
