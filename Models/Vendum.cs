namespace AntaresAPI.Models;

public partial class Vendum
{
    public int Chave { get; set; }

    public string Documento { get; set; } = null!;

    public string? Pedido { get; set; }

    public string? Cliente { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public string? Cnpjcpf { get; set; }

    public string? Uf { get; set; }

    public string? Faturamento { get; set; }

    public DateTime? Emissao { get; set; }

    public decimal? Icms { get; set; }

    public decimal? Icmssubst { get; set; }

    public decimal? Ipi { get; set; }

    public string? Devolucao { get; set; }

    public string? Tipodesconto { get; set; }

    public decimal Desconto { get; set; }

    public string? Frete { get; set; }

    public decimal? Fretevalor { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? Totalproduto { get; set; }

    public decimal? Total { get; set; }

    public string? Observacao { get; set; }

    public string? Observacaofisco { get; set; }

    public string? Recebimento { get; set; }

    /// <summary>
    /// Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe
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

    public string? Vendedor1 { get; set; }

    public string? Nomevendedor1 { get; set; }

    public decimal? Comissao1 { get; set; }

    public string? Vendedor2 { get; set; }

    public string? Nomevendedor2 { get; set; }

    public decimal? Comissao2 { get; set; }

    public decimal? Comissaorepresentante { get; set; }

    public decimal? Valorcomissaorepresentante { get; set; }

    public string? Codigofornecedor { get; set; }

    public string? Fantasiafornecedor { get; set; }

    public string? Transportadora { get; set; }

    public string? Vale { get; set; }

    public string? Tipo { get; set; }

    public string? Fornecedor { get; set; }

    public decimal? Despesa { get; set; }

    public string? Especie { get; set; }

    public string? Icmsfrete { get; set; }

    public string? Cfoptrasnportador { get; set; }

    public string? Placa { get; set; }

    public string? Protocolo { get; set; }

    public string? Tipofrete { get; set; }

    public string? Tabela { get; set; }

    public string? Recibonfe { get; set; }

    public string? Chavenfe { get; set; }

    public string? Faturado { get; set; }

    public string? Numerovolume { get; set; }

    public string? Quantidadevol { get; set; }

    public string? Origem { get; set; }

    public decimal? Basecalculoicms { get; set; }

    public decimal? Valoricms { get; set; }

    public decimal? Basecalculoicmsst { get; set; }

    public decimal? Valoricmsst { get; set; }

    public decimal? Valoripi { get; set; }

    public string? Emitido { get; set; }

    public string? Tipoemissao { get; set; }

    public string? Fat { get; set; }

    public DateTime? Saida { get; set; }

    public string? Motivocancelamento { get; set; }

    public int? Seqcce { get; set; }

    public string? St { get; set; }

    public string? Documento2 { get; set; }

    public string? Nferef { get; set; }

    public DateTime? Saidaromaneio { get; set; }

    public DateTime? Entregaromaneio { get; set; }

    public string? Marca { get; set; }

    public string? Romaneio { get; set; }

    public string? Ordemcompra { get; set; }

    public string? Lacre1 { get; set; }

    public string? Lacre2 { get; set; }

    public string? Kmandamento { get; set; }

    public string? Cliente2 { get; set; }

    public string? Razao2 { get; set; }

    public string? Placa1 { get; set; }

    public string? Placa2 { get; set; }

    public string? Hidrometro { get; set; }

    public string? Contrato { get; set; }

    public string? Campo1 { get; set; }

    public string? Campo2 { get; set; }

    public string? Campo3 { get; set; }

    public string? Campo4 { get; set; }

    public string? Nfse { get; set; }

    public string? Denegada { get; set; }

    public string? Tipocfop { get; set; }

    public string? Gnre { get; set; }

    public decimal? Pliquido { get; set; }

    public decimal? Pbruto { get; set; }

    public string? Codigoverificacaonfse { get; set; }

    public decimal? Totalproduto2 { get; set; }

    public decimal? Total2 { get; set; }

    public decimal? Percentual { get; set; }

    public decimal? Percentualissretido { get; set; }

    public decimal? Valorissretido { get; set; }

    public string? IpiBcicms { get; set; }

    public string? Municipioprestacaoservico { get; set; }

    public string? Modelobc { get; set; }

    public string? Ufplaca { get; set; }

    public int? Codigoendereco { get; set; }

    public string? Statusvenda { get; set; }

    public string? Codigocusto { get; set; }

    public string? Centrocusto { get; set; }

    public string? Codigotransportador { get; set; }

    public decimal? Impostoaproximado { get; set; }

    public string? Codigoantt { get; set; }

    public string? Empresa { get; set; }

    public string? Documentomdfe { get; set; }

    public string? Almoxarifado { get; set; }

    public int? Numeroparcelas { get; set; }

    public string? Mododesconto { get; set; }

    public string? Historicoremoverfinanceiro { get; set; }

    public decimal? Pis { get; set; }

    public decimal? Cofins { get; set; }

    public decimal? Csll { get; set; }

    public decimal? Inss { get; set; }

    public decimal? Irpj { get; set; }

    public decimal? Vbcipi { get; set; }

    public decimal? Vbsipi { get; set; }

    public string? Cnfe { get; set; }

    public decimal? Desconto2 { get; set; }

    public string? Sincronizado { get; set; }

    public string? XmlAssinado { get; set; }

    public string? XmlProc { get; set; }

    public int? Localentrega { get; set; }

    public int? Serie { get; set; }
}
