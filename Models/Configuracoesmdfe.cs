namespace AntaresAPI.Models;

public partial class Configuracoesmdfe
{
    /// <summary>
    /// Chave de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    public string? Empresa { get; set; }

    public string? Licenca { get; set; }

    public string? Certificado { get; set; }

    public string? Senhacertificado { get; set; }

    public string? Serie { get; set; }

    public string? Versao { get; set; }

    public string? Pathschemas { get; set; }

    public string? Pathxml { get; set; }

    public string? Ambiente { get; set; }

    public string? Verproc { get; set; }

    public string? Unidadefederada { get; set; }

    public string? Unidadefederadacodigo { get; set; }

    public string? Ativatrace { get; set; }

    public string? Nferecepcao { get; set; }

    public string? Nferetrecepcao { get; set; }

    public string? Nferecepcaoevento { get; set; }

    public string? Nfecancelamento { get; set; }

    public string? Nfeinutilizacao { get; set; }

    public string? Nfeconsultaprotocolo { get; set; }

    public string? Nfestatusservico { get; set; }

    public string? Cnpj { get; set; }

    public string? Avisoexpiracertificado { get; set; }
}
