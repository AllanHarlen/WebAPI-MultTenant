namespace AntaresAPI.Models;

public partial class VwEstoqueatual
{
    public string? Produto { get; set; }

    public string? Descricao { get; set; }

    public string? Codigofornecedor { get; set; }

    public string? Fornecedor { get; set; }

    public decimal? Custo { get; set; }

    public decimal? Precovenda { get; set; }

    public string? Referencia { get; set; }

    public string? Unidade { get; set; }

    public decimal? Qtdvolume { get; set; }

    public decimal? Qtdminima { get; set; }

    public string? Codigogrupo { get; set; }

    public string? Descricaogrupo { get; set; }

    public string? Aplicacao { get; set; }

    public int Id { get; set; }

    public decimal? Preco1 { get; set; }

    public decimal? Pliquido { get; set; }

    public decimal? Estoque { get; set; }

    public int Total { get; set; }
}
