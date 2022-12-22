namespace AntaresAPI.Models;

/// <summary>
/// ste registro deve ser apresentado para discriminar os valores totais dos itens/produtos do inventário realizado em 31
/// de dezembro de cada exercício, ou nas demais datas estabelecidas pela legislação fiscal ou comercial.
/// O inventário deverá ser apresentado no arquivo da EFD-ICMS/IPI até o segundo mês subsequente ao evento.
/// Exemplo: Inventário realizado em 31/12/08 deverá ser apresentado na EFD-ICMS/IPI de período de referência fevereiro de
/// 2009.
/// A partir de julho de 2012, as empresas que exerçam as atividades descritas na Classificação Nacional de Atividades
/// Econômicas /Fiscal (CNAE-Fiscal) sob os códigos 4681-8/01 e 4681-8/02 deverão apresentar este registro, mensalmente,
/// para discriminar os valores itens/produtos do Inventário realizado ao final do mesmo período de referência do arquivo da
/// EFD-ICMS/IPI. Informar como MOT_INV o código “01”. Exemplo: o inventário realizado no final do mês de janeiro,
/// deverá ser apresentado na escrituração do mês de janeiro.
/// Atribuir valor Zero ao inventário significa escriturar sem estoque.
/// </summary>
public partial class BlH010
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;H010” 
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Código do item (campo 02 do Registro 0200) - 60 caracteres. Coincide com o código do item na tabela produtos
    /// </summary>
    public string? CodItem { get; set; }

    /// <summary>
    /// Unidade do item - 6 caracteres. 
    /// </summary>
    public string? Unid { get; set; }

    /// <summary>
    /// Quantidade do item - decimal com 3 casas
    /// </summary>
    public decimal? Qtd { get; set; }

    /// <summary>
    /// Valor unitário do item - decimal com 6 casas
    /// </summary>
    public decimal? VlUnit { get; set; }

    /// <summary>
    /// Valor do item - decimal com 2 casas
    /// </summary>
    public decimal? VlItem { get; set; }

    /// <summary>
    /// ndicador de propriedade/posse do item:
    /// 0- Item de propriedade do informante e em seu poder;
    /// 1- Item de propriedade do informante em posse de terceiros;
    /// 2- Item de propriedade de terceiros em posse do informante
    /// 1 caractere
    /// </summary>
    public string? IndProp { get; set; }

    /// <summary>
    /// Código do participante (campo 02 do Registro 0150):
    /// - proprietário/possuidor que não seja o informante do arquivo. 60 caracteres
    /// </summary>
    public string? CodPart { get; set; }

    /// <summary>
    /// Descrição complementar. 
    /// </summary>
    public string? TxtCompl { get; set; }

    /// <summary>
    /// Código da conta analítica contábil debitada/creditada 
    /// </summary>
    public string? CodCta { get; set; }

    /// <summary>
    /// Valor do item para efeitos do Imposto de Renda. Decimal com 2 casas
    /// </summary>
    public decimal? VlItemIr { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
