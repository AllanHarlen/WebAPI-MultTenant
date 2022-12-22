namespace AntaresAPI.Models;

public partial class Turma
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public ulong Ativo { get; set; }

    public DateTime Datacadastro { get; set; }

    public string Usuariocadastro { get; set; } = null!;

    public DateTime? Dataatualizacao { get; set; }

    public string? Usuarioalteracao { get; set; }

    public decimal? Meta { get; set; }
}
