namespace AntaresAPI.Models;

public partial class Cheque
{
    public int Id { get; set; }

    public string? Banco { get; set; }

    public string? Agencia { get; set; }

    public string? Conta { get; set; }

    public string? Numerocheque { get; set; }

    public DateTime? Vencimento { get; set; }

    public decimal? Valor { get; set; }

    public string? Responsavelnome { get; set; }

    public string? Responsavelcnpj { get; set; }

    public string? Responsavelfone { get; set; }

    public string? Emitentenome { get; set; }

    public string? Emitentecnpj { get; set; }

    public string? Emitentefone { get; set; }

    public string? Observacao { get; set; }

    public string? Titulo { get; set; }

    public string? Origem { get; set; }

    public string? Status { get; set; }

    public string? Factoring { get; set; }

    public DateTime? Datafactoring { get; set; }

    public string? Codigofactoring { get; set; }

    public string? Auditoria { get; set; }
}
