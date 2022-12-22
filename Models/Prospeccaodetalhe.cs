namespace AntaresAPI.Models;

public partial class Prospeccaodetalhe
{
    public int Id { get; set; }

    public int? Idprospeccao { get; set; }

    public string? Observacao { get; set; }

    public DateTime? Data { get; set; }

    public string? Responsavel { get; set; }

    public string? Prioridade { get; set; }

    public string? Cargo { get; set; }

    public DateTime? Lembrar { get; set; }

    public string? Sincronizado { get; set; }
}
