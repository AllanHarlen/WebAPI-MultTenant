namespace AntaresAPI.Models;

public partial class Reajustepreco
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Produto { get; set; }

    public decimal? Precoatual { get; set; }

    public decimal? Preconovo { get; set; }

    public string? Usuario { get; set; }
}
