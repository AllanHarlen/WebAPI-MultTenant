namespace AntaresAPI.Models;

/// <summary>
/// Este registro tem por objetivo representar a escrituração dos documentos fiscais totalizados por CST, CFOP e
/// Alíquota de ICMS.
/// Validação do Registro: não podem ser informados dois ou mais registros com a mesma combinação de valores dos
/// campos: CST_ICMS, CFOP e ALIQ_ICMS. A combinação dos valores dos campos CST_ICMS, CFOP e ALIQ_ICMS
/// devem existir no respectivo registro de itens do C170, quando este registro for exigido
/// </summary>
public partial class BlC190
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;C190&quot;
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Código da Situação Tributária, conforme a
    /// Tabela indicada no item 4.3.1 - 3 caracteres
    /// </summary>
    public string? CstIcms { get; set; }

    /// <summary>
    /// Código Fiscal de Operação e Prestação do
    /// agrupamento de itens - 4 caracteres
    /// </summary>
    public string? Cfop { get; set; }

    /// <summary>
    /// Alíquota do ICMS - 6 caracteres; decimal com 6 caracteres
    /// </summary>
    public decimal? AliqIcms { get; set; }

    /// <summary>
    /// Valor da operação na combinação de
    /// CST_ICMS, CFOP e alíquota do ICMS,
    /// correspondente ao somatório do valor das
    /// mercadorias, despesas acessórias (frete, seguros
    /// e outras despesas acessórias), ICMS_ST,
    /// FCP_ST e IPI - decimal com 2 casas
    /// </summary>
    public decimal? VlOpr { get; set; }

    /// <summary>
    /// Parcela correspondente ao &quot;Valor da base de
    /// cálculo do ICMS&quot; referente à combinação de
    /// CST_ICMS, CFOP e alíquota do ICMS. Decimal com 2 casas
    /// </summary>
    public decimal? VlBcIcms { get; set; }

    /// <summary>
    /// Parcela correspondente ao &quot;Valor do ICMS&quot;,
    /// incluindo o FCP, quando aplicável, referente à
    /// combinação de CST_ICMS, CFOP e alíquota do
    /// ICMS - decimal com 2 casas
    /// </summary>
    public decimal? VlIcms { get; set; }

    /// <summary>
    /// Parcela correspondente ao &quot;Valor da base de
    /// cálculo do ICMS&quot; da substituição tributária
    /// referente à combinação de CST_ICMS, CFOP e
    /// alíquota do ICMS. Decimal com 2 casas
    /// </summary>
    public decimal? VlBcIcmsSt { get; set; }

    /// <summary>
    /// Parcela correspondente ao valor
    /// creditado/debitado do ICMS da substituição
    /// tributária, incluindo o FCP_ ST, quando
    /// aplicável, referente à combinação de
    /// CST_ICMS, CFOP, e alíquota do ICMS. Decimal com 2 casas
    /// </summary>
    public decimal? VlIcmsSt { get; set; }

    /// <summary>
    /// Valor não tributado em função da redução da
    /// base de cálculo do ICMS, referente à
    /// combinação de CST_ICMS, CFOP e alíquota do
    /// ICMS - decimal com 2 casas
    /// </summary>
    public decimal? VlRedBc { get; set; }

    /// <summary>
    /// Parcela correspondente ao &quot;Valor do IPI&quot;
    /// referente à combinação CST_ICMS, CFOP e
    /// alíquota do ICMS. Decimal com 2 casas
    /// </summary>
    public decimal? VlIpi { get; set; }

    /// <summary>
    /// Código da observação do lançamento fiscal C 006 - OC OC
    /// (campo 02 do Registro 0460) - 6 caracteres
    /// </summary>
    public string? CodObs { get; set; }

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
