namespace AntaresAPI.Models;

public partial class Produto
{
    public int Id { get; set; }

    public string? Produto1 { get; set; }

    public string? Descricao { get; set; }

    public string? Codigogrupo { get; set; }

    public string? Grupo { get; set; }

    public string? Descricaogrupo { get; set; }

    public decimal? Custo { get; set; }

    public decimal? Precovenda { get; set; }

    public decimal? Icms { get; set; }

    public decimal? Icmssub { get; set; }

    public decimal? Minimo { get; set; }

    public decimal? Grosso { get; set; }

    public decimal? Valorsugerido { get; set; }

    public decimal? Margem { get; set; }

    public string? Codigo { get; set; }

    public string? Servico { get; set; }

    public string? Referencia { get; set; }

    public string? Cbarra { get; set; }

    public string? Unidade { get; set; }

    public string? St { get; set; }

    public string? Cf { get; set; }

    /// <summary>
    /// Campo que define se produto sincroniza com MeuMenu:
    /// 0 sincroniza produto no MeuMenu
    /// 1 desabilita produto noMeuMenu
    /// 2 nao sincroniza produto no MeuMenu
    /// </summary>
    public string? Modelo { get; set; }

    public string? Venda { get; set; }

    public string? Cor { get; set; }

    public string? Grade { get; set; }

    public decimal? Ipi { get; set; }

    public string? Cstpiscofins { get; set; }

    public string? Cstpis { get; set; }

    public string? Cstcofins { get; set; }

    public decimal? Aliquotapis { get; set; }

    public decimal? Aliquotacofins { get; set; }

    public string? Cest { get; set; }

    public decimal? Iss { get; set; }

    public decimal? Ibptpis { get; set; }

    public decimal? Ibptcofins { get; set; }

    public decimal? Ibptcsll { get; set; }

    public decimal? Ibptirpj { get; set; }

    public decimal? Ibpticms { get; set; }

    public string? Aplicacao { get; set; }

    public string? Mensagem { get; set; }

    public string? Embalagem { get; set; }

    public decimal? Pliquido { get; set; }

    public decimal? Pbruto { get; set; }

    public string? Codigofornecedor { get; set; }

    public string? Fornecedor { get; set; }

    public decimal? Qtdminima { get; set; }

    public string? Supergrupo { get; set; }

    public string? Planocontas { get; set; }

    public string? Inativo { get; set; }

    public decimal? Preco1 { get; set; }

    public decimal? Preco2 { get; set; }

    public decimal? Preco3 { get; set; }

    public decimal? Preco4 { get; set; }

    public decimal? Preco5 { get; set; }

    public decimal? Preco6 { get; set; }

    public decimal? Preco7 { get; set; }

    public decimal? Preco8 { get; set; }

    public string? Tabela { get; set; }

    public decimal? Preco9 { get; set; }

    public decimal? Preco10 { get; set; }

    public decimal? Precopauta { get; set; }

    public DateTime? Ultimacompra { get; set; }

    public decimal? Ultimopreco { get; set; }

    public decimal? Ultimocusto { get; set; }

    public DateTime? Ultimavenda { get; set; }

    public decimal? Descontomaximo { get; set; }

    public decimal? Descontomax { get; set; }

    public DateTime? Datacadastro { get; set; }

    public string? Dataatualizacao { get; set; }

    public decimal? Qtd { get; set; }

    public string? Fichatecnica { get; set; }

    public string? Nomeimpressora { get; set; }

    public string? Localimpressao { get; set; }

    public string? Observacao { get; set; }

    public string? Calculacustost { get; set; }

    public string? Auditoria { get; set; }

    public string? Sincronizado { get; set; }

    public string? Movimentaestoque { get; set; }

    public decimal? Creditoicms { get; set; }

    public string? Cfopnfce { get; set; }

    public string? StNfce { get; set; }

    public uint? IcmsNfce { get; set; }

    public int? IcmssubNfce { get; set; }

    public string? CstcofinsNfce { get; set; }

    public string? CstpisNfce { get; set; }

