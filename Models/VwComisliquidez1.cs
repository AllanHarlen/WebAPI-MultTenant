namespace AntaresAPI.Models;

public partial class VwComisliquidez1
{
    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public int Chave1 { get; set; }

    public DateTime? Emissao { get; set; }

    public DateTime? Vencimento { get; set; }

    public DateTime? Pagamento { get; set; }

    public string? Documento2 { get; set; }

    public string? Documento3 { get; set; }

    public string Documento { get; set; } = null!;

    public decimal? Totalprodutos { get; set; }

    public string? Codigovendedor { get; set; }

    public string? Nomevendedor { get; set; }

    public decimal? Valorbruto { get; set; }

    public decimal? Comissao { get; set; }

    public decimal? Total { get; set; }

    public string? Empresa { get; set; }

    public decimal? Percentualdiferenca { get; set; }

    public decimal? Diferenca { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Valorparcial { get; set; }
}
