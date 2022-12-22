namespace AntaresAPI.Models;

/// <summary>
/// Este registro deve ser gerado para cada documento fiscal código 01, 1B, 04, 55 e 65 (saída), conforme item 4.1.1 da
/// Nota Técnica (Ato COTEPE/ICMS nº 44/2018 e alterações), registrando a entrada ou saída de produtos ou outras situações
/// que envolvam a emissão dos documentos fiscais mencionados. As NFC-e (código 65) não devem ser escrituradas nas
/// entradas
/// </summary>
public partial class BlC100
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;C100&quot;
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Indicador do tipo de operação:
    /// 0 - Entrada;
    /// 1 - Saída
    /// 1 caractere
    /// </summary>
    public string? IndOper { get; set; }

    /// <summary>
    /// Indicador do emitente do documento fiscal:
    /// 0 - Emissão própria;
    /// 1 - Terceiros
    /// 1 caractere
    /// </summary>
    public string? IndEmit { get; set; }

    /// <summary>
    /// Código do participante (campo 02 do Registro
    /// 0150):
    /// - do emitente do documento ou do remetente
    /// das mercadorias, no caso de entradas;
    /// - do adquirente, no caso de saídas
    /// 60 caracteres
    /// </summary>
    public string? CodPart { get; set; }

    /// <summary>
    /// Código do modelo do documento fiscal,
    /// conforme a Tabela 4.1.1 - 2 caracteres
    /// </summary>
    public string? CodMod { get; set; }

    /// <summary>
    /// Código da situação do documento fiscal,
    /// conforme a Tabela 4.1.2 - 2 caracteres
    /// </summary>
    public string? CodSit { get; set; }

    /// <summary>
    /// Série do documento fiscal - 3 caracteres
    /// </summary>
    public string? Ser { get; set; }

    /// <summary>
    /// Número do documento fiscal - 9 caracteres
    /// </summary>
    public string? NumDoc { get; set; }

    /// <summary>
    /// Chave da Nota Fiscal Eletrônica - 44 caracteres
    /// </summary>
    public string? ChvNfe { get; set; }

    /// <summary>
    /// Data da emissão do documento fiscal - 8 caracteres
    /// </summary>
    public string? DtDoc { get; set; }

    /// <summary>
    /// Data da entrada ou da saída - 8 caracteres
    /// </summary>
    public string? DtES { get; set; }

    /// <summary>
    /// Valor total do documento fiscal - Decimal com 2 casas
    /// </summary>
    public decimal? VlDoc { get; set; }

    /// <summary>
    /// Indicador do tipo de pagamento:
    /// 0 - À vista;
    /// 1 - A prazo;
    /// 9 - Sem pagamento.
    /// Obs.: A partir de 01/07/2012 passará a ser:
    /// Indicador do tipo de pagamento:
    /// 0 - À vista;
    /// 1 - A prazo;
    /// 2 - Outros
    /// 1 caractere
    /// </summary>
    public string? IndPgto { get; set; }

    /// <summary>
    /// Valor total do desconto - decimal com 2 casas
    /// </summary>
    public decimal? VlDesc { get; set; }

    /// <summary>
    /// Abatimento não tributado e não comercial
    /// Por exemplo: desconto ICMS nas remessas para
    /// ZFM.
    /// decimal com 2 casas
    /// </summary>
    public decimal? VlAbatNt { get; set; }

    /// <summary>
    /// Valor total das mercadorias e serviços - 2 caracteres
    /// </summary>
    public decimal? VlMerc { get; set; }

    /// <summary>
    /// Indicador do tipo do frete:
    /// Obs: A partir de 01/01/2018 passará a ser:
    /// Indicador do tipo de frete:
    /// 0 - Contratação do Frete por conta do
    /// Remetente (CIF);
    /// 1 - Contratação do Frete por conta do
    /// Destinatário (FOB);
    /// 2 - Contratação do Frete por conta de
    /// Terceiros;
    /// 3 - Transporte Próprio por conta do
    /// Remetente;
    /// 4 - Transporte Próprio por conta do
    /// Destinatário;
    /// 9 - Sem Ocorrência de Transporte.
    /// 1 caractere
    /// </summary>
    public string? IndFrt { get; set; }

    /// <summary>
    /// Valor do frete indicado no documento fiscal - decimal com duas casas
    /// </summary>
    public decimal? VlFrt { get; set; }

    /// <summary>
    /// Valor do seguro indicado no documento fiscal - decimal com duas casas
    /// </summary>
    public decimal? VlSeg { get; set; }

    /// <summary>
    /// Valor de outras despesas acessórias - decimal com duas casas
    /// </summary>
    public decimal? VlOutDa { get; set; }

    /// <summary>
    /// Valor da base de cálculo do ICMS - decimal com duas casas
    /// </summary>
    public decimal? VlBcIcms { get; set; }

    /// <summary>
    /// Valor do ICMS - decimal com duas casas
    /// </summary>
    public decimal? VlIcms { get; set; }

    /// <summary>
    /// Valor da base de cálculo do ICMS substituição - decimal com duas casas
    /// </summary>
    public decimal? VlBcIcmsst { get; set; }

    /// <summary>
    /// Valor do ICMS retido por substituição - decimal com duas casas
    /// </summary>
    public decimal? VlIcmsSt { get; set; }

    /// <summary>
    /// Valor total do IPI - decimal com duas casas
    /// </summary>
    public decimal? VlIpi { get; set; }

    public decimal? VlPis { get; set; }

    /// <summary>
    /// Valor total do COFINS - decimal com duas casas
    /// </summary>
    public decimal? VlCofins { get; set; }

    /// <summary>
    /// Valor total do PIS retido por substituição - decimal com duas casas
    /// </summary>
    public decimal? VlPisSt { get; set; }

    /// <summary>
    /// Valor total do COFINS retido por substituição - decimal com duas casas
    /// </summary>
    public decimal? VlCofinsSt { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Chave primária da compra informada no registro
    /// </summary>
    public int? IdCompra { get; set; }

    /// <summary>
    /// Chave primária da venda informada no registro
    /// </summary>
    public int? IdVenda { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
