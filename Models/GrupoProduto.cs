namespace AntaresAPI.Models;

public partial class GrupoProduto
{
    public int Id { get; set; }

    public string? Grupo { get; set; }

    public string? Descricao { get; set; }

    public decimal? Meta { get; set; }

    public string? CodAtividade { get; set; }

    public string? Colunas { get; set; }

    public string? Atividade { get; set; }

    public string? Desativar { get; set; }

    public decimal? Cargatributaria { get; set; }

    public decimal? Comissao { get; set; }

    public string? Supervisor { get; set; }

    public string? Codigosupervisor { get; set; }

    public string? Sincronizado { get; set; }

    public string? Tipo { get; set; }

    public string? NomeUrl { get; set; }

    public string? Imagem { get; set; }
}
