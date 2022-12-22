namespace AntaresAPI.Models;

public partial class Transportadora
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    /// <summary>
    /// Razão social do transportador. 60 caracteres conforme manual da nfe.
    /// </summary>
    public string? Razao { get; set; }

    /// <summary>
    /// Nome fantasia do transportador. 60 caracteres conforme manual da nfe.
    /// </summary>
    public string? Fantasia { get; set; }

    /// <summary>
    /// Endereço do transportador
    /// </summary>
    public string? Endereco { get; set; }

    /// <summary>
    /// Bairro do transportador
    /// </summary>
    public string? Bairro { get; set; }

    /// <summary>
    /// Cidade do transportador
    /// </summary>
    public string? Cidade { get; set; }

    /// <summary>
    /// Código da cidade do transportador de acordo com IBGE 
    /// </summary>
    public string? Codigocidade { get; set; }

    /// <summary>
    /// UF do transportador
    /// </summary>
    public string? Uf { get; set; }

    /// <summary>
    /// Código da UF(Estado) do transportador de acordo com IBGE 
    /// </summary>
    public string? Codigouf { get; set; }

    /// <summary>
    /// CEP do transportador de acordo com IBGE 
    /// </summary>
    public string? Cep { get; set; }

    public string? Telefone1 { get; set; }

    public string? Telefone2 { get; set; }

    public string? Celular { get; set; }

    public string? Contato { get; set; }

    /// <summary>
    /// CNPJ OU CPF do transportador
    /// </summary>
    public string? CpfCnpj { get; set; }

    /// <summary>
    /// Número da inscrição estadual do transportador. Caso seja pessoa física deve ser ISENTO
    /// </summary>
    public string? RgInsc { get; set; }

    /// <summary>
    /// Email do transportador
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Data de cadastro dotransportador
    /// </summary>
    public DateTime? Datacad { get; set; }

    public string? Status { get; set; }

    public string? Sincronizado { get; set; }

    public string? Plano { get; set; }

    public string? Tipotransportador { get; set; }

    public string? Homepage { get; set; }

    public string? Observacao { get; set; }

    /// <summary>
    /// RNTRC do Transportador.
    /// </summary>
    public string? Rntrc { get; set; }
}
