namespace AntaresAPI.Models;

public partial class Pedidovendum
{
    public int Chave { get; set; }

    public string Documento { get; set; } = null!;

    public string? Cliente { get; set; }

    public string? Codigoauxiliar { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public string? Cnpjcpf { get; set; }

    public string? Uf { get; set; }

    public DateTime? Faturamento { get; set; }

    public DateTime? Emissao { get; set; }

    public decimal? Icms { get; set; }

    public decimal? Icmssubst { get; set; }

    public decimal? Ipi { get; set; }

    public string? Devolucao { get; set; }

    public string? Tipodesconto { get; set; }

    public decimal? Desconto { get; set; }

    public string? Frete { get; set; }

    public decimal? Fretevalor { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? Totalproduto { get; set; }

    public decimal? Total { get; set; }

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

    public DateTime? Cancelado { get; set; }

    public string? Auditoria { get; set; }

    public string? Au { get; set; }

    public string? Vendedor1 { get; set; }

    public string? Nomevendedor1 { get; set; }

    public decimal? Comissao1 { get; set; }

    public string? Vendedor2 { get; set; }

    public string? Nomevendedor2 { get; set; }

    public decimal? Comissao2 { get; set; }

    public decimal? Comissaorepresentante { get; set; }

    public decimal? Valorcomissaorepresentante { get; set; }

    public string? Fornecedor { get; set; }

    public string? Codigofornecedor { get; set; }

    public string? Fantasiafornecedor { get; set; }

    public string? Transportadora { get; set; }

    public string? Vale { get; set; }

    public string? Tipo { get; set; }

    public decimal? Despesa { get; set; }

    public string? Cotacao { get; set; }

    public string? Faturamentominimo { get; set; }

    public string? Garantia { get; set; }

    public string? Validade { get; set; }

    public string? Impostos { get; set; }

    public int? Revisao { get; set; }

    public string? Contato { get; set; }

    public string? Endereco { get; set; }

    public string? Fone { get; set; }

    public string? Ordemcompra { get; set; }

    public string? Categoria { get; set; }

    public string? Contrato { get; set; }

    public string? Situacao { get; set; }

    public string? Status { get; set; }

    public int? Codigoendereco { get; set; }

    public string? Codigocusto { get; set; }

    public string? Centrocusto { get; set; }

    public int? Numeroparcelas { get; set; }

    public string? Placa { get; set; }

    public string? Ufplaca { get; set; }

    public string? Mododesconto { get; set; }

    public string? Codigotransportadora { get; set; }

    public decimal? Bcicms { get; set; }

    public decimal? Bcipi { get; set; }

    public decimal? Vicms { get; set; }

    public decimal? Vipi { get; set; }

    public decimal? Pliquido { get; set; }

    public decimal? Pbruto { get; set; }

    public string? Empresa { get; set; }

    public string? Sincronizado { get; set; }

    /// <summary>
    /// Valor da base de cálculo do ICMS ST no pedido de venda
    /// </summary>
    public decimal? Vbcst { get; set; }

    /// <summary>
    /// Valor do ICMS ST no pedido de venda
    /// </summary>
    public decimal? Vicmsst { get; set; }

    /// <summary>
    /// Valor do PIS no pedido de venda
    /// </summary>
    public decimal? Vpis { get; set; }

    /// <summary>
    /// Valor do COFINS no pedido de venda
    /// </summary>
    public decimal? Vcofins { get; set; }
}
