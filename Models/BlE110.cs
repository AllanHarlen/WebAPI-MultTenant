namespace AntaresAPI.Models;

/// <summary>
/// Este registro tem por objetivo informar os valores relativos à apuração do ICMS referentes às operações próprias. O
/// registro deve ser apresentado inclusive nos casos de períodos sem movimento. Neste caso, os valores deverão ser
/// apresentados zerados.
/// </summary>
public partial class BlE110
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;E110&quot;
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Valor total dos débitos por &quot;Saídas e prestações com
    /// débito do imposto&quot; Decimal com 2 casas
    /// </summary>
    public decimal? VlTotDebitos { get; set; }

    /// <summary>
    /// Valor total dos ajustes a débito decorrentes do
    /// documento fiscal. Decimal com 2 casas
    /// </summary>
    public decimal? VlAjDebitos { get; set; }

    /// <summary>
    /// Valor total de &quot;Ajustes a débito&quot; - Decimal com 2 casas
    /// </summary>
    public decimal? VlTotAjDebitos { get; set; }

    /// <summary>
    /// Valor total de Ajustes “Estornos de créditos” - decimal com 2 casas
    /// </summary>
    public decimal? VlEstornosCred { get; set; }

    /// <summary>
    /// Valor total dos créditos por &quot;Entradas e aquisições com
    /// crédito do imposto&quot; - Decimal com 2 casas
    /// </summary>
    public decimal? VlTotCreditos { get; set; }

    /// <summary>
    /// Valor total dos ajustes a crédito decorrentes do
    /// documento fiscal. Decimal com 2 casas
    /// </summary>
    public decimal? VlAjCreditos { get; set; }

    /// <summary>
    /// Valor total de &quot;Ajustes a crédito&quot; - Decimal com 2 casas
    /// </summary>
    public decimal? VlTotAjCreditos { get; set; }

    /// <summary>
    /// Valor total de Ajustes “Estornos de Débitos” - Decimal com 2 Casas
    /// </summary>
    public decimal? VlEstornosDeb { get; set; }

    /// <summary>
    /// Valor total de &quot;Saldo credor do período anterior&quot;  - decimal com 2 casas
    /// </summary>
    public decimal? VlSldCredorAnt { get; set; }

    /// <summary>
    /// Valor do saldo devedor apurado - decimal com 2 casas
    /// </summary>
    public decimal? VlSldApurado { get; set; }

    /// <summary>
    /// Valor total de &quot;Deduções&quot; - decimal com 2 casas
    /// </summary>
    public decimal? VlTotDed { get; set; }

    /// <summary>
    /// Valor total de &quot;ICMS a recolher (11-12) - decimal com 2 casas
    /// </summary>
    public decimal? VlIcmsRecolher { get; set; }

    /// <summary>
    /// Valor total de &quot;Saldo credor a transportar para o período
    /// seguinte” - decimal com 2 casas
    /// </summary>
    public decimal? VlSldCredorTransportar { get; set; }

    /// <summary>
    /// Valores recolhidos ou a recolher, extra-apuração. Decimal com 2 casas
    /// </summary>
    public decimal? DebEsp { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
