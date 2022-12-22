namespace AntaresAPI.Models;

public partial class Leiautemovimento
{
    public int Id { get; set; }

    public string Pedido { get; set; } = null!;

    public string Produto { get; set; } = null!;

    public string Registro { get; set; } = null!;

    public string Camisafrentepeitodireito { get; set; } = null!;

    public string Camisafrentebolsodireito { get; set; } = null!;

    public string Camisafrentemangadireta { get; set; } = null!;

    public string Calcafrentebolsodireito { get; set; } = null!;

    public string Calcafrentepernadireita { get; set; } = null!;

    public string Camisafrentepeitoesquerdo { get; set; } = null!;

    public string Camisafrentevistabolso { get; set; } = null!;

    public string Camisafretebolsoesquerdo { get; set; } = null!;

    public string Camisafrentemangaesquerdo { get; set; } = null!;

    public string Calcafrentebolsoesquerdo { get; set; } = null!;

    public string Camisacosta { get; set; } = null!;

    public string Calcacostabolsodireito { get; set; } = null!;

    public string Calcacostabolsoesquerdo { get; set; } = null!;

    public string? Sincronizado { get; set; }
}
