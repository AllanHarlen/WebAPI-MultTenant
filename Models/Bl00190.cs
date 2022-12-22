namespace AntaresAPI.Models;

/// <summary>
/// Tabela para gerar arquivo Sped ECf ICMS IPI na Identificação das Unidades de Medida
/// </summary>
public partial class Bl00190
{
    /// <summary>
    /// campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo 0190 - 4 caracteres
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Código da unidade de medida - 6 caracteres
    /// </summary>
    public string? Unid { get; set; }

    /// <summary>
    /// Descrição da unidade de medida
    /// </summary>
    public string? Descr { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo. 
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
