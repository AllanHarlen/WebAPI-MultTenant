namespace AntaresAPI.Models;

public partial class Configuracoesnfe
{
    public int Id { get; set; }

    public string? Ambiente { get; set; }

    public string? Ativatrace { get; set; }

    public string? Cnpj { get; set; }

    public string? Danfecanhoto { get; set; }

    public string? Danfeinfo { get; set; }

    public string? Danfelogo { get; set; }

    public string? Danfetpdesc { get; set; }

    public string? Datapacket { get; set; }

    public string? Datapacketformseg { get; set; }

    public string? Formatoitemqtd { get; set; }

    public string? Formatoitemunt { get; set; }

    public string? Modelo { get; set; }

    public string? Nferecepcao { get; set; }

    public string? Nferetrecepcao { get; set; }

    public string? Nferecepcaoevento { get; set; }

    public string? Nfecancelamento { get; set; }

    public string? Nfeinutilizacao { get; set; }

    public string? Nfeconsultaprotocolo { get; set; }

    public string? Nfestatusservico { get; set; }

    public string? Pathprincipal { get; set; }

    public string? Serie { get; set; }

    public string? Sizefontsobs { get; set; }

    public string? Tipodanfe { get; set; }

    public string? Totalizarcfop { get; set; }

    public string? Pathschemas { get; set; }

    public string? Unidadefederada { get; set; }

    public string? Noseriecertificado { get; set; }

    public string? Verproc { get; set; }

    public string? Unidadefederadacodigo { get; set; }

    public string? Email { get; set; }

    public string? Avisoexpiracertificado { get; set; }

    public string? Nomeexibicao { get; set; }

    public string? Senha { get; set; }

    public string? Servidorsmtp { get; set; }

    public string? Tipossl { get; set; }

    public string? Portaemail { get; set; }

    public string? Host { get; set; }

    public string? Usuario { get; set; }

    public string? Codmunicipio { get; set; }

    public string? Ie { get; set; }

    public string? Municipio { get; set; }

    /// <summary>
    /// Ultimo NSU para consulta DFE Webservice
    /// </summary>
    public string? Ultimonsu { get; set; }

    public string? ValAss { get; set; }

    public string? ValMd5 { get; set; }

    public string? Portaproxy { get; set; }

    public string? Senhaproxy { get; set; }

    /// <summary>
    /// Configura uso da referencia no lugar do código na emissão. Coluna true / false
    /// </summary>
    public string? ReferenciaProdutoNota { get; set; }
}
