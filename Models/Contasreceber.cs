namespace AntaresAPI.Models;

public partial class Contasreceber
{
    public int Chave1 { get; set; }

    public string? Chave2 { get; set; }

    public string? Cliente { get; set; }

    public string? Razao { get; set; }

    public string? Fantasia { get; set; }

    public DateTime? Emissao { get; set; }

    public DateTime? Vencimento { get; set; }

    public string? Dias { get; set; }

    public string? Documento { get; set; }

    public string? Pedido { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? Pagamento { get; set; }

    public string? Responsavel { get; set; }

    public string? Usuariobaixa { get; set; }

    public string? Cancelado { get; set; }

    public string? Documento2 { get; set; }

    public string? Historico { get; set; }

    public string? Cheque { get; set; }

    public string? Estado { get; set; }

    public string? Tipo { get; set; }

    public string? Origem { get; set; }

    public string? Unificado { get; set; }

    public string? Compra { get; set; }

    public string? Planocontas { get; set; }

    public string? Descricaoplano { get; set; }

    public string? Au { get; set; }

    public decimal? Valorparcial { get; set; }

    public string? Acompanhamento { get; set; }

    public string? Codigobanco { get; set; }

    public string? Banco { get; set; }

    public string? Modelobanco { get; set; }

    public string? Ag { get; set; }

    public string? Cc { get; set; }

    public string? ResponsavelBanco { get; set; }

    public string? Liberacaodesconto { get; set; }

    public decimal? Valordesconto { get; set; }

    public string? Codigorecebimento { get; set; }

    /// <summary>
    /// Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe
    /// </summary>
    public string? Recebimento { get; set; }

    public string? Observacao { get; set; }

    public string? Documento3 { get; set; }

    public string? Romaneio { get; set; }

    public string? Remessa { get; set; }

    public string? Retorno { get; set; }

    public string? Ordemcompra { get; set; }

    public string? Situacao { get; set; }

    public string? Dataremessa { get; set; }

    public string? Dataretorno { get; set; }

    public int? Seqpagparcial { get; set; }

    public string? Backcampodocumento { get; set; }

    public string? Ultimaparcela { get; set; }

    public string? Ch { get; set; }

    public string? Observacaoboleto { get; set; }

    public DateTime? DataPgComissao { get; set; }

    public string? Enviolembrete { get; set; }

    public string? Referencias { get; set; }

    public string? Lembraremailcar { get; set; }

    public string? Empresa { get; set; }

    public string? Forma { get; set; }

    public DateTime? Datacancelamento { get; set; }

    public string? Cnpj { get; set; }

    public string? Sincronizado { get; set; }

    /// <summary>
    /// Link de boleto Safe2pay
    /// </summary>
    public string? Linkboleto { get; set; }

    /// <summary>
    /// Link de carnê Safe2pay
    /// </summary>
    public string? Linkcarne { get; set; }

    /// <summary>
    /// Campo destinado a guardar valor de  acréscimo de boleto ou juros
    /// </summary>
    public decimal? Valoracrescimo { get; set; }
}
