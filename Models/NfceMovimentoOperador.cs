namespace AntaresAPI.Models;

public partial class NfceMovimentoOperador
{
    public int Id { get; set; }

    public int? IdOperador { get; set; }

    public int? IdMovimento { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalCancelado { get; set; }

    public int? Status { get; set; }

    public int? IdRecebimento { get; set; }

    public string? Descricaorecebimento { get; set; }

    public string? Nomeoperador { get; set; }

    public DateTime? Datamovimento { get; set; }

    public decimal? TotalCalculado { get; set; }

    public DateTime? Data { get; set; }

    public string? Sincronizado { get; set; }
}
