namespace AntaresAPI.Models;

public partial class NfceSangriaSuprimento
{
    public int Id { get; set; }

    public DateOnly? Data { get; set; }

    public decimal? Valor { get; set; }

    public int? IdOperador { get; set; }

    public int? Idmovimento { get; set; }

    /// <summary>
    /// Destinado a anotações ao comandar sangria ou suprimentos
    /// </summary>
    public string? Observacao { get; set; }
}
