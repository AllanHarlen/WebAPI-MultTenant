namespace AntaresAPI.Models;

public partial class Pedidovendamovimento
{
    public int Chave { get; set; }

    public DateTime? Data { get; set; }

    public DateTime? Entrega { get; set; }

    public string? Produto { get; set; }

    public string? Descricao { get; set; }

    public string? Referencia { get; set; }

    public decimal? Quantidade { get; set; }

    public decimal? Atendido { get; set; }

    public decimal? Custo { get; set; }

    public decimal? Preco { get; set; }

    public decimal? Fator { get; set; }

    public decimal? Comissvendedor { get; set; }

    public string? Vendedor { get; set; }

    public string? Nomevendedor { get; set; }

    public decimal? Comissvendedor2 { get; set; }

    public string? Nomevendedor2 { get; set; }

    public string? Vendedor2 { get; set; }

    public string? Tipo { get; set; }

    public string? Cfop { get; set; }

    public string? Cliente { get; set; }

    public string? Nome { get; set; }

    public string? Uf { get; set; }

    public string? Historico { get; set; }

    public string? Documento { get; set; }

    public string? Unidade { get; set; }

    public string? Modelo { get; set; }

    public string? Cor { get; set; }

    public string? Grupo { get; set; }

    public DateTime? Emissao { get; set; }

    public decimal? Hora { get; set; }

    public string? Cancelado { get; set; }

    public decimal? Icms { get; set; }

    public string? Aliquota { get; set; }

    public decimal? Desconto { get; set; }

    public string? Responsavel { get; set; }

    public string? Lote { get; set; }

    public decimal? Ipi { get; set; }

    public decimal? Valoricms { get; set; }

    public decimal? Valoripi { get; set; }

    public decimal? Reducaobase { get; set; }

    public string? Nomeusuario { get; set; }

    public string? Observacao { get; set; }

    public string? Auditoria { get; set; }

    public string? Au { get; set; }

    public string? Fantasiafornecedor { get; set; }

    public string? Vale { get; set; }

    public string? Codigofornecedor { get; set; }

    public decimal? Precon { get; set; }

    public decimal? Comissao { get; set; }

    public string? Cf { get; set; }

    public string? St { get; set; }

    public string? Cotacao { get; set; }

    public string? Fichatecnica { get; set; }

    public string? Produtoficha { get; set; }

    public string? Cbarra { get; set; }

    public string? Movimentaestoque { get; set; }

    public DateTime? Validade { get; set; }

    public decimal? Creditoicms { get; set; }

    public DateTime? Fabricacao { get; set; }

    public decimal? Qtdvolume { get; set; }

    public decimal? Pliquido { get; set; }

    public decimal? Pbruto { get; set; }

    /// <summary>
    /// Campo destinado tanto a guarda do número sequencial do pedido quanto do nitemped, quando necessário
    /// </summary>
    public string? Registro { get; set; }

    public string? Categoria { get; set; }

    public string? Ordemcompra { get; set; }

    public decimal? Precopauta { get; set; }

    public string? Matriz { get; set; }

    public decimal? Freteproduto { get; set; }

    public string? Itemagrupador { get; set; }

    public string? Arquivo { get; set; }

    public string? Modeloroupa { get; set; }

    public string? Logo { get; set; }

    public string? Fita { get; set; }

    public string? Tecido { get; set; }

    public string? Logomarca { get; set; }

    public string? Artigo { get; set; }

    public decimal? Precooriginal { get; set; }

    public string? Observacao2 { get; set; }

    public decimal? Bcicms { get; set; }

    public decimal? Bcipi { get; set; }

    public decimal? Total { get; set; }

    public decimal? Bicms { get; set; }

    public string? Empresa { get; set; }

    public string? Sincronizado { get; set; }

    public string? Campo1 { get; set; }

    public string? Campo2 { get; set; }

    public string? Campo3 { get; set; }

    public string? Campo4 { get; set; }

    public string? Campo5 { get; set; }

    public int? U { get; set; }

    public int? P { get; set; }

    public int? M { get; set; }

    public int? G { get; set; }

    public int? Gg { get; set; }

    public int? Eg { get; set; }

    public int? G28 { get; set; }

    public int? G29 { get; set; }

    public int? G30 { get; set; }

    public int? G31 { get; set; }

    public int? G32 { get; set; }

    public int? G33 { get; set; }

    public int? G34 { get; set; }

    public int? G35 { get; set; }

    public int? G36 { get; set; }

    public int? G37 { get; set; }

    public int? G38 { get; set; }

    public int? G39 { get; set; }

    public int? G40 { get; set; }

    public int? G41 { get; set; }

    public int? G42 { get; set; }

    public int? G43 { get; set; }

    public int? G44 { get; set; }

    public int? G45 { get; set; }

    public int? G46 { get; set; }

    public int? G3G { get; set; }

    public decimal? G1 { get; set; }

    public decimal? G2 { get; set; }

    public decimal? G3 { get; set; }

    public decimal? G4 { get; set; }

    public decimal? G5 { get; set; }

    public decimal? G6 { get; set; }

    public decimal? G7 { get; set; }

    public decimal? G8 { get; set; }

    public decimal? G10 { get; set; }

    public decimal? G12 { get; set; }

    public decimal? G14 { get; set; }

    public decimal? Gg1 { get; set; }

    public decimal? Gg2 { get; set; }

    public decimal? Gg3 { get; set; }

    public decimal? Pp { get; set; }

    /// <summary>
    /// Valor de acréscimo por produto no pedido de venda
    /// </summary>
    public decimal? Acrescimo { get; set; }

    /// <summary>
    /// Valor de Pis por produto no pedido de venda
    /// </summary>
    public decimal? Vpis { get; set; }

    /// <summary>
    /// ST do Pis por produto no pedido de venda
    /// </summary>
    public string? Pisst { get; set; }

    /// <summary>
    /// Percentual do Pis por produto no pedido de venda
    /// </summary>
    public decimal? Ppis { get; set; }

    /// <summary>
    /// Valor de Cofins por produto no pedido de venda
    /// </summary>
    public decimal? Vcofins { get; set; }

    /// <summary>
    /// ST do Cofins por produto no pedido de venda
    /// </summary>
    public string? Cofinsst { get; set; }

    /// <summary>
    /// Percentual do Cofins por produto no pedido de venda
    /// </summary>
    public decimal? Pcofins { get; set; }

    /// <summary>
    /// Modbc ICMS por produto no item do pedido de venda
    /// </summary>
    public string? Modbcicms { get; set; }

    /// <summary>
    /// Modbcst ICMS ST por produto no item do pedido de venda
    /// </summary>
    public string? Modbcicmsst { get; set; }
}
