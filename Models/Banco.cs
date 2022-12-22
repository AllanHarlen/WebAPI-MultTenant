namespace AntaresAPI.Models;

public partial class Banco
{
    public int Id { get; set; }

    public string? Banco1 { get; set; }

    public string? Descricao { get; set; }

    public string? Agencia { get; set; }

    public string? DigitoAg { get; set; }

    public string? Conta { get; set; }

    public string? DigitoConta { get; set; }

    public decimal? Saldo { get; set; }

    public string? Datacadastro { get; set; }

    public string? Responsavel { get; set; }

    public string? NCheque { get; set; }

    public string? Tipoboleto { get; set; }

    public string? Mensagem1 { get; set; }

    public string? Mensagem2 { get; set; }

    public string? Mensagem3 { get; set; }

    public int? Diasprotesto { get; set; }

    public string? Nossonumero { get; set; }

    public string? Carteira { get; set; }

    public string? Convenio { get; set; }

    public string? Protestar { get; set; }

    public string? Cnab { get; set; }

    public int? Protestardiascorridos { get; set; }

    public int? Protestardiasuteis { get; set; }

    public int? Naoreceberdias { get; set; }

    public decimal? Jurosdemora { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Multa { get; set; }

    public string? Especie { get; set; }

    public string? Reciboentrega { get; set; }

    public string? Codigoempresa { get; set; }

    public int? Qtdremessa { get; set; }

    public string? Registrada { get; set; }

    public string? Ativo { get; set; }

    public int Codigo { get; set; }

    public string? Desativar { get; set; }

    public string? Sincronizado { get; set; }

    /// <summary>
    /// Habilita Safe2pay pra conta bancária
    /// </summary>
    public string? Apiboleto { get; set; }
}
