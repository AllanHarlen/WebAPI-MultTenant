namespace AntaresAPI.Models;

public partial class Suite
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int Reserva { get; set; }

    public int? Ativo { get; set; }

    public string? Numero { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? Tempo { get; set; }

    public decimal? ValorAdicional { get; set; }

    public int? Idproduto { get; set; }
}
