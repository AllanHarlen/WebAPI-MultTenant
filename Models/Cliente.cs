namespace AntaresAPI.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Codigoauxiliar { get; set; }

    /// <summary>
    /// Razão social do cliente. 60 caracteres conforme manual da nfe.
    /// </summary>
    public string? Razao { get; set; }

    public string? Endereco { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    /// <summary>
    /// Bairro da empresa. 2 a 60 caracteres permitidos
    /// </summary>
    public string? Bairro { get; set; }

    /// <summary>
    /// Código da UF com dois dígitos. Utilizar a Tabela do IBGE
    /// </summary>
    public string? Codigocidade { get; set; }

    public string? Cidade { get; set; }

    /// <summary>
    /// Codigo da UF com dois dígitos. Utilizar a Tabela do IBGE
    /// </summary>
    public string? Codigouf { get; set; }

    /// <summary>
    /// Sigla da UF com dois dígitos. Utilizar a Tabela do IBGE
    /// </summary>
    public string? Uf { get; set; }

    public string? Cep { get; set; }

    public string? Inscricao { get; set; }

    public string? Tipo { get; set; }

    public string? Cgc { get; set; }

    public string? Fone { get; set; }

    public string? Fax { get; set; }

    public string? Celular { get; set; }

    public string? Pessoa { get; set; }

    public decimal? Taxa { get; set; }

    public string? Contato { get; set; }

    public string? Prazo { get; set; }

    public string? Codigovendedor { get; set; }

    public string? Vendedor { get; set; }

    public decimal? Comissao { get; set; }

    public decimal? Limite { get; set; }

    /// <summary>
    /// Guarda data de atualização do cadastro do cliente
    /// </summary>
    public DateTime? Dataatualizacao { get; set; }

    public DateTime? Nascimento { get; set; }

    /// <summary>
    /// Nome fantasia do cliente. 60 caracteres conforme manual da nfe.
    /// </summary>
    public string? Fantasia { get; set; }

    public string? Ativo { get; set; }

    public string? Refpessoal1 { get; set; }

    public string? Refpesfone1 { get; set; }

    public string? Refpessoal2 { get; set; }

    public string? Refpesfone2 { get; set; }

    public string? Refcomercial1 { get; set; }

    public string? Refcomfone1 { get; set; }

    public string? Refcomercial2 { get; set; }

    public string? Refcomfone2 { get; set; }

    public string? Banco1 { get; set; }

    public string? Ag1 { get; set; }

    public string? Cc1 { get; set; }

    public string? Banco2 { get; set; }

    public string? Ag2 { get; set; }

    public string? Cc2 { get; set; }

    public string? Empresa { get; set; }

    public string? Enderecoemp { get; set; }

    public string? Foneemp { get; set; }

    public string? Ccorrente { get; set; }

    public string? Bloqueio { get; set; }

    public string? Faxcom { get; set; }

    public DateTime? Inicio { get; set; }

    public DateTime? Final { get; set; }

    public string? Venda { get; set; }

    public string? Classificacao { get; set; }

    public int? Codigogrupo { get; set; }

    public string? Observacoes { get; set; }

    public string? Grupo { get; set; }

    public string? Portador { get; set; }

    public string? Emailcom { get; set; }

    public string? Email { get; set; }

    public string? Dsp { get; set; }

    public string? Enderecocom { get; set; }

    public string? Observacao { get; set; }

    public string? Bairrocom { get; set; }

    public string? Cepcom { get; set; }

    public string? Fonecom { get; set; }

    public string? Ufcom { get; set; }

    public string? Contatocom { get; set; }

    public string? Cidadecom { get; set; }

    public string? Estado { get; set; }

    public string? Area { get; set; }

    public string? Isentoipi { get; set; }

    public string? Planocontas { get; set; }

    public decimal? Valormeta { get; set; }

    public string? Vendedor2 { get; set; }

    public decimal? Comissao2 { get; set; }

    public string? Maladireta { get; set; }

    public string? Pontoreferencia { get; set; }

    public string? Codigoportador { get; set; }

    public string? Descricaoportador { get; set; }

    public DateTime? Datacadastro { get; set; }

    public string? Codigorecebimento { get; set; }

    public string? Recebimento { get; set; }

    public string? Descricaogrupo { get; set; }

    public string? Consumidorfinal { get; set; }

    public string? Tabelapreco { get; set; }

    public string? Transferencia { get; set; }

    public string? Pais { get; set; }

    public string? Inscricaomunicipal { get; set; }

    public string? Codigovendedor2 { get; set; }

    public string? Codigoportadoraux { get; set; }

    public string? Descricaoportadoraux { get; set; }

    public decimal? Valorminimo { get; set; }

    public string? Modalidade { get; set; }

    public string? Cfoppadrao { get; set; }

    public string? Descontoboleto { get; set; }

    public string? Responsavel { get; set; }

    public string? Clientedadosadicionais { get; set; }

    public string? Sincronizado { get; set; }

    public string? Sincronizacao { get; set; }
}
