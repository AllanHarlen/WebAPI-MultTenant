namespace AntaresAPI.Models;

public partial class Configuracoesnfse
{
    public int Id { get; set; }

    public string? Ambiente { get; set; }

    public string? Pathprincipal { get; set; }

    public string? Serie { get; set; }

    public string? Token { get; set; }

    public int? Documento { get; set; }

    /// <summary>
    /// Guarda núemro do Rps da NFSE
    /// </summary>
    public int? Rps { get; set; }
}
