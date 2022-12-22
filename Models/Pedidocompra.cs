namespace AntaresAPI.Models;

public partial class Pedidocompra
{
    public int Chave { get; set; }

    public string? Documento { get; set; }

    public string? Fornecedor { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public string? Cnpjcpf { get; set; }

    public DateTime? Emissao { get; set; }

    public string? Entrega { get; set; }

    public decimal? Icms { get; set; }

    public decimal? Icmssubst { get; set; }

    public decimal? Ipi { get; set; }

    public string? Devolucao { get; set; }

    public decimal? Desconto { get; set; }

    public string? Frete { get; set; }

    public decimal? Fretevalor { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? Total { get; set; }

    public decimal? Totalprodutos { get; set; }

    public string? Observacao { get; set; }

    public string? Recebimento { get; set; }

    /// <summary>
    /// Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe
    /// 
    /// </summary>
    public string? Descricaorecebimento { get; set; }

    public string? Usuario { get; set; }

    public string? Nomeusuario { get; set; }

    public string? Planocontas { get; set; }

    public string? Descricaoplano { get; set; }

    public string? Cfop { get; set; }

    public string? Descricaocfop { get; set; }

    public int? Qtdparcelas { get; set; }

    public string? Cancelado { get; set; }

    public string? Auditoria { get; set; }

    public string? Au { get; set; }

    public string? Codigotransportadora { get; set; }

    public string? Transportadora { get; set; }

    public string? Prazoentrega { get; set; }

    public DateTime? Faturamento { get; set; }

    public string? Liberado { get; set; }

    public string? Ordemcompra { get; set; }

    public string? Cotacao { get; set; }

    public string? Codigocentro { get; set; }

    public string? Centrocusto { get; set; }

    public string? Codigocusto { get; set; }

    public decimal? Bcicms { get; set; }

    public decimal? Bcipi { get; set; }

    public decimal? Valoricms { get; set; }

    public decimal? Valoripi { get; set; }

    public int? Numeroparcelas { get; set; }

    public string? Faturado { get; set; }

    public decimal? Valorsubtrib { get; set; }

    public string? Empresa { get; set; }

    public string? Sincronizado { get; set; }
}
