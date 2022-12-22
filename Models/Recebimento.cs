namespace AntaresAPI.Models;

public partial class Recebimento
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    /// <summary>
    /// Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe
    /// </summary>
    public string? Descricao { get; set; }

    public string? Ativo { get; set; }

    public string? Forma { get; set; }

    public string? Permissoes { get; set; }

    public string? Ativfinanceira { get; set; }

    public string? AtividadeFinanceira { get; set; }

    public DateTime? DataCadastro { get; set; }

    public string? Prazo1 { get; set; }

    public string? Prazo2 { get; set; }

    public string? Prazo3 { get; set; }

    public string? Prazo4 { get; set; }

    public string? Prazo5 { get; set; }

    public string? Prazo6 { get; set; }

    public string? Prazo7 { get; set; }

    public string? Prazo8 { get; set; }

    public string? Prazo9 { get; set; }

    public string? Prazo10 { get; set; }

    public string? Prazo11 { get; set; }

    public string? Prazo12 { get; set; }

    public string? CodigoGrupo { get; set; }

    public string? DescricaoGrupo { get; set; }

    public string? Sigla { get; set; }

    public string? Condicoes { get; set; }

    public string? Tipopagamento { get; set; }

    public decimal? Limitetroco { get; set; }

    public string? Baixaautomatica { get; set; }

    public string? Tabela { get; set; }

    public decimal? Aliquota1 { get; set; }

    public decimal? Aliquota2 { get; set; }

    public decimal? Aliquota3 { get; set; }

    public decimal? Aliquota4 { get; set; }

    public decimal? Aliquota5 { get; set; }

    public decimal? Aliquota6 { get; set; }

    public decimal? Aliquota7 { get; set; }

    public decimal? Aliquota8 { get; set; }

    public decimal? Aliquota9 { get; set; }

    public decimal? Aliquota10 { get; set; }

    public string? Sincronizado { get; set; }

    public string? CnpjOperadora { get; set; }

    public string Visualizar { get; set; } = null!;

    /// <summary>
    /// Guarda data de modificação do tipo de recebimento
    /// </summary>
    public DateTime? DataAlteracao { get; set; }

    /// <summary>
    /// Guarda data de inserção ou atualização do tipo de recebimento
    /// </summary>
    public int? Usuario { get; set; }

    /// <summary>
    /// Permite que o recebimento em questão seja manipulado livremente nos lançamentos sem precisar configurar as parcelas. Campo true ou false
    /// </summary>
    public string? ParcelasLivre { get; set; }

    /// <summary>
    /// Define se o recebimento tem ou não integração
    /// </summary>
    public string? Integracao { get; set; }
}
