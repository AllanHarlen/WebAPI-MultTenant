namespace AntaresAPI.Models;

public partial class Produtosrankingcomissao
{
    public int Id { get; set; }

    public int? Idproduto { get; set; }

    public decimal? Valorpadrao { get; set; }

    public decimal? MargeminicialP { get; set; }

    public decimal? MargemfinalP { get; set; }

    public decimal? MargeminicialV { get; set; }

    public decimal? MargemfinalV { get; set; }

    public decimal? ComissaoP { get; set; }

    public decimal? ComissaoV { get; set; }

    public DateTime? DataAtualizacao { get; set; }
}
