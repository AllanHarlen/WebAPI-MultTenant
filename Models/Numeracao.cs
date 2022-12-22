namespace AntaresAPI.Models;

public partial class Numeracao
{
    public int Id { get; set; }

    public string Codigocliente { get; set; } = null!;

    public string Codigofornecedor { get; set; } = null!;

    public string Codigoproduto { get; set; } = null!;

    public string Codigousuario { get; set; } = null!;

    public string Codigotippag { get; set; } = null!;

    public string Codigobanco { get; set; } = null!;

    public string Codigovendedor { get; set; } = null!;

    public string Codigofuncionario { get; set; } = null!;

    public string Codigogrupoproduto { get; set; } = null!;

    public string Codigoequipamento { get; set; } = null!;

    public string Codigotransportador { get; set; } = null!;

    public string? Empresa { get; set; }
}
