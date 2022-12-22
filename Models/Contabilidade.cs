namespace AntaresAPI.Models;

/// <summary>
/// Utilizado para gerar arquivo SPED
/// </summary>
public partial class Contabilidade
{
    /// <summary>
    /// campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nome do contador ou contabilidade
    /// </summary>
    public string Nome { get; set; } = null!;

    /// <summary>
    /// CPF do contador
    /// </summary>
    public string Cpf { get; set; } = null!;

    /// <summary>
    /// CRC do contador ou contabilidade
    /// </summary>
    public string Crc { get; set; } = null!;

    /// <summary>
    /// CNPJ do contador ou contabilidade
    /// </summary>
    public string Cnpj { get; set; } = null!;

    /// <summary>
    /// CEP do contador ou contabilidade
    /// </summary>
    public string Cep { get; set; } = null!;

    /// <summary>
    /// Endereço do contador ou contabilidade
    /// </summary>
    public string Endereco { get; set; } = null!;

    /// <summary>
    /// Número físico do contador ou contabilidade
    /// </summary>
    public string Numero { get; set; } = null!;

    /// <summary>
    /// Complemento de endereço do contador ou contabilidade
    /// </summary>
    public string Complemento { get; set; } = null!;

    /// <summary>
    /// Bairro do contador ou contabilidade
    /// </summary>
    public string Bairro { get; set; } = null!;

    /// <summary>
    /// Telefone do contador ou contabilidade
    /// </summary>
    public string Fone { get; set; } = null!;

    /// <summary>
    /// FAX do contador ou contabilidade
    /// </summary>
    public string Fax { get; set; } = null!;

    /// <summary>
    /// Email do contador ou contabilidade
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Codigo IBGE da cidade do contador ou contabilidade
    /// </summary>
    public string Codigomunicipio { get; set; } = null!;
}
