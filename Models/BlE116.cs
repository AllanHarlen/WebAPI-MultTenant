namespace AntaresAPI.Models;

/// <summary>
/// Este registro tem o objetivo de discriminar os pagamentos realizados ou a realizar, referentes à apuração do ICMS –
/// Operações Próprias do período. A soma do valor das obrigações deste registro deve ser igual à soma dos campos
/// VL_ICMS_RECOLHER e DEB_ESP, do registro E110
/// </summary>
public partial class BlE116
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;E116&quot; 
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Código da obrigação a recolher, conforme a Tabela 5.4 - 3 caracteres
    /// </summary>
    public string? CodOr { get; set; }

    /// <summary>
    /// Valor da obrigação a recolher - decimal com 2 casas
    /// </summary>
    public decimal? VlOr { get; set; }

    /// <summary>
    /// Data de vencimento da obrigação - 8 caracteres
    /// </summary>
    public string? DtVcto { get; set; }

    /// <summary>
    /// Código de receita referente à obrigação, próprio da unidade da
    /// federação, conforme legislação estadual.
    /// </summary>
    public string? CodRec { get; set; }

    /// <summary>
    /// Número do processo ou auto de infração ao qual a obrigação está vinculada, se houver - 15 caracteres
    /// </summary>
    public string? NumProc { get; set; }

    /// <summary>
    /// Indicador da origem do processo:
    /// 0- SEFAZ;
    /// 1- Justiça Federal;
    /// 2- Justiça Estadual;
    /// 9- Outros
    /// 1 caracteres
    /// </summary>
    public string? IndProc { get; set; }

    /// <summary>
    /// Descrição resumida do processo que embasou o lançamento 
    /// </summary>
    public string? Proc { get; set; }

    /// <summary>
    /// Descrição complementar das obrigações a recolher
    /// </summary>
    public string? TxtCompl { get; set; }

    /// <summary>
    /// Informe o mês de referência no formato “mmaaaa” - 6 caracteres
    /// </summary>
    public string? MesRef { get; set; }

    public DateTime? Data { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
