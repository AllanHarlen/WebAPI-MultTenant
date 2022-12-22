namespace AntaresAPI.Models;

public partial class AppTransacaoSafe2pay
{
    public int Id { get; set; }

    public string IdTransaction { get; set; } = null!;

    /// <summary>
    /// Token transação cartão
    /// </summary>
    public string Token { get; set; } = null!;

    /// <summary>
    /// Retorno transação cartão
    /// </summary>
    public string Descricao { get; set; } = null!;

    /// <summary>
    /// Status transação cartão
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// Mensagem transação cartão
    /// </summary>
    public string Mensagem { get; set; } = null!;

    /// <summary>
    /// Data transação cartão
    /// </summary>
    public DateOnly Data { get; set; }

    /// <summary>
    /// Número do pedido transação cartão
    /// </summary>
    public string Pedido { get; set; } = null!;
}
