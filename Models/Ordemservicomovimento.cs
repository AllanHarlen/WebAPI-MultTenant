namespace AntaresAPI.Models;

public partial class Ordemservicomovimento
{
    public int Chave { get; set; }

    /// <summary>
    /// Guarda Documento da Ordem de Serviço
    /// </summary>
    public string? Documento { get; set; }

    /// <summary>
    /// Guarda código do produto na Ordem de Serviço
    /// </summary>
    public string? Produto { get; set; }

    /// <summary>
    /// Guarda referencia do produto na Ordem de Serviço
    /// </summary>
    public string? Referencia { get; set; }

    /// <summary>
    /// Guarda descricao do produto na Ordem de Serviço
    /// </summary>
    public string? Descricao { get; set; }

    /// <summary>
    /// Guarda quantidade do produto na Ordem de Serviço. Decimal com duas casas
    /// </summary>
    public decimal? Quantidade { get; set; }

    /// <summary>
    /// Guarda custo do produto na Ordem de Serviço. Decimal com duas casas
    /// </summary>
    public decimal? Custo { get; set; }

    /// <summary>
    /// Guarda valor unitario do produto na Ordem de Serviço. Decimal com duas casas
    /// </summary>
    public decimal? Preco { get; set; }

    /// <summary>
    /// Guarda codigo do funcionário definido como atendente na Ordem de Serviço
    /// </summary>
    public string? Atendente { get; set; }

    /// <summary>
    /// Guarda nome do funcionário definido como atendente na Ordem de Serviço
    /// </summary>
    public string? Nomeatendente { get; set; }

    public decimal? Comissvendedor { get; set; }

    public decimal? Comissvendedor2 { get; set; }

    public decimal? Comissavendedor2 { get; set; }

    public string? Cancelado { get; set; }

    public decimal? Icms { get; set; }

    public decimal? Mva { get; set; }

    public decimal? Reducao { get; set; }

    public decimal? Icmssub { get; set; }

    public decimal? Baseicms { get; set; }

    public decimal? Baseicmssub { get; set; }

    public decimal? Valoricms { get; set; }

    public decimal? Valoricmssub { get; set; }

    public decimal? Baseiss { get; set; }

    public decimal? Iss { get; set; }

    public decimal? Valoriss { get; set; }

    public decimal? Desconto { get; set; }

    public string? Movimentaestoque { get; set; }

    public string? Tecnico { get; set; }

    public string? Nometecnico { get; set; }

    public string? Pendente { get; set; }

    public string? Servico { get; set; }

    public string? Cliente { get; set; }

    public string? Unidade { get; set; }

    public string? Observacao { get; set; }

    public string? Numeropontos { get; set; }

    public string? Arquivobordado { get; set; }

    public DateTime? Data { get; set; }

    public string? Fabricante { get; set; }

    public string? Capacidadeextintora { get; set; }

    public string? Tipo { get; set; }

    public string? Motivoreparo { get; set; }

    public string? Pgcomissao { get; set; }

    public string? ChaveOriginal { get; set; }

    public int? RegistroServico { get; set; }

    public string? TipoServico { get; set; }

    public string? Marca { get; set; }

    public decimal? Total { get; set; }

    public string? Sincronizado { get; set; }
}
