namespace AntaresAPI.Models;

public partial class Vendedore
{
    public string Vendedor { get; set; } = null!;

    public string? Nome { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Uf { get; set; }

    public string? Cep { get; set; }

    public string? Rg { get; set; }

    public string? Cpf { get; set; }

    public string? Fone { get; set; }

    public decimal? Comissao { get; set; }

    public decimal? Meta { get; set; }

    public string? Banco { get; set; }

    public string? Ag { get; set; }

    public string? Cc { get; set; }

    public string? Inativo { get; set; }

    public string? Email { get; set; }

    public string? DescricaoGrupo { get; set; }

    public string? CodigoGrupo { get; set; }

    public string? Celular { get; set; }

    public string? Relatoriocomissao { get; set; }

    public string? Codigosupervisor { get; set; }

    public string? Supervisor { get; set; }

    public string? Sup { get; set; }

    public string? Tabelavendedor { get; set; }

    public int Chave { get; set; }
}
