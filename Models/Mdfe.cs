namespace AntaresAPI.Models;

public partial class Mdfe
{
    public int Id { get; set; }

    public string? Documento { get; set; }

    public string? Status { get; set; }

    public string? Modo { get; set; }

    public string? Ufcarregamento { get; set; }

    public string? Ufdescarregamento { get; set; }

    public string? Serie { get; set; }

    public DateTime? Emissao { get; set; }

    public string? Rntc { get; set; }

    public string? Ciot { get; set; }

    public string? Placa { get; set; }

    public string? Uf { get; set; }

    public string? Carroceria { get; set; }

    public decimal? Tara { get; set; }

    public string? Tiporodado { get; set; }

    public decimal? Capacidadekg { get; set; }

    public decimal? Capacidadem3 { get; set; }

    public string? Propriedade { get; set; }

    public string? Proprietarionome { get; set; }

    public string? Proprietariocnpj { get; set; }

    public string? Proprietarioinscricao { get; set; }

    public string? Proprietariouf { get; set; }

    public string? Proprietariotipo { get; set; }

    public string? Unidade { get; set; }

    public decimal? Pesobruto { get; set; }

    public decimal? Valorcarga { get; set; }

    public string? Observacao { get; set; }

    public DateTime? Cancelado { get; set; }

    public string? Protocolo { get; set; }

    public string? Chavenfe { get; set; }

    public string? Encerramento { get; set; }

    public string? Recibo { get; set; }

    public string? Proprietariorntc { get; set; }

    public string? Justificativacancelamento { get; set; }

    public string? Empresa { get; set; }

    public string? Sincronizado { get; set; }

    public string? Tipocarga { get; set; }

    public string? Produto { get; set; }

    public string? Cepcarregamento { get; set; }

    public string? Cepdescarregamento { get; set; }

    public string? Responsavelpagamentonome { get; set; }

    public string? Responsavelpagamentocnpj { get; set; }

    public string? Tipocomponente { get; set; }

    public decimal? Valorcomponente { get; set; }

    public decimal? Valorcontrato { get; set; }

    public string? Formapagamento { get; set; }

    public string? Cnpjipef { get; set; }

    /// <summary>
    /// Guarda arquivo xml resultante do mdfe emitido
    /// </summary>
    public string? ProcXml { get; set; }

    /// <summary>
    /// Numero do Chassi.
    /// </summary>
    public string? Chassi { get; set; }
}
