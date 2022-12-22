namespace AntaresAPI.Models;

public partial class NfceDetalhe
{
    public int Id { get; set; }

    public string? CodigoProduto { get; set; }

    public int? IdNfeCabecalho { get; set; }

    public int? NumeroItem { get; set; }

    public string? Gtin { get; set; }

    public string? NomeProduto { get; set; }

    public string? Ncm { get; set; }

    public string? Cfop { get; set; }

    public string? Unidade { get; set; }

    public decimal? Quantidade { get; set; }

    public decimal? ValorUnitario { get; set; }

    public decimal? ValorDesconto { get; set; }

    public decimal? ValorSubtotal { get; set; }

    public decimal? ValorTotal { get; set; }

    public decimal? ValorTotalTributos { get; set; }

    public DateTime? Data { get; set; }

    public string? Documento { get; set; }

    public string? Cancelado { get; set; }

    public string? Descricao { get; set; }

    public decimal? Icms { get; set; }

    public decimal? IcmsReducao { get; set; }

    public decimal? ValorIcms { get; set; }

    public decimal? BaseIcms { get; set; }

    public decimal? Mva { get; set; }

    public decimal? MvaReducao { get; set; }

    public decimal? MvaIcms { get; set; }

    public decimal? ValorIcmsSt { get; set; }

    public decimal? BaseIcmsSt { get; set; }

    public string? Fichatecnica { get; set; }

    public string? Movimentaestoque { get; set; }

    public string? Produtoficha { get; set; }

    public string? Sincronizado { get; set; }

    public string? Emitido { get; set; }

    public string? Codigovendedor { get; set; }

    public string? Nomevendedor { get; set; }

    public decimal? Comissao { get; set; }

    public decimal? ValorAcrescimo { get; set; }

    /// <summary>
    /// Guarda o custo no dia da venda. Implementado em 11/01/2022
    /// </summary>
    public decimal? Custo { get; set; }
}
