namespace AntaresAPI.Models;

public partial class Producaocontrolequalidade
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public string? Documento { get; set; }

    public string? Condicoeslaboratorio { get; set; }

    public string? Condicoestemperatura { get; set; }

    public string? Condicoesumidade { get; set; }

    public string? Turno { get; set; }

    public DateTime? Fabricacao { get; set; }

    public decimal? Qtdanalisada { get; set; }

    public DateTime? Analise { get; set; }

    public string? Lote { get; set; }

    public string? Temperaturamediainicial { get; set; }

    public string? Temperaturamediafinal { get; set; }

    public string? Trababilidade { get; set; }

    public string? Tipoproduto { get; set; }

    public string? Embalagem { get; set; }

    public decimal? Conteudoliquido { get; set; }

    public string? Modulofinura { get; set; }

    public string? Massaunitaria { get; set; }

    public string? Agualivre { get; set; }

    public string? Aguacristalizacao { get; set; }

    public string? Anedridosufurico { get; set; }

    public string? Oxidocalcio { get; set; }

    public string? Consistencia { get; set; }

    public string? Tempodepegainicio { get; set; }

    public string? Tempodepegafim { get; set; }

    public string? Dureza { get; set; }

    public string? Resistenciacomposicao { get; set; }

    public string? Metodologia { get; set; }

    public string? Especificacao { get; set; }

    public string? Unidade { get; set; }

    public string? Medicoes { get; set; }

    public string? Resultado { get; set; }

    public string? Granulometria { get; set; }
}
