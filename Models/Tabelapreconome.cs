namespace AntaresAPI.Models;

public partial class Tabelapreconome
{
    public int Chave { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public string? Sincronizado { get; set; }
}
