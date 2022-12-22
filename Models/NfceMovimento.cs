namespace AntaresAPI.Models;

public partial class NfceMovimento
{
    public int Id { get; set; }

    public DateOnly? Dataabertura { get; set; }

    public DateTime? Horaabertura { get; set; }

    public int? Idusuarioabertura { get; set; }

    public decimal? Fundocaixa { get; set; }

    public DateOnly? Datafechamento { get; set; }

    public DateTime? Horafechamento { get; set; }

    public int? Idusuariofechamento { get; set; }

    public int? Status { get; set; }

    public string? Sincronizado { get; set; }
}
