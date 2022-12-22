namespace AntaresAPI.Models;

public partial class LocaisEntrega
{
    public int Id { get; set; }

    public string Bairro { get; set; } = null!;

    public decimal Taxa { get; set; }
}
