namespace AntaresAPI.Models;

public partial class Movimentocaixa
{
    public int Id { get; set; }

    public string Chave { get; set; } = null!;

    public string? Documento { get; set; }

    public string? Codigo { get; set; }

    public string? Historico { get; set; }

    public DateTime? Data { get; set; }

    public string? Origem { get; set; }

    public DateTime? Competencia { get; set; }

    public string? Concilacao { get; set; }

    public string? Codigoplano { get; set; }

    public string? Planocontas { get; set; }

    public string? Codigorecebimento { get; set; }

    /// <summary>
    /// Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe
    /// </summary>
    public string? Recebimento { get; set; }

    public string? Usuario { get; set; }

    public string? Codigobanco { get; set; }

    public string? Banco { get; set; }

    public string? Numeroconta { get; set; }

    public string? Contacorrente { get; set; }

    public string? Tipo { get; set; }

    public decimal? Valor { get; set; }

    public string? Auditoria { get; set; }

    public string? Cancelado { get; set; }

    public string? Empresa { get; set; }

    public string? Sincronizado { get; set; }
}
