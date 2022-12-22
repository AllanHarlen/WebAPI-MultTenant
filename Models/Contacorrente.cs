namespace AntaresAPI.Models;

public partial class Contacorrente
{
    public int Chave { get; set; }

    public string? Cliente { get; set; }

    public string? Documento { get; set; }

    public DateTime? Data { get; set; }

    public string? Hora { get; set; }

    public string? Responsavel { get; set; }

    public decimal? Valor { get; set; }

    public string? Cancelado { get; set; }

    public string? Observacao { get; set; }

    public decimal? Preco { get; set; }

    public string? Origem { get; set; }

    public string? Recebimento { get; set; }
}
