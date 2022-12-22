namespace AntaresAPI.Models;

/// <summary>
/// Registro obrigatório para discriminar os itens da nota fiscal (mercadorias e/ou serviços constantes em notas
/// conjugadas), inclusive em operações de entrada de mercadorias acompanhadas de Nota Fiscal Eletrônica (NF-e) de emissão
/// de terceiros.
/// Conforme item 2.4.2.2.1 da Nota Técnica, instituída pelo Ato COTEPE/ICMS nº 44/2018 e alterações, o termo
/// “item” é aplicado às operações fiscais que envolvam mercadorias, serviços, produtos ou quaisquer outros itens concernentes
/// às transações fiscais suportadas pelo documento, como, por exemplo, nota fiscal complementar, nota fiscal de ressarcimento,
/// transferências de créditos e outros casos.
///  Validação do Registro: Não podem ser informados para um mesmo documento fiscal dois ou mais registros com o
/// mesmo conteúdo no campo NUM_ITEM.
/// IMPORTANTE: para documentos de entrada, os campos de valor de imposto, base de cálculo e alíquota só devem ser
/// informados se o adquirente tiver direito à apropriação do crédito (enfoque do declarante).
/// </summary>
public partial class BlC170
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;C170&quot; - 4 caracteres
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Número sequencial do item no documento - 3 caracteres
    /// </summary>
    public string? NumItem { get; set; }

    /// <summary>
    /// Código do item (campo 02 do Registro 0200) - 60 caracteres
    /// </summary>
    public string? CodItem { get; set; }

    /// <summary>
    /// Descrição complementar do item como adotado
    /// </summary>
    public string? DescrCompl { get; set; }

    /// <summary>
    /// Quantidade do item - decimal com 5 casas
    /// </summary>
    public decimal? Qtd { get; set; }

    /// <summary>
    /// Unidade do item (Campo 02 do registro 0190) - 6 caracteres
    /// </summary>
    public string? Unid { get; set; }

    /// <summary>
    /// Valor total do item (mercadorias ou serviços) - 2 caracteres
    /// </summary>
    public decimal? VlItem { get; set; }

    /// <summary>
    /// Valor do desconto comercial - decimal com 2 casas
    /// </summary>
    public decimal? VlDesc { get; set; }

    /// <summary>
    /// Movimentação física do ITEM/PRODUTO:
    /// 0. SIM
    /// 1. NÃO
    /// 1 caractere
    /// </summary>
    public string? IndMov { get; set; }

    /// <summary>
    /// Código da Situação Tributária referente ao
    /// ICMS, conforme a Tabela indicada no item
    /// 4.3.1
    /// 3 caracteres
    /// </summary>
    public string? CstIcms { get; set; }

    /// <summary>
    /// CFOP - Código Fiscal de Operação e Prestação
    /// </summary>
    public string? Cfop { get; set; }

    /// <summary>
    /// Código da conta analítica contábil
    /// debitada/creditada
    /// </summary>
    public string? CodNat { get; set; }

    /// <summary>
    /// Valor da base de cálculo do ICMS - decimal com 2 casas
    /// </summary>
    public decimal? VlBcIcms { get; set; }

    /// <summary>
    /// Alíquota do ICMS - 6 caracteres decimal com duas casas
    /// </summary>
    public decimal? AliqIcms { get; set; }

    /// <summary>
    /// Valor da base de cálculo referente à
    /// substituição tributária
    /// Decimal com 2 casas decimais
    /// </summary>
    public decimal? VlIcms { get; set; }

    /// <summary>
    /// Valor da base de cálculo referente à
    /// substituição tributária - decimal com 2 casas
    /// </summary>
    public decimal? VlBcIcmsSt { get; set; }

    /// <summary>
    /// Alíquota do ICMS da substituição tributária na
    /// </summary>
    public decimal? AliqSt { get; set; }

    /// <summary>
    /// Valor do ICMS referente à substituição
    /// tributária - decimal com 2 casa
    /// </summary>
    public decimal? VlIcmsSt { get; set; }

    /// <summary>
    /// Indicador de período de apuração do IPI:
    /// 0 - Mensal;
    /// 1 - Decendial
    /// 1 caractere
    /// </summary>
    public string? IndApur { get; set; }

    /// <summary>
    /// Indicador de período de apuração do IPI:
    /// 0 - Mensal;
    /// 1 - Decendial
    ///  2 caracteres
    /// </summary>
    public string? CstIpi { get; set; }

    /// <summary>
    /// Código de enquadramento legal do IPI,
    /// conforme tabela indicada no item 4.5.3.
    /// 3 caracteres
    /// </summary>
    public string? CodEnq { get; set; }

    /// <summary>
    /// Valor da base de cálculo do IPI - decimal com 2 casas
    /// </summary>
    public decimal? VlBcIpi { get; set; }

    /// <summary>
    /// Alíquota do IPI - 6 caracteres decimal com 2 casas
    /// </summary>
    public decimal? AliqIpi { get; set; }

    /// <summary>
    /// Valor do IPI creditado/debitado - decimal com 2 casas
    /// </summary>
    public decimal? VlIpi { get; set; }

    /// <summary>
    /// Código da Situação Tributária referente ao PIS - 2 caracteres
    /// </summary>
    public string? CstPis { get; set; }

    /// <summary>
    /// Valor da base de cálculo do PIS - decimal com 2 casas
    /// </summary>
    public decimal? VlBcPis { get; set; }

    /// <summary>
    /// Alíquota do PIS (em percentual) - 8 caracteres, decimal com 4 casas
    /// </summary>
    public decimal? AliqPis { get; set; }

    /// <summary>
    /// Quantidade – Base de cálculo PIS - decimal com 3 casas
    /// </summary>
    public decimal? QuantBcPis { get; set; }

    /// <summary>
    /// Alíquota do PIS (em reais) - decimal com 3 casas
    /// </summary>
    public decimal? AliqPisReais { get; set; }

    /// <summary>
    /// Valor do PIS - decimal com 2 casas
    /// </summary>
    public decimal? VlPis { get; set; }

    /// <summary>
    /// Código da Situação Tributária referente ao
    /// COFINS - 2 caracteres
    /// </summary>
    public string? CstCofins { get; set; }

    /// <summary>
    /// Valor da base de cálculo da COFINS - decimal com 2 casas
    /// </summary>
    public decimal? VlBcCofins { get; set; }

    /// <summary>
    /// Alíquota do COFINS (em percentual) - 8 caracteres; decimal com 4 casas
    /// </summary>
    public decimal? AliqCofins { get; set; }

    /// <summary>
    /// Quantidade – Base de cálculo COFINS - decimal com 3 casas
    /// </summary>
    public decimal? QuantBcCofins { get; set; }

    /// <summary>
    /// Alíquota da COFINS (em reais) - decimal com 4 casas
    /// </summary>
    public decimal? AliqCofinsReais { get; set; }

    /// <summary>
    /// Valor da COFINS - decimal com 2 casas
    /// </summary>
    public decimal? VlCofins { get; set; }

    /// <summary>
    /// Código da conta analítica contábil
    /// debitada/creditada
    /// </summary>
    public string? CodCta { get; set; }

    /// <summary>
    /// Valor do abatimento não tributado e não
    /// comercial - decimal com 2 casas
    /// </summary>
    public decimal? VlAbatNt { get; set; }

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
