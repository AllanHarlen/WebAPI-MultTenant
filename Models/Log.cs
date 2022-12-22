namespace AntaresAPI.Models;

public partial class Log
{
    public int Chave { get; set; }

    public int Usuario { get; set; }

    public string? Acao { get; set; }

    public string? Setor { get; set; }

    public DateTime? Datahora { get; set; }
}
