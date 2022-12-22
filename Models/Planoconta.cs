namespace AntaresAPI.Models;

public partial class Planoconta
{
    public int Codigoresumido { get; set; }

    public string Codigocontabil { get; set; } = null!;

    public string? Descricao { get; set; }

    public string? Codigocentrocusto { get; set; }

    public string? Centrocusto { get; set; }

    public string? Movimento { get; set; }

    public string? Despesa { get; set; }

    public string? Status { get; set; }

    public string? Sincronizado { get; set; }
}
