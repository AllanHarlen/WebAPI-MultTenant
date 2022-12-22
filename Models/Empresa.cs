namespace AntaresAPI.Models;

public partial class Empresa
{
    public string Codigo { get; set; } = null!;

    public string? Fantasia { get; set; }

    public string? Razao { get; set; }

    public string? Endereco { get; set; }

    public int? Numero { get; set; }

    /// <summary>
    /// Bairro da empresa. 2 a 60 caracteres permitidos
    /// </summary>
    public string? Bairro { get; set; }

    public string? Complemento { get; set; }

    public string? Codigocidade { get; set; }

    public string? Cidade { get; set; }

    public string? Uf { get; set; }

    /// <summary>
    /// Código da UF com dois dígitos. Utilizar a Tabela do IBGE
    /// </summary>
    public string? Codigouf { get; set; }

    public string? Cep { get; set; }

    public string? Inscricao { get; set; }

    public string? Cnpj { get; set; }

    public string? Email { get; set; }

    public string? Fone { get; set; }

    /// <summary>
    /// Guarda mensagem automática utilizada no envio da nota fiscal eletrônica, tela de vendas
    /// </summary>
    public string? Mensagem { get; set; }

    public string? Fax { get; set; }

    public string? Contato { get; set; }

    public string? Cpfcontato { get; set; }

    public string? Emailcontato { get; set; }

    public string? Modelonf { get; set; }

    public string? Serienf { get; set; }

    public string? Nomecontador { get; set; }

    public string? Cpfcontador { get; set; }

    public string? Crccontador { get; set; }

    public string? Fonecontador { get; set; }

    public string? Faxcontador { get; set; }

    public string? Emailcontador { get; set; }

    public int? Numerorecibo { get; set; }

    public decimal? Pis { get; set; }

    public decimal? Cofins { get; set; }

    public decimal? Csll { get; set; }

    public decimal? Irpj { get; set; }

    public decimal? Inss { get; set; }

    public decimal? Prazo10000perc { get; set; }

    public DateTime? Databackup { get; set; }

    public string? Smtp { get; set; }

    public string? Usuario { get; set; }

    public string? Senha { get; set; }

    public string? Email2 { get; set; }

    public string? Scan { get; set; }

    public string? Bloquarcliente { get; set; }

    public string? Grade { get; set; }

    /// <summary>
    /// Código de Regime Tributário. Este campo será obrigatoriamente preenchido com:
    /// 1 – Simples Nacional;
    /// 2 – Simples Nacional – excesso de sublimite de receita bruta;
    /// 3 – Regime Normal.
    /// </summary>
    public string? Regime { get; set; }

    public string? Nomeexibicao { get; set; }

    public string? Inscricaomunicipal { get; set; }

    public string? Cnae { get; set; }

    public string? Mensagem2 { get; set; }

    public string? Modelotabelapreco { get; set; }

    public string? Versao { get; set; }

    public string? Certificadodigital { get; set; }

    public string? Cnpjcontador { get; set; }

    public string? Dadosadicionais { get; set; }

    public decimal? Icms { get; set; }

    public decimal? Creditoicms { get; set; }

    public string? Perfilsistema { get; set; }

    public int? Prazomaxperc { get; set; }

    public string? Tipossl { get; set; }

    public string? Validadecertificado { get; set; }

    public byte[]? Logo { get; set; }

    public DateOnly? DiaEnviaXml { get; set; }

    /// <summary>
    /// Guarda cor de destaque na utilizacão  do Multi Empresa
    /// </summary>
    public string? Destaque { get; set; }
}
