namespace AntaresAPI.Models;

public partial class Compra
{
    public int Chave { get; set; }

    /// <summary>
    /// Guarda documento de compra
    /// </summary>
    public string? Documento { get; set; }

    public string? Pedido { get; set; }

    public string? Fornecedor { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public string? Cnpjcpf { get; set; }

    public DateTime? Emissao { get; set; }

    public decimal? Icms { get; set; }

    public decimal? Icmssubst { get; set; }

    public decimal? Ipi { get; set; }

    public string? Devolucao { get; set; }

    public decimal? Desconto { get; set; }

    public string? Frete { get; set; }

    public decimal? Fretevalor { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? Totalnota { get; set; }

    public decimal? Totalprodutos { get; set; }

    /// <summary>
    /// Limite observacao nfe 5000 caracteres
    /// </summary>
    public string? Observacao { get; set; }

    public string? Recebimento { get; set; }

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

    public string? Modelonf { get; set; }

    public string? Serienf { get; set; }

    public string? Almoxarifado { get; set; }

    public DateTime? Lancamento { get; set; }

    public string? Transportador { get; set; }

    public string? Codigotransportador { get; set; }

    public string? Cfopfrete { get; set; }

    public string? Vencimentofrete { get; set; }

    public string? Conhecimento { get; set; }

    public string? Seriefrete { get; set; }

    public decimal? Bcicmsfrete { get; set; }

    public string? Emissaofrete { get; set; }

    public decimal? Icmsfrete { get; set; }

    public DateTime? Faturamento { get; set; }

    public string? Tipodesconto { get; set; }

    public string? Au { get; set; }

    public string? Tipo { get; set; }

    public decimal? Despesa { get; set; }

    public string? Especie { get; set; }

    public string? Cfoptrasnportador { get; set; }

    public string? Placa { get; set; }

    public string? Protocolo { get; set; }

    public string? Tipofrete { get; set; }

    public string? Recibonfe { get; set; }

    public string? Chavenfe { get; set; }

    public string? Faturado { get; set; }

    public string? Numerovolume { get; set; }

    public string? Quantidadevol { get; set; }

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

    /// <summary>
    /// Guarda chave referenciada da nfe de devolução
    /// </summary>
    public string? Nferef { get; set; }

    public string? Marca { get; set; }

    public string? Conferencia { get; set; }

    public string? Ordemcompra { get; set; }

    public string? Justificativa { get; set; }

    public string? Calcularicmsst { get; set; }

    public decimal? Pispasep { get; set; }

    public decimal? Cofins { get; set; }

    public decimal? Despesasaduaneiras { get; set; }

    public decimal? Vii { get; set; }

    public string? Chavecte { get; set; }

    public string? Modelofrete { get; set; }

    public string? Modbcicms { get; set; }

    public string? Centrocusto { get; set; }

    public string? Nfref { get; set; }

    public string? Codigocusto { get; set; }

    public string? Ufplaca { get; set; }

    public int? Numeroparcelas { get; set; }

    public string? Empresa { get; set; }

    public string? Documentomdfe { get; set; }

    public decimal? Baseipi { get; set; }

    public string? Mododesconto { get; set; }

    public decimal? Basecalculoipi { get; set; }

    public decimal? Denegada { get; set; }

    public decimal? Pliquido { get; set; }

    public decimal? Pbruto { get; set; }

    public string? Cnfe { get; set; }

    public string? Sincronizado { get; set; }

    /// <summary>
    /// Destinado a guarda de xmls das notas emitidas em compras
    /// </summary>
    public string? XmlProc { get; set; }
}
