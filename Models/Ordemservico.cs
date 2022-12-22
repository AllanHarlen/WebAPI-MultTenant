namespace AntaresAPI.Models;

public partial class Ordemservico
{
    public int Chave { get; set; }

    public string? Documento { get; set; }

    public string? Cliente { get; set; }

    public string? Razao { get; set; }

    public string? Cnpjcpf { get; set; }

    public DateTime? Entrada { get; set; }

    public string? Horaentrada { get; set; }

    public DateTime? Saida { get; set; }

    public string? Horasaida { get; set; }

    public string? Tipodesconto { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Totalproduto { get; set; }

    public decimal? Totalservico { get; set; }

    public decimal? Total { get; set; }

    public string? Recebimento { get; set; }

    /// <summary>
    /// Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe
    /// </summary>
    public string? Descricaorecebimento { get; set; }

    public string? Usuario { get; set; }

    public string? Nomeusuario { get; set; }

    public DateTime? Cancelado { get; set; }

    public string? Atendente { get; set; }

    public string? Nomeatendente { get; set; }

    public decimal? Comissao1 { get; set; }

    public string? Tecnico { get; set; }

    public string? Nometecnico { get; set; }

    public decimal? Comissao2 { get; set; }

    public string? Status { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? Observacao { get; set; }

    public string? Defeito { get; set; }

    public string? Defeitoidentificado { get; set; }

    public string? Finalizada { get; set; }

    public string? Prisma { get; set; }

    public string? Tombo { get; set; }

    public string? Hodrometro { get; set; }

    public string? Tipocombustivel { get; set; }

    public string? Cor { get; set; }

    public string? Placa { get; set; }

    public string? Potencia { get; set; }

    public string? Hodometro { get; set; }

    public string? Listaequipamentos { get; set; }

    public string? Listafuncionarios { get; set; }

    public string? Faturado { get; set; }

    public string? Orcamento { get; set; }

    public DateTime? PrevisaoSaida { get; set; }

    public string? Acessorio { get; set; }

    public string? Ordemap { get; set; }

    public int? Validadeproposta { get; set; }

    public int? Garantia { get; set; }

    public int? Numeroparcelas { get; set; }

    public string? Mododesconto { get; set; }

    public string? Fantasia { get; set; }

    public string? Sincronizado { get; set; }
}
