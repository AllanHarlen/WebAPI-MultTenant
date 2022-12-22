namespace AntaresAPI.Models;

public partial class Veiculo
{
    public int Id { get; set; }

    /// <summary>
    /// Placa do Veiculo.
    /// </summary>
    public string? Placa { get; set; }

    /// <summary>
    /// 00, 01, 02, 03, 04, 05 - Codigo da Carroceria.
    /// </summary>
    public string? Carroceria { get; set; }

    /// <summary>
    /// 00, 01, 02, 03, 04, 05, 06 - Codigo do tipo rodado.
    /// </summary>
    public string? Tiporodado { get; set; }

    /// <summary>
    /// Chassi do Veiculo.
    /// </summary>
    public string? Chassi { get; set; }

    /// <summary>
    /// 01 - Próprio, 02 - Terceiro.
    /// </summary>
    public string? Proprietario { get; set; }

    /// <summary>
    /// Estado da Placa.
    /// </summary>
    public string? Uf { get; set; }

    /// <summary>
    /// Tara do Veiculo.
    /// </summary>
    public decimal? Tara { get; set; }

    /// <summary>
    /// Capacidade do Veiculo em M3.
    /// </summary>
    public decimal? Capacidademetrocubico { get; set; }

    /// <summary>
    /// Capacidade do Veiculo em KG.
    /// </summary>
    public decimal? Capacidadekg { get; set; }

    public string? Placareboque { get; set; }

    public string? Carroceriareboque { get; set; }

    public string? Tiporodadoreboque { get; set; }

    public string? Ufreboque { get; set; }

    public string? Proprietarioreboque { get; set; }

    public string? Chassireboque { get; set; }

    public decimal? Tarareboque { get; set; }

    public decimal? Capacidadekgreboque { get; set; }

    public decimal? Capacidademetrocubicoreboque { get; set; }

    /// <summary>
    /// Nome do Veiculo
    /// </summary>
    public string? Nomedoveiculo { get; set; }
}
