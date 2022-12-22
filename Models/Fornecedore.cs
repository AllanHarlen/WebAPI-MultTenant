namespace AntaresAPI.Models;

public partial class Fornecedore
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    /// <summary>
    /// Razão social do fornecedor. 60 caracteres conforme manual da nfe.
    /// </summary>
    public string? Razao { get; set; }

    /// <summary>
    /// Nome fantasia do fornecedor. 60 caracteres conforme manual da nfe.
    /// </summary>
    public string? Fantasia { get; set; }

    public string? Endereco { get; set; }

    /// <summary>
    /// Bairro do fornecedor. 2 a 60 caracteres permitidos
    /// </summary>
    public string? Bairro { get; set; }

    public string? Complemento { get; set; }

    public string? Cidade { get; set; }

    /// <summary>
    /// Sigla da UF com dois dígitos. Utilizar a Tabela do IBGE
    /// </summary>
    public string? Uf { get; set; }

    public string? Cep { get; set; }

    public string? Inscricao { get; set; }

    public string? Cnpj { get; set; }

    public string? Fone { get; set; }

    public string? Fax { get; set; }

    public string? Contato { get; set; }

    public string? Prazo { get; set; }

    public string? Status { get; set; }

    public DateTime? Cadastro { get; set; }

    public int? Grupo { get; set; }

    public string? Email { get; set; }

    public string? Tipo { get; set; }

    /// <summary>
    /// Guarda data de ultima alteração no cadastro de fornecedor
    /// </summary>
    public DateTime? Dataatualizacao { get; set; }

    public int? Indicepedido { get; set; }

    public string? Grade { get; set; }

    public decimal? Comissaorepresentante { get; set; }

    public decimal? Comissaovendedor { get; set; }

    public string? Modelograde { get; set; }

    public string? Fabricante { get; set; }

    public string? Observacao { get; set; }

    public string? Tipopedido { get; set; }

    public decimal? Freteminimo { get; set; }

    public string? Codigorecebimento { get; set; }

    public string? Recebimento { get; set; }

    public string? Referencias { get; set; }

    public string? Planocontas { get; set; }

    /// <summary>
    /// Código da UF com dois dígitos. Utilizar a Tabela do IBGE
    /// </summary>
    public string? Codigocidade { get; set; }

    /// <summary>
    /// Codigo da UF com dois dígitos. Utilizar a Tabela do IBGE
    /// </summary>
    public string? Codigouf { get; set; }

    public string? Pais { get; set; }

    public string? Cfop { get; set; }

    public string? Plano { get; set; }

    public string? Auxiliar { get; set; }

    public string? Sincronizado { get; set; }

    /// <summary>
    /// Guarda número físico do endereço do fornecedor
    /// </summary>
    public string? Numero { get; set; }

    /// <summary>
    /// Guarda número do telefone móvel do fornecedor
    /// </summary>
    public string? Celular { get; set; }

    /// <summary>
    /// Guarda ponto de referência do endereço do fornecedor
    /// </summary>
    public string? Pontoreferencia { get; set; }

    /// <summary>
    /// Guarda inscrição municipal do seu fornecedor
    /// </summary>
    public string? Inscricaomunicipal { get; set; }
}
