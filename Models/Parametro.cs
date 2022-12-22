namespace AntaresAPI.Models;

public partial class Parametro
{
    public int Id { get; set; }

    public int Empresa { get; set; }

    public decimal? Maxdescontossenha { get; set; }

    public decimal? Maxdescontocsenha { get; set; }

    /// <summary>
    /// controle geral de casas decimais
    /// </summary>
    public int? Casasdecimais { get; set; }

    /// <summary>
    /// controle de casas decimais para telas de pedido de compra e compra
    /// </summary>
    public int? CasasdecimalPedidocompraCompra { get; set; }

    /// <summary>
    /// controle de casas decimais para venda e pre-venda
    /// </summary>
    public int? CasasdecimalPedidovendaVenda { get; set; }

    /// <summary>
    /// controle de casasdecimais para ordem de servico
    /// </summary>
    public int? CasasdecimalOrdemservico { get; set; }

    /// <summary>
    /// Controle de estoque:
    /// 0 - Sem estoque negativo
    /// 1 - Permite estoque negativo
    /// </summary>
    public string? Estoquenegativo { get; set; }

    public string? Pendenciafinanceira { get; set; }

    public string? Modelopedidovenda { get; set; }

    public string? Nomepedido { get; set; }

    public string? Logomarcacliente { get; set; }

    /// <summary>
    /// 0-Codigo do produto manual; 1- Codigo do produto automatico
    /// </summary>
    public string? Produtoautomatico { get; set; }

    public string? Manterprevenda { get; set; }

    public string? Manterpedidocompra { get; set; }

    public string? Pdvcodigobarras { get; set; }

    public string? Alteradescricaoproduto { get; set; }

    public string? Precocustovenda { get; set; }

    public string? Vendedorobservacao { get; set; }

    public string? Inativarprodutosprevenda { get; set; }

    public string? Obscfopvenda { get; set; }

    public string? Clienteobrigatorio { get; set; }

    public string? Mensagemordemservico { get; set; }

    public string? Pedidoclientelivre { get; set; }

    public string? Alterarestoqueminimo { get; set; }

    public string? Ativarlembrete { get; set; }

    public string? Estoqueminimoavisar { get; set; }

    public string? Nfeentradaigualsaida { get; set; }

    public string? Cadprodutoprecoobrigatorio { get; set; }

    public string? Nomevendapendente { get; set; }

    public string? Modelocomprovantevenda { get; set; }

    public string? Modeloordemservico { get; set; }

    public string? Supervisor { get; set; }

    public string? Nomesupervisor { get; set; }

    public string? Tempobackup { get; set; }

    public string? Previsualizarpv { get; set; }

    public string? Previsualizarpvms { get; set; }

    public string? Previsualizarvd { get; set; }

    public string? Previsualizarvdmp { get; set; }

    public string? Pendenciafinanceirasenha { get; set; }

    public string? Modelocusto { get; set; }

    public string? Modelomapaseparacaopv { get; set; }

    public string? Nomecomprovantevenda { get; set; }

    public string? Nomemapaseparacao { get; set; }

    public string? Separarimposto { get; set; }

    public string? Validacnpj { get; set; }

    public string? Preco2navenda { get; set; }

    public string? Matriz { get; set; }

    public string? Rankingcomissaovenda { get; set; }

    public string? Descontoisspagamento { get; set; }

    public string? Prazocabecalhopedido { get; set; }

    public string? Loteobrigatorio { get; set; }

    public string? Avisoatualizacliente { get; set; }

    public string? Visualizarestoqueav { get; set; }

    public string? Modelocotacao { get; set; }

    public string? Arquivoconsultapreco { get; set; }

    public string? Alterartabelapreco { get; set; }

    public string? Nomeempresaemrelatorios { get; set; }

    public string? Tabelacomissao { get; set; }

    public string? Mensagemfixacomprovantecompra { get; set; }

    public string? Mensagemfixacomprovantevenda { get; set; }

    public string? Telamodeloos { get; set; }

    public string? Volumepedidovenda { get; set; }

    public string? Cabecalhoimpressaoopcional { get; set; }

    public string? Freteporproduto { get; set; }

    public string? Agruparproduto { get; set; }

    public string? Movimentarestoquenopedido { get; set; }

    public string? Patharquivos { get; set; }

    public string? Caixaspaf { get; set; }

    public string? Modelorecibo { get; set; }

    public string? Letranumero { get; set; }

    public string? Utilizargrade { get; set; }

    public string? Utilizarlimitecliente { get; set; }

    public string? Faturargerartitulo { get; set; }

    public string? Sequencialetiqueta { get; set; }

    public string? Naoavisaritemduplicado { get; set; }

    public string? Lembraremailcar { get; set; }

    public string? Separafrete { get; set; }

    public string? Planocontasobrigatorio { get; set; }

    public string? Backup1 { get; set; }

    public string? Backup2 { get; set; }

    public string? Logo { get; set; }

    public string? Tokenversao { get; set; }

    public string? Fixavendedorconsultapedidovenda { get; set; }

    public string? Fixavendedorconsultavenda { get; set; }

    public decimal? Faturamentopessoafisicajuridica { get; set; }

    /// <summary>
    /// Campo essencial para abertura do Antares. Não pode ser removido. Guarda Modelo de impressora Nfce utilizada com os seguintes códigos em uso:
    /// Elgin i9 modeloimpressora=i9
    ///  
    /// 
    /// </summary>
    public string? Modeloimpressora { get; set; }

    /// <summary>
    /// Habilita e desabilita uso do Safe2pay como cobrança no Antares
    /// </summary>
    public string? Apiboleto { get; set; }

    /// <summary>
    /// Token de identificação Safe2pay
    /// </summary>
    public string? Apitoken { get; set; }

    public string? Utilizarpaf { get; set; }

    /// <summary>
    /// Volume do transportador igual ao total dos volumes dos produtos.
    /// </summary>
    public string? Volumeigualproduto { get; set; }

    /// <summary>
    /// Ativa faturamento de pedido de compra ao faturar abrir tela de compra automaticamente. Campo True/False
    /// </summary>
    public string? Abrirpedidocomprafaturado { get; set; }

    /// <summary>
    /// Ativa faturamento de pedido de venda ao faturar abrir tela de venda automaticamente. Campo True/False
    /// </summary>
    public string? Abrirpedidovendafaturado { get; set; }
}
