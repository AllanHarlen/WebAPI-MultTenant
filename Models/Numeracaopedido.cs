namespace AntaresAPI.Models;

public partial class Numeracaopedido
{
    public int Id { get; set; }

    public int Pedidocompra { get; set; }

    public int Pedidovenda { get; set; }

    public int? Contrato { get; set; }
}