    public decimal? AliquotapisNfce { get; set; }

    public decimal? AliquotacofinsNfce { get; set; }

    public string? CstipiNfce { get; set; }

    public decimal? IpiNfce { get; set; }

    public decimal? Qtdvolume { get; set; }

    public decimal? Previsao { get; set; }

    public decimal? Pendencia { get; set; }

    public decimal? Estoque { get; set; }

    public string? Similar { get; set; }

    public string? Codigoanvisa { get; set; }

    public string? Informacoesadicionais { get; set; }

    public string? Marca { get; set; }

    public decimal? Altura { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? M3 { get; set; }

    public string? Dimensoes { get; set; }

    public string? Peso { get; set; }

    public string? Lote { get; set; }

    public string? Balanca { get; set; }

    public decimal? Ipivalor { get; set; }

    public decimal? Comissao { get; set; }

    public string? Prestacao { get; set; }

    public decimal? Qtdvolumecompra { get; set; }

    public DateTime? Validade { get; set; }

    public decimal? Precotmp { get; set; }

    public string? Servicomunicipal { get; set; }

    public decimal? Proporcaounitaria { get; set; }

    public decimal? Fatorproducao { get; set; }

    public string? Pesoespecifico { get; set; }

    public string? Pesorm { get; set; }

    public string? Sincpaf { get; set; }

    public string? Filiais { get; set; }

    public string? Lotepaf { get; set; }

    public decimal? Fator0 { get; set; }

    public decimal? Fator9 { get; set; }

    public decimal? Fator10 { get; set; }

    public string? Mensagempiscofins { get; set; }

    public string? Importado { get; set; }

    public string? Fabricado { get; set; }

    public string? Descricaoetq { get; set; }

    public string? Composicao { get; set; }

    public string? Centrocusto { get; set; }

    public int? Codigomarca { get; set; }

    public int? Codigounidade { get; set; }

    public DateTime? Validacao { get; set; }

    public decimal? Pfcpufdest { get; set; }

    public decimal? Picmsinter { get; set; }

    public string? Aliquota { get; set; }

    public decimal? Picmsinterpart { get; set; }

    public string? Almoxarifado { get; set; }

    public string? Cstipi { get; set; }

    public decimal? IpNacional { get; set; }

    public decimal? IpEstadual { get; set; }

    public decimal? IpImportado { get; set; }

    public decimal? IpMunicipal { get; set; }

    public decimal? IpTipo { get; set; }

    public DateTime? IpVigenciainicio { get; set; }

    public DateTime? IpVigenciafim { get; set; }

    public string? IpVersao { get; set; }

    public string? Pathimagem { get; set; }

    public string? Diasvalidade { get; set; }

    public string? Vendedores { get; set; }

    public decimal? Customva { get; set; }

    public decimal? Custoicms { get; set; }

    public decimal? Custoipi { get; set; }

    public decimal? Custofrete { get; set; }

    public decimal? Custojuros { get; set; }

    public decimal? Custoadm { get; set; }

    public decimal? Custoimposto { get; set; }

    public decimal? Custost { get; set; }

    public decimal? Custocomissao { get; set; }

    public decimal? Custoicmsinterno { get; set; }

    public decimal? Margem1 { get; set; }

    public decimal? Margem2 { get; set; }

    public decimal? Margem3 { get; set; }

    public decimal? Margem4 { get; set; }

    public decimal? Margem5 { get; set; }

    public decimal? Margem6 { get; set; }

    public decimal? Margem7 { get; set; }

    public decimal? Margem8 { get; set; }

    public decimal? Fator1 { get; set; }

    public decimal? Fator2 { get; set; }

    public decimal? Fator3 { get; set; }

    public decimal? Fator4 { get; set; }

    public decimal? Fator5 { get; set; }

    public decimal? Fator6 { get; set; }

    public decimal? Fator7 { get; set; }

    public decimal? Fator8 { get; set; }

    public string? Modbcicmsst { get; set; }

    public string? Modbcicms { get; set; }
}
