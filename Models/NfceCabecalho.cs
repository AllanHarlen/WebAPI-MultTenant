namespace AntaresAPI.Models;

public partial class NfceCabecalho
{
    public int Id { get; set; }

    public int? IdNfceMovimento { get; set; }

    public string? Vendedor { get; set; }

    public string? Cliente { get; set; }

    public string? Documento { get; set; }

    public DateTime? DataEmissao { get; set; }

    public DateTime? HoraEmissao { get; set; }

    public string? ChaveAcesso { get; set; }

    public decimal? BaseCalculoIcms { get; set; }

    public decimal? ValorIcms { get; set; }

    public decimal? BaseCalculoIcmsSt { get; set; }

    public decimal? ValorIcmsSt { get; set; }

    public decimal? ValorTotalProdutos { get; set; }

    public decimal? ValorDesconto { get; set; }

    public decimal? ValorIpi { get; set; }

    public decimal? ValorPis { get; set; }

    public decimal? ValorCofins { get; set; }

    public decimal? ValorTotal { get; set; }

    public int? StatusNota { get; set; }

    public decimal? Troco { get; set; }

    public string? NumeroRecibo { get; set; }

    public string? NumeroProtocolo { get; set; }

    public string? Nome { get; set; }

    public string? Cpfcnpj { get; set; }

    public int? IdOperador { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Taxadesconto { get; set; }

    public string? Observacao { get; set; }

    public string? Viacartao { get; set; }

    public string? Cnfce { get; set; }

    public string? Observacao2 { get; set; }

    public int? Identregador { get; set; }

    public DateTime? Hinicial { get; set; }

    public DateTime? Hfinal { get; set; }

    public int? Delivery { get; set; }

    public int? Statusdelivery { get; set; }

    public int? Tpentrega { get; set; }

    public string? Sincronizado { get; set; }

    public int? Idsuitetipo { get; set; }

    public int? NumeroSuite { get; set; }

    public string? XmlAssinado { get; set; }

    public string? XmlProc { get; set; }

    public string? AutorizacaoCartao { get; set; }

    public decimal? Valoracrescimo { get; set; }

    public decimal? Taxaacrescimo { get; set; }
}
