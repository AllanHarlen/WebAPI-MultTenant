namespace AntaresAPI.Models;

/// <summary>
/// Tabela para gerar arquivo Sped ECf ICMS IPI. Este registro tem por objetivo relacionar e cadastrar os participantes (fornecedores e clientes pessoa jurídica ou pessoa
/// física) que tenham realizado operações com a empresa, objeto de registro nos Blocos A, C, D, F ou 1.
/// </summary>
public partial class Bl00150
{
    /// <summary>
    /// campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo “0150”
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Código de identificação do participante no arquivo. - 60 caracteres. Antares preenche com o cnpj/cpf
    /// </summary>
    public string? CodPart { get; set; }

    /// <summary>
    /// Nome pessoal ou empresarial do participante. - 100 caracteres
    /// </summary>
    public string? Nome { get; set; }

    /// <summary>
    /// Código do país do participante, conforme a tabela indicada - 5 carcateres
    /// </summary>
    public string? CodPais { get; set; }

    /// <summary>
    /// CNPJ do participante - 14 caracteres
    /// </summary>
    public string? Cnpj { get; set; }

    /// <summary>
    /// CPF do participante - 11 caracteres
    /// </summary>
    public string? Cpf { get; set; }

    /// <summary>
    /// Inscricao estadual do participante - 14 caracteres
    /// </summary>
    public string? Ie { get; set; }

    /// <summary>
    /// Código do município, conforme a tabela IBGE - 7 caracteres
    /// </summary>
    public string? CodMun { get; set; }

    /// <summary>
    /// Número de inscrição do participante na Suframa - 9 caracteres
    /// </summary>
    public string? Suframa { get; set; }

    /// <summary>
    /// Logradouro e endereço do imóvel - 60 caracteres
    /// </summary>
    public string? End { get; set; }

    /// <summary>
    /// Número do imóvel 
    /// </summary>
    public string? Num { get; set; }

    /// <summary>
    /// Dados complementares do endereço - 60 caracteres
    /// </summary>
    public string? Compl { get; set; }

    /// <summary>
    /// Bairro em que o imóvel está situado - 60 caracteres
    /// </summary>
    public string? Bairro { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo. Venda e emissao, compra e lancamento
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
