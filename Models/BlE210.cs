namespace AntaresAPI.Models;

/// <summary>
/// Este registro tem por objetivo informar valores relativos à apuração do ICMS de substituição tributária, mesmo nos
/// casos de períodos sem movimento.
/// </summary>
public partial class BlE210
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// exto fixo contendo &quot;E210&quot; 
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Indicador de movimento:
    /// 0 – Sem operações com ST
    /// 1 – Com operações de ST
    /// 1 caractere
    /// </summary>
    public string? IndMovSt { get; set; }

    /// <summary>
    /// Valor do &quot;Saldo credor de período anterior –
    /// Substituição Tributária&quot; - decimal com 2 casas
    /// </summary>
    public decimal? VlSldCredAntSt { get; set; }

    /// <summary>
    /// Valor total do ICMS ST de devolução de mercadorias - decimal com 2 casas
    /// </summary>
    public decimal? VlDevolSt { get; set; }

    /// <summary>
    /// Valor total do ICMS ST de ressarcimentos - decimal com 2 casas
    /// </summary>
    public decimal? VlRessarcSt { get; set; }

    /// <summary>
    /// Valor total de Ajustes &quot;Outros créditos ST&quot; e “Estorno de débitos ST” - decimal com 2 casas
    /// </summary>
    public decimal? VlOutCredSt { get; set; }

    /// <summary>
    /// Valor total dos ajustes a crédito de ICMS ST, provenientes de ajustes do documento fiscal. Decimal com 2 casas
    /// </summary>
    public decimal? VlAjCreditosSt { get; set; }

    /// <summary>
    /// Valor Total do ICMS retido por Substituição Tributária - decimal com 2 casas
    /// </summary>
    public decimal? VlRetencaoSt { get; set; }

    /// <summary>
    /// Valor Total dos ajustes &quot;Outros débitos ST&quot; &quot; e “Estorno de créditos ST - decimal com 2 casas
    /// </summary>
    public decimal? VlOutDebSt { get; set; }

    /// <summary>
    /// Valor total dos ajustes a débito de ICMS ST, provenientes de ajustes do documento fiscal. Decimal com 2 casas
    /// </summary>
    public decimal? VlAjDebitosSt { get; set; }

    /// <summary>
    /// Valor total de Saldo devedor antes das deduções - decimal com 2 casas
    /// </summary>
    public decimal? VlSldDevAntSt { get; set; }

    /// <summary>
    /// Valor total dos ajustes &quot;Deduções ST&quot; - decimal com 2 casas
    /// </summary>
    public decimal? VlDeducoesSt { get; set; }

    /// <summary>
    /// Imposto a recolher ST (11-12) - decimal com 2 casas
    /// </summary>
    public decimal? VlIcmsRecolSt { get; set; }

    /// <summary>
    /// Saldo credor de ST a transportar para o período seguinte [(03+04+05+06+07+12) – (08+09+10)]. Decimal com 2 casas
    /// </summary>
    public decimal? VlSldCredStTransportar { get; set; }

    /// <summary>
    /// Valores recolhidos ou a recolher, extra-apuração - decimal com 2 casas
    /// </summary>
    public decimal? DebEstSt { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Orienta sobre se o registro é de entrada ou saída na contabilização do arquivo
    /// </summary>
    public string? Origem { get; set; }

    /// <summary>
    /// Identifica lançamento correspondente no registro e200
    /// </summary>
    public int? IdE200 { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }

    /// <summary>
    /// Guarda a UF de acordo com o registro bl_e200
    /// </summary>
    public string? Uf { get; set; }
}
