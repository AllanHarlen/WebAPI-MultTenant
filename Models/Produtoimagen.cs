namespace AntaresAPI.Models;

public partial class Produtoimagen
{
    public int Id { get; set; }

    public int Idproduto { get; set; }

    public string? Nome { get; set; }

    public string? Tipo1 { get; set; }

    public string? Tipo2 { get; set; }

    public byte[]? Imagem { get; set; }
}
