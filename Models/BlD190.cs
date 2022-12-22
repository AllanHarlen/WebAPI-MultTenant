namespace AntaresAPI.Models;

/// <summary>
/// Este registro tem por objetivo informar as Notas Fiscais de Serviço de Transporte (Código 07) e demais documentos
/// elencados no título deste registro e especificados no registro D100, totalizados pelo agrupamento das combinações dos
/// valores de CST, CFOP e Alíquota dos itens de cada documento.
/// Obs.: Nas operações de entradas, informar o CST sob o enfoque do declarante
/// </summary>
public partial class BlD190
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;D190&quot; 
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Código da Situação Tributária, conforme a tabela
    /// indicada no item 4.3.1 - 3 caracteres
    /// </summary>
    public string? CstIcms { get; set; }

    /// <summary>
    /// Código Fiscal de Operação e Prestação, conforme a
    /// tabela indicada no item 4.2.2 - 4 caracteres
    /// </summary>
    public string? Cfop { get; set; }

    /// <summary>
    /// Alíquota do ICMS - 6 caracteres, decimal com 2 casas
    /// </summary>
    public decimal? AliqIcms { get; set; }

    /// <summary>
    /// Valor da operação correspondente à combinação de
    /// CST_ICMS, CFOP, e alíquota do ICMS. Decimal com 2 casas
    /// </summary>
    public decimal? VlOpr { get; set; }

    /// <summary>
    /// Parcela correspondente ao &quot;Valor da base de cálculo
    /// do ICMS&quot; referente à combinação CST_ICMS,
    /// CFOP, e alíquota do ICMS - decimal com 2 casas
    /// </summary>
    public decimal? VlBcIcms { get; set; }

    /// <summary>
    /// Parcela correspondente ao &quot;Valor do ICMS&quot;
    /// referente à combinação CST_ICMS, CFOP e
    /// alíquota do ICMS - decimal com 2 casas
    /// </summary>
    public decimal? VlIcms { get; set; }

    /// <summary>
    /// Valor não tributado em função da redução da base de
    /// cálculo do ICMS, referente à combinação de
    /// CST_ICMS, CFOP e alíquota do ICMS - decimal com 2 casas
    /// </summary>
    public decimal? VlRedBr { get; set; }

    /// <summary>
    /// Código da observação do lançamento fiscal (campo
    /// 02 do Registro 0460) - 6 caracteres
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
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
