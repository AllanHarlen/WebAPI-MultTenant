namespace AntaresAPI.Models;

public partial class Configuracoesemail
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Usuario { get; set; }

    public string? Senha { get; set; }

    public string? Tipossl { get; set; }

    public string Tiposmtp { get; set; } = null!;

    public string? Porta { get; set; }

    public string? Mensagemfixa { get; set; }

    public string Modulo { get; set; } = null!;

    public string? Nomeexibicao { get; set; }
}
