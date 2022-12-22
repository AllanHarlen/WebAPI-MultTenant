namespace AntaresAPI.Models;

public partial class Producao
{
    public int Chave { get; set; }

    public string? Documento { get; set; }

    public DateTime? Datainicio { get; set; }

    public string? Horainicio { get; set; }

    public DateTime? Datafim { get; set; }

    public string? Horafim { get; set; }

    public string? Status { get; set; }

    public string? Responsavel { get; set; }

    public DateTime? Cancelado { get; set; }

    public string? Observacao { get; set; }

    public decimal? Totalperda { get; set; }

    public int? Idturma { get; set; }

    public string? Espessura { get; set; }

    public string? Cristalizacao { get; set; }

    public int? Tempo1 { get; set; }

    public int? Tempo2 { get; set; }

    public string? Liberado { get; set; }

    public string? Horaintervalo { get; set; }

    public decimal? Totalcusto { get; set; }

    public string? Sincronizado { get; set; }
}
