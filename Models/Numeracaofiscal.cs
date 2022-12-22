namespace AntaresAPI.Models;

public partial class Numeracaofiscal
{
    public int Chave { get; set; }

    public string Docsaida { get; set; } = null!;

    public string Selofiscalsaida { get; set; } = null!;

    public string Numeronotasaida { get; set; } = null!;

    public string Docentrada { get; set; } = null!;

    public string Selofiscalentrada { get; set; } = null!;

    public string Numeronotaentrada { get; set; } = null!;

    public string? Numeronotascan { get; set; }

    public string? Lotenfse { get; set; }

    public string? Numeroloterps { get; set; }

    public string? Empresa { get; set; }

    public int Numeronotanfce { get; set; }

    public int? Numeronotamdfe { get; set; }

    public int? Numeroromaneio { get; set; }
}
