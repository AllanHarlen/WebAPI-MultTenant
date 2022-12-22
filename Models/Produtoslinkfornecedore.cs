namespace AntaresAPI.Models;

public partial class Produtoslinkfornecedore
{
    public int Id { get; set; }

    public int Idproduto { get; set; }

    public string Produtofornecedor { get; set; } = null!;

    public string Cnpjfornecedor { get; set; } = null!;
}
