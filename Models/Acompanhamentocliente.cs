namespace AntaresAPI.Models;

public partial class Acompanhamentocliente
{
    public int Chave { get; set; }

    public string? Cliente { get; set; }

    public string? Fantasia { get; set; }

    public string? Acompanhamento { get; set; }

    public DateTime? Hora { get; set; }

    public DateTime? Data { get; set; }

    public string? Responsavel { get; set; }

    public DateTime? Lembrar { get; set; }

    public string? Origem { get; set; }

    public string? Documento { get; set; }

    public string? Removerlembrete { get; set; }

    public string? Sincronizado { get; set; }
}
