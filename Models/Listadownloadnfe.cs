namespace AntaresAPI.Models;

/// <summary>
/// Armazena lista de download de documentos fiscais
/// </summary>
public partial class Listadownloadnfe
{
    public int Id { get; set; }

    public string? Chave { get; set; }

    /// <summary>
    /// Número do Documento da NFE.
    /// </summary>
    public string? Documento { get; set; }

    public string? Cnpj { get; set; }

    /// <summary>
    /// Nome fantasia do cliente. 60 caracteres conforme manual da nfe.
    /// </summary>
    public string? Nome { get; set; }

    public string? Ie { get; set; }

    public int? Tiponf { get; set; }

    public decimal? Valor { get; set; }

    public string? Digval { get; set; }

    public DateTime? Data { get; set; }

    public string? Hora { get; set; }

    public string? Protocolo { get; set; }

    public int? Situacao { get; set; }

    /// <summary>
    /// Guarda último Número Sequencial Único (NSU)  código numérico gerado pela Sefaz (Secretaria da Fazenda) para distinguir e identificar um tipo de Nota Fiscal eletrônica, uma Carta de Correção eletrônica, um Evento da NF-e  ou até mesmo um conjunto destes documentos
    /// </summary>
    public string? Nsu { get; set; }

    /// <summary>
    /// Guarda o codigo da manifestação, 210200 = Confirmado, 210210 = Ciente, 210220 = Desconhecimento, 210240 = Não realizado.
    /// </summary>
    public string? Manifestacao { get; set; }

    /// <summary>
    /// True = Importado, False = Não importado.
    /// </summary>
    public string? Importado { get; set; }
}
