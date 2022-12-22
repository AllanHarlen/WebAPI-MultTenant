namespace AntaresAPI.Models;

public partial class Relatorio
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Nome { get; set; }

    public string? Modulo { get; set; }

    public string? Descricao { get; set; }

    public string? Controle { get; set; }
}
