namespace AntaresAPI.Models;

/// <summary>
/// Tabela que guarda os CFOPs utilizados no sistema
/// </summary>
public partial class Cfop
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Código do CFOP
    /// </summary>
    public string Cfop1 { get; set; } = null!;

    /// <summary>
    /// Descrição do CFOP
    /// </summary>
    public string? Descricao { get; set; }

    /// <summary>
    /// Observação fixa vinculada ao CFOP na venda
    /// </summary>
    public string? Aplicacao { get; set; }

    /// <summary>
    /// Campo de controle que define se ao utilizar o referido cfop será gerado financeiro ou não no lançamento
    /// </summary>
    public string? Capcar { get; set; }

    /// <summary>
    /// Campo de controle que define se ao utilizar o referido cfop será gerado faturamento ou não no lançamento
    /// </summary>
    public string? Faturamento { get; set; }

    /// <summary>
    /// Campo de sincronização.
    /// </summary>
    public string? Sincronizado { get; set; }

    /// <summary>
    /// Guarda data de cadastro do CFOP
    /// </summary>
    public DateOnly? Cadastro { get; set; }

    /// <summary>
    /// Guarda data de atualização do cadastro do CFOP
    /// </summary>
    public DateOnly? Atualizacao { get; set; }

    /// <summary>
    /// Guarda id do usuário que cadastrou ou último a editar o cfop
    /// </summary>
    public int? Usuario { get; set; }
}
