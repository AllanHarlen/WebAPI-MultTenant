namespace AntaresAPI.Models;

/// <summary>
/// Tabela para registro de ações de usuário
/// </summary>
public partial class Audit
{
    /// <summary>
    /// Data da inserção do log
    /// </summary>
    public DateTime Data { get; set; }

    /// <summary>
    /// Log de ações do usuário
    /// </summary>
    public string Log { get; set; } = null!;
}
