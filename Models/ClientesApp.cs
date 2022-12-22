namespace AntaresAPI.Models;

public partial class ClientesApp
{
    public int Id { get; set; }

    /// <summary>
    /// Nome do cliente cadastrado online
    /// </summary>
    public string? Nome { get; set; }

    /// <summary>
    /// Email do cliente cadastrado online
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Senha do cliente cadastrado online
    /// </summary>
    public string? Senha { get; set; }

    /// <summary>
    /// Cpf ou cnpj do cliente cadastrado online
    /// </summary>
    public string? Cpfcnpj { get; set; }

    /// <summary>
    /// Endereço do cliente cadastrado online
    /// </summary>
    public string? Endereco { get; set; }

    /// <summary>
    /// Número físico do endereço do cliente cadastrado online
    /// </summary>
    public string? Numero { get; set; }

    /// <summary>
    /// Bairro do cliente cadastrado online
    /// </summary>
    public string? Bairro { get; set; }

    /// <summary>
    /// Cidade do cliente cadastrado online
    /// </summary>
    public string? Cidade { get; set; }

    /// <summary>
    /// CEP do cliente cadastrado online
    /// </summary>
    public string? Cep { get; set; }

    /// <summary>
    /// Código da UF com dois dígitos do cliente cadastrado online
    /// </summary>
    public string? Uf { get; set; }

    /// <summary>
    /// Complemento do endereço do cliente cadastraonline
    /// </summary>
    public string? Complemento { get; set; }

    /// <summary>
    /// Telefone do cliente cadastrado online
    /// </summary>
    public string? Telefone { get; set; }

    /// <summary>
    /// Status do cliente cadastrado online
    /// </summary>
    public string? Ativo { get; set; }
}
