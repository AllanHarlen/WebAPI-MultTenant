namespace AntaresAPI.Models;

public partial class Agendum
{
    public int Id { get; set; }

    public string? Compromisso { get; set; }

    public DateTime? Data { get; set; }

    public string? Lembrar { get; set; }

    public string? Usuario { get; set; }

    public string? Periodo { get; set; }

    public DateTime? Conclusao { get; set; }
}
