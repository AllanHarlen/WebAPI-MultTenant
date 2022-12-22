using AntaresAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AntaresAPI.Data;

public partial class AntaresContext : DbContext
{

    private readonly IConfiguration _config;
    private readonly string _clientename;
    public AntaresContext(IConfiguration config, string clientename)
    {
        _config = config;
        _clientename = clientename;
    }

    public AntaresContext(DbContextOptions<AntaresContext> options, IConfiguration config, string clientename) : base(options)
    {
        _config = config;
        _clientename = clientename;
    }

    public virtual DbSet<Acompanhamentocliente> Acompanhamentoclientes { get; set; }

    public virtual DbSet<Acompanhamentofornecedor> Acompanhamentofornecedors { get; set; }

    public virtual DbSet<Agendum> Agenda { get; set; }

    public virtual DbSet<AppLink> AppLinks { get; set; }

    public virtual DbSet<AppTransacaoSafe2pay> AppTransacaoSafe2pays { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Artigo> Artigos { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<Bl00150> Bl00150s { get; set; }

    public virtual DbSet<Bl00190> Bl00190s { get; set; }

    public virtual DbSet<Bl00200> Bl00200s { get; set; }

    public virtual DbSet<Bl00400> Bl00400s { get; set; }

    public virtual DbSet<BlC100> BlC100s { get; set; }

    public virtual DbSet<BlC170> BlC170s { get; set; }

    public virtual DbSet<BlC190> BlC190s { get; set; }

    public virtual DbSet<BlD100> BlD100s { get; set; }

    public virtual DbSet<BlD190> BlD190s { get; set; }

    public virtual DbSet<BlE110> BlE110s { get; set; }

    public virtual DbSet<BlE116> BlE116s { get; set; }

    public virtual DbSet<BlE200> BlE200s { get; set; }

    public virtual DbSet<BlE210> BlE210s { get; set; }

    public virtual DbSet<BlH005> BlH005s { get; set; }

    public virtual DbSet<BlH010> BlH010s { get; set; }

    public virtual DbSet<Bordado> Bordados { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cce> Cces { get; set; }

    public virtual DbSet<Centrocusto> Centrocustos { get; set; }

    public virtual DbSet<Cfop> Cfops { get; set; }

    public virtual DbSet<CfopSt> CfopSts { get; set; }

    public virtual DbSet<Cheque> Cheques { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClientesApp> ClientesApps { get; set; }

    public virtual DbSet<Clientesdadosadicionai> Clientesdadosadicionais { get; set; }

    public virtual DbSet<Codigoservicomunicipal> Codigoservicomunicipals { get; set; }

    public virtual DbSet<Codigoservicosfederai> Codigoservicosfederais { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Configuracoescte> Configuracoesctes { get; set; }

    public virtual DbSet<Configuracoesemail> Configuracoesemails { get; set; }

    public virtual DbSet<Configuracoesmdfe> Configuracoesmdves { get; set; }

    public virtual DbSet<Configuracoesnfce> Configuracoesnfces { get; set; }

    public virtual DbSet<Configuracoesnfe> Configuracoesnves { get; set; }

    public virtual DbSet<Configuracoesnfse> Configuracoesnfses { get; set; }

    public virtual DbSet<Configuracoestef> Configuracoestefs { get; set; }

    public virtual DbSet<Configusuario> Configusuarios { get; set; }

    public virtual DbSet<Contabilidade> Contabilidades { get; set; }

    public virtual DbSet<Contacorrente> Contacorrentes { get; set; }

    public virtual DbSet<Contaspagar> Contaspagars { get; set; }

    public virtual DbSet<Contaspagarhistorico> Contaspagarhistoricos { get; set; }

    public virtual DbSet<Contasreceber> Contasrecebers { get; set; }

    public virtual DbSet<Contasreceberhistorico> Contasreceberhistoricos { get; set; }

    public virtual DbSet<Contatoscliente> Contatosclientes { get; set; }

    public virtual DbSet<Contatosfornecedore> Contatosfornecedores { get; set; }

    public virtual DbSet<Cop> Cops { get; set; }

    public virtual DbSet<Cor> Cors { get; set; }

    public virtual DbSet<Cstcsosn> Cstcsosns { get; set; }

    public virtual DbSet<CteListaNfe> CteListaNves { get; set; }

    public virtual DbSet<Detalhesbordadofitum> Detalhesbordadofita { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Estoque> Estoques { get; set; }

    public virtual DbSet<Filiai> Filiais { get; set; }

    public virtual DbSet<Fitum> Fita { get; set; }

    public virtual DbSet<Fornecedore> Fornecedores { get; set; }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }

    public virtual DbSet<GrupoProduto> GrupoProdutos { get; set; }

    public virtual DbSet<Historicoarquivo> Historicoarquivos { get; set; }

    public virtual DbSet<Historicocartacorrecao> Historicocartacorrecaos { get; set; }

    public virtual DbSet<Historicomatriz> Historicomatrizs { get; set; }

    public virtual DbSet<Icm> Icms { get; set; }

    public virtual DbSet<Inutilizacaonumeracao> Inutilizacaonumeracaos { get; set; }

    public virtual DbSet<Leiautemovimento> Leiautemovimentos { get; set; }

    public virtual DbSet<Listadownloadnfe> Listadownloadnves { get; set; }

    public virtual DbSet<LocaisEntrega> LocaisEntregas { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Matriz> Matrizs { get; set; }

    public virtual DbSet<Mdfe> Mdves { get; set; }

    public virtual DbSet<Mdfecidadecarregamento> Mdfecidadecarregamentos { get; set; }

    public virtual DbSet<Mdfecidadedescarregamento> Mdfecidadedescarregamentos { get; set; }

    public virtual DbSet<Mdfelistanfe> Mdfelistanves { get; set; }

    public virtual DbSet<Mdfemotorista> Mdfemotoristas { get; set; }

    public virtual DbSet<Mdfereboque> Mdfereboques { get; set; }

    public virtual DbSet<Mdfeufpercurso> Mdfeufpercursos { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Movimentocaixa> Movimentocaixas { get; set; }

    public virtual DbSet<Municipiosibge> Municipiosibges { get; set; }

    public virtual DbSet<Mva> Mvas { get; set; }

    public virtual DbSet<Ncm> Ncms { get; set; }

    public virtual DbSet<NfceCabecalho> NfceCabecalhos { get; set; }

    public virtual DbSet<NfceDetalhe> NfceDetalhes { get; set; }

    public virtual DbSet<NfceMovimento> NfceMovimentos { get; set; }

    public virtual DbSet<NfceMovimentoOperador> NfceMovimentoOperadors { get; set; }

    public virtual DbSet<NfceSangriaSuprimento> NfceSangriaSuprimentos { get; set; }

    public virtual DbSet<Numeracao> Numeracaos { get; set; }

    public virtual DbSet<Numeracaocaixa> Numeracaocaixas { get; set; }

    public virtual DbSet<Numeracaofiscal> Numeracaofiscals { get; set; }

    public virtual DbSet<Numeracaopedido> Numeracaopedidos { get; set; }

    public virtual DbSet<Ordemservico> Ordemservicos { get; set; }

    public virtual DbSet<Ordemservicomovimento> Ordemservicomovimentos { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<Peca> Pecas { get; set; }

    public virtual DbSet<Pedidocompra> Pedidocompras { get; set; }

    public virtual DbSet<Pedidocompramovimento> Pedidocompramovimentos { get; set; }

    public virtual DbSet<Pedidomovimentograde> Pedidomovimentogrades { get; set; }

    public virtual DbSet<Pedidovendadetalhebordado> Pedidovendadetalhebordados { get; set; }

    public virtual DbSet<Pedidovendamovimento> Pedidovendamovimentos { get; set; }

    public virtual DbSet<Pedidovendum> Pedidovenda { get; set; }

    public virtual DbSet<Placa> Placas { get; set; }

    public virtual DbSet<Planoconta> Planocontas { get; set; }

    public virtual DbSet<Precoespecialcliente> Precoespecialclientes { get; set; }

    public virtual DbSet<Producao> Producaos { get; set; }

    public virtual DbSet<Producaocontrolequalidade> Producaocontrolequalidades { get; set; }

    public virtual DbSet<Producaocustosadicionai> Producaocustosadicionais { get; set; }

    public virtual DbSet<Producaodetalhe> Producaodetalhes { get; set; }

    public virtual DbSet<Producaooperadore> Producaooperadores { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Produtodetalhe> Produtodetalhes { get; set; }

    public virtual DbSet<Produtoimagen> Produtoimagens { get; set; }

    public virtual DbSet<Produtoslinkfornecedore> Produtoslinkfornecedores { get; set; }

    public virtual DbSet<Produtosrankingcomissao> Produtosrankingcomissaos { get; set; }

    public virtual DbSet<Prospeccao> Prospeccaos { get; set; }

    public virtual DbSet<Prospeccaocontato> Prospeccaocontatos { get; set; }

    public virtual DbSet<Prospeccaodetalhe> Prospeccaodetalhes { get; set; }

    public virtual DbSet<Reajustepreco> Reajusteprecos { get; set; }

    public virtual DbSet<Recebimento> Recebimentos { get; set; }

    public virtual DbSet<Relatorio> Relatorios { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Statusfinanceiro> Statusfinanceiros { get; set; }

    public virtual DbSet<Suite> Suites { get; set; }

    public virtual DbSet<Suitetipo> Suitetipos { get; set; }

    public virtual DbSet<Tabelaprecocliente> Tabelaprecoclientes { get; set; }

    public virtual DbSet<Tabelapreconome> Tabelapreconomes { get; set; }

    public virtual DbSet<Tecido> Tecidos { get; set; }

    public virtual DbSet<Transportadora> Transportadoras { get; set; }

    public virtual DbSet<Turma> Turmas { get; set; }

    public virtual DbSet<Unidade> Unidades { get; set; }

    public virtual DbSet<Veiculo> Veiculos { get; set; }

    public virtual DbSet<Vendedore> Vendedores { get; set; }

    public virtual DbSet<Vendum> Venda { get; set; }

    public virtual DbSet<VwComisliquidez1> VwComisliquidez1s { get; set; }

    public virtual DbSet<VwContaspagar> VwContaspagars { get; set; }

    public virtual DbSet<VwContasreceber> VwContasrecebers { get; set; }

    public virtual DbSet<VwEstoque> VwEstoques { get; set; }

    public virtual DbSet<VwEstoqueatual> VwEstoqueatuals { get; set; }

    public virtual DbSet<VwEstoquelote> VwEstoquelotes { get; set; }

    public virtual DbSet<VwLegendaproducao> VwLegendaproducaos { get; set; }

    public virtual DbSet<VwListaCompra> VwListaCompras { get; set; }

    public virtual DbSet<VwListaOrdemservico> VwListaOrdemservicos { get; set; }

    public virtual DbSet<VwListaPedidocompra> VwListaPedidocompras { get; set; }

    public virtual DbSet<VwListaPedidovendum> VwListaPedidovenda { get; set; }

    public virtual DbSet<VwListaVenda> VwListaVendas { get; set; }

    public virtual DbSet<VwSomaestoque> VwSomaestoques { get; set; }

    public virtual DbSet<VwSomanfce> VwSomanfces { get; set; }

    public virtual DbSet<VwSomaordemservico> VwSomaordemservicos { get; set; }

    public virtual DbSet<Webservice> Webservices { get; set; }

    public virtual DbSet<Y1> Y1s { get; set; }

    public virtual DbSet<Y2> Y2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql(_config.GetConnectionString(_clientename), Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.6-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Acompanhamentocliente>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("acompanhamentocliente");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Acompanhamento)
                .HasMaxLength(10000)
                .HasColumnName("acompanhamento");
            entity.Property(e => e.Cliente)
                .HasMaxLength(6)
                .HasColumnName("cliente");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(150)
                .HasColumnName("fantasia");
            entity.Property(e => e.Hora)
                .HasColumnType("datetime")
                .HasColumnName("hora");
            entity.Property(e => e.Lembrar)
                .HasColumnType("datetime")
                .HasColumnName("lembrar");
            entity.Property(e => e.Origem)
                .HasMaxLength(1)
                .HasColumnName("origem");
            entity.Property(e => e.Removerlembrete)
                .HasMaxLength(1)
                .HasColumnName("removerlembrete");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Acompanhamentofornecedor>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("acompanhamentofornecedor");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Acompanhamento)
                .HasMaxLength(10000)
                .HasColumnName("acompanhamento");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(150)
                .HasColumnName("fantasia");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(6)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Hora)
                .HasColumnType("datetime")
                .HasColumnName("hora");
            entity.Property(e => e.Lembrar)
                .HasColumnType("datetime")
                .HasColumnName("lembrar");
            entity.Property(e => e.Origem)
                .HasMaxLength(1)
                .HasColumnName("origem");
            entity.Property(e => e.Removerlembrete)
                .HasMaxLength(1)
                .HasColumnName("removerlembrete");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Agendum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("agenda");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Compromisso)
                .HasMaxLength(10000)
                .HasColumnName("compromisso");
            entity.Property(e => e.Conclusao)
                .HasColumnType("datetime")
                .HasColumnName("conclusao");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Lembrar)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("lembrar");
            entity.Property(e => e.Periodo)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("periodo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(5)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<AppLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_link");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Idvendedor)
                .HasColumnType("int(11)")
                .HasColumnName("idvendedor");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<AppTransacaoSafe2pay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("app_transacao_safe2pay");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasComment("Data transação cartão")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasComment("Retorno transação cartão")
                .HasColumnName("descricao");
            entity.Property(e => e.IdTransaction)
                .HasMaxLength(15)
                .HasColumnName("id_transaction");
            entity.Property(e => e.Mensagem)
                .HasMaxLength(255)
                .HasComment("Mensagem transação cartão")
                .HasColumnName("mensagem");
            entity.Property(e => e.Pedido)
                .HasMaxLength(15)
                .HasComment("Número do pedido transação cartão")
                .HasColumnName("pedido");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasComment("Status transação cartão")
                .HasColumnName("status");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasComment("Token transação cartão")
                .HasColumnName("token");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("area");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Descricao)
                .HasMaxLength(15)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Artigo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("artigo");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Audit>(entity =>
        {
            entity.HasKey(e => e.Data).HasName("PRIMARY");

            entity.ToTable("audit", tb => tb.HasComment("Tabela para registro de ações de usuário"));

            entity.Property(e => e.Data)
                .HasComment("Data da inserção do log")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Log)
                .HasComment("Log de ações do usuário")
                .HasColumnName("log")
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bancos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Agencia)
                .HasMaxLength(15)
                .HasColumnName("agencia");
            entity.Property(e => e.Apiboleto)
                .HasMaxLength(2)
                .HasComment("Habilita Safe2pay pra conta bancária")
                .HasColumnName("apiboleto");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasColumnName("ativo");
            entity.Property(e => e.Banco1)
                .HasMaxLength(3)
                .HasColumnName("banco");
            entity.Property(e => e.Carteira)
                .HasMaxLength(10)
                .HasColumnName("carteira");
            entity.Property(e => e.Cnab)
                .HasMaxLength(15)
                .HasColumnName("cnab");
            entity.Property(e => e.Codigo)
                .HasColumnType("int(11)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codigoempresa)
                .HasMaxLength(20)
                .HasColumnName("codigoempresa");
            entity.Property(e => e.Conta)
                .HasMaxLength(15)
                .HasColumnName("conta");
            entity.Property(e => e.Convenio)
                .HasMaxLength(50)
                .HasColumnName("convenio");
            entity.Property(e => e.Datacadastro)
                .HasMaxLength(20)
                .HasColumnName("datacadastro");
            entity.Property(e => e.Desativar)
                .HasMaxLength(5)
                .HasDefaultValueSql("'false'")
                .HasColumnName("desativar");
            entity.Property(e => e.Desconto)
                .HasPrecision(10, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(25)
                .HasColumnName("descricao");
            entity.Property(e => e.Diasprotesto)
                .HasColumnType("int(11)")
                .HasColumnName("diasprotesto");
            entity.Property(e => e.DigitoAg)
                .HasMaxLength(2)
                .HasColumnName("digito_ag");
            entity.Property(e => e.DigitoConta)
                .HasMaxLength(2)
                .HasColumnName("digito_conta");
            entity.Property(e => e.Especie)
                .HasMaxLength(10)
                .HasColumnName("especie");
            entity.Property(e => e.Jurosdemora)
                .HasPrecision(10, 4)
                .HasColumnName("jurosdemora");
            entity.Property(e => e.Mensagem1)
                .HasMaxLength(20)
                .HasColumnName("mensagem1");
            entity.Property(e => e.Mensagem2)
                .HasMaxLength(20)
                .HasColumnName("mensagem2");
            entity.Property(e => e.Mensagem3)
                .HasMaxLength(20)
                .HasColumnName("mensagem3");
            entity.Property(e => e.Multa)
                .HasPrecision(10, 4)
                .HasColumnName("multa");
            entity.Property(e => e.NCheque)
                .HasMaxLength(6)
                .HasColumnName("n_cheque");
            entity.Property(e => e.Naoreceberdias)
                .HasColumnType("int(11)")
                .HasColumnName("naoreceberdias");
            entity.Property(e => e.Nossonumero)
                .HasMaxLength(20)
                .HasColumnName("nossonumero");
            entity.Property(e => e.Protestar)
                .HasMaxLength(5)
                .HasColumnName("protestar");
            entity.Property(e => e.Protestardiascorridos)
                .HasColumnType("int(11)")
                .HasColumnName("protestardiascorridos");
            entity.Property(e => e.Protestardiasuteis)
                .HasColumnType("int(11)")
                .HasColumnName("protestardiasuteis");
            entity.Property(e => e.Qtdremessa)
                .HasColumnType("int(11)")
                .HasColumnName("qtdremessa");
            entity.Property(e => e.Reciboentrega)
                .HasMaxLength(5)
                .HasColumnName("reciboentrega");
            entity.Property(e => e.Registrada)
                .HasMaxLength(5)
                .HasColumnName("registrada");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(20)
                .HasColumnName("responsavel");
            entity.Property(e => e.Saldo)
                .HasPrecision(10, 4)
                .HasColumnName("saldo");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tipoboleto)
                .HasMaxLength(15)
                .HasColumnName("tipoboleto");
        });

        modelBuilder.Entity<Bl00150>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl0_0150", tb => tb.HasComment("Tabela para gerar arquivo Sped ECf ICMS IPI. Este registro tem por objetivo relacionar e cadastrar os participantes (fornecedores e clientes pessoa jurídica ou pessoa\r\nfísica) que tenham realizado operações com a empresa, objeto de registro nos Blocos A, C, D, F ou 1."));

            entity.Property(e => e.Id)
                .HasComment("campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasComment("Bairro em que o imóvel está situado - 60 caracteres")
                .HasColumnName("bairro");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(25)
                .HasComment("CNPJ do participante - 14 caracteres")
                .HasColumnName("cnpj");
            entity.Property(e => e.CodMun)
                .HasMaxLength(10)
                .HasComment("Código do município, conforme a tabela IBGE - 7 caracteres")
                .HasColumnName("cod_mun");
            entity.Property(e => e.CodPais)
                .HasMaxLength(8)
                .HasComment("Código do país do participante, conforme a tabela indicada - 5 carcateres")
                .HasColumnName("cod_pais");
            entity.Property(e => e.CodPart)
                .HasMaxLength(25)
                .HasComment("Código de identificação do participante no arquivo. - 60 caracteres. Antares preenche com o cnpj/cpf")
                .HasColumnName("cod_part");
            entity.Property(e => e.Compl)
                .HasMaxLength(50)
                .HasComment("Dados complementares do endereço - 60 caracteres")
                .HasColumnName("compl");
            entity.Property(e => e.Cpf)
                .HasMaxLength(25)
                .HasComment("CPF do participante - 11 caracteres")
                .HasColumnName("cpf");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo. Venda e emissao, compra e lancamento")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.End)
                .HasMaxLength(50)
                .HasComment("Logradouro e endereço do imóvel - 60 caracteres")
                .HasColumnName("end");
            entity.Property(e => e.Ie)
                .HasMaxLength(25)
                .HasComment("Inscricao estadual do participante - 14 caracteres")
                .HasColumnName("ie");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasComment("Nome pessoal ou empresarial do participante. - 100 caracteres")
                .HasColumnName("nome");
            entity.Property(e => e.Num)
                .HasMaxLength(10)
                .HasComment("Número do imóvel ")
                .HasColumnName("num");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'0150'")
                .HasComment("Texto fixo contendo “0150”")
                .HasColumnName("reg");
            entity.Property(e => e.Suframa)
                .HasMaxLength(50)
                .HasComment("Número de inscrição do participante na Suframa - 9 caracteres")
                .HasColumnName("suframa");
        });

        modelBuilder.Entity<Bl00190>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl0_0190", tb => tb.HasComment("Tabela para gerar arquivo Sped ECf ICMS IPI na Identificação das Unidades de Medida"));

            entity.Property(e => e.Id)
                .HasComment("campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo. ")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Descr)
                .HasMaxLength(50)
                .HasComment("Descrição da unidade de medida")
                .HasColumnName("descr");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'0190'")
                .HasComment("Texto fixo contendo 0190 - 4 caracteres")
                .HasColumnName("reg");
            entity.Property(e => e.Unid)
                .HasMaxLength(10)
                .HasComment("Código da unidade de medida - 6 caracteres")
                .HasColumnName("unid");
        });

        modelBuilder.Entity<Bl00200>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl0_0200", tb => tb.HasComment("Tabela de Identificação do Item (Produtos e Serviços) no SPED\r\nEste registro tem por objetivo informar as mercadorias, serviços, produtos ou quaisquer outros itens concernentes às\r\ntransações representativas de receitas e/ou geradoras de créditos, objeto de escrituração nos Blocos A, C, D, F ou 1."));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AliqIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Alíquota de ICMS aplicável ao item naoperações\r\ninternas - 6 caracteres")
                .HasColumnName("aliq_icms");
            entity.Property(e => e.Cest)
                .HasMaxLength(15)
                .HasComment("Código Especificador da Substituição Tributária - 7 caracteres")
                .HasColumnName("cest");
            entity.Property(e => e.CodAntItem)
                .HasMaxLength(15)
                .HasComment("Código anterior do item com relação à última informação - 60 caracteres")
                .HasColumnName("cod_ant_item");
            entity.Property(e => e.CodBarra)
                .HasMaxLength(25)
                .HasComment("Representação alfanumérico do código de barra do\r\nproduto, se houver- 60 caracteres")
                .HasColumnName("cod_barra");
            entity.Property(e => e.CodGen)
                .HasMaxLength(50)
                .HasComment("Código do gênero do item, conforme a Tabela 4.2.1. - 2 caracteres")
                .HasColumnName("cod_gen");
            entity.Property(e => e.CodItem)
                .HasMaxLength(15)
                .HasComment("Código do item - 60 caracteres")
                .HasColumnName("cod_item");
            entity.Property(e => e.CodLst)
                .HasMaxLength(50)
                .HasComment("Código do serviço conforme lista do Anexo I da Lei\r\nComplementar Federal nº 116/03. Obs: A partir do período de apuração maio de 2015\r\n(versão 2.11 do PVA), o código a ser informado neste\r\ncampo poderá ser informado 05 (cinco) caracteres, no\r\nformato “XX.XX”, conforme a codificação adotada na\r\nLei Complementar nº 116/2003 e na EFD-ICMS/IPI - 5 caracteres")
                .HasColumnName("cod_lst");
            entity.Property(e => e.CodNcm)
                .HasMaxLength(10)
                .HasComment("Código da Nomenclatura Comum do Mercosul - 8 caracteres")
                .HasColumnName("cod_ncm");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo.")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DescrItem)
                .HasMaxLength(100)
                .HasComment("Descrição do item")
                .HasColumnName("descr_item");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.ExIpi)
                .HasMaxLength(50)
                .HasComment("Código EX, conforme a TIPI - 3 caracteres")
                .HasColumnName("ex_ipi");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'0200'")
                .HasComment("Texto fixo contendo 0200 - 4 caracteres")
                .HasColumnName("reg");
            entity.Property(e => e.TipoItem)
                .HasMaxLength(50)
                .HasComment("Tipo do item – Atividades Industriais, Comerciais e\r\nServiços:\r\n00 – Mercadoria para Revenda;\r\n01 – Matéria-Prima;\r\n02 – Embalagem;\r\n03 – Produto em Processo;\r\n04 – Produto Acabado;\r\n05 – Subproduto;\r\n06 – Produto Intermediário;\r\n07 – Material de Uso e Consumo;\r\n08 – Ativo Imobilizado;\r\n09 – Serviços;\r\n10 – Outros insumos;\r\n99 – Outras\r\n2 caracteres")
                .HasColumnName("tipo_item");
            entity.Property(e => e.UnidInv)
                .HasMaxLength(6)
                .HasComment("Unidade de medida utilizada na quantificação de\r\nestoques - 6 caracteres")
                .HasColumnName("unid_inv");
        });

        modelBuilder.Entity<Bl00400>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl0_0400", tb => tb.HasComment("Este registro tem por objetivo codificar os textos das diferentes naturezas da operação/prestações discriminadas nos\r\ndocumentos fiscais. Esta codificação e suas descrições são livremente criadas e mantidas pelo contribuinte.\r\nEste registro não se refere ao CFOP. Algumas empresas utilizam outra classificação além das apresentadas nos\r\nCFOP. Esta codificação permite informar estes agrupamentos próprios.\r\nValidação do Registro: Não podem ser informados dois ou mais registros com o mesmo conteúdo no campo COD_NAT."));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CodNat)
                .HasMaxLength(10)
                .HasComment("Código da natureza da operação/prestação - 10 caracteres")
                .HasColumnName("cod_nat");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DescrNat)
                .HasMaxLength(100)
                .HasComment("Descrição da natureza da operação/prestação")
                .HasColumnName("descr_nat");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'0400'")
                .HasComment("Texto fixo contendo 0400")
                .HasColumnName("reg");
        });

        modelBuilder.Entity<BlC100>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_c100", tb => tb.HasComment("Este registro deve ser gerado para cada documento fiscal código 01, 1B, 04, 55 e 65 (saída), conforme item 4.1.1 da\r\nNota Técnica (Ato COTEPE/ICMS nº 44/2018 e alterações), registrando a entrada ou saída de produtos ou outras situações\r\nque envolvam a emissão dos documentos fiscais mencionados. As NFC-e (código 65) não devem ser escrituradas nas\r\nentradas"));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ChvNfe)
                .HasMaxLength(50)
                .HasComment("Chave da Nota Fiscal Eletrônica - 44 caracteres")
                .HasColumnName("chv_nfe");
            entity.Property(e => e.CodMod)
                .HasMaxLength(5)
                .HasComment("Código do modelo do documento fiscal,\r\nconforme a Tabela 4.1.1 - 2 caracteres")
                .HasColumnName("cod_mod");
            entity.Property(e => e.CodPart)
                .HasMaxLength(25)
                .HasComment("Código do participante (campo 02 do Registro\r\n0150):\r\n- do emitente do documento ou do remetente\r\ndas mercadorias, no caso de entradas;\r\n- do adquirente, no caso de saídas\r\n60 caracteres")
                .HasColumnName("cod_part");
            entity.Property(e => e.CodSit)
                .HasMaxLength(5)
                .HasComment("Código da situação do documento fiscal,\r\nconforme a Tabela 4.1.2 - 2 caracteres")
                .HasColumnName("cod_sit");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DtDoc)
                .HasMaxLength(15)
                .HasComment("Data da emissão do documento fiscal - 8 caracteres")
                .HasColumnName("dt_doc");
            entity.Property(e => e.DtES)
                .HasMaxLength(15)
                .HasComment("Data da entrada ou da saída - 8 caracteres")
                .HasColumnName("dt_e_s");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.IdCompra)
                .HasComment("Chave primária da compra informada no registro")
                .HasColumnType("int(11)")
                .HasColumnName("id_compra");
            entity.Property(e => e.IdVenda)
                .HasComment("Chave primária da venda informada no registro")
                .HasColumnType("int(11)")
                .HasColumnName("id_venda");
            entity.Property(e => e.IndEmit)
                .HasMaxLength(5)
                .HasComment("Indicador do emitente do documento fiscal:\r\n0 - Emissão própria;\r\n1 - Terceiros\r\n1 caractere")
                .HasColumnName("ind_emit");
            entity.Property(e => e.IndFrt)
                .HasMaxLength(5)
                .HasComment("Indicador do tipo do frete:\r\nObs: A partir de 01/01/2018 passará a ser:\r\nIndicador do tipo de frete:\r\n0 - Contratação do Frete por conta do\r\nRemetente (CIF);\r\n1 - Contratação do Frete por conta do\r\nDestinatário (FOB);\r\n2 - Contratação do Frete por conta de\r\nTerceiros;\r\n3 - Transporte Próprio por conta do\r\nRemetente;\r\n4 - Transporte Próprio por conta do\r\nDestinatário;\r\n9 - Sem Ocorrência de Transporte.\r\n1 caractere")
                .HasColumnName("ind_frt");
            entity.Property(e => e.IndOper)
                .HasMaxLength(5)
                .HasComment("Indicador do tipo de operação:\r\n0 - Entrada;\r\n1 - Saída\r\n1 caractere")
                .HasColumnName("ind_oper");
            entity.Property(e => e.IndPgto)
                .HasMaxLength(5)
                .HasComment("Indicador do tipo de pagamento:\r\n0 - À vista;\r\n1 - A prazo;\r\n9 - Sem pagamento.\r\nObs.: A partir de 01/07/2012 passará a ser:\r\nIndicador do tipo de pagamento:\r\n0 - À vista;\r\n1 - A prazo;\r\n2 - Outros\r\n1 caractere")
                .HasColumnName("ind_pgto");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(15)
                .HasComment("Número do documento fiscal - 9 caracteres")
                .HasColumnName("num_doc");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'C100'")
                .HasComment("Texto fixo contendo \"C100\"")
                .HasColumnName("reg");
            entity.Property(e => e.Ser)
                .HasMaxLength(5)
                .HasComment("Série do documento fiscal - 3 caracteres")
                .HasColumnName("ser");
            entity.Property(e => e.VlAbatNt)
                .HasPrecision(18, 2)
                .HasComment("Abatimento não tributado e não comercial\r\nPor exemplo: desconto ICMS nas remessas para\r\nZFM.\r\ndecimal com 2 casas")
                .HasColumnName("vl_abat_nt");
            entity.Property(e => e.VlBcIcms)
                .HasPrecision(18, 2)
                .HasComment("Valor da base de cálculo do ICMS - decimal com duas casas")
                .HasColumnName("vl_bc_icms");
            entity.Property(e => e.VlBcIcmsst)
                .HasPrecision(18, 2)
                .HasComment("Valor da base de cálculo do ICMS substituição - decimal com duas casas")
                .HasColumnName("vl_bc_icmsst");
            entity.Property(e => e.VlCofins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total do COFINS - decimal com duas casas")
                .HasColumnName("vl_cofins");
            entity.Property(e => e.VlCofinsSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total do COFINS retido por substituição - decimal com duas casas")
                .HasColumnName("vl_cofins_st");
            entity.Property(e => e.VlDesc)
                .HasPrecision(18, 2)
                .HasComment("Valor total do desconto - decimal com 2 casas")
                .HasColumnName("vl_desc");
            entity.Property(e => e.VlDoc)
                .HasPrecision(18, 2)
                .HasComment("Valor total do documento fiscal - Decimal com 2 casas")
                .HasColumnName("vl_doc");
            entity.Property(e => e.VlFrt)
                .HasPrecision(18, 2)
                .HasComment("Valor do frete indicado no documento fiscal - decimal com duas casas")
                .HasColumnName("vl_frt");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 2)
                .HasComment("Valor do ICMS - decimal com duas casas")
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlIcmsSt)
                .HasPrecision(18, 2)
                .HasComment("Valor do ICMS retido por substituição - decimal com duas casas")
                .HasColumnName("vl_icms_st");
            entity.Property(e => e.VlIpi)
                .HasPrecision(18, 2)
                .HasComment("Valor total do IPI - decimal com duas casas")
                .HasColumnName("vl_ipi");
            entity.Property(e => e.VlMerc)
                .HasPrecision(18, 2)
                .HasComment("Valor total das mercadorias e serviços - 2 caracteres")
                .HasColumnName("vl_merc");
            entity.Property(e => e.VlOutDa)
                .HasPrecision(18, 2)
                .HasComment("Valor de outras despesas acessórias - decimal com duas casas")
                .HasColumnName("vl_out_da");
            entity.Property(e => e.VlPis)
                .HasPrecision(18, 2)
                .HasColumnName("vl_pis");
            entity.Property(e => e.VlPisSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total do PIS retido por substituição - decimal com duas casas")
                .HasColumnName("vl_pis_st");
            entity.Property(e => e.VlSeg)
                .HasPrecision(18, 2)
                .HasComment("Valor do seguro indicado no documento fiscal - decimal com duas casas")
                .HasColumnName("vl_seg");
        });

        modelBuilder.Entity<BlC170>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_c170", tb => tb.HasComment("Registro obrigatório para discriminar os itens da nota fiscal (mercadorias e/ou serviços constantes em notas\r\nconjugadas), inclusive em operações de entrada de mercadorias acompanhadas de Nota Fiscal Eletrônica (NF-e) de emissão\r\nde terceiros.\r\nConforme item 2.4.2.2.1 da Nota Técnica, instituída pelo Ato COTEPE/ICMS nº 44/2018 e alterações, o termo\r\n“item” é aplicado às operações fiscais que envolvam mercadorias, serviços, produtos ou quaisquer outros itens concernentes\r\nàs transações fiscais suportadas pelo documento, como, por exemplo, nota fiscal complementar, nota fiscal de ressarcimento,\r\ntransferências de créditos e outros casos.\r\n Validação do Registro: Não podem ser informados para um mesmo documento fiscal dois ou mais registros com o\r\nmesmo conteúdo no campo NUM_ITEM.\r\nIMPORTANTE: para documentos de entrada, os campos de valor de imposto, base de cálculo e alíquota só devem ser\r\ninformados se o adquirente tiver direito à apropriação do crédito (enfoque do declarante)."));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AliqCofins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Alíquota do COFINS (em percentual) - 8 caracteres; decimal com 4 casas")
                .HasColumnName("aliq_cofins");
            entity.Property(e => e.AliqCofinsReais)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Alíquota da COFINS (em reais) - decimal com 4 casas")
                .HasColumnName("aliq_cofins_reais");
            entity.Property(e => e.AliqIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Alíquota do ICMS - 6 caracteres decimal com duas casas")
                .HasColumnName("aliq_icms");
            entity.Property(e => e.AliqIpi)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Alíquota do IPI - 6 caracteres decimal com 2 casas")
                .HasColumnName("aliq_ipi");
            entity.Property(e => e.AliqPis)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Alíquota do PIS (em percentual) - 8 caracteres, decimal com 4 casas")
                .HasColumnName("aliq_pis");
            entity.Property(e => e.AliqPisReais)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Alíquota do PIS (em reais) - decimal com 3 casas")
                .HasColumnName("aliq_pis_reais");
            entity.Property(e => e.AliqSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Alíquota do ICMS da substituição tributária na")
                .HasColumnName("aliq_st");
            entity.Property(e => e.Cfop)
                .HasMaxLength(5)
                .HasComment("CFOP - Código Fiscal de Operação e Prestação")
                .HasColumnName("cfop");
            entity.Property(e => e.CodCta)
                .HasMaxLength(50)
                .HasComment("Código da conta analítica contábil\r\ndebitada/creditada")
                .HasColumnName("cod_cta");
            entity.Property(e => e.CodEnq)
                .HasMaxLength(5)
                .HasComment("Código de enquadramento legal do IPI,\r\nconforme tabela indicada no item 4.5.3.\r\n3 caracteres")
                .HasColumnName("cod_enq");
            entity.Property(e => e.CodItem)
                .HasMaxLength(15)
                .HasComment("Código do item (campo 02 do Registro 0200) - 60 caracteres")
                .HasColumnName("cod_item");
            entity.Property(e => e.CodNat)
                .HasMaxLength(6)
                .HasComment("Código da conta analítica contábil\r\ndebitada/creditada")
                .HasColumnName("cod_nat");
            entity.Property(e => e.CstCofins)
                .HasMaxLength(2)
                .HasComment("Código da Situação Tributária referente ao\r\nCOFINS - 2 caracteres")
                .HasColumnName("cst_cofins");
            entity.Property(e => e.CstIcms)
                .HasMaxLength(5)
                .HasComment("Código da Situação Tributária referente ao\r\nICMS, conforme a Tabela indicada no item\r\n4.3.1\r\n3 caracteres")
                .HasColumnName("cst_icms");
            entity.Property(e => e.CstIpi)
                .HasMaxLength(2)
                .HasComment("Indicador de período de apuração do IPI:\r\n0 - Mensal;\r\n1 - Decendial\r\n 2 caracteres")
                .HasColumnName("cst_ipi");
            entity.Property(e => e.CstPis)
                .HasMaxLength(2)
                .HasComment("Código da Situação Tributária referente ao PIS - 2 caracteres")
                .HasColumnName("cst_pis");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DescrCompl)
                .HasMaxLength(100)
                .HasComment("Descrição complementar do item como adotado")
                .HasColumnName("descr_compl");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.IdCompra)
                .HasComment("Chave primária da compra informada no registro")
                .HasColumnType("int(11)")
                .HasColumnName("id_compra");
            entity.Property(e => e.IndApur)
                .HasMaxLength(6)
                .HasComment("Indicador de período de apuração do IPI:\r\n0 - Mensal;\r\n1 - Decendial\r\n1 caractere")
                .HasColumnName("ind_apur");
            entity.Property(e => e.IndMov)
                .HasMaxLength(5)
                .HasComment("Movimentação física do ITEM/PRODUTO:\r\n0. SIM\r\n1. NÃO\r\n1 caractere")
                .HasColumnName("ind_mov");
            entity.Property(e => e.NumItem)
                .HasMaxLength(15)
                .HasComment("Número sequencial do item no documento - 3 caracteres")
                .HasColumnName("num_item");
            entity.Property(e => e.Qtd)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Quantidade do item - decimal com 5 casas")
                .HasColumnName("qtd");
            entity.Property(e => e.QuantBcCofins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Quantidade – Base de cálculo COFINS - decimal com 3 casas")
                .HasColumnName("quant_bc_cofins");
            entity.Property(e => e.QuantBcPis)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Quantidade – Base de cálculo PIS - decimal com 3 casas")
                .HasColumnName("quant_bc_pis");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'C170'")
                .HasComment("Texto fixo contendo \"C170\" - 4 caracteres")
                .HasColumnName("reg");
            entity.Property(e => e.Unid)
                .HasMaxLength(6)
                .HasComment("Unidade do item (Campo 02 do registro 0190) - 6 caracteres")
                .HasColumnName("unid");
            entity.Property(e => e.VlAbatNt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor do abatimento não tributado e não\r\ncomercial - decimal com 2 casas")
                .HasColumnName("vl_abat_nt");
            entity.Property(e => e.VlBcCofins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da base de cálculo da COFINS - decimal com 2 casas")
                .HasColumnName("vl_bc_cofins");
            entity.Property(e => e.VlBcIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da base de cálculo do ICMS - decimal com 2 casas")
                .HasColumnName("vl_bc_icms");
            entity.Property(e => e.VlBcIcmsSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da base de cálculo referente à\r\nsubstituição tributária - decimal com 2 casas")
                .HasColumnName("vl_bc_icms_st");
            entity.Property(e => e.VlBcIpi)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da base de cálculo do IPI - decimal com 2 casas")
                .HasColumnName("vl_bc_ipi");
            entity.Property(e => e.VlBcPis)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da base de cálculo do PIS - decimal com 2 casas")
                .HasColumnName("vl_bc_pis");
            entity.Property(e => e.VlCofins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da COFINS - decimal com 2 casas")
                .HasColumnName("vl_cofins");
            entity.Property(e => e.VlDesc)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor do desconto comercial - decimal com 2 casas")
                .HasColumnName("vl_desc");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da base de cálculo referente à\r\nsubstituição tributária\r\nDecimal com 2 casas decimais")
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlIcmsSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor do ICMS referente à substituição\r\ntributária - decimal com 2 casa")
                .HasColumnName("vl_icms_st");
            entity.Property(e => e.VlIpi)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor do IPI creditado/debitado - decimal com 2 casas")
                .HasColumnName("vl_ipi");
            entity.Property(e => e.VlItem)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total do item (mercadorias ou serviços) - 2 caracteres")
                .HasColumnName("vl_item");
            entity.Property(e => e.VlPis)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor do PIS - decimal com 2 casas")
                .HasColumnName("vl_pis");
        });

        modelBuilder.Entity<BlC190>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_c190", tb => tb.HasComment("Este registro tem por objetivo representar a escrituração dos documentos fiscais totalizados por CST, CFOP e\r\nAlíquota de ICMS.\r\nValidação do Registro: não podem ser informados dois ou mais registros com a mesma combinação de valores dos\r\ncampos: CST_ICMS, CFOP e ALIQ_ICMS. A combinação dos valores dos campos CST_ICMS, CFOP e ALIQ_ICMS\r\ndevem existir no respectivo registro de itens do C170, quando este registro for exigido"));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AliqIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Alíquota do ICMS - 6 caracteres; decimal com 6 caracteres")
                .HasColumnName("aliq_icms");
            entity.Property(e => e.Cfop)
                .HasMaxLength(10)
                .HasComment("Código Fiscal de Operação e Prestação do\r\nagrupamento de itens - 4 caracteres")
                .HasColumnName("cfop");
            entity.Property(e => e.CodObs)
                .HasMaxLength(6)
                .HasComment("Código da observação do lançamento fiscal C 006 - OC OC\r\n(campo 02 do Registro 0460) - 6 caracteres")
                .HasColumnName("cod_obs");
            entity.Property(e => e.CstIcms)
                .HasMaxLength(8)
                .HasComment("Código da Situação Tributária, conforme a\r\nTabela indicada no item 4.3.1 - 3 caracteres")
                .HasColumnName("cst_icms");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.IdCompra)
                .HasComment("Chave primária da compra informada no registro")
                .HasColumnType("int(11)")
                .HasColumnName("id_compra");
            entity.Property(e => e.IdVenda)
                .HasComment("Chave primária da venda informada no registro")
                .HasColumnType("int(11)")
                .HasColumnName("id_venda");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'C190'")
                .HasComment("Texto fixo contendo \"C190\"")
                .HasColumnName("reg");
            entity.Property(e => e.VlBcIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Parcela correspondente ao \"Valor da base de\r\ncálculo do ICMS\" referente à combinação de\r\nCST_ICMS, CFOP e alíquota do ICMS. Decimal com 2 casas")
                .HasColumnName("vl_bc_icms");
            entity.Property(e => e.VlBcIcmsSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Parcela correspondente ao \"Valor da base de\r\ncálculo do ICMS\" da substituição tributária\r\nreferente à combinação de CST_ICMS, CFOP e\r\nalíquota do ICMS. Decimal com 2 casas")
                .HasColumnName("vl_bc_icms_st");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Parcela correspondente ao \"Valor do ICMS\",\r\nincluindo o FCP, quando aplicável, referente à\r\ncombinação de CST_ICMS, CFOP e alíquota do\r\nICMS - decimal com 2 casas")
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlIcmsSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Parcela correspondente ao valor\r\ncreditado/debitado do ICMS da substituição\r\ntributária, incluindo o FCP_ ST, quando\r\naplicável, referente à combinação de\r\nCST_ICMS, CFOP, e alíquota do ICMS. Decimal com 2 casas")
                .HasColumnName("vl_icms_st");
            entity.Property(e => e.VlIpi)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Parcela correspondente ao \"Valor do IPI\"\r\nreferente à combinação CST_ICMS, CFOP e\r\nalíquota do ICMS. Decimal com 2 casas")
                .HasColumnName("vl_ipi");
            entity.Property(e => e.VlOpr)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da operação na combinação de\r\nCST_ICMS, CFOP e alíquota do ICMS,\r\ncorrespondente ao somatório do valor das\r\nmercadorias, despesas acessórias (frete, seguros\r\ne outras despesas acessórias), ICMS_ST,\r\nFCP_ST e IPI - decimal com 2 casas")
                .HasColumnName("vl_opr");
            entity.Property(e => e.VlRedBc)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor não tributado em função da redução da\r\nbase de cálculo do ICMS, referente à\r\ncombinação de CST_ICMS, CFOP e alíquota do\r\nICMS - decimal com 2 casas")
                .HasColumnName("vl_red_bc");
        });

        modelBuilder.Entity<BlD100>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_d100", tb => tb.HasComment("Este registro deve ser apresentado por todos os contribuintes adquirentes ou prestadores dos serviços que utilizem os\r\ndocumentos especificados.\r\nO campo CHV_CTE passa a ser de preenchimento obrigatório a partir de abril de 2012 em todas as situações, exceto para\r\nCOD_SIT = 5 (numeração inutilizada).\r\nIMPORTANTE: para documentos de entrada, os campos de valor de imposto/contribuição, base de cálculo e alíquota só devem\r\nser informados se o adquirente tiver direito à apropriação do crédito (enfoque do declarante).\r\nValidação do Registro: não podem ser informados dois ou mais registros com a combinação de mesmos valores\r\ndos campos:\r\n1. emissão de terceiros: IND_EMIT+NUM_DOC+COD_MOD+SER+SUB+COD_PART;\r\n2. emissão própria: IND_EMIT+NUM_DOC+COD_MOD+SER+SUB.\r\n3. A partir de 01/01/2014, foi incluído o campo CHV_CTE para compor a chave do registro."));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ChvCte)
                .HasMaxLength(50)
                .HasComment("Chave do Conhecimento de Transporte Eletrônico ou\r\ndo Bilhete de Passagem Eletrônico - 44 caracteres")
                .HasColumnName("chv_cte");
            entity.Property(e => e.ChvCteRef)
                .HasMaxLength(50)
                .HasComment("Chave do Bilhete de Passagem Eletrônico substituído - 44 caracteres")
                .HasColumnName("chv_cte_ref");
            entity.Property(e => e.CodCta)
                .HasMaxLength(50)
                .HasComment("Código da conta analítica contábil debitada/creditada")
                .HasColumnName("cod_cta");
            entity.Property(e => e.CodInf)
                .HasMaxLength(50)
                .HasComment("Código da informação complementar do documento\r\nfiscal (campo 02 do Registro 0450) - 6 caracteres")
                .HasColumnName("cod_inf");
            entity.Property(e => e.CodMod)
                .HasMaxLength(50)
                .HasComment("Código do modelo do documento fiscal, conforme a\r\nTabela 4.1.1 - 2 caracteres")
                .HasColumnName("cod_mod");
            entity.Property(e => e.CodMunDest)
                .HasMaxLength(50)
                .HasComment("Código do município de destino, conforme a tabela\r\nIBGE (Preencher com 9999999, se Exterior) - 7 carcacteres")
                .HasColumnName("cod_mun_dest");
            entity.Property(e => e.CodMunOrig)
                .HasMaxLength(50)
                .HasComment("Código do município de origem do serviço, conforme a\r\ntabela IBGE (Preencher com 9999999, se Exterior) - 7 caracteres")
                .HasColumnName("cod_mun_orig");
            entity.Property(e => e.CodPart)
                .HasMaxLength(50)
                .HasComment("Código do participante (campo 02 do Registro 0150):\r\n- do prestador de serviço, no caso de aquisição de\r\nserviço;\r\n- do tomador do serviço, no caso de prestação de\r\nserviços.\r\n60 caracteres")
                .HasColumnName("cod_part");
            entity.Property(e => e.CodSit)
                .HasMaxLength(50)
                .HasComment("Código da situação do documento fiscal, conforme a\r\nTabela 4.1.2 - 2 caracteres")
                .HasColumnName("cod_sit");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DtAP)
                .HasMaxLength(50)
                .HasComment("Data da aquisição ou da prestação do serviço - 8 caracteres")
                .HasColumnName("dt_a_p");
            entity.Property(e => e.DtDoc)
                .HasMaxLength(50)
                .HasComment("Data da emissão do documento fiscal - 8 caracteres")
                .HasColumnName("dt_doc");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.IdCompra)
                .HasComment("Chave primária da compra informada no registro")
                .HasColumnType("int(11)")
                .HasColumnName("id_compra");
            entity.Property(e => e.IndEmit)
                .HasMaxLength(50)
                .HasComment("Indicador do emitente do documento fiscal:\r\n0 - Emissão própria;\r\n1 - Terceiros\r\n1 caractere")
                .HasColumnName("ind_emit");
            entity.Property(e => e.IndFrt)
                .HasMaxLength(5)
                .HasComment("Indicador do tipo do frete:\r\n0 - Por conta de terceiros;\r\n1 - Por conta do emitente;\r\n2 - Por conta do destinatário;\r\n9 - Sem cobrança de frete.\r\nObs.: A partir de 01/07/2012 passará a ser:\r\nIndicador do tipo do frete:\r\n0 - Por conta do emitente;\r\n1 - Por conta do destinatário/remetente;\r\n2 - Por conta de terceiros;\r\n9 - Sem cobrança de frete.\r\n1 caractere")
                .HasColumnName("ind_frt");
            entity.Property(e => e.IndOper)
                .HasMaxLength(50)
                .HasComment("Indicador do tipo de operação:\r\n0 - Aquisição;\r\n1 - Prestação\r\n1 caractere")
                .HasColumnName("ind_oper");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(50)
                .HasComment("Número do documento fiscal - 9 caracteres")
                .HasColumnName("num_doc");
            entity.Property(e => e.Reg)
                .HasMaxLength(6)
                .HasDefaultValueSql("'D100'")
                .HasComment("Texto fixo contendo \"D100\" ")
                .HasColumnName("reg");
            entity.Property(e => e.Ser)
                .HasMaxLength(50)
                .HasComment("Série do documento fiscal - 4 caracteres")
                .HasColumnName("ser");
            entity.Property(e => e.Sub)
                .HasMaxLength(50)
                .HasComment("Subsérie do documento fiscal - 4 caracteres")
                .HasColumnName("sub");
            entity.Property(e => e.TpCte)
                .HasMaxLength(50)
                .HasComment("Tipo de Conhecimento de Transporte Eletrônico\r\nconforme definido no Manual de Integração do CT-e ou\r\ndo Bilhete de Passagem Eletrônico conforme definido\r\nno Manual de Integração do BP-e\r\n1 caracteres")
                .HasColumnName("tp_cte");
            entity.Property(e => e.VlBcIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da base de cálculo do ICMS \r\nDecimal com 2 casas")
                .HasColumnName("vl_bc_icms");
            entity.Property(e => e.VlDesc)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total do desconto - decimal com 2 casas")
                .HasColumnName("vl_desc");
            entity.Property(e => e.VlDoc)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total do documento fiscal - decimal com 2 casas")
                .HasColumnName("vl_doc");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor do ICMS - decimal com 2 casas")
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlNt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor não-tributado - decimal com 2 casas")
                .HasColumnName("vl_nt");
            entity.Property(e => e.VlServ)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total da prestação de serviço \r\nDecimal com 2 casas")
                .HasColumnName("vl_serv");
        });

        modelBuilder.Entity<BlD190>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_d190", tb => tb.HasComment("Este registro tem por objetivo informar as Notas Fiscais de Serviço de Transporte (Código 07) e demais documentos\nelencados no título deste registro e especificados no registro D100, totalizados pelo agrupamento das combinações dos\nvalores de CST, CFOP e Alíquota dos itens de cada documento.\nObs.: Nas operações de entradas, informar o CST sob o enfoque do declarante"));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AliqIcms)
                .HasDefaultValueSql("'0000000000000000.00'")
                .HasComment("Alíquota do ICMS - 6 caracteres, decimal com 2 casas")
                .HasColumnType("decimal(18,2) unsigned zerofill")
                .HasColumnName("aliq_icms");
            entity.Property(e => e.Cfop)
                .HasMaxLength(8)
                .HasComment("Código Fiscal de Operação e Prestação, conforme a\ntabela indicada no item 4.2.2 - 4 caracteres")
                .HasColumnName("cfop");
            entity.Property(e => e.CodObs)
                .HasMaxLength(50)
                .HasComment("Código da observação do lançamento fiscal (campo\n02 do Registro 0460) - 6 caracteres")
                .HasColumnName("cod_obs");
            entity.Property(e => e.CstIcms)
                .HasMaxLength(5)
                .HasComment("Código da Situação Tributária, conforme a tabela\nindicada no item 4.3.1 - 3 caracteres")
                .HasColumnName("cst_icms");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.IdCompra)
                .HasComment("Chave primária da compra informada no registro")
                .HasColumnType("int(11)")
                .HasColumnName("id_compra");
            entity.Property(e => e.Reg)
                .HasMaxLength(6)
                .HasDefaultValueSql("'D190'")
                .HasComment("Texto fixo contendo \"D190\" ")
                .HasColumnName("reg");
            entity.Property(e => e.VlBcIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Parcela correspondente ao \"Valor da base de cálculo\ndo ICMS\" referente à combinação CST_ICMS,\nCFOP, e alíquota do ICMS - decimal com 2 casas")
                .HasColumnName("vl_bc_icms");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Parcela correspondente ao \"Valor do ICMS\"\nreferente à combinação CST_ICMS, CFOP e\nalíquota do ICMS - decimal com 2 casas")
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlOpr)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da operação correspondente à combinação de\nCST_ICMS, CFOP, e alíquota do ICMS. Decimal com 2 casas")
                .HasColumnName("vl_opr");
            entity.Property(e => e.VlRedBr)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor não tributado em função da redução da base de\ncálculo do ICMS, referente à combinação de\nCST_ICMS, CFOP e alíquota do ICMS - decimal com 2 casas")
                .HasColumnName("vl_red_br");
        });

        modelBuilder.Entity<BlE110>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_e110", tb => tb.HasComment("Este registro tem por objetivo informar os valores relativos à apuração do ICMS referentes às operações próprias. O\nregistro deve ser apresentado inclusive nos casos de períodos sem movimento. Neste caso, os valores deverão ser\napresentados zerados."));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DebEsp)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valores recolhidos ou a recolher, extra-apuração. Decimal com 2 casas")
                .HasColumnName("deb_esp");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'E110'")
                .HasComment("Texto fixo contendo \"E110\"")
                .HasColumnName("reg");
            entity.Property(e => e.VlAjCreditos)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total dos ajustes a crédito decorrentes do\ndocumento fiscal. Decimal com 2 casas")
                .HasColumnName("vl_aj_creditos");
            entity.Property(e => e.VlAjDebitos)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total dos ajustes a débito decorrentes do\ndocumento fiscal. Decimal com 2 casas")
                .HasColumnName("vl_aj_debitos");
            entity.Property(e => e.VlEstornosCred)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total de Ajustes “Estornos de créditos” - decimal com 2 casas")
                .HasColumnName("vl_estornos_cred");
            entity.Property(e => e.VlEstornosDeb)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total de Ajustes “Estornos de Débitos” - Decimal com 2 Casas")
                .HasColumnName("vl_estornos_deb");
            entity.Property(e => e.VlIcmsRecolher)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total de \"ICMS a recolher (11-12) - decimal com 2 casas")
                .HasColumnName("vl_icms_recolher");
            entity.Property(e => e.VlSldApurado)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor do saldo devedor apurado - decimal com 2 casas")
                .HasColumnName("vl_sld_apurado");
            entity.Property(e => e.VlSldCredorAnt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total de \"Saldo credor do período anterior\"  - decimal com 2 casas")
                .HasColumnName("vl_sld_credor_ant");
            entity.Property(e => e.VlSldCredorTransportar)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total de \"Saldo credor a transportar para o período\nseguinte” - decimal com 2 casas")
                .HasColumnName("vl_sld_credor_transportar");
            entity.Property(e => e.VlTotAjCreditos)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total de \"Ajustes a crédito\" - Decimal com 2 casas")
                .HasColumnName("vl_tot_aj_creditos");
            entity.Property(e => e.VlTotAjDebitos)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total de \"Ajustes a débito\" - Decimal com 2 casas")
                .HasColumnName("vl_tot_aj_debitos");
            entity.Property(e => e.VlTotCreditos)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total dos créditos por \"Entradas e aquisições com\ncrédito do imposto\" - Decimal com 2 casas")
                .HasColumnName("vl_tot_creditos");
            entity.Property(e => e.VlTotDebitos)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total dos débitos por \"Saídas e prestações com\ndébito do imposto\" Decimal com 2 casas")
                .HasColumnName("vl_tot_debitos");
            entity.Property(e => e.VlTotDed)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total de \"Deduções\" - decimal com 2 casas")
                .HasColumnName("vl_tot_ded");
        });

        modelBuilder.Entity<BlE116>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_e116", tb => tb.HasComment("Este registro tem o objetivo de discriminar os pagamentos realizados ou a realizar, referentes à apuração do ICMS –\nOperações Próprias do período. A soma do valor das obrigações deste registro deve ser igual à soma dos campos\nVL_ICMS_RECOLHER e DEB_ESP, do registro E110"));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CodOr)
                .HasMaxLength(50)
                .HasComment("Código da obrigação a recolher, conforme a Tabela 5.4 - 3 caracteres")
                .HasColumnName("cod_or");
            entity.Property(e => e.CodRec)
                .HasMaxLength(15)
                .HasComment("Código de receita referente à obrigação, próprio da unidade da\nfederação, conforme legislação estadual.")
                .HasColumnName("cod_rec");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DtVcto)
                .HasMaxLength(15)
                .HasComment("Data de vencimento da obrigação - 8 caracteres")
                .HasColumnName("dt_vcto");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.IndProc)
                .HasMaxLength(50)
                .HasComment("Indicador da origem do processo:\n0- SEFAZ;\n1- Justiça Federal;\n2- Justiça Estadual;\n9- Outros\n1 caracteres")
                .HasColumnName("ind_proc");
            entity.Property(e => e.MesRef)
                .HasMaxLength(25)
                .HasComment("Informe o mês de referência no formato “mmaaaa” - 6 caracteres")
                .HasColumnName("mes_ref");
            entity.Property(e => e.NumProc)
                .HasMaxLength(50)
                .HasComment("Número do processo ou auto de infração ao qual a obrigação está vinculada, se houver - 15 caracteres")
                .HasColumnName("num_proc");
            entity.Property(e => e.Proc)
                .HasMaxLength(50)
                .HasComment("Descrição resumida do processo que embasou o lançamento ")
                .HasColumnName("proc");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'E116'")
                .HasComment("Texto fixo contendo \"E116\" ")
                .HasColumnName("reg");
            entity.Property(e => e.TxtCompl)
                .HasMaxLength(50)
                .HasComment("Descrição complementar das obrigações a recolher")
                .HasColumnName("txt_compl");
            entity.Property(e => e.VlOr)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor da obrigação a recolher - decimal com 2 casas")
                .HasColumnName("vl_or");
        });

        modelBuilder.Entity<BlE200>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_e200", tb => tb.HasComment("Este registro tem por objetivo informar o(s) período(s) de apuração do ICMS – Substituição Tributária para cada UF\nonde o informante seja inscrito como substituto tributário, inclusive para o seu estado, nas operações internas que envolvam\nsubstituição, e também para UF para a qual o declarante tenha comercializado e que não tenha inscrição como substituto. Os\nperíodos informados devem abranger todo o período previsto no registro 0000, sem haver sobreposição ou omissão de datas,\npor UF.\nEste registro também deve ser informado pelo substituído, se este for o responsável pelo recolhimento do imposto\ndevido nas operações subsequentes, quando recebe mercadoria de outra unidade da federação, sujeita ao regime de\nsubstituição tributária, na hipótese de o remetente não estar obrigado à retenção do imposto.\nValidação do Registro: o registro é obrigatório se a soma, por UF, dos valores do campo VL_ICMS_ST dos\nregistros C190, C590, C597, C690, C791, for maior que “0” (zero), ou se existir registro 0015 (substituto tributário) para a\nUF, ou se existir algum registro C197 ou D197, onde o quarto caractere do código de ajuste (campo COD_AJ) for igual\n\"1\".Não pode haver mais de um registro com a mesma combinação de valores para os campos UF, DT_INI e DT_FIN, nem\nsobreposição ou omissão de períodos para a combinação."));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DtFin)
                .HasMaxLength(15)
                .HasComment("Data final a que a apuração se refere - 8 caracteres")
                .HasColumnName("dt_fin");
            entity.Property(e => e.DtIni)
                .HasMaxLength(15)
                .HasComment("Data inicial a que a apuração se refere - 8 caracteres")
                .HasColumnName("dt_ini");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.Origem)
                .HasMaxLength(50)
                .HasComment("Orienta sobre se o registro é de entrada ou saída na contabilização do arquivo")
                .HasColumnName("origem");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'E200'")
                .HasComment("Texto fixo contendo \"E200\" ")
                .HasColumnName("reg");
            entity.Property(e => e.Uf)
                .HasMaxLength(5)
                .HasComment("Sigla da unidade da federação a que se refere a apuração do ICMS ST - 2 caracteres")
                .HasColumnName("UF");
        });

        modelBuilder.Entity<BlE210>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_e210", tb => tb.HasComment("Este registro tem por objetivo informar valores relativos à apuração do ICMS de substituição tributária, mesmo nos\ncasos de períodos sem movimento."));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DebEstSt)
                .HasPrecision(18, 2)
                .HasComment("Valores recolhidos ou a recolher, extra-apuração - decimal com 2 casas")
                .HasColumnName("deb_est_st");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.IdE200)
                .HasComment("Identifica lançamento correspondente no registro e200")
                .HasColumnType("int(11)")
                .HasColumnName("id_e200");
            entity.Property(e => e.IndMovSt)
                .HasMaxLength(1)
                .HasComment("Indicador de movimento:\n0 – Sem operações com ST\n1 – Com operações de ST\n1 caractere")
                .HasColumnName("ind_mov_st");
            entity.Property(e => e.Origem)
                .HasMaxLength(50)
                .HasComment("Orienta sobre se o registro é de entrada ou saída na contabilização do arquivo")
                .HasColumnName("origem");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'E210'")
                .HasComment("exto fixo contendo \"E210\" ")
                .HasColumnName("reg");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasComment("Guarda a UF de acordo com o registro bl_e200")
                .HasColumnName("uf");
            entity.Property(e => e.VlAjCreditosSt)
                .HasPrecision(18, 2)
                .HasComment("Valor total dos ajustes a crédito de ICMS ST, provenientes de ajustes do documento fiscal. Decimal com 2 casas")
                .HasColumnName("vl_aj_creditos_st");
            entity.Property(e => e.VlAjDebitosSt)
                .HasPrecision(18, 2)
                .HasComment("Valor total dos ajustes a débito de ICMS ST, provenientes de ajustes do documento fiscal. Decimal com 2 casas")
                .HasColumnName("vl_aj_debitos_st");
            entity.Property(e => e.VlDeducoesSt)
                .HasPrecision(18, 2)
                .HasComment("Valor total dos ajustes \"Deduções ST\" - decimal com 2 casas")
                .HasColumnName("vl_deducoes_st");
            entity.Property(e => e.VlDevolSt)
                .HasPrecision(18, 2)
                .HasComment("Valor total do ICMS ST de devolução de mercadorias - decimal com 2 casas")
                .HasColumnName("vl_devol_st");
            entity.Property(e => e.VlIcmsRecolSt)
                .HasPrecision(18, 2)
                .HasComment("Imposto a recolher ST (11-12) - decimal com 2 casas")
                .HasColumnName("vl_icms_recol_st");
            entity.Property(e => e.VlOutCredSt)
                .HasPrecision(18, 2)
                .HasComment("Valor total de Ajustes \"Outros créditos ST\" e “Estorno de débitos ST” - decimal com 2 casas")
                .HasColumnName("vl_out_cred_st");
            entity.Property(e => e.VlOutDebSt)
                .HasPrecision(18, 2)
                .HasComment("Valor Total dos ajustes \"Outros débitos ST\" \" e “Estorno de créditos ST - decimal com 2 casas")
                .HasColumnName("vl_out_deb_st");
            entity.Property(e => e.VlRessarcSt)
                .HasPrecision(18, 2)
                .HasComment("Valor total do ICMS ST de ressarcimentos - decimal com 2 casas")
                .HasColumnName("vl_ressarc_st");
            entity.Property(e => e.VlRetencaoSt)
                .HasPrecision(18, 2)
                .HasComment("Valor Total do ICMS retido por Substituição Tributária - decimal com 2 casas")
                .HasColumnName("vl_retencao_st");
            entity.Property(e => e.VlSldCredAntSt)
                .HasPrecision(18, 2)
                .HasComment("Valor do \"Saldo credor de período anterior –\nSubstituição Tributária\" - decimal com 2 casas")
                .HasColumnName("vl_sld_cred_ant_st");
            entity.Property(e => e.VlSldCredStTransportar)
                .HasPrecision(18, 2)
                .HasComment("Saldo credor de ST a transportar para o período seguinte [(03+04+05+06+07+12) – (08+09+10)]. Decimal com 2 casas")
                .HasColumnName("vl_sld_cred_st_transportar");
            entity.Property(e => e.VlSldDevAntSt)
                .HasPrecision(18, 2)
                .HasComment("Valor total de Saldo devedor antes das deduções - decimal com 2 casas")
                .HasColumnName("vl_sld_dev_ant_st");
        });

        modelBuilder.Entity<BlH005>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_h005");

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.DtInv)
                .HasComment("Data do inventário")
                .HasColumnType("datetime")
                .HasColumnName("dt_inv");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.MotInv)
                .HasMaxLength(50)
                .HasComment("nforme o motivo do Inventário:\n01 – No final no período;\n02 – Na mudança de forma de tributação da mercadoria (ICMS);\n03 – Na solicitação da baixa cadastral, paralisação temporária e\noutras situações;\n04 – Na alteração de regime de pagamento – condição do\ncontribuinte;\n05 – Por determinação dos fiscos;\n06 – Para controle das mercadorias sujeitas ao regime de substituição\ntributária – restituição/ ressarcimento/ complementação\n2 caracteres")
                .HasColumnName("mot_inv");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'H005'")
                .HasComment("Texto fixo contendo \"H005\" ")
                .HasColumnName("reg");
            entity.Property(e => e.VlInv)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor total do estoque - decimal com 2 casas")
                .HasColumnName("vl_inv");
        });

        modelBuilder.Entity<BlH010>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bl_h010", tb => tb.HasComment("ste registro deve ser apresentado para discriminar os valores totais dos itens/produtos do inventário realizado em 31\nde dezembro de cada exercício, ou nas demais datas estabelecidas pela legislação fiscal ou comercial.\nO inventário deverá ser apresentado no arquivo da EFD-ICMS/IPI até o segundo mês subsequente ao evento.\nExemplo: Inventário realizado em 31/12/08 deverá ser apresentado na EFD-ICMS/IPI de período de referência fevereiro de\n2009.\nA partir de julho de 2012, as empresas que exerçam as atividades descritas na Classificação Nacional de Atividades\nEconômicas /Fiscal (CNAE-Fiscal) sob os códigos 4681-8/01 e 4681-8/02 deverão apresentar este registro, mensalmente,\npara discriminar os valores itens/produtos do Inventário realizado ao final do mesmo período de referência do arquivo da\nEFD-ICMS/IPI. Informar como MOT_INV o código “01”. Exemplo: o inventário realizado no final do mês de janeiro,\ndeverá ser apresentado na escrituração do mês de janeiro.\nAtribuir valor Zero ao inventário significa escriturar sem estoque."));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CodCta)
                .HasMaxLength(50)
                .HasComment("Código da conta analítica contábil debitada/creditada ")
                .HasColumnName("cod_cta");
            entity.Property(e => e.CodItem)
                .HasMaxLength(15)
                .HasComment("Código do item (campo 02 do Registro 0200) - 60 caracteres. Coincide com o código do item na tabela produtos")
                .HasColumnName("cod_item");
            entity.Property(e => e.CodPart)
                .HasMaxLength(25)
                .HasComment("Código do participante (campo 02 do Registro 0150):\n- proprietário/possuidor que não seja o informante do arquivo. 60 caracteres")
                .HasColumnName("cod_part");
            entity.Property(e => e.Data)
                .HasComment("Data de entrada do registro no sped para gerar arquivo")
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasComment("Guarda Cnpj da empresa no lançamento do bloco")
                .HasColumnName("empresa");
            entity.Property(e => e.IndProp)
                .HasMaxLength(5)
                .HasComment("ndicador de propriedade/posse do item:\n0- Item de propriedade do informante e em seu poder;\n1- Item de propriedade do informante em posse de terceiros;\n2- Item de propriedade de terceiros em posse do informante\n1 caractere")
                .HasColumnName("ind_prop");
            entity.Property(e => e.Qtd)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Quantidade do item - decimal com 3 casas")
                .HasColumnName("qtd");
            entity.Property(e => e.Reg)
                .HasMaxLength(5)
                .HasDefaultValueSql("'H010'")
                .HasComment("Texto fixo contendo \"H010” ")
                .HasColumnName("reg");
            entity.Property(e => e.TxtCompl)
                .HasMaxLength(50)
                .HasComment("Descrição complementar. ")
                .HasColumnName("txt_compl");
            entity.Property(e => e.Unid)
                .HasMaxLength(8)
                .HasComment("Unidade do item - 6 caracteres. ")
                .HasColumnName("unid");
            entity.Property(e => e.VlItem)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor do item - decimal com 2 casas")
                .HasColumnName("vl_item");
            entity.Property(e => e.VlItemIr)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor do item para efeitos do Imposto de Renda. Decimal com 2 casas")
                .HasColumnName("vl_item_ir");
            entity.Property(e => e.VlUnit)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Valor unitário do item - decimal com 6 casas")
                .HasColumnName("vl_unit");
        });

        modelBuilder.Entity<Bordado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bordado");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(25)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.Categoria).HasName("PRIMARY");

            entity.ToTable("categoria");

            entity.Property(e => e.Categoria)
                .HasColumnType("int(11)")
                .HasColumnName("categoria");
            entity.Property(e => e.Descricao)
                .HasMaxLength(20)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Cce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cce");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Chaveent)
                .HasColumnType("int(11)")
                .HasColumnName("chaveent");
            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .HasColumnName("data");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Empresa)
                .HasMaxLength(10000)
                .HasColumnName("empresa");
            entity.Property(e => e.Motivo)
                .HasMaxLength(10000)
                .HasColumnName("motivo");
            entity.Property(e => e.Origem)
                .HasMaxLength(1)
                .HasColumnName("origem");
            entity.Property(e => e.Protocolo)
                .HasMaxLength(50)
                .HasColumnName("protocolo");
            entity.Property(e => e.Sequencial)
                .HasColumnType("int(11)")
                .HasColumnName("sequencial");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Centrocusto>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("centrocusto");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Centrocusto1)
                .HasMaxLength(50)
                .HasColumnName("centrocusto");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Cfop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cfop", tb => tb.HasComment("Tabela que guarda os CFOPs utilizados no sistema"));

            entity.Property(e => e.Id)
                .HasComment("Campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Aplicacao)
                .HasMaxLength(500)
                .HasComment("Observação fixa vinculada ao CFOP na venda")
                .HasColumnName("aplicacao");
            entity.Property(e => e.Atualizacao)
                .HasComment("Guarda data de atualização do cadastro do CFOP")
                .HasColumnName("atualizacao");
            entity.Property(e => e.Cadastro)
                .HasComment("Guarda data de cadastro do CFOP")
                .HasColumnName("cadastro");
            entity.Property(e => e.Capcar)
                .HasMaxLength(5)
                .HasComment("Campo de controle que define se ao utilizar o referido cfop será gerado financeiro ou não no lançamento")
                .HasColumnName("capcar");
            entity.Property(e => e.Cfop1)
                .HasMaxLength(6)
                .HasComment("Código do CFOP")
                .HasColumnName("cfop");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .HasComment("Descrição do CFOP")
                .HasColumnName("descricao");
            entity.Property(e => e.Faturamento)
                .HasMaxLength(5)
                .HasComment("Campo de controle que define se ao utilizar o referido cfop será gerado faturamento ou não no lançamento")
                .HasColumnName("faturamento");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'n'")
                .HasComment("Campo de sincronização.")
                .HasColumnName("sincronizado");
            entity.Property(e => e.Usuario)
                .HasComment("Guarda id do usuário que cadastrou ou último a editar o cfop")
                .HasColumnType("int(11)")
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<CfopSt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cfop_st");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CfopDentro)
                .HasMaxLength(7)
                .HasColumnName("cfop_dentro");
            entity.Property(e => e.CfopFora)
                .HasMaxLength(10)
                .HasColumnName("cfop_fora");
            entity.Property(e => e.St)
                .HasMaxLength(4)
                .HasColumnName("st");
        });

        modelBuilder.Entity<Cheque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cheque");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Agencia)
                .HasMaxLength(5)
                .HasColumnName("agencia");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(50)
                .HasColumnName("auditoria");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasColumnName("banco");
            entity.Property(e => e.Codigofactoring)
                .HasMaxLength(5)
                .HasColumnName("codigofactoring");
            entity.Property(e => e.Conta)
                .HasMaxLength(50)
                .HasColumnName("conta");
            entity.Property(e => e.Datafactoring)
                .HasColumnType("datetime")
                .HasColumnName("datafactoring");
            entity.Property(e => e.Emitentecnpj)
                .HasMaxLength(18)
                .HasColumnName("emitentecnpj");
            entity.Property(e => e.Emitentefone)
                .HasMaxLength(50)
                .HasColumnName("emitentefone");
            entity.Property(e => e.Emitentenome)
                .HasMaxLength(100)
                .HasColumnName("emitentenome");
            entity.Property(e => e.Factoring)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("factoring");
            entity.Property(e => e.Numerocheque)
                .HasMaxLength(12)
                .HasColumnName("numerocheque");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .HasColumnName("observacao");
            entity.Property(e => e.Origem)
                .HasMaxLength(3)
                .HasColumnName("origem");
            entity.Property(e => e.Responsavelcnpj)
                .HasMaxLength(18)
                .HasColumnName("responsavelcnpj");
            entity.Property(e => e.Responsavelfone)
                .HasMaxLength(50)
                .HasColumnName("responsavelfone");
            entity.Property(e => e.Responsavelnome)
                .HasMaxLength(150)
                .HasColumnName("responsavelnome");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .HasColumnName("titulo");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 4)
                .HasColumnName("valor");
            entity.Property(e => e.Vencimento)
                .HasColumnType("datetime")
                .HasColumnName("vencimento");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ag1)
                .HasMaxLength(50)
                .HasColumnName("ag1");
            entity.Property(e => e.Ag2)
                .HasMaxLength(10)
                .HasColumnName("ag2");
            entity.Property(e => e.Area)
                .HasMaxLength(15)
                .HasColumnName("area");
            entity.Property(e => e.Ativo)
                .HasMaxLength(7)
                .HasColumnName("ativo");
            entity.Property(e => e.Bairro)
                .HasMaxLength(60)
                .HasComment("Bairro da empresa. 2 a 60 caracteres permitidos")
                .HasColumnName("bairro");
            entity.Property(e => e.Bairrocom)
                .HasMaxLength(50)
                .HasColumnName("bairrocom");
            entity.Property(e => e.Banco1)
                .HasMaxLength(50)
                .HasColumnName("banco1");
            entity.Property(e => e.Banco2)
                .HasMaxLength(100)
                .HasColumnName("banco2");
            entity.Property(e => e.Bloqueio)
                .HasMaxLength(15)
                .HasColumnName("bloqueio");
            entity.Property(e => e.Cc1)
                .HasMaxLength(50)
                .HasColumnName("cc1");
            entity.Property(e => e.Cc2)
                .HasMaxLength(10)
                .HasColumnName("cc2");
            entity.Property(e => e.Ccorrente)
                .HasMaxLength(5)
                .HasColumnName("ccorrente");
            entity.Property(e => e.Celular)
                .HasMaxLength(53)
                .HasColumnName("celular");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .HasColumnName("cep");
            entity.Property(e => e.Cepcom)
                .HasMaxLength(15)
                .HasColumnName("cepcom");
            entity.Property(e => e.Cfoppadrao)
                .HasMaxLength(10)
                .HasColumnName("cfoppadrao");
            entity.Property(e => e.Cgc)
                .HasMaxLength(30)
                .HasColumnName("cgc");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Cidadecom)
                .HasMaxLength(50)
                .HasColumnName("cidadecom");
            entity.Property(e => e.Classificacao)
                .HasMaxLength(2)
                .HasColumnName("classificacao");
            entity.Property(e => e.Clientedadosadicionais)
                .HasMaxLength(50)
                .HasColumnName("clientedadosadicionais");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("codigo");
            entity.Property(e => e.Codigoauxiliar)
                .HasMaxLength(50)
                .HasColumnName("codigoauxiliar");
            entity.Property(e => e.Codigocidade)
                .HasMaxLength(18)
                .HasComment("Código da UF com dois dígitos. Utilizar a Tabela do IBGE")
                .HasColumnName("codigocidade");
            entity.Property(e => e.Codigogrupo)
                .HasColumnType("int(11)")
                .HasColumnName("codigogrupo");
            entity.Property(e => e.Codigoportador)
                .HasMaxLength(4)
                .HasColumnName("codigoportador");
            entity.Property(e => e.Codigoportadoraux)
                .HasMaxLength(5)
                .HasColumnName("codigoportadoraux");
            entity.Property(e => e.Codigorecebimento)
                .HasMaxLength(3)
                .HasColumnName("codigorecebimento");
            entity.Property(e => e.Codigouf)
                .HasMaxLength(2)
                .HasComment("Codigo da UF com dois dígitos. Utilizar a Tabela do IBGE")
                .HasColumnName("codigouf");
            entity.Property(e => e.Codigovendedor)
                .HasMaxLength(4)
                .HasColumnName("codigovendedor");
            entity.Property(e => e.Codigovendedor2)
                .HasMaxLength(5)
                .HasColumnName("codigovendedor2");
            entity.Property(e => e.Comissao)
                .HasPrecision(10, 4)
                .HasColumnName("comissao");
            entity.Property(e => e.Comissao2)
                .HasPrecision(10, 4)
                .HasColumnName("comissao2");
            entity.Property(e => e.Complemento)
                .HasMaxLength(30)
                .HasColumnName("complemento");
            entity.Property(e => e.Consumidorfinal)
                .HasMaxLength(5)
                .HasColumnName("consumidorfinal");
            entity.Property(e => e.Contato)
                .HasMaxLength(50)
                .HasColumnName("contato");
            entity.Property(e => e.Contatocom)
                .HasMaxLength(50)
                .HasColumnName("contatocom");
            entity.Property(e => e.Dataatualizacao)
                .HasComment("Guarda data de atualização do cadastro do cliente")
                .HasColumnType("datetime")
                .HasColumnName("dataatualizacao");
            entity.Property(e => e.Datacadastro)
                .HasColumnType("datetime")
                .HasColumnName("datacadastro");
            entity.Property(e => e.Descontoboleto)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'")
                .HasColumnName("descontoboleto");
            entity.Property(e => e.Descricaogrupo)
                .HasMaxLength(20)
                .HasColumnName("descricaogrupo");
            entity.Property(e => e.Descricaoportador)
                .HasMaxLength(30)
                .HasColumnName("descricaoportador");
            entity.Property(e => e.Descricaoportadoraux)
                .HasMaxLength(50)
                .HasColumnName("descricaoportadoraux");
            entity.Property(e => e.Dsp)
                .HasMaxLength(15)
                .HasColumnName("dsp");
            entity.Property(e => e.Email)
                .HasMaxLength(300)
                .HasColumnName("email");
            entity.Property(e => e.Emailcom)
                .HasMaxLength(300)
                .HasColumnName("emailcom");
            entity.Property(e => e.Empresa)
                .HasMaxLength(1)
                .HasColumnName("empresa");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasColumnName("endereco");
            entity.Property(e => e.Enderecocom)
                .HasMaxLength(100)
                .HasColumnName("enderecocom");
            entity.Property(e => e.Enderecoemp)
                .HasMaxLength(100)
                .HasColumnName("enderecoemp");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasColumnName("estado");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(60)
                .HasComment("Nome fantasia do cliente. 60 caracteres conforme manual da nfe.")
                .HasColumnName("fantasia");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.Faxcom)
                .HasMaxLength(30)
                .HasColumnName("faxcom");
            entity.Property(e => e.Final)
                .HasColumnType("datetime")
                .HasColumnName("final");
            entity.Property(e => e.Fone)
                .HasMaxLength(50)
                .HasColumnName("fone");
            entity.Property(e => e.Fonecom)
                .HasMaxLength(50)
                .HasColumnName("fonecom");
            entity.Property(e => e.Foneemp)
                .HasMaxLength(20)
                .HasColumnName("foneemp");
            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .HasColumnName("grupo");
            entity.Property(e => e.Inicio)
                .HasColumnType("datetime")
                .HasColumnName("inicio");
            entity.Property(e => e.Inscricao)
                .HasMaxLength(20)
                .HasColumnName("inscricao");
            entity.Property(e => e.Inscricaomunicipal)
                .HasMaxLength(20)
                .HasColumnName("inscricaomunicipal");
            entity.Property(e => e.Isentoipi)
                .HasMaxLength(1)
                .HasColumnName("isentoipi");
            entity.Property(e => e.Limite)
                .HasPrecision(10, 4)
                .HasColumnName("limite");
            entity.Property(e => e.Maladireta)
                .HasMaxLength(7)
                .HasColumnName("maladireta");
            entity.Property(e => e.Modalidade)
                .HasMaxLength(30)
                .HasColumnName("modalidade");
            entity.Property(e => e.Nascimento)
                .HasColumnType("datetime")
                .HasColumnName("nascimento");
            entity.Property(e => e.Numero)
                .HasMaxLength(6)
                .HasColumnName("numero");
            entity.Property(e => e.Observacao)
                .HasMaxLength(4000)
                .HasColumnName("observacao");
            entity.Property(e => e.Observacoes)
                .HasMaxLength(4000)
                .HasColumnName("observacoes");
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .HasColumnName("pais");
            entity.Property(e => e.Pessoa)
                .HasMaxLength(1)
                .HasColumnName("pessoa");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(20)
                .HasColumnName("planocontas");
            entity.Property(e => e.Pontoreferencia)
                .HasMaxLength(150)
                .HasColumnName("pontoreferencia");
            entity.Property(e => e.Portador)
                .HasMaxLength(2)
                .HasColumnName("portador");
            entity.Property(e => e.Prazo)
                .HasMaxLength(4)
                .HasColumnName("prazo");
            entity.Property(e => e.Razao)
                .HasMaxLength(60)
                .HasComment("Razão social do cliente. 60 caracteres conforme manual da nfe.")
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(30)
                .HasColumnName("recebimento");
            entity.Property(e => e.Refcomercial1)
                .HasMaxLength(30)
                .HasColumnName("refcomercial1");
            entity.Property(e => e.Refcomercial2)
                .HasMaxLength(30)
                .HasColumnName("refcomercial2");
            entity.Property(e => e.Refcomfone1)
                .HasMaxLength(20)
                .HasColumnName("refcomfone1");
            entity.Property(e => e.Refcomfone2)
                .HasMaxLength(20)
                .HasColumnName("refcomfone2");
            entity.Property(e => e.Refpesfone1)
                .HasMaxLength(20)
                .HasColumnName("refpesfone1");
            entity.Property(e => e.Refpesfone2)
                .HasMaxLength(20)
                .HasColumnName("refpesfone2");
            entity.Property(e => e.Refpessoal1)
                .HasMaxLength(30)
                .HasColumnName("refpessoal1");
            entity.Property(e => e.Refpessoal2)
                .HasMaxLength(30)
                .HasColumnName("refpessoal2");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.Sincronizacao)
                .HasMaxLength(50)
                .HasColumnName("sincronizacao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tabelapreco)
                .HasMaxLength(120)
                .HasColumnName("tabelapreco");
            entity.Property(e => e.Taxa)
                .HasPrecision(10, 4)
                .HasColumnName("taxa");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
            entity.Property(e => e.Transferencia)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("transferencia");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasComment("Sigla da UF com dois dígitos. Utilizar a Tabela do IBGE")
                .HasColumnName("uf");
            entity.Property(e => e.Ufcom)
                .HasMaxLength(2)
                .HasColumnName("ufcom");
            entity.Property(e => e.Valormeta)
                .HasPrecision(10, 4)
                .HasColumnName("valormeta");
            entity.Property(e => e.Valorminimo)
                .HasPrecision(10, 4)
                .HasColumnName("valorminimo");
            entity.Property(e => e.Venda)
                .HasMaxLength(5)
                .HasColumnName("venda");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(50)
                .HasColumnName("vendedor");
            entity.Property(e => e.Vendedor2)
                .HasMaxLength(50)
                .HasColumnName("vendedor2");
        });

        modelBuilder.Entity<ClientesApp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("clientes_app");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasComment("Status do cliente cadastrado online")
                .HasColumnName("ativo");
            entity.Property(e => e.Bairro)
                .HasMaxLength(80)
                .HasComment("Bairro do cliente cadastrado online")
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(12)
                .HasComment("CEP do cliente cadastrado online")
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(80)
                .HasComment("Cidade do cliente cadastrado online")
                .HasColumnName("cidade");
            entity.Property(e => e.Complemento)
                .HasMaxLength(150)
                .HasComment("Complemento do endereço do cliente cadastraonline")
                .HasColumnName("complemento");
            entity.Property(e => e.Cpfcnpj)
                .HasMaxLength(22)
                .HasComment("Cpf ou cnpj do cliente cadastrado online")
                .HasColumnName("cpfcnpj");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasComment("Email do cliente cadastrado online")
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasComment("Endereço do cliente cadastrado online")
                .HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .HasComment("Nome do cliente cadastrado online")
                .HasColumnName("nome");
            entity.Property(e => e.Numero)
                .HasMaxLength(6)
                .HasComment("Número físico do endereço do cliente cadastrado online")
                .HasColumnName("numero");
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .HasComment("Senha do cliente cadastrado online")
                .HasColumnName("senha");
            entity.Property(e => e.Telefone)
                .HasMaxLength(12)
                .HasComment("Telefone do cliente cadastrado online")
                .HasColumnName("telefone");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasComment("Código da UF com dois dígitos do cliente cadastrado online")
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Clientesdadosadicionai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("clientesdadosadicionais");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(13)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Cliente)
                .HasMaxLength(6)
                .HasColumnName("cliente");
            entity.Property(e => e.Cmun)
                .HasMaxLength(8)
                .HasColumnName("cmun");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("cnpj");
            entity.Property(e => e.Contato)
                .HasMaxLength(25)
                .HasColumnName("contato");
            entity.Property(e => e.Cpais)
                .HasMaxLength(10)
                .HasColumnName("cpais");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasColumnName("endereco");
            entity.Property(e => e.Fone)
                .HasMaxLength(13)
                .HasColumnName("fone");
            entity.Property(e => e.Ie)
                .HasMaxLength(15)
                .HasColumnName("ie");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome");
            entity.Property(e => e.Numero)
                .HasMaxLength(5)
                .HasColumnName("numero");
            entity.Property(e => e.Pais)
                .HasMaxLength(25)
                .HasColumnName("pais");
            entity.Property(e => e.Pontoreferencia)
                .HasMaxLength(100)
                .HasColumnName("pontoreferencia");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Codigoservicomunicipal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("codigoservicomunicipal");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Servicomunicipal)
                .HasMaxLength(2000)
                .HasColumnName("servicomunicipal");
        });

        modelBuilder.Entity<Codigoservicosfederai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("codigoservicosfederais");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descricaoservico)
                .HasMaxLength(5000)
                .HasColumnName("descricaoservico");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("compra");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(10, 4)
                .HasColumnName("acrescimo");
            entity.Property(e => e.Almoxarifado)
                .HasMaxLength(5)
                .HasColumnName("almoxarifado");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(5)
                .HasColumnName("auditoria");
            entity.Property(e => e.Basecalculoicms)
                .HasPrecision(10, 4)
                .HasColumnName("basecalculoicms");
            entity.Property(e => e.Basecalculoicmsst)
                .HasPrecision(10, 4)
                .HasColumnName("basecalculoicmsst");
            entity.Property(e => e.Basecalculoipi)
                .HasPrecision(18, 4)
                .HasColumnName("basecalculoipi");
            entity.Property(e => e.Baseipi)
                .HasPrecision(18, 4)
                .HasColumnName("baseipi");
            entity.Property(e => e.Bcicmsfrete)
                .HasPrecision(10, 4)
                .HasColumnName("bcicmsfrete");
            entity.Property(e => e.Calcularicmsst)
                .HasMaxLength(5)
                .HasColumnName("calcularicmsst");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(10)
                .HasColumnName("cancelado");
            entity.Property(e => e.Centrocusto)
                .HasMaxLength(50)
                .HasColumnName("centrocusto");
            entity.Property(e => e.Cfop)
                .HasMaxLength(50)
                .HasColumnName("cfop");
            entity.Property(e => e.Cfopfrete)
                .HasMaxLength(6)
                .HasColumnName("cfopfrete");
            entity.Property(e => e.Cfoptrasnportador)
                .HasMaxLength(5)
                .HasColumnName("cfoptrasnportador");
            entity.Property(e => e.Chavecte)
                .HasMaxLength(50)
                .HasColumnName("chavecte");
            entity.Property(e => e.Chavenfe)
                .HasMaxLength(200)
                .HasColumnName("chavenfe");
            entity.Property(e => e.Cnfe)
                .HasMaxLength(15)
                .HasColumnName("cnfe");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Codigocusto)
                .HasMaxLength(10)
                .HasColumnName("codigocusto");
            entity.Property(e => e.Codigotransportador)
                .HasMaxLength(10)
                .HasColumnName("codigotransportador");
            entity.Property(e => e.Cofins)
                .HasPrecision(10, 4)
                .HasColumnName("cofins");
            entity.Property(e => e.Conferencia)
                .HasMaxLength(5)
                .HasColumnName("conferencia");
            entity.Property(e => e.Conhecimento)
                .HasMaxLength(50)
                .HasColumnName("conhecimento");
            entity.Property(e => e.Denegada)
                .HasPrecision(18, 4)
                .HasColumnName("denegada");
            entity.Property(e => e.Desconto)
                .HasPrecision(10, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Descricaocfop)
                .HasMaxLength(50)
                .HasColumnName("descricaocfop");
            entity.Property(e => e.Descricaoplano)
                .HasMaxLength(30)
                .HasColumnName("descricaoplano");
            entity.Property(e => e.Descricaorecebimento)
                .HasMaxLength(25)
                .HasColumnName("descricaorecebimento");
            entity.Property(e => e.Despesa)
                .HasPrecision(10, 4)
                .HasColumnName("despesa");
            entity.Property(e => e.Despesasaduaneiras)
                .HasPrecision(10, 4)
                .HasColumnName("despesasaduaneiras");
            entity.Property(e => e.Devolucao)
                .HasMaxLength(5)
                .HasColumnName("devolucao");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .HasComment("Guarda documento de compra")
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Documentomdfe)
                .HasMaxLength(20)
                .HasColumnName("documentomdfe");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Emissaofrete)
                .HasMaxLength(10)
                .HasColumnName("emissaofrete");
            entity.Property(e => e.Emitido)
                .HasMaxLength(5)
                .HasColumnName("emitido");
            entity.Property(e => e.Empresa)
                .HasMaxLength(10000)
                .HasColumnName("empresa");
            entity.Property(e => e.Especie)
                .HasMaxLength(15)
                .HasColumnName("especie");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(150)
                .HasColumnName("fantasia");
            entity.Property(e => e.Fat)
                .HasMaxLength(5)
                .HasColumnName("fat");
            entity.Property(e => e.Faturado)
                .HasMaxLength(5)
                .HasColumnName("faturado");
            entity.Property(e => e.Faturamento)
                .HasColumnType("datetime")
                .HasColumnName("faturamento");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(6)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Frete)
                .HasMaxLength(3)
                .HasColumnName("frete");
            entity.Property(e => e.Fretevalor)
                .HasPrecision(10, 4)
                .HasColumnName("fretevalor");
            entity.Property(e => e.Icms)
                .HasPrecision(10, 4)
                .HasColumnName("icms");
            entity.Property(e => e.Icmsfrete)
                .HasPrecision(10, 4)
                .HasColumnName("icmsfrete");
            entity.Property(e => e.Icmssubst)
                .HasPrecision(10, 4)
                .HasColumnName("icmssubst");
            entity.Property(e => e.Ipi)
                .HasPrecision(10, 4)
                .HasColumnName("ipi");
            entity.Property(e => e.Justificativa)
                .HasMaxLength(50)
                .HasColumnName("justificativa");
            entity.Property(e => e.Lancamento)
                .HasColumnType("datetime")
                .HasColumnName("lancamento");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .HasColumnName("marca");
            entity.Property(e => e.Modbcicms)
                .HasMaxLength(1)
                .HasColumnName("modbcicms");
            entity.Property(e => e.Modelofrete)
                .HasMaxLength(50)
                .HasColumnName("modelofrete");
            entity.Property(e => e.Modelonf)
                .HasMaxLength(2)
                .HasColumnName("modelonf");
            entity.Property(e => e.Mododesconto)
                .HasMaxLength(1)
                .HasColumnName("mododesconto");
            entity.Property(e => e.Motivocancelamento)
                .HasMaxLength(255)
                .HasColumnName("motivocancelamento");
            entity.Property(e => e.Nferef)
                .HasMaxLength(44)
                .HasComment("Guarda chave referenciada da nfe de devolução")
                .HasColumnName("nferef");
            entity.Property(e => e.Nfref)
                .HasMaxLength(20)
                .HasColumnName("nfref");
            entity.Property(e => e.Nomeusuario)
                .HasMaxLength(20)
                .HasColumnName("nomeusuario");
            entity.Property(e => e.Numeroparcelas)
                .HasColumnType("int(11)")
                .HasColumnName("numeroparcelas");
            entity.Property(e => e.Numerovolume)
                .HasMaxLength(10)
                .HasColumnName("numerovolume");
            entity.Property(e => e.Observacao)
                .HasMaxLength(5000)
                .HasComment("Limite observacao nfe 5000 caracteres")
                .HasColumnName("observacao");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(20)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.Pbruto)
                .HasPrecision(18, 4)
                .HasColumnName("pbruto");
            entity.Property(e => e.Pedido)
                .HasMaxLength(20)
                .HasColumnName("pedido");
            entity.Property(e => e.Pispasep)
                .HasPrecision(10, 4)
                .HasColumnName("pispasep");
            entity.Property(e => e.Placa)
                .HasMaxLength(8)
                .HasColumnName("placa");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(20)
                .HasColumnName("planocontas");
            entity.Property(e => e.Pliquido)
                .HasPrecision(18, 4)
                .HasColumnName("pliquido");
            entity.Property(e => e.Protocolo)
                .HasMaxLength(20)
                .HasColumnName("protocolo");
            entity.Property(e => e.Qtdparcelas)
                .HasColumnType("int(11)")
                .HasColumnName("qtdparcelas");
            entity.Property(e => e.Quantidadevol)
                .HasMaxLength(5)
                .HasColumnName("quantidadevol");
            entity.Property(e => e.Razao)
                .HasMaxLength(150)
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(3)
                .HasColumnName("recebimento");
            entity.Property(e => e.Recibonfe)
                .HasMaxLength(50)
                .HasColumnName("recibonfe");
            entity.Property(e => e.Saida)
                .HasColumnType("datetime")
                .HasColumnName("saida");
            entity.Property(e => e.Seqcce)
                .HasColumnType("int(11)")
                .HasColumnName("seqcce");
            entity.Property(e => e.Seriefrete)
                .HasMaxLength(4)
                .HasColumnName("seriefrete");
            entity.Property(e => e.Serienf)
                .HasMaxLength(3)
                .HasColumnName("serienf");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.St)
                .HasMaxLength(5)
                .HasColumnName("st");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipodesconto)
                .HasMaxLength(2)
                .HasColumnName("tipodesconto");
            entity.Property(e => e.Tipoemissao)
                .HasMaxLength(50)
                .HasColumnName("tipoemissao");
            entity.Property(e => e.Tipofrete)
                .HasMaxLength(3)
                .HasColumnName("tipofrete");
            entity.Property(e => e.Totalnota)
                .HasPrecision(10, 4)
                .HasColumnName("totalnota");
            entity.Property(e => e.Totalprodutos)
                .HasPrecision(10, 4)
                .HasColumnName("totalprodutos");
            entity.Property(e => e.Transportador)
                .HasMaxLength(100)
                .HasColumnName("transportador");
            entity.Property(e => e.Ufplaca)
                .HasMaxLength(2)
                .HasColumnName("ufplaca");
            entity.Property(e => e.Usuario)
                .HasMaxLength(4)
                .HasColumnName("usuario");
            entity.Property(e => e.Valoricms)
                .HasPrecision(10, 4)
                .HasColumnName("valoricms");
            entity.Property(e => e.Valoricmsst)
                .HasPrecision(10, 4)
                .HasColumnName("valoricmsst");
            entity.Property(e => e.Valoripi)
                .HasPrecision(10, 4)
                .HasColumnName("valoripi");
            entity.Property(e => e.Vencimentofrete)
                .HasMaxLength(10)
                .HasColumnName("vencimentofrete");
            entity.Property(e => e.Vii)
                .HasPrecision(10, 4)
                .HasColumnName("vii");
            entity.Property(e => e.XmlProc)
                .HasComment("Destinado a guarda de xmls das notas emitidas em compras")
                .HasColumnName("xml_proc");
        });

        modelBuilder.Entity<Configuracoescte>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("configuracoescte");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ambiente)
                .HasMaxLength(5)
                .HasColumnName("ambiente");
            entity.Property(e => e.Certificado)
                .HasMaxLength(150)
                .HasColumnName("certificado");
            entity.Property(e => e.Empresa)
                .HasMaxLength(15)
                .HasColumnName("empresa");
            entity.Property(e => e.Licenca)
                .HasMaxLength(500)
                .HasColumnName("licenca");
            entity.Property(e => e.Pathschemas)
                .HasMaxLength(250)
                .HasColumnName("pathschemas");
            entity.Property(e => e.Pathxml)
                .HasMaxLength(250)
                .HasColumnName("pathxml");
            entity.Property(e => e.Senhacertificado)
                .HasMaxLength(100)
                .HasColumnName("senhacertificado");
            entity.Property(e => e.Serie)
                .HasMaxLength(3)
                .HasColumnName("serie");
            entity.Property(e => e.Versao)
                .HasMaxLength(25)
                .HasColumnName("versao");
        });

        modelBuilder.Entity<Configuracoesemail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("configuracoesemail");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Mensagemfixa)
                .HasMaxLength(500)
                .HasColumnName("mensagemfixa");
            entity.Property(e => e.Modulo)
                .HasMaxLength(15)
                .HasColumnName("modulo");
            entity.Property(e => e.Nomeexibicao)
                .HasMaxLength(50)
                .HasColumnName("nomeexibicao");
            entity.Property(e => e.Porta)
                .HasMaxLength(5)
                .HasColumnName("porta");
            entity.Property(e => e.Senha)
                .HasMaxLength(100)
                .HasColumnName("senha");
            entity.Property(e => e.Tiposmtp)
                .HasMaxLength(50)
                .HasColumnName("tiposmtp");
            entity.Property(e => e.Tipossl)
                .HasMaxLength(10)
                .HasColumnName("tipossl");
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Configuracoesmdfe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("configuracoesmdfe");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Chave de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ambiente)
                .HasMaxLength(5)
                .HasColumnName("ambiente");
            entity.Property(e => e.Ativatrace)
                .HasMaxLength(250)
                .HasColumnName("ativatrace");
            entity.Property(e => e.Avisoexpiracertificado)
                .HasMaxLength(250)
                .HasColumnName("avisoexpiracertificado");
            entity.Property(e => e.Certificado)
                .HasMaxLength(150)
                .HasColumnName("certificado");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(250)
                .HasColumnName("cnpj");
            entity.Property(e => e.Empresa)
                .HasMaxLength(15)
                .HasColumnName("empresa");
            entity.Property(e => e.Licenca)
                .HasMaxLength(500)
                .HasColumnName("licenca");
            entity.Property(e => e.Nfecancelamento)
                .HasMaxLength(250)
                .HasColumnName("nfecancelamento");
            entity.Property(e => e.Nfeconsultaprotocolo)
                .HasMaxLength(250)
                .HasColumnName("nfeconsultaprotocolo");
            entity.Property(e => e.Nfeinutilizacao)
                .HasMaxLength(250)
                .HasColumnName("nfeinutilizacao");
            entity.Property(e => e.Nferecepcao)
                .HasMaxLength(250)
                .HasColumnName("nferecepcao");
            entity.Property(e => e.Nferecepcaoevento)
                .HasMaxLength(250)
                .HasColumnName("nferecepcaoevento");
            entity.Property(e => e.Nferetrecepcao)
                .HasMaxLength(250)
                .HasColumnName("nferetrecepcao");
            entity.Property(e => e.Nfestatusservico)
                .HasMaxLength(250)
                .HasColumnName("nfestatusservico");
            entity.Property(e => e.Pathschemas)
                .HasMaxLength(250)
                .HasColumnName("pathschemas");
            entity.Property(e => e.Pathxml)
                .HasMaxLength(250)
                .HasColumnName("pathxml");
            entity.Property(e => e.Senhacertificado)
                .HasMaxLength(100)
                .HasColumnName("senhacertificado");
            entity.Property(e => e.Serie)
                .HasMaxLength(3)
                .HasColumnName("serie");
            entity.Property(e => e.Unidadefederada)
                .HasMaxLength(250)
                .HasColumnName("unidadefederada");
            entity.Property(e => e.Unidadefederadacodigo)
                .HasMaxLength(250)
                .HasColumnName("unidadefederadacodigo");
            entity.Property(e => e.Verproc)
                .HasMaxLength(250)
                .HasColumnName("verproc");
            entity.Property(e => e.Versao)
                .HasMaxLength(25)
                .HasColumnName("versao");
        });

        modelBuilder.Entity<Configuracoesnfce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("configuracoesnfce");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ambiente)
                .HasMaxLength(2)
                .HasColumnName("ambiente");
            entity.Property(e => e.Ativatrace)
                .HasMaxLength(2)
                .HasColumnName("ativatrace");
            entity.Property(e => e.Avisoexpiracertificado)
                .HasMaxLength(5)
                .HasColumnName("avisoexpiracertificado");
            entity.Property(e => e.Cidtoken)
                .HasMaxLength(50)
                .HasColumnName("cidtoken");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(50)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codmunicipio)
                .HasMaxLength(15)
                .HasColumnName("codmunicipio");
            entity.Property(e => e.Csc)
                .HasMaxLength(100)
                .HasColumnName("csc");
            entity.Property(e => e.Danfecanhoto)
                .HasMaxLength(2)
                .HasColumnName("danfecanhoto");
            entity.Property(e => e.Danfeinfo).HasColumnName("danfeinfo");
            entity.Property(e => e.Danfelogo).HasColumnName("danfelogo");
            entity.Property(e => e.Danfetpdesc)
                .HasMaxLength(2)
                .HasColumnName("danfetpdesc");
            entity.Property(e => e.Datapacket).HasColumnName("datapacket");
            entity.Property(e => e.Datapacketformseg).HasColumnName("datapacketformseg");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Formatoitemqtd)
                .HasMaxLength(50)
                .HasColumnName("formatoitemqtd");
            entity.Property(e => e.Formatoitemunt)
                .HasMaxLength(50)
                .HasColumnName("formatoitemunt");
            entity.Property(e => e.Host).HasColumnName("host");
            entity.Property(e => e.Ie)
                .HasMaxLength(50)
                .HasColumnName("ie");
            entity.Property(e => e.Modelo)
                .HasMaxLength(5)
                .HasColumnName("modelo");
            entity.Property(e => e.Municipio).HasColumnName("municipio");
            entity.Property(e => e.Nfecancelamento).HasColumnName("nfecancelamento");
            entity.Property(e => e.Nfeconsultaprotocolo).HasColumnName("nfeconsultaprotocolo");
            entity.Property(e => e.Nfeinutilizacao).HasColumnName("nfeinutilizacao");
            entity.Property(e => e.Nferecepcao).HasColumnName("nferecepcao");
            entity.Property(e => e.Nferecepcaoevento).HasColumnName("nferecepcaoevento");
            entity.Property(e => e.Nferetrecepcao).HasColumnName("nferetrecepcao");
            entity.Property(e => e.Nfestatusservico).HasColumnName("nfestatusservico");
            entity.Property(e => e.Nomeexibicao).HasColumnName("nomeexibicao");
            entity.Property(e => e.Nomeimpressora)
                .HasMaxLength(50)
                .HasComment("Guarda nome da impressora para comando direto de impressão no pdv, sem visualização")
                .HasColumnName("nomeimpressora");
            entity.Property(e => e.Noseriecertificado).HasColumnName("noseriecertificado");
            entity.Property(e => e.Pathprincipal).HasColumnName("pathprincipal");
            entity.Property(e => e.Pathschemas).HasColumnName("pathschemas");
            entity.Property(e => e.Portaemail)
                .HasMaxLength(5)
                .HasColumnName("portaemail");
            entity.Property(e => e.Portaproxy)
                .HasMaxLength(15)
                .HasColumnName("portaproxy");
            entity.Property(e => e.Senha).HasColumnName("senha");
            entity.Property(e => e.Senhaproxy).HasColumnName("senhaproxy");
            entity.Property(e => e.Serie)
                .HasMaxLength(5)
                .HasColumnName("serie");
            entity.Property(e => e.Servidorsmtp).HasColumnName("servidorsmtp");
            entity.Property(e => e.Sizefontsobs)
                .HasMaxLength(5)
                .HasColumnName("sizefontsobs");
            entity.Property(e => e.Tipodanfe)
                .HasMaxLength(2)
                .HasColumnName("tipodanfe");
            entity.Property(e => e.Tipossl)
                .HasMaxLength(5)
                .HasColumnName("tipossl");
            entity.Property(e => e.Totalizarcfop)
                .HasMaxLength(2)
                .HasColumnName("totalizarcfop");
            entity.Property(e => e.Unidadefederada)
                .HasMaxLength(5)
                .HasColumnName("unidadefederada");
            entity.Property(e => e.Unidadefederadacodigo)
                .HasMaxLength(5)
                .HasColumnName("unidadefederadacodigo");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
            entity.Property(e => e.ValAss).HasColumnName("val_ass");
            entity.Property(e => e.ValMd5).HasColumnName("val_md5");
            entity.Property(e => e.Verproc)
                .HasMaxLength(15)
                .HasColumnName("verproc");
        });

        modelBuilder.Entity<Configuracoesnfe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("configuracoesnfe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ambiente)
                .HasMaxLength(2)
                .HasColumnName("ambiente");
            entity.Property(e => e.Ativatrace)
                .HasMaxLength(2)
                .HasColumnName("ativatrace");
            entity.Property(e => e.Avisoexpiracertificado)
                .HasMaxLength(5)
                .HasColumnName("avisoexpiracertificado");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(50)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codmunicipio)
                .HasMaxLength(15)
                .HasColumnName("codmunicipio");
            entity.Property(e => e.Danfecanhoto)
                .HasMaxLength(2)
                .HasColumnName("danfecanhoto");
            entity.Property(e => e.Danfeinfo)
                .HasMaxLength(500)
                .HasColumnName("danfeinfo");
            entity.Property(e => e.Danfelogo)
                .HasMaxLength(500)
                .HasColumnName("danfelogo");
            entity.Property(e => e.Danfetpdesc)
                .HasMaxLength(2)
                .HasColumnName("danfetpdesc");
            entity.Property(e => e.Datapacket)
                .HasMaxLength(500)
                .HasColumnName("datapacket");
            entity.Property(e => e.Datapacketformseg)
                .HasMaxLength(500)
                .HasColumnName("datapacketformseg");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .HasColumnName("email");
            entity.Property(e => e.Formatoitemqtd)
                .HasMaxLength(50)
                .HasColumnName("formatoitemqtd");
            entity.Property(e => e.Formatoitemunt)
                .HasMaxLength(50)
                .HasColumnName("formatoitemunt");
            entity.Property(e => e.Host)
                .HasMaxLength(500)
                .HasColumnName("host");
            entity.Property(e => e.Ie)
                .HasMaxLength(50)
                .HasColumnName("ie");
            entity.Property(e => e.Modelo)
                .HasMaxLength(5)
                .HasDefaultValueSql("'55'")
                .HasColumnName("modelo");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .HasColumnName("municipio");
            entity.Property(e => e.Nfecancelamento)
                .HasMaxLength(500)
                .HasColumnName("nfecancelamento");
            entity.Property(e => e.Nfeconsultaprotocolo)
                .HasMaxLength(500)
                .HasColumnName("nfeconsultaprotocolo");
            entity.Property(e => e.Nfeinutilizacao)
                .HasMaxLength(500)
                .HasColumnName("nfeinutilizacao");
            entity.Property(e => e.Nferecepcao)
                .HasMaxLength(500)
                .HasColumnName("nferecepcao");
            entity.Property(e => e.Nferecepcaoevento)
                .HasMaxLength(500)
                .HasColumnName("nferecepcaoevento");
            entity.Property(e => e.Nferetrecepcao)
                .HasMaxLength(500)
                .HasColumnName("nferetrecepcao");
            entity.Property(e => e.Nfestatusservico)
                .HasMaxLength(500)
                .HasColumnName("nfestatusservico");
            entity.Property(e => e.Nomeexibicao)
                .HasMaxLength(500)
                .HasColumnName("nomeexibicao");
            entity.Property(e => e.Noseriecertificado)
                .HasMaxLength(500)
                .HasColumnName("noseriecertificado");
            entity.Property(e => e.Pathprincipal)
                .HasMaxLength(500)
                .HasColumnName("pathprincipal");
            entity.Property(e => e.Pathschemas)
                .HasMaxLength(500)
                .HasColumnName("pathschemas");
            entity.Property(e => e.Portaemail)
                .HasMaxLength(5)
                .HasColumnName("portaemail");
            entity.Property(e => e.Portaproxy)
                .HasMaxLength(15)
                .HasColumnName("portaproxy");
            entity.Property(e => e.ReferenciaProdutoNota)
                .HasMaxLength(5)
                .HasDefaultValueSql("'false'")
                .HasComment("Configura uso da referencia no lugar do código na emissão. Coluna true / false")
                .HasColumnName("referencia_produto_nota");
            entity.Property(e => e.Senha)
                .HasMaxLength(500)
                .HasColumnName("senha");
            entity.Property(e => e.Senhaproxy)
                .HasMaxLength(500)
                .HasColumnName("senhaproxy");
            entity.Property(e => e.Serie)
                .HasMaxLength(5)
                .HasDefaultValueSql("'1'")
                .HasColumnName("serie");
            entity.Property(e => e.Servidorsmtp)
                .HasMaxLength(500)
                .HasColumnName("servidorsmtp");
            entity.Property(e => e.Sizefontsobs)
                .HasMaxLength(5)
                .HasColumnName("sizefontsobs");
            entity.Property(e => e.Tipodanfe)
                .HasMaxLength(2)
                .HasColumnName("tipodanfe");
            entity.Property(e => e.Tipossl)
                .HasMaxLength(5)
                .HasColumnName("tipossl");
            entity.Property(e => e.Totalizarcfop)
                .HasMaxLength(50)
                .HasColumnName("totalizarcfop");
            entity.Property(e => e.Ultimonsu)
                .HasMaxLength(20)
                .HasComment("Ultimo NSU para consulta DFE Webservice")
                .HasColumnName("ultimonsu");
            entity.Property(e => e.Unidadefederada)
                .HasMaxLength(5)
                .HasColumnName("unidadefederada");
            entity.Property(e => e.Unidadefederadacodigo)
                .HasMaxLength(5)
                .HasColumnName("unidadefederadacodigo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(500)
                .HasColumnName("usuario");
            entity.Property(e => e.ValAss)
                .HasMaxLength(500)
                .HasColumnName("val_ass");
            entity.Property(e => e.ValMd5)
                .HasMaxLength(500)
                .HasColumnName("val_md5");
            entity.Property(e => e.Verproc)
                .HasMaxLength(15)
                .HasColumnName("verproc");
        });

        modelBuilder.Entity<Configuracoesnfse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("configuracoesnfse");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ambiente)
                .HasMaxLength(2)
                .HasColumnName("ambiente");
            entity.Property(e => e.Documento)
                .HasColumnType("int(11)")
                .HasColumnName("documento");
            entity.Property(e => e.Pathprincipal)
                .HasMaxLength(500)
                .HasColumnName("pathprincipal");
            entity.Property(e => e.Rps)
                .HasComment("Guarda núemro do Rps da NFSE")
                .HasColumnType("int(11)")
                .HasColumnName("rps");
            entity.Property(e => e.Serie)
                .HasMaxLength(5)
                .HasColumnName("serie");
            entity.Property(e => e.Token)
                .HasMaxLength(500)
                .HasColumnName("token");
        });

        modelBuilder.Entity<Configuracoestef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("configuracoestef");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Chaveativacao)
                .HasMaxLength(100)
                .HasColumnName("chaveativacao");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasColumnName("cnpj");
            entity.Property(e => e.Pdv)
                .HasMaxLength(2)
                .HasColumnName("pdv");
            entity.Property(e => e.Tipo)
                .HasMaxLength(45)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipoparcelamento)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(11)")
                .HasColumnName("tipoparcelamento");
        });

        modelBuilder.Entity<Configusuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("configusuarios");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ajustarlote)
                .HasMaxLength(5)
                .HasColumnName("ajustarlote");
            entity.Property(e => e.Almoxarifado)
                .HasMaxLength(5)
                .HasColumnName("almoxarifado");
            entity.Property(e => e.Alteracomissao)
                .HasMaxLength(5)
                .HasColumnName("alteracomissao");
            entity.Property(e => e.Alterapreco)
                .HasMaxLength(5)
                .HasColumnName("alterapreco");
            entity.Property(e => e.Alterarvendedor)
                .HasMaxLength(5)
                .HasColumnName("alterarvendedor");
            entity.Property(e => e.Ativo)
                .HasMaxLength(5)
                .HasColumnName("ativo");
            entity.Property(e => e.Baixamanual)
                .HasMaxLength(5)
                .HasColumnName("baixamanual");
            entity.Property(e => e.Cadastrarartigo)
                .HasMaxLength(1)
                .HasColumnName("cadastrarartigo");
            entity.Property(e => e.Cadastrarbordado)
                .HasMaxLength(1)
                .HasColumnName("cadastrarbordado");
            entity.Property(e => e.Cadastrarcfop)
                .HasMaxLength(5)
                .HasColumnName("cadastrarcfop");
            entity.Property(e => e.Cadastrarcliente)
                .HasMaxLength(5)
                .HasColumnName("cadastrarcliente");
            entity.Property(e => e.Cadastrarcor)
                .HasMaxLength(1)
                .HasColumnName("cadastrarcor");
            entity.Property(e => e.Cadastrarequipamento)
                .HasMaxLength(1)
                .HasColumnName("cadastrarequipamento");
            entity.Property(e => e.Cadastrarfita)
                .HasMaxLength(1)
                .HasColumnName("cadastrarfita");
            entity.Property(e => e.Cadastrarfornecedor)
                .HasMaxLength(5)
                .HasColumnName("cadastrarfornecedor");
            entity.Property(e => e.Cadastraroperacoes)
                .HasMaxLength(5)
                .HasColumnName("cadastraroperacoes");
            entity.Property(e => e.Cadastrarpecabordado)
                .HasMaxLength(1)
                .HasColumnName("cadastrarpecabordado");
            entity.Property(e => e.Cadastrarpecafita)
                .HasMaxLength(1)
                .HasColumnName("cadastrarpecafita");
            entity.Property(e => e.Cadastrarplanocontas)
                .HasMaxLength(5)
                .HasColumnName("cadastrarplanocontas");
            entity.Property(e => e.Cadastrarrecebimento)
                .HasMaxLength(5)
                .HasColumnName("cadastrarrecebimento");
            entity.Property(e => e.Cadastrarservico)
                .HasMaxLength(5)
                .HasColumnName("cadastrarservico");
            entity.Property(e => e.Cadastrartecido)
                .HasMaxLength(1)
                .HasColumnName("cadastrartecido");
            entity.Property(e => e.Cadastrartransportador)
                .HasMaxLength(5)
                .HasColumnName("cadastrartransportador");
            entity.Property(e => e.Cadastrarveiculo)
                .HasMaxLength(1)
                .HasColumnName("cadastrarveiculo");
            entity.Property(e => e.Cadastrarvendedores)
                .HasMaxLength(5)
                .HasColumnName("cadastrarvendedores");
            entity.Property(e => e.Cadastroacesso)
                .HasMaxLength(5)
                .HasColumnName("cadastroacesso");
            entity.Property(e => e.Cadastroadicionar)
                .HasMaxLength(5)
                .HasColumnName("cadastroadicionar");
            entity.Property(e => e.Cadastroadicionarproduto)
                .HasMaxLength(5)
                .HasColumnName("cadastroadicionarproduto");
            entity.Property(e => e.Cadastroeditar)
                .HasMaxLength(5)
                .HasColumnName("cadastroeditar");
            entity.Property(e => e.Cadastroeditarproduto)
                .HasMaxLength(5)
                .HasColumnName("cadastroeditarproduto");
            entity.Property(e => e.Cadastroexcluir)
                .HasMaxLength(5)
                .HasColumnName("cadastroexcluir");
            entity.Property(e => e.Cadastroexcluirproduto)
                .HasMaxLength(5)
                .HasColumnName("cadastroexcluirproduto");
            entity.Property(e => e.Cadastrogeral)
                .HasMaxLength(5)
                .HasColumnName("cadastrogeral");
            entity.Property(e => e.Cadprodutos)
                .HasMaxLength(5)
                .HasColumnName("cadprodutos");
            entity.Property(e => e.Cadstroadicionar)
                .HasMaxLength(5)
                .HasColumnName("cadstroadicionar");
            entity.Property(e => e.Caixa)
                .HasMaxLength(5)
                .HasColumnName("caixa");
            entity.Property(e => e.Codigo)
                .HasColumnType("int(11)")
                .HasColumnName("codigo");
            entity.Property(e => e.Codigobarras)
                .HasMaxLength(5)
                .HasColumnName("codigobarras");
            entity.Property(e => e.Compra)
                .HasMaxLength(5)
                .HasColumnName("compra");
            entity.Property(e => e.Compracancelar)
                .HasMaxLength(5)
                .HasColumnName("compracancelar");
            entity.Property(e => e.Compraeditar)
                .HasMaxLength(5)
                .HasColumnName("compraeditar");
            entity.Property(e => e.Compraincluir)
                .HasMaxLength(5)
                .HasColumnName("compraincluir");
            entity.Property(e => e.Configetiqueta)
                .HasMaxLength(5)
                .HasColumnName("configetiqueta");
            entity.Property(e => e.Configurarnfse)
                .HasMaxLength(1)
                .HasColumnName("configurarnfse");
            entity.Property(e => e.Configurarparametros)
                .HasMaxLength(1)
                .HasColumnName("configurarparametros");
            entity.Property(e => e.Configusuario1)
                .HasMaxLength(5)
                .HasColumnName("configusuario");
            entity.Property(e => e.Configusuarios)
                .HasMaxLength(5)
                .HasColumnName("configusuarios");
            entity.Property(e => e.Contaspagar)
                .HasMaxLength(5)
                .HasColumnName("contaspagar");
            entity.Property(e => e.ContaspagarAcrescimodesconto)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_acrescimodesconto");
            entity.Property(e => e.ContaspagarAdicionar)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_adicionar");
            entity.Property(e => e.ContaspagarBaixar)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_baixar");
            entity.Property(e => e.ContaspagarConsultarcheque)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_consultarcheque");
            entity.Property(e => e.ContaspagarDefinecheque)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_definecheque");
            entity.Property(e => e.ContaspagarEditar)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_editar");
            entity.Property(e => e.ContaspagarEmitirboleto)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_emitirboleto");
            entity.Property(e => e.ContaspagarEmitirrecibo)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_emitirrecibo");
            entity.Property(e => e.ContaspagarEstornar)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_estornar");
            entity.Property(e => e.ContaspagarExcluir)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_excluir");
            entity.Property(e => e.ContaspagarMultiplicarparcela)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_multiplicarparcela");
            entity.Property(e => e.ContaspagarParcelar)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_parcelar");
            entity.Property(e => e.ContaspagarProrrogar)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_prorrogar");
            entity.Property(e => e.ContaspagarUnificar)
                .HasMaxLength(5)
                .HasColumnName("contaspagar_unificar");
            entity.Property(e => e.Contasreceber)
                .HasMaxLength(5)
                .HasColumnName("contasreceber");
            entity.Property(e => e.ContasreceberAcrescimodesconto)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_acrescimodesconto");
            entity.Property(e => e.ContasreceberAdicionar)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_adicionar");
            entity.Property(e => e.ContasreceberBaixar)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_baixar");
            entity.Property(e => e.ContasreceberCalcularjuros)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_calcularjuros");
            entity.Property(e => e.ContasreceberConsultarcheque)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_consultarcheque");
            entity.Property(e => e.ContasreceberDefinecheque)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_definecheque");
            entity.Property(e => e.ContasreceberDefineoperacao)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_defineoperacao");
            entity.Property(e => e.ContasreceberEditar)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_editar");
            entity.Property(e => e.ContasreceberEmitirboleto)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_emitirboleto");
            entity.Property(e => e.ContasreceberEmitirrecibo)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_emitirrecibo");
            entity.Property(e => e.ContasreceberEstornar)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_estornar");
            entity.Property(e => e.ContasreceberExcluir)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_excluir");
            entity.Property(e => e.ContasreceberParcelar)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_parcelar");
            entity.Property(e => e.ContasreceberProrrogar)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_prorrogar");
            entity.Property(e => e.ContasreceberRemessa)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_remessa");
            entity.Property(e => e.ContasreceberUnificar)
                .HasMaxLength(5)
                .HasColumnName("contasreceber_unificar");
            entity.Property(e => e.Controlecheque)
                .HasMaxLength(5)
                .HasColumnName("controlecheque");
            entity.Property(e => e.Dadosempresa)
                .HasMaxLength(5)
                .HasColumnName("dadosempresa");
            entity.Property(e => e.Desconto)
                .HasPrecision(10, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Descricaogrupo)
                .HasMaxLength(20)
                .HasColumnName("descricaogrupo");
            entity.Property(e => e.Emissaocheque)
                .HasMaxLength(5)
                .HasColumnName("emissaocheque");
            entity.Property(e => e.Entradaprodutos)
                .HasMaxLength(5)
                .HasColumnName("entradaprodutos");
            entity.Property(e => e.Exportardados)
                .HasMaxLength(1)
                .HasColumnName("exportardados");
            entity.Property(e => e.Filiais)
                .HasMaxLength(5)
                .HasColumnName("filiais");
            entity.Property(e => e.Followupclientes)
                .HasMaxLength(5)
                .HasColumnName("followupclientes");
            entity.Property(e => e.Followupfornecedor)
                .HasMaxLength(5)
                .HasColumnName("followupfornecedor");
            entity.Property(e => e.Funcionarios)
                .HasMaxLength(5)
                .HasColumnName("funcionarios");
            entity.Property(e => e.Grafico)
                .HasMaxLength(5)
                .HasColumnName("grafico");
            entity.Property(e => e.Graficos)
                .HasMaxLength(5)
                .HasColumnName("graficos");
            entity.Property(e => e.Idvendedor)
                .HasMaxLength(4)
                .HasColumnName("idvendedor");
            entity.Property(e => e.Importarproduto)
                .HasMaxLength(5)
                .HasColumnName("importarproduto");
            entity.Property(e => e.Importartabela)
                .HasMaxLength(5)
                .HasColumnName("importartabela");
            entity.Property(e => e.Importexportproutos)
                .HasMaxLength(5)
                .HasColumnName("importexportproutos");
            entity.Property(e => e.Inventario)
                .HasMaxLength(5)
                .HasColumnName("inventario");
            entity.Property(e => e.Liberarsenha)
                .HasMaxLength(5)
                .HasColumnName("liberarsenha");
            entity.Property(e => e.Listageminventario)
                .HasMaxLength(5)
                .HasColumnName("listageminventario");
            entity.Property(e => e.Maladireta)
                .HasMaxLength(5)
                .HasColumnName("maladireta");
            entity.Property(e => e.Mdfe)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasColumnName("mdfe");
            entity.Property(e => e.Mdfecancelar)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasColumnName("mdfecancelar");
            entity.Property(e => e.Mdfeeditar)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasColumnName("mdfeeditar");
            entity.Property(e => e.Mdfeincluir)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasColumnName("mdfeincluir");
            entity.Property(e => e.Modopesquisaproduto)
                .HasMaxLength(1)
                .HasColumnName("modopesquisaproduto");
            entity.Property(e => e.Nivel)
                .HasMaxLength(1)
                .HasColumnName("nivel");
            entity.Property(e => e.Nivelsenhapdv)
                .HasMaxLength(1)
                .HasColumnName("nivelsenhapdv");
            entity.Property(e => e.Nomeusuario)
                .HasMaxLength(30)
                .HasColumnName("nomeusuario");
            entity.Property(e => e.Ordemservico)
                .HasMaxLength(5)
                .HasColumnName("ordemservico");
            entity.Property(e => e.Ordemservicocancelar)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasColumnName("ordemservicocancelar");
            entity.Property(e => e.Ordemservicoeditar)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasColumnName("ordemservicoeditar");
            entity.Property(e => e.Ordemservicofaturar)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasColumnName("ordemservicofaturar");
            entity.Property(e => e.Ordemservicoincluir)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasColumnName("ordemservicoincluir");
            entity.Property(e => e.Pedidocompra)
                .HasMaxLength(5)
                .HasColumnName("pedidocompra");
            entity.Property(e => e.Pedidovenda)
                .HasMaxLength(5)
                .HasColumnName("pedidovenda");
            entity.Property(e => e.Permitealterarvendedor)
                .HasMaxLength(5)
                .HasColumnName("permitealterarvendedor");
            entity.Property(e => e.Pesquisacliente)
                .HasMaxLength(2)
                .HasColumnName("pesquisacliente");
            entity.Property(e => e.Pesquisarprodutos)
                .HasMaxLength(20)
                .HasColumnName("pesquisarprodutos");
            entity.Property(e => e.Relatoriocomissao)
                .HasMaxLength(5)
                .HasColumnName("relatoriocomissao");
            entity.Property(e => e.Relatorioestoque)
                .HasMaxLength(5)
                .HasColumnName("relatorioestoque");
            entity.Property(e => e.Relatoriofinanceiro)
                .HasMaxLength(5)
                .HasColumnName("relatoriofinanceiro");
            entity.Property(e => e.Relatoriofiscal)
                .HasMaxLength(5)
                .HasColumnName("relatoriofiscal");
            entity.Property(e => e.Relatoriogerenciais)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasColumnName("relatoriogerenciais");
            entity.Property(e => e.Relatoriomodulomesa)
                .HasMaxLength(5)
                .HasColumnName("relatoriomodulomesa");
            entity.Property(e => e.Relatoriomovimentacao)
                .HasMaxLength(5)
                .HasColumnName("relatoriomovimentacao");
            entity.Property(e => e.Relatoriopdv)
                .HasMaxLength(5)
                .HasColumnName("relatoriopdv");
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .HasColumnName("senha");
            entity.Property(e => e.Senhaliberacao)
                .HasMaxLength(50)
                .HasColumnName("senhaliberacao");
            entity.Property(e => e.Senhapdv)
                .HasMaxLength(60)
                .HasColumnName("senhapdv");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tabelapreco)
                .HasMaxLength(5)
                .HasColumnName("tabelapreco");
            entity.Property(e => e.Tabelaprecofixa)
                .HasMaxLength(1)
                .HasColumnName("tabelaprecofixa");
            entity.Property(e => e.Utilitarioexcluirpedidovenda)
                .HasMaxLength(5)
                .HasColumnName("utilitarioexcluirpedidovenda");
            entity.Property(e => e.Utilitarioexluirpedidocompra)
                .HasMaxLength(5)
                .HasColumnName("utilitarioexluirpedidocompra");
            entity.Property(e => e.Venda)
                .HasMaxLength(5)
                .HasColumnName("venda");
            entity.Property(e => e.Vendacancelar)
                .HasMaxLength(5)
                .HasColumnName("vendacancelar");
            entity.Property(e => e.Vendaeditar)
                .HasMaxLength(5)
                .HasColumnName("vendaeditar");
            entity.Property(e => e.Vendaincluir)
                .HasMaxLength(5)
                .HasColumnName("vendaincluir");
            entity.Property(e => e.Vendapendente)
                .HasMaxLength(5)
                .HasColumnName("vendapendente");
            entity.Property(e => e.Vendapendentecancelar)
                .HasMaxLength(5)
                .HasColumnName("vendapendentecancelar");
            entity.Property(e => e.Vendapendenteeditar)
                .HasMaxLength(5)
                .HasColumnName("vendapendenteeditar");
            entity.Property(e => e.Vendapendentefaturar)
                .HasMaxLength(5)
                .HasColumnName("vendapendentefaturar");
            entity.Property(e => e.Vendapendenteincluir)
                .HasMaxLength(5)
                .HasColumnName("vendapendenteincluir");
            entity.Property(e => e.Vendas)
                .HasMaxLength(5)
                .HasColumnName("vendas");
            entity.Property(e => e.VisualizarLembrete)
                .HasMaxLength(10)
                .HasComment("Controla o que o usuário visualiza no lembrete de acordo com as siglas:\nA - Acompanhamentos\nE - Estoque do produto\nL - Validade dos lotes \nP - Prospecção")
                .HasColumnName("visualizar_lembrete");
            entity.Property(e => e.Visualizatransferencias)
                .HasMaxLength(5)
                .HasColumnName("visualizatransferencias");
        });

        modelBuilder.Entity<Contabilidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("contabilidade", tb => tb.HasComment("Utilizado para gerar arquivo SPED"))
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id)
                .HasComment("campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasComment("Bairro do contador ou contabilidade")
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasComment("CEP do contador ou contabilidade")
                .HasColumnName("cep");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(25)
                .HasComment("CNPJ do contador ou contabilidade")
                .HasColumnName("cnpj");
            entity.Property(e => e.Codigomunicipio)
                .HasMaxLength(10)
                .HasComment("Codigo IBGE da cidade do contador ou contabilidade")
                .HasColumnName("codigomunicipio");
            entity.Property(e => e.Complemento)
                .HasMaxLength(100)
                .HasComment("Complemento de endereço do contador ou contabilidade")
                .HasColumnName("complemento");
            entity.Property(e => e.Cpf)
                .HasMaxLength(15)
                .HasComment("CPF do contador")
                .HasColumnName("cpf");
            entity.Property(e => e.Crc)
                .HasMaxLength(25)
                .HasComment("CRC do contador ou contabilidade")
                .HasColumnName("crc");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasComment("Email do contador ou contabilidade")
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasComment("Endereço do contador ou contabilidade")
                .HasColumnName("endereco");
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .HasComment("FAX do contador ou contabilidade")
                .HasColumnName("fax");
            entity.Property(e => e.Fone)
                .HasMaxLength(15)
                .HasComment("Telefone do contador ou contabilidade")
                .HasColumnName("fone");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasComment("Nome do contador ou contabilidade")
                .HasColumnName("nome");
            entity.Property(e => e.Numero)
                .HasMaxLength(5)
                .HasComment("Número físico do contador ou contabilidade")
                .HasColumnName("numero");
        });

        modelBuilder.Entity<Contacorrente>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("contacorrente");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cancelado");
            entity.Property(e => e.Cliente)
                .HasMaxLength(6)
                .HasColumnName("cliente");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .HasColumnName("documento");
            entity.Property(e => e.Hora)
                .HasMaxLength(50)
                .HasColumnName("hora");
            entity.Property(e => e.Observacao)
                .HasMaxLength(200)
                .HasColumnName("observacao");
            entity.Property(e => e.Origem)
                .HasMaxLength(1)
                .HasColumnName("origem");
            entity.Property(e => e.Preco)
                .HasPrecision(10, 4)
                .HasColumnName("preco");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(4)
                .HasColumnName("recebimento");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(30)
                .HasColumnName("responsavel");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Contaspagar>(entity =>
        {
            entity.HasKey(e => e.Chave1).HasName("PRIMARY");

            entity.ToTable("contaspagar");

            entity.Property(e => e.Chave1)
                .HasColumnType("int(11)")
                .HasColumnName("chave1");
            entity.Property(e => e.Acompanhamento)
                .HasMaxLength(5)
                .HasColumnName("acompanhamento");
            entity.Property(e => e.Ag)
                .HasMaxLength(15)
                .HasColumnName("ag");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasColumnName("banco");
            entity.Property(e => e.Bb)
                .HasMaxLength(5)
                .HasColumnName("bb");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasColumnName("cancelado");
            entity.Property(e => e.Cc)
                .HasMaxLength(15)
                .HasColumnName("cc");
            entity.Property(e => e.Centrocusto)
                .HasMaxLength(50)
                .HasColumnName("centrocusto");
            entity.Property(e => e.Chave2)
                .HasMaxLength(5)
                .HasColumnName("chave2");
            entity.Property(e => e.Cheque)
                .HasMaxLength(15)
                .HasColumnName("cheque");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(25)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codigobanco)
                .HasMaxLength(3)
                .HasColumnName("codigobanco");
            entity.Property(e => e.Codigorecebimento)
                .HasMaxLength(5)
                .HasColumnName("codigorecebimento");
            entity.Property(e => e.Compra)
                .HasMaxLength(10)
                .HasColumnName("compra");
            entity.Property(e => e.Datacancelamento)
                .HasColumnType("datetime")
                .HasColumnName("datacancelamento");
            entity.Property(e => e.Descricaoplano)
                .HasMaxLength(50)
                .HasColumnName("descricaoplano");
            entity.Property(e => e.Dias)
                .HasMaxLength(10)
                .HasColumnName("dias");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Documento3)
                .HasMaxLength(50)
                .HasColumnName("documento3");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(10000)
                .HasColumnName("empresa");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasColumnName("estado");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(250)
                .HasColumnName("fantasia");
            entity.Property(e => e.Forma)
                .HasMaxLength(100)
                .HasColumnName("forma");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(5)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Historico)
                .HasMaxLength(250)
                .HasColumnName("historico");
            entity.Property(e => e.Idmultibaixas)
                .HasColumnType("int(11)")
                .HasColumnName("idmultibaixas");
            entity.Property(e => e.Liberacaodesconto)
                .HasMaxLength(25)
                .HasColumnName("liberacaodesconto");
            entity.Property(e => e.Observacao)
                .HasMaxLength(250)
                .HasColumnName("observacao");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(20)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.Origem)
                .HasMaxLength(3)
                .HasColumnName("origem");
            entity.Property(e => e.Pagamento)
                .HasColumnType("datetime")
                .HasColumnName("pagamento");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(50)
                .HasColumnName("planocontas");
            entity.Property(e => e.Razao)
                .HasMaxLength(250)
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe")
                .HasColumnName("recebimento");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.ResponsavelBanco)
                .HasMaxLength(25)
                .HasColumnName("responsavel_banco");
            entity.Property(e => e.Seqpagparcial)
                .HasColumnType("int(11)")
                .HasColumnName("seqpagparcial");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .HasColumnName("tipo");
            entity.Property(e => e.Unificado)
                .HasMaxLength(20)
                .HasColumnName("unificado");
            entity.Property(e => e.Usuariobaixa)
                .HasMaxLength(50)
                .HasColumnName("usuariobaixa");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 4)
                .HasColumnName("valor");
            entity.Property(e => e.Valoracrescimo)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasComment("Destinado a guardar valor de acrescimo no contas a pagar")
                .HasColumnName("valoracrescimo");
            entity.Property(e => e.Valordesconto)
                .HasPrecision(10, 4)
                .HasColumnName("valordesconto");
            entity.Property(e => e.Valorparcial)
                .HasPrecision(10, 4)
                .HasColumnName("valorparcial");
            entity.Property(e => e.Vencimento)
                .HasColumnType("datetime")
                .HasColumnName("vencimento");
        });

        modelBuilder.Entity<Contaspagarhistorico>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("contaspagarhistorico");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("DATA");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(8)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Historico)
                .HasMaxLength(255)
                .HasColumnName("historico");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(30)
                .HasColumnName("responsavel");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tipo)
                .HasMaxLength(3)
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Contasreceber>(entity =>
        {
            entity.HasKey(e => e.Chave1).HasName("PRIMARY");

            entity.ToTable("contasreceber");

            entity.Property(e => e.Chave1)
                .HasColumnType("int(11)")
                .HasColumnName("chave1");
            entity.Property(e => e.Acompanhamento)
                .HasMaxLength(5)
                .HasColumnName("acompanhamento");
            entity.Property(e => e.Ag)
                .HasMaxLength(50)
                .HasColumnName("ag");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Backcampodocumento)
                .HasMaxLength(20)
                .HasColumnName("backcampodocumento");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasColumnName("banco");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasColumnName("cancelado");
            entity.Property(e => e.Cc)
                .HasMaxLength(50)
                .HasColumnName("cc");
            entity.Property(e => e.Ch)
                .HasMaxLength(1)
                .HasColumnName("ch");
            entity.Property(e => e.Chave2)
                .HasMaxLength(10)
                .HasColumnName("chave2");
            entity.Property(e => e.Cheque)
                .HasMaxLength(50)
                .HasColumnName("cheque");
            entity.Property(e => e.Cliente)
                .HasMaxLength(6)
                .HasColumnName("cliente");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(25)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codigobanco)
                .HasMaxLength(3)
                .HasColumnName("codigobanco");
            entity.Property(e => e.Codigorecebimento)
                .HasMaxLength(5)
                .HasColumnName("codigorecebimento");
            entity.Property(e => e.Compra)
                .HasMaxLength(10)
                .HasColumnName("compra");
            entity.Property(e => e.DataPgComissao)
                .HasColumnType("datetime")
                .HasColumnName("data_pg_comissao");
            entity.Property(e => e.Datacancelamento)
                .HasColumnType("datetime")
                .HasColumnName("datacancelamento");
            entity.Property(e => e.Dataremessa)
                .HasMaxLength(10)
                .HasColumnName("dataremessa");
            entity.Property(e => e.Dataretorno)
                .HasMaxLength(10)
                .HasColumnName("dataretorno");
            entity.Property(e => e.Descricaoplano)
                .HasMaxLength(250)
                .HasColumnName("descricaoplano");
            entity.Property(e => e.Dias)
                .HasMaxLength(10)
                .HasColumnName("dias");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Documento3)
                .HasMaxLength(50)
                .HasColumnName("documento3");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(25)
                .HasColumnName("empresa");
            entity.Property(e => e.Enviolembrete)
                .HasMaxLength(1)
                .HasColumnName("enviolembrete");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasColumnName("estado");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(250)
                .HasColumnName("fantasia");
            entity.Property(e => e.Forma)
                .HasMaxLength(100)
                .HasColumnName("forma");
            entity.Property(e => e.Historico)
                .HasMaxLength(500)
                .HasColumnName("historico");
            entity.Property(e => e.Lembraremailcar)
                .HasMaxLength(5)
                .HasColumnName("lembraremailcar");
            entity.Property(e => e.Liberacaodesconto)
                .HasMaxLength(25)
                .HasColumnName("liberacaodesconto");
            entity.Property(e => e.Linkboleto)
                .HasMaxLength(500)
                .HasComment("Link de boleto Safe2pay")
                .HasColumnName("linkboleto");
            entity.Property(e => e.Linkcarne)
                .HasMaxLength(500)
                .HasComment("Link de carnê Safe2pay")
                .HasColumnName("linkcarne");
            entity.Property(e => e.Modelobanco)
                .HasMaxLength(5)
                .HasColumnName("modelobanco");
            entity.Property(e => e.Observacao)
                .HasMaxLength(150)
                .HasColumnName("observacao");
            entity.Property(e => e.Observacaoboleto)
                .HasMaxLength(255)
                .HasColumnName("observacaoboleto");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(50)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.Origem)
                .HasMaxLength(3)
                .HasColumnName("origem");
            entity.Property(e => e.Pagamento)
                .HasColumnType("datetime")
                .HasColumnName("pagamento");
            entity.Property(e => e.Pedido)
                .HasMaxLength(50)
                .HasColumnName("pedido");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(50)
                .HasColumnName("planocontas");
            entity.Property(e => e.Razao)
                .HasMaxLength(250)
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe")
                .HasColumnName("recebimento");
            entity.Property(e => e.Referencias)
                .HasMaxLength(500)
                .HasColumnName("referencias");
            entity.Property(e => e.Remessa)
                .HasMaxLength(5)
                .HasColumnName("remessa");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.ResponsavelBanco)
                .HasMaxLength(50)
                .HasColumnName("responsavel_banco");
            entity.Property(e => e.Retorno)
                .HasMaxLength(5)
                .HasColumnName("retorno");
            entity.Property(e => e.Romaneio)
                .HasMaxLength(50)
                .HasColumnName("romaneio");
            entity.Property(e => e.Seqpagparcial)
                .HasColumnType("int(11)")
                .HasColumnName("seqpagparcial");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Situacao)
                .HasMaxLength(5)
                .HasColumnName("situacao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
            entity.Property(e => e.Ultimaparcela)
                .HasMaxLength(5)
                .HasColumnName("ultimaparcela");
            entity.Property(e => e.Unificado)
                .HasMaxLength(5)
                .HasColumnName("unificado");
            entity.Property(e => e.Usuariobaixa)
                .HasMaxLength(50)
                .HasColumnName("usuariobaixa");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasColumnName("valor");
            entity.Property(e => e.Valoracrescimo)
                .HasPrecision(18, 2)
                .HasComment("Campo destinado a guardar valor de  acréscimo de boleto ou juros")
                .HasColumnName("valoracrescimo");
            entity.Property(e => e.Valordesconto)
                .HasPrecision(18, 2)
                .HasColumnName("valordesconto");
            entity.Property(e => e.Valorparcial)
                .HasPrecision(18, 2)
                .HasColumnName("valorparcial");
            entity.Property(e => e.Vencimento)
                .HasColumnType("datetime")
                .HasColumnName("vencimento");
        });

        modelBuilder.Entity<Contasreceberhistorico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("contasreceberhistorico");

            entity.Property(e => e.Cliente)
                .HasMaxLength(8)
                .HasColumnName("cliente");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Historico)
                .HasMaxLength(255)
                .HasColumnName("historico");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(10000)
                .HasColumnName("responsavel");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Contatoscliente>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("contatosclientes");

            entity.Property(e => e.Codigo)
                .HasColumnType("int(11)")
                .HasColumnName("codigo");
            entity.Property(e => e.Aniversario)
                .HasColumnType("datetime")
                .HasColumnName("aniversario");
            entity.Property(e => e.Calcado)
                .HasMaxLength(20)
                .HasColumnName("calcado");
            entity.Property(e => e.Cargo)
                .HasMaxLength(30)
                .HasColumnName("cargo");
            entity.Property(e => e.Cliente)
                .HasMaxLength(10)
                .HasColumnName("cliente");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fone)
                .HasMaxLength(50)
                .HasColumnName("fone");
            entity.Property(e => e.Fone2)
                .HasMaxLength(20)
                .HasColumnName("fone2");
            entity.Property(e => e.Link)
                .HasMaxLength(300)
                .HasColumnName("link");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Roupa)
                .HasMaxLength(20)
                .HasColumnName("roupa");
            entity.Property(e => e.Sexo)
                .HasMaxLength(10)
                .HasColumnName("sexo");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Contatosfornecedore>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("contatosfornecedores");

            entity.Property(e => e.Codigo)
                .HasColumnType("int(11)")
                .HasColumnName("codigo");
            entity.Property(e => e.Cargo)
                .HasMaxLength(30)
                .HasColumnName("cargo");
            entity.Property(e => e.Codigofornecedor)
                .HasMaxLength(6)
                .HasColumnName("codigofornecedor");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fone)
                .HasMaxLength(50)
                .HasColumnName("fone");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Cop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cop");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cfops)
                .HasMaxLength(1000)
                .HasColumnName("cfops");
            entity.Property(e => e.Cop1)
                .HasMaxLength(20)
                .HasColumnName("cop");
        });

        modelBuilder.Entity<Cor>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("cor");

            entity.Property(e => e.Codigo)
                .HasColumnType("int(11)")
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(25)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Cstcsosn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cstcsosn");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
            entity.Property(e => e.Produto)
                .HasMaxLength(6)
                .HasColumnName("produto");
            entity.Property(e => e.Regime)
                .HasMaxLength(1)
                .HasColumnName("regime");
        });

        modelBuilder.Entity<CteListaNfe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cte_lista_nfe");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ChaveNfe)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("chave_nfe");
            entity.Property(e => e.IdCte)
                .HasColumnType("int(11)")
                .HasColumnName("id_cte");
        });

        modelBuilder.Entity<Detalhesbordadofitum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("detalhesbordadofita");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.Local)
                .HasMaxLength(20)
                .HasColumnName("local");
            entity.Property(e => e.Peca)
                .HasMaxLength(20)
                .HasColumnName("peca");
            entity.Property(e => e.Produto)
                .HasMaxLength(15)
                .HasColumnName("produto");
            entity.Property(e => e.Registro)
                .HasMaxLength(10)
                .HasColumnName("registro");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("tipo");
            entity.Property(e => e.Tp)
                .HasMaxLength(20)
                .HasColumnName("tp");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("empresa");

            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .HasColumnName("codigo");
            entity.Property(e => e.Bairro)
                .HasMaxLength(60)
                .HasComment("Bairro da empresa. 2 a 60 caracteres permitidos")
                .HasColumnName("bairro");
            entity.Property(e => e.Bloquarcliente)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bloquarcliente");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .HasColumnName("cep");
            entity.Property(e => e.Certificadodigital)
                .HasMaxLength(500)
                .HasColumnName("certificadodigital");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Cnae)
                .HasMaxLength(10)
                .HasColumnName("cnae");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("cnpj");
            entity.Property(e => e.Cnpjcontador)
                .HasMaxLength(50)
                .HasColumnName("cnpjcontador");
            entity.Property(e => e.Codigocidade)
                .HasMaxLength(8)
                .HasColumnName("codigocidade");
            entity.Property(e => e.Codigouf)
                .HasMaxLength(2)
                .HasComment("Código da UF com dois dígitos. Utilizar a Tabela do IBGE")
                .HasColumnName("codigouf");
            entity.Property(e => e.Cofins)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("cofins");
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .HasColumnName("complemento");
            entity.Property(e => e.Contato)
                .HasMaxLength(50)
                .HasColumnName("contato");
            entity.Property(e => e.Cpfcontador)
                .HasMaxLength(11)
                .HasColumnName("cpfcontador");
            entity.Property(e => e.Cpfcontato)
                .HasMaxLength(11)
                .HasColumnName("cpfcontato");
            entity.Property(e => e.Crccontador)
                .HasMaxLength(10)
                .HasColumnName("crccontador");
            entity.Property(e => e.Creditoicms)
                .HasPrecision(10, 4)
                .HasColumnName("creditoicms");
            entity.Property(e => e.Csll)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("csll");
            entity.Property(e => e.Dadosadicionais)
                .HasMaxLength(500)
                .HasColumnName("dadosadicionais");
            entity.Property(e => e.Databackup)
                .HasColumnType("datetime")
                .HasColumnName("databackup");
            entity.Property(e => e.Destaque)
                .HasMaxLength(50)
                .HasComment("Guarda cor de destaque na utilizacão  do Multi Empresa")
                .HasColumnName("destaque");
            entity.Property(e => e.DiaEnviaXml).HasColumnName("dia_envia_xml");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Email2)
                .HasMaxLength(100)
                .HasColumnName("email2");
            entity.Property(e => e.Emailcontador)
                .HasMaxLength(50)
                .HasColumnName("emailcontador");
            entity.Property(e => e.Emailcontato)
                .HasMaxLength(50)
                .HasColumnName("emailcontato");
            entity.Property(e => e.Endereco)
                .HasMaxLength(55)
                .HasColumnName("endereco");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(60)
                .HasColumnName("fantasia");
            entity.Property(e => e.Fax)
                .HasMaxLength(25)
                .HasColumnName("fax");
            entity.Property(e => e.Faxcontador)
                .HasMaxLength(20)
                .HasColumnName("faxcontador");
            entity.Property(e => e.Fone)
                .HasMaxLength(25)
                .HasColumnName("fone");
            entity.Property(e => e.Fonecontador)
                .HasMaxLength(20)
                .HasColumnName("fonecontador");
            entity.Property(e => e.Grade)
                .HasMaxLength(5)
                .HasColumnName("grade");
            entity.Property(e => e.Icms)
                .HasPrecision(10, 4)
                .HasColumnName("icms");
            entity.Property(e => e.Inscricao)
                .HasMaxLength(18)
                .HasColumnName("inscricao");
            entity.Property(e => e.Inscricaomunicipal)
                .HasMaxLength(20)
                .HasColumnName("inscricaomunicipal");
            entity.Property(e => e.Inss)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("inss");
            entity.Property(e => e.Irpj)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("irpj");
            entity.Property(e => e.Logo).HasColumnName("logo");
            entity.Property(e => e.Mensagem)
                .HasMaxLength(500)
                .HasComment("Guarda mensagem automática utilizada no envio da nota fiscal eletrônica, tela de vendas")
                .HasColumnName("mensagem");
            entity.Property(e => e.Mensagem2)
                .HasMaxLength(10000)
                .HasColumnName("mensagem2");
            entity.Property(e => e.Modelonf)
                .HasMaxLength(2)
                .HasColumnName("modelonf");
            entity.Property(e => e.Modelotabelapreco)
                .HasMaxLength(1)
                .HasColumnName("modelotabelapreco");
            entity.Property(e => e.Nomecontador)
                .HasMaxLength(50)
                .HasColumnName("nomecontador");
            entity.Property(e => e.Nomeexibicao)
                .HasMaxLength(50)
                .HasColumnName("nomeexibicao");
            entity.Property(e => e.Numero)
                .HasColumnType("int(11)")
                .HasColumnName("numero");
            entity.Property(e => e.Numerorecibo)
                .HasColumnType("int(11)")
                .HasColumnName("numerorecibo");
            entity.Property(e => e.Perfilsistema)
                .HasMaxLength(500)
                .HasColumnName("perfilsistema");
            entity.Property(e => e.Pis)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("pis");
            entity.Property(e => e.Prazo10000perc)
                .HasPrecision(10, 4)
                .HasColumnName("prazo10000perc");
            entity.Property(e => e.Prazomaxperc)
                .HasColumnType("int(11)")
                .HasColumnName("prazomaxperc");
            entity.Property(e => e.Razao)
                .HasMaxLength(60)
                .HasColumnName("razao");
            entity.Property(e => e.Regime)
                .HasMaxLength(1)
                .HasDefaultValueSql("'1'")
                .IsFixedLength()
                .HasComment("Código de Regime Tributário. Este campo será obrigatoriamente preenchido com:\n1 – Simples Nacional;\n2 – Simples Nacional – excesso de sublimite de receita bruta;\n3 – Regime Normal.")
                .HasColumnName("regime");
            entity.Property(e => e.Scan)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'")
                .IsFixedLength()
                .HasColumnName("scan");
            entity.Property(e => e.Senha)
                .HasMaxLength(50)
                .HasColumnName("senha");
            entity.Property(e => e.Serienf)
                .HasMaxLength(3)
                .HasColumnName("serienf");
            entity.Property(e => e.Smtp)
                .HasMaxLength(50)
                .HasColumnName("smtp");
            entity.Property(e => e.Tipossl)
                .HasMaxLength(50)
                .HasColumnName("tipossl");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.Validadecertificado)
                .HasMaxLength(50)
                .HasColumnName("validadecertificado");
            entity.Property(e => e.Versao)
                .HasMaxLength(15)
                .HasColumnName("versao");
        });

        modelBuilder.Entity<Estoque>(entity =>
        {
            entity.HasKey(e => e.Chave2).HasName("PRIMARY");

            entity.ToTable("estoque");

            entity.Property(e => e.Chave2)
                .HasColumnType("int(11)")
                .HasColumnName("chave2");
            entity.Property(e => e.Aliquota)
                .HasMaxLength(10)
                .HasColumnName("aliquota");
            entity.Property(e => e.Almoxarifado)
                .HasMaxLength(5)
                .HasColumnName("almoxarifado");
            entity.Property(e => e.Altura)
                .HasPrecision(18, 4)
                .HasColumnName("altura");
            entity.Property(e => e.Atendido)
                .HasPrecision(18, 4)
                .HasColumnName("atendido");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(25)
                .HasColumnName("auditoria");
            entity.Property(e => e.Baseipi)
                .HasPrecision(18, 4)
                .HasColumnName("baseipi");
            entity.Property(e => e.Campo1)
                .HasMaxLength(50)
                .HasColumnName("campo1");
            entity.Property(e => e.Campo2)
                .HasMaxLength(50)
                .HasColumnName("campo2");
            entity.Property(e => e.Campo3)
                .HasMaxLength(50)
                .HasColumnName("campo3");
            entity.Property(e => e.Campo4)
                .HasMaxLength(50)
                .HasColumnName("campo4");
            entity.Property(e => e.Campo5)
                .HasMaxLength(100)
                .HasColumnName("campo5");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasColumnName("cancelado");
            entity.Property(e => e.Cbarra)
                .HasMaxLength(50)
                .HasColumnName("cbarra");
            entity.Property(e => e.Cexportador)
                .HasMaxLength(100)
                .HasColumnName("cexportador");
            entity.Property(e => e.Cf)
                .HasMaxLength(8)
                .HasColumnName("cf");
            entity.Property(e => e.Cfabricante)
                .HasMaxLength(100)
                .HasColumnName("cfabricante");
            entity.Property(e => e.Cfop)
                .HasMaxLength(8)
                .HasColumnName("cfop");
            entity.Property(e => e.Chave3)
                .HasMaxLength(50)
                .HasColumnName("chave3");
            entity.Property(e => e.Chaveent)
                .HasColumnType("int(11)")
                .HasColumnName("chaveent");
            entity.Property(e => e.Chavesai)
                .HasColumnType("int(11)")
                .HasColumnName("chavesai");
            entity.Property(e => e.Cliente)
                .HasMaxLength(10)
                .HasColumnName("cliente");
            entity.Property(e => e.Codigofornecedor)
                .HasMaxLength(5)
                .HasColumnName("codigofornecedor");
            entity.Property(e => e.Comissao)
                .HasPrecision(18, 4)
                .HasColumnName("comissao");
            entity.Property(e => e.Comissvendedor)
                .HasPrecision(18, 4)
                .HasColumnName("comissvendedor");
            entity.Property(e => e.Comissvendedor2)
                .HasPrecision(18, 4)
                .HasColumnName("comissvendedor2");
            entity.Property(e => e.Contrato)
                .HasMaxLength(1)
                .HasColumnName("contrato");
            entity.Property(e => e.Cop)
                .HasMaxLength(100)
                .HasColumnName("cop");
            entity.Property(e => e.Cor)
                .HasMaxLength(25)
                .HasColumnName("cor");
            entity.Property(e => e.Creditoicms)
                .HasPrecision(18, 4)
                .HasColumnName("creditoicms");
            entity.Property(e => e.Custo)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("custo");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Ddesemb)
                .HasMaxLength(20)
                .HasColumnName("ddesemb");
            entity.Property(e => e.Ddi)
                .HasMaxLength(20)
                .HasColumnName("ddi");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Desconto2)
                .HasPrecision(18, 4)
                .HasColumnName("desconto2");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("descricao");
            entity.Property(e => e.Despesas)
                .HasPrecision(18, 4)
                .HasColumnName("despesas");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(25)
                .HasColumnName("empresa");
            entity.Property(e => e.Fabricacao)
                .HasColumnType("datetime")
                .HasColumnName("fabricacao");
            entity.Property(e => e.Fantasiafornecedor)
                .HasMaxLength(50)
                .HasColumnName("fantasiafornecedor");
            entity.Property(e => e.Fat)
                .HasMaxLength(5)
                .HasColumnName("fat");
            entity.Property(e => e.Fator)
                .HasPrecision(18, 4)
                .HasColumnName("fator");
            entity.Property(e => e.Fichatecnica)
                .HasMaxLength(10)
                .HasColumnName("fichatecnica");
            entity.Property(e => e.Frete)
                .HasPrecision(10, 4)
                .HasColumnName("frete");
            entity.Property(e => e.Fretevalor)
                .HasPrecision(18, 4)
                .HasColumnName("fretevalor");
            entity.Property(e => e.Grupo)
                .HasMaxLength(4)
                .HasColumnName("grupo");
            entity.Property(e => e.Historico)
                .HasMaxLength(500)
                .HasColumnName("historico");
            entity.Property(e => e.Hora)
                .HasPrecision(18, 4)
                .HasColumnName("hora");
            entity.Property(e => e.Icms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("icms");
            entity.Property(e => e.Infadicional)
                .HasMaxLength(500)
                .HasColumnName("infadicional");
            entity.Property(e => e.Ipi)
                .HasPrecision(18, 4)
                .HasColumnName("ipi");
            entity.Property(e => e.Largura)
                .HasPrecision(18, 4)
                .HasColumnName("largura");
            entity.Property(e => e.Lembrar)
                .HasColumnType("datetime")
                .HasColumnName("lembrar");
            entity.Property(e => e.Localizacao)
                .HasMaxLength(50)
                .HasColumnName("localizacao");
            entity.Property(e => e.Locdesemb)
                .HasMaxLength(50)
                .HasColumnName("locdesemb");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .HasColumnName("lote");
            entity.Property(e => e.Modbc)
                .HasColumnType("int(11)")
                .HasColumnName("modbc");
            entity.Property(e => e.Modbcst)
                .HasPrecision(18, 4)
                .HasColumnName("modbcst");
            entity.Property(e => e.Modelo)
                .HasMaxLength(30)
                .HasColumnName("modelo");
            entity.Property(e => e.Movimentaestoque)
                .HasMaxLength(5)
                .HasColumnName("movimentaestoque");
            entity.Property(e => e.Nadicao)
                .HasMaxLength(20)
                .HasColumnName("nadicao");
            entity.Property(e => e.Ndi)
                .HasMaxLength(10)
                .HasColumnName("ndi");
            entity.Property(e => e.Nfci)
                .HasMaxLength(500)
                .HasComment("Guarda numero da Ficha de Conteúdo de Importação - FCI")
                .HasColumnName("nfci");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.Nomeusuario)
                .HasMaxLength(25)
                .HasColumnName("nomeusuario");
            entity.Property(e => e.Nomevendedor)
                .HasMaxLength(50)
                .HasColumnName("nomevendedor");
            entity.Property(e => e.Nomevendedor2)
                .HasMaxLength(50)
                .HasColumnName("nomevendedor2");
            entity.Property(e => e.Nseqadic)
                .HasMaxLength(20)
                .HasColumnName("nseqadic");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .HasColumnName("observacao");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(50)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.Pbruto)
                .HasPrecision(18, 4)
                .HasColumnName("pbruto");
            entity.Property(e => e.Pedido)
                .HasMaxLength(50)
                .HasColumnName("pedido");
            entity.Property(e => e.Picms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("picms");
            entity.Property(e => e.Picmsst)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("picmsst");
            entity.Property(e => e.Pliquido)
                .HasPrecision(18, 4)
                .HasColumnName("pliquido");
            entity.Property(e => e.Pmvast)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("pmvast");
            entity.Property(e => e.Pp)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("pp");
            entity.Property(e => e.Preco)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("preco");
            entity.Property(e => e.Preco2)
                .HasPrecision(18, 4)
                .HasColumnName("preco2");
            entity.Property(e => e.Precon)
                .HasPrecision(18, 4)
                .HasColumnName("precon");
            entity.Property(e => e.Precopauta)
                .HasPrecision(18, 4)
                .HasColumnName("precopauta");
            entity.Property(e => e.Predbc)
                .HasPrecision(18, 4)
                .HasColumnName("predbc");
            entity.Property(e => e.Predbcst)
                .HasPrecision(18, 4)
                .HasColumnName("predbcst");
            entity.Property(e => e.Produto)
                .HasMaxLength(40)
                .HasColumnName("produto");
            entity.Property(e => e.Produtoficha)
                .HasMaxLength(20)
                .HasColumnName("produtoficha");
            entity.Property(e => e.Qtdvolume)
                .HasPrecision(10, 4)
                .HasColumnName("qtdvolume");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("quantidade");
            entity.Property(e => e.Reducaobase)
                .HasPrecision(18, 4)
                .HasColumnName("reducaobase");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .HasColumnName("referencia");
            entity.Property(e => e.Registro)
                .HasMaxLength(15)
                .HasComment("Campo destinado tanto a guarda do número sequencial da venda quanto do nitemped na nfe, quando necessário")
                .HasColumnName("registro");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.Romaneio)
                .HasMaxLength(50)
                .HasColumnName("romaneio");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.St)
                .HasMaxLength(4)
                .HasColumnName("st");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .HasColumnName("tipo");
            entity.Property(e => e.Total)
                .HasPrecision(18, 4)
                .HasColumnName("total");
            entity.Property(e => e.Total2)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("total2");
            entity.Property(e => e.Troca)
                .HasMaxLength(50)
                .HasColumnName("troca");
            entity.Property(e => e.Ufdesemb)
                .HasMaxLength(10)
                .HasColumnName("ufdesemb");
            entity.Property(e => e.Unidade)
                .HasMaxLength(10)
                .HasColumnName("unidade");
            entity.Property(e => e.Vale)
                .HasMaxLength(5)
                .HasColumnName("vale");
            entity.Property(e => e.Validade)
                .HasColumnType("datetime")
                .HasColumnName("validade");
            entity.Property(e => e.Valoricms)
                .HasPrecision(18, 4)
                .HasColumnName("valoricms");
            entity.Property(e => e.Valoripi)
                .HasPrecision(18, 4)
                .HasColumnName("valoripi");
            entity.Property(e => e.Vbc)
                .HasPrecision(18, 4)
                .HasColumnName("vbc");
            entity.Property(e => e.Vbcst)
                .HasPrecision(18, 4)
                .HasColumnName("vbcst");
            entity.Property(e => e.Vcofins)
                .HasPrecision(18, 4)
                .HasColumnName("vcofins");
            entity.Property(e => e.Vcsll)
                .HasPrecision(18, 4)
                .HasColumnName("vcsll");
            entity.Property(e => e.Vdescdi)
                .HasMaxLength(20)
                .HasColumnName("vdescdi");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(4)
                .HasColumnName("vendedor");
            entity.Property(e => e.Vendedor2)
                .HasMaxLength(4)
                .HasColumnName("vendedor2");
            entity.Property(e => e.Vicms)
                .HasPrecision(18, 4)
                .HasColumnName("vicms");
            entity.Property(e => e.Vicmsst)
                .HasPrecision(18, 4)
                .HasColumnName("vicmsst");
            entity.Property(e => e.Virpj)
                .HasPrecision(18, 4)
                .HasColumnName("virpj");
            entity.Property(e => e.Vpis)
                .HasPrecision(18, 4)
                .HasColumnName("vpis");
        });

        modelBuilder.Entity<Filiai>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("filiais");

            entity.Property(e => e.Codigo)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("codigo");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasColumnName("banco");
            entity.Property(e => e.Documentotransferencia)
                .HasColumnType("int(11)")
                .HasColumnName("documentotransferencia");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Path)
                .HasMaxLength(50)
                .HasColumnName("path");
        });

        modelBuilder.Entity<Fitum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("fita");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Fornecedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("fornecedores");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Auxiliar)
                .HasMaxLength(15)
                .HasColumnName("auxiliar");
            entity.Property(e => e.Bairro)
                .HasMaxLength(60)
                .HasComment("Bairro do fornecedor. 2 a 60 caracteres permitidos")
                .HasColumnName("bairro");
            entity.Property(e => e.Cadastro)
                .HasColumnType("datetime")
                .HasColumnName("cadastro");
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .HasComment("Guarda número do telefone móvel do fornecedor")
                .HasColumnName("celular");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .HasColumnName("cep");
            entity.Property(e => e.Cfop)
                .HasMaxLength(100)
                .HasColumnName("cfop");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(25)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .HasColumnName("codigo");
            entity.Property(e => e.Codigocidade)
                .HasMaxLength(18)
                .HasComment("Código da UF com dois dígitos. Utilizar a Tabela do IBGE")
                .HasColumnName("codigocidade");
            entity.Property(e => e.Codigorecebimento)
                .HasMaxLength(3)
                .HasColumnName("codigorecebimento");
            entity.Property(e => e.Codigouf)
                .HasMaxLength(2)
                .HasComment("Codigo da UF com dois dígitos. Utilizar a Tabela do IBGE")
                .HasColumnName("codigouf");
            entity.Property(e => e.Comissaorepresentante)
                .HasPrecision(10, 4)
                .HasColumnName("comissaorepresentante");
            entity.Property(e => e.Comissaovendedor)
                .HasPrecision(10, 4)
                .HasColumnName("comissaovendedor");
            entity.Property(e => e.Complemento)
                .HasMaxLength(30)
                .HasColumnName("complemento");
            entity.Property(e => e.Contato)
                .HasMaxLength(25)
                .HasColumnName("contato");
            entity.Property(e => e.Dataatualizacao)
                .HasComment("Guarda data de ultima alteração no cadastro de fornecedor")
                .HasColumnType("datetime")
                .HasColumnName("dataatualizacao");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasColumnName("endereco");
            entity.Property(e => e.Fabricante)
                .HasMaxLength(5)
                .HasColumnName("fabricante");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(60)
                .HasComment("Nome fantasia do fornecedor. 60 caracteres conforme manual da nfe.")
                .HasColumnName("fantasia");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .HasColumnName("fax");
            entity.Property(e => e.Fone)
                .HasMaxLength(30)
                .HasColumnName("fone");
            entity.Property(e => e.Freteminimo)
                .HasPrecision(10, 4)
                .HasColumnName("freteminimo");
            entity.Property(e => e.Grade)
                .HasMaxLength(5)
                .HasColumnName("grade");
            entity.Property(e => e.Grupo)
                .HasColumnType("int(11)")
                .HasColumnName("grupo");
            entity.Property(e => e.Indicepedido)
                .HasColumnType("int(11)")
                .HasColumnName("indicepedido");
            entity.Property(e => e.Inscricao)
                .HasMaxLength(25)
                .HasColumnName("inscricao");
            entity.Property(e => e.Inscricaomunicipal)
                .HasMaxLength(25)
                .HasComment("Guarda inscrição municipal do seu fornecedor")
                .HasColumnName("inscricaomunicipal");
            entity.Property(e => e.Modelograde)
                .HasMaxLength(2)
                .HasColumnName("modelograde");
            entity.Property(e => e.Numero)
                .HasMaxLength(15)
                .HasComment("Guarda número físico do endereço do fornecedor")
                .HasColumnName("numero");
            entity.Property(e => e.Observacao)
                .HasMaxLength(100)
                .HasColumnName("observacao");
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .HasColumnName("pais");
            entity.Property(e => e.Plano)
                .HasMaxLength(20)
                .HasColumnName("plano");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(20)
                .HasColumnName("planocontas");
            entity.Property(e => e.Pontoreferencia)
                .HasMaxLength(100)
                .HasComment("Guarda ponto de referência do endereço do fornecedor")
                .HasColumnName("pontoreferencia");
            entity.Property(e => e.Prazo)
                .HasMaxLength(3)
                .HasColumnName("prazo");
            entity.Property(e => e.Razao)
                .HasMaxLength(60)
                .HasComment("Razão social do fornecedor. 60 caracteres conforme manual da nfe.")
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(30)
                .HasColumnName("recebimento");
            entity.Property(e => e.Referencias)
                .HasMaxLength(4000)
                .HasColumnName("referencias");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(5)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .HasColumnName("status");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipopedido)
                .HasMaxLength(2)
                .HasColumnName("tipopedido");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasComment("Sigla da UF com dois dígitos. Utilizar a Tabela do IBGE")
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("funcionarios");

            entity.Property(e => e.Codigo)
                .HasColumnType("int(11)")
                .HasColumnName("codigo");
            entity.Property(e => e.Admissao)
                .HasColumnType("datetime")
                .HasColumnName("admissao");
            entity.Property(e => e.Agencia)
                .HasMaxLength(20)
                .HasColumnName("agencia");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.Banco)
                .HasMaxLength(530)
                .HasColumnName("banco");
            entity.Property(e => e.Cep)
                .HasMaxLength(12)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Comissao)
                .HasPrecision(10, 4)
                .HasColumnName("comissao");
            entity.Property(e => e.Conta)
                .HasMaxLength(50)
                .HasColumnName("conta");
            entity.Property(e => e.Cpf)
                .HasMaxLength(20)
                .HasColumnName("cpf");
            entity.Property(e => e.Ctps)
                .HasMaxLength(20)
                .HasColumnName("ctps");
            entity.Property(e => e.Dadoscomplementares)
                .HasMaxLength(500)
                .HasColumnName("dadoscomplementares");
            entity.Property(e => e.Departamento)
                .HasMaxLength(20)
                .HasColumnName("departamento");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(50)
                .HasColumnName("endereco");
            entity.Property(e => e.Fone)
                .HasMaxLength(15)
                .HasColumnName("fone");
            entity.Property(e => e.Fone2)
                .HasMaxLength(20)
                .HasColumnName("fone2");
            entity.Property(e => e.Funcao)
                .HasMaxLength(50)
                .HasColumnName("funcao");
            entity.Property(e => e.Inativo)
                .HasMaxLength(5)
                .HasColumnName("inativo");
            entity.Property(e => e.Meta)
                .HasPrecision(10, 4)
                .HasColumnName("meta");
            entity.Property(e => e.Nascimento)
                .HasColumnType("datetime")
                .HasColumnName("nascimento");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Observacao)
                .HasMaxLength(255)
                .HasColumnName("observacao");
            entity.Property(e => e.Pis)
                .HasMaxLength(30)
                .HasColumnName("pis");
            entity.Property(e => e.Rg)
                .HasMaxLength(20)
                .HasColumnName("rg");
            entity.Property(e => e.Salario)
                .HasPrecision(10, 4)
                .HasColumnName("salario");
            entity.Property(e => e.Seriectps)
                .HasMaxLength(10)
                .HasColumnName("seriectps");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<GrupoProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("grupo_produtos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Atividade)
                .HasMaxLength(30)
                .HasColumnName("atividade");
            entity.Property(e => e.Cargatributaria)
                .HasPrecision(10, 4)
                .HasColumnName("cargatributaria");
            entity.Property(e => e.CodAtividade)
                .HasMaxLength(20)
                .HasColumnName("cod_atividade");
            entity.Property(e => e.Codigosupervisor)
                .HasMaxLength(20)
                .HasColumnName("codigosupervisor");
            entity.Property(e => e.Colunas)
                .HasMaxLength(1000)
                .HasColumnName("colunas");
            entity.Property(e => e.Comissao)
                .HasPrecision(10, 4)
                .HasColumnName("comissao");
            entity.Property(e => e.Desativar)
                .HasMaxLength(5)
                .HasColumnName("desativar");
            entity.Property(e => e.Descricao)
                .HasMaxLength(30)
                .HasColumnName("descricao");
            entity.Property(e => e.Grupo)
                .HasMaxLength(6)
                .HasColumnName("grupo");
            entity.Property(e => e.Imagem)
                .HasMaxLength(100)
                .HasColumnName("imagem");
            entity.Property(e => e.Meta)
                .HasPrecision(10, 4)
                .HasColumnName("meta");
            entity.Property(e => e.NomeUrl)
                .HasMaxLength(50)
                .HasColumnName("nome_url");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Supervisor)
                .HasMaxLength(100)
                .HasColumnName("supervisor");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Historicoarquivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("historicoarquivos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Corlinha)
                .HasMaxLength(1000)
                .HasColumnName("corlinha");
            entity.Property(e => e.Corpeca)
                .HasMaxLength(50)
                .HasColumnName("corpeca");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Localpeca)
                .HasMaxLength(50)
                .HasColumnName("localpeca");
            entity.Property(e => e.Patharquivo)
                .HasMaxLength(1000)
                .HasColumnName("patharquivo");
            entity.Property(e => e.Produto)
                .HasMaxLength(50)
                .HasColumnName("produto");
        });

        modelBuilder.Entity<Historicocartacorrecao>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("historicocartacorrecao");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Data)
                .HasMaxLength(10)
                .HasColumnName("data");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Hora)
                .HasMaxLength(50)
                .HasColumnName("hora");
            entity.Property(e => e.Motivocarta)
                .HasMaxLength(250)
                .HasColumnName("motivocarta");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
        });

        modelBuilder.Entity<Historicomatriz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("historicomatriz");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cliente)
                .HasMaxLength(6)
                .HasColumnName("cliente");
            entity.Property(e => e.Comprimento)
                .HasPrecision(10, 4)
                .HasColumnName("comprimento");
            entity.Property(e => e.Documento)
                .HasMaxLength(10)
                .HasColumnName("documento");
            entity.Property(e => e.Espessura)
                .HasPrecision(10, 4)
                .HasColumnName("espessura");
            entity.Property(e => e.Largura)
                .HasPrecision(10, 4)
                .HasColumnName("largura");
            entity.Property(e => e.Margemlateral)
                .HasPrecision(10, 4)
                .HasColumnName("margemlateral");
            entity.Property(e => e.Margemlateral2)
                .HasPrecision(10, 4)
                .HasColumnName("margemlateral2");
            entity.Property(e => e.Margemterminal)
                .HasPrecision(10, 4)
                .HasColumnName("margemterminal");
            entity.Property(e => e.Margemterminal2)
                .HasPrecision(10, 4)
                .HasColumnName("margemterminal2");
            entity.Property(e => e.Matriz)
                .HasMaxLength(50)
                .HasColumnName("matriz");
            entity.Property(e => e.Produto)
                .HasMaxLength(10)
                .HasColumnName("produto");
        });

        modelBuilder.Entity<Icm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("icms");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
            entity.Property(e => e.Icms1)
                .HasPrecision(10, 4)
                .HasColumnName("icms1");
            entity.Property(e => e.Icms10)
                .HasPrecision(10, 4)
                .HasColumnName("icms10");
            entity.Property(e => e.Icms2)
                .HasPrecision(10, 4)
                .HasColumnName("icms2");
            entity.Property(e => e.Icms3)
                .HasPrecision(10, 4)
                .HasColumnName("icms3");
            entity.Property(e => e.Icms4)
                .HasPrecision(10, 4)
                .HasColumnName("icms4");
            entity.Property(e => e.Icms5)
                .HasPrecision(10, 4)
                .HasColumnName("icms5");
            entity.Property(e => e.Icms6)
                .HasPrecision(10, 4)
                .HasColumnName("icms6");
            entity.Property(e => e.Icms7)
                .HasPrecision(10, 4)
                .HasColumnName("icms7");
            entity.Property(e => e.Icms8)
                .HasPrecision(10, 4)
                .HasColumnName("icms8");
            entity.Property(e => e.Icms9)
                .HasPrecision(10, 4)
                .HasColumnName("icms9");
            entity.Property(e => e.Reducao1)
                .HasPrecision(10, 4)
                .HasColumnName("reducao1");
            entity.Property(e => e.Reducao10)
                .HasPrecision(10, 4)
                .HasColumnName("reducao10");
            entity.Property(e => e.Reducao2)
                .HasPrecision(10, 4)
                .HasColumnName("reducao2");
            entity.Property(e => e.Reducao3)
                .HasPrecision(10, 4)
                .HasColumnName("reducao3");
            entity.Property(e => e.Reducao4)
                .HasPrecision(10, 4)
                .HasColumnName("reducao4");
            entity.Property(e => e.Reducao5)
                .HasPrecision(10, 4)
                .HasColumnName("reducao5");
            entity.Property(e => e.Reducao6)
                .HasPrecision(10, 4)
                .HasColumnName("reducao6");
            entity.Property(e => e.Reducao7)
                .HasPrecision(10, 4)
                .HasColumnName("reducao7");
            entity.Property(e => e.Reducao8)
                .HasPrecision(10, 4)
                .HasColumnName("reducao8");
            entity.Property(e => e.Reducao9)
                .HasPrecision(10, 4)
                .HasColumnName("reducao9");
            entity.Property(e => e.St1)
                .HasMaxLength(4)
                .HasColumnName("st1");
            entity.Property(e => e.St10)
                .HasMaxLength(5)
                .HasColumnName("st10");
            entity.Property(e => e.St2)
                .HasMaxLength(4)
                .HasColumnName("st2");
            entity.Property(e => e.St3)
                .HasMaxLength(5)
                .HasColumnName("st3");
            entity.Property(e => e.St4)
                .HasMaxLength(5)
                .HasColumnName("st4");
            entity.Property(e => e.St5)
                .HasMaxLength(5)
                .HasColumnName("st5");
            entity.Property(e => e.St6)
                .HasMaxLength(5)
                .HasColumnName("st6");
            entity.Property(e => e.St7)
                .HasMaxLength(5)
                .HasColumnName("st7");
            entity.Property(e => e.St8)
                .HasMaxLength(5)
                .HasColumnName("st8");
            entity.Property(e => e.St9)
                .HasMaxLength(5)
                .HasColumnName("st9");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Inutilizacaonumeracao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("inutilizacaonumeracao");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Empresa)
                .HasMaxLength(10000)
                .HasColumnName("empresa");
            entity.Property(e => e.Justificativa)
                .HasMaxLength(50)
                .HasColumnName("justificativa");
            entity.Property(e => e.Numeracao)
                .HasMaxLength(50)
                .HasColumnName("numeracao");
            entity.Property(e => e.Serie)
                .HasMaxLength(3)
                .HasColumnName("serie");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Leiautemovimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("leiautemovimento");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Calcacostabolsodireito)
                .HasMaxLength(50)
                .HasColumnName("calcacostabolsodireito");
            entity.Property(e => e.Calcacostabolsoesquerdo)
                .HasMaxLength(50)
                .HasColumnName("calcacostabolsoesquerdo");
            entity.Property(e => e.Calcafrentebolsodireito)
                .HasMaxLength(50)
                .HasColumnName("calcafrentebolsodireito");
            entity.Property(e => e.Calcafrentebolsoesquerdo)
                .HasMaxLength(50)
                .HasColumnName("calcafrentebolsoesquerdo");
            entity.Property(e => e.Calcafrentepernadireita)
                .HasMaxLength(50)
                .HasColumnName("calcafrentepernadireita");
            entity.Property(e => e.Camisacosta)
                .HasMaxLength(50)
                .HasColumnName("camisacosta");
            entity.Property(e => e.Camisafrentebolsodireito)
                .HasMaxLength(50)
                .HasColumnName("camisafrentebolsodireito");
            entity.Property(e => e.Camisafrentemangadireta)
                .HasMaxLength(50)
                .HasColumnName("camisafrentemangadireta");
            entity.Property(e => e.Camisafrentemangaesquerdo)
                .HasMaxLength(50)
                .HasColumnName("camisafrentemangaesquerdo");
            entity.Property(e => e.Camisafrentepeitodireito)
                .HasMaxLength(50)
                .HasColumnName("camisafrentepeitodireito");
            entity.Property(e => e.Camisafrentepeitoesquerdo)
                .HasMaxLength(50)
                .HasColumnName("camisafrentepeitoesquerdo");
            entity.Property(e => e.Camisafrentevistabolso)
                .HasMaxLength(50)
                .HasColumnName("camisafrentevistabolso");
            entity.Property(e => e.Camisafretebolsoesquerdo)
                .HasMaxLength(50)
                .HasColumnName("camisafretebolsoesquerdo");
            entity.Property(e => e.Pedido)
                .HasMaxLength(50)
                .HasColumnName("pedido");
            entity.Property(e => e.Produto)
                .HasMaxLength(50)
                .HasColumnName("produto");
            entity.Property(e => e.Registro)
                .HasMaxLength(50)
                .HasColumnName("registro");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Listadownloadnfe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("listadownloadnfe", tb => tb.HasComment("Armazena lista de download de documentos fiscais"));

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Chave)
                .HasMaxLength(50)
                .HasColumnName("chave");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(50)
                .HasColumnName("cnpj");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Digval)
                .HasMaxLength(50)
                .HasColumnName("digval");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasComment("Número do Documento da NFE.")
                .HasColumnName("documento");
            entity.Property(e => e.Hora)
                .HasMaxLength(50)
                .HasColumnName("hora");
            entity.Property(e => e.Ie)
                .HasMaxLength(50)
                .HasColumnName("ie");
            entity.Property(e => e.Importado)
                .HasMaxLength(6)
                .HasComment("True = Importado, False = Não importado.")
                .HasColumnName("importado");
            entity.Property(e => e.Manifestacao)
                .HasMaxLength(6)
                .HasComment("Guarda o codigo da manifestação, 210200 = Confirmado, 210210 = Ciente, 210220 = Desconhecimento, 210240 = Não realizado.")
                .HasColumnName("manifestacao");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .HasComment("Nome fantasia do cliente. 60 caracteres conforme manual da nfe.")
                .HasColumnName("nome");
            entity.Property(e => e.Nsu)
                .HasMaxLength(50)
                .HasComment("Guarda último Número Sequencial Único (NSU)  código numérico gerado pela Sefaz (Secretaria da Fazenda) para distinguir e identificar um tipo de Nota Fiscal eletrônica, uma Carta de Correção eletrônica, um Evento da NF-e  ou até mesmo um conjunto destes documentos")
                .HasColumnName("nsu");
            entity.Property(e => e.Protocolo)
                .HasMaxLength(50)
                .HasColumnName("protocolo");
            entity.Property(e => e.Situacao)
                .HasColumnType("int(11)")
                .HasColumnName("situacao");
            entity.Property(e => e.Tiponf)
                .HasColumnType("int(11)")
                .HasColumnName("tiponf");
            entity.Property(e => e.Valor)
                .HasPrecision(20, 6)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<LocaisEntrega>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("locais_entrega");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(100)
                .HasColumnName("bairro");
            entity.Property(e => e.Taxa)
                .HasPrecision(18, 2)
                .HasColumnName("taxa");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("log");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Acao)
                .HasMaxLength(50)
                .HasColumnName("acao");
            entity.Property(e => e.Datahora)
                .HasMaxLength(6)
                .HasColumnName("datahora");
            entity.Property(e => e.Setor)
                .HasMaxLength(255)
                .HasColumnName("setor");
            entity.Property(e => e.Usuario)
                .HasColumnType("int(11)")
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("marca");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Matriz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("matriz");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Areaaberta)
                .HasPrecision(10, 4)
                .HasColumnName("areaaberta");
            entity.Property(e => e.Cc)
                .HasPrecision(10, 4)
                .HasColumnName("cc");
            entity.Property(e => e.Ccl)
                .HasPrecision(10, 4)
                .HasColumnName("ccl");
            entity.Property(e => e.Cordao)
                .HasPrecision(10, 4)
                .HasColumnName("cordao");
            entity.Property(e => e.Crique124)
                .HasMaxLength(50)
                .HasColumnName("crique124");
            entity.Property(e => e.Crique3)
                .HasMaxLength(50)
                .HasColumnName("crique3");
            entity.Property(e => e.Disposicao)
                .HasMaxLength(100)
                .HasColumnName("disposicao");
            entity.Property(e => e.Engrenagem124)
                .HasMaxLength(50)
                .HasColumnName("engrenagem124");
            entity.Property(e => e.EngrenagemMaq3)
                .HasMaxLength(50)
                .HasColumnName("engrenagem_maq3");
            entity.Property(e => e.Espessura)
                .HasMaxLength(20)
                .HasColumnName("espessura");
            entity.Property(e => e.FuroMalha)
                .HasPrecision(10, 4)
                .HasColumnName("furo_malha");
            entity.Property(e => e.FuroMalhaPor)
                .HasPrecision(10, 4)
                .HasColumnName("furo_malha_por");
            entity.Property(e => e.GrauFio)
                .HasPrecision(10, 4)
                .HasColumnName("grau_fio");
            entity.Property(e => e.Kgm2)
                .HasPrecision(10, 4)
                .HasColumnName("kgm2");
            entity.Property(e => e.Matriz1)
                .HasMaxLength(200)
                .HasColumnName("matriz");
            entity.Property(e => e.Observacao)
                .HasMaxLength(10000)
                .HasColumnName("observacao");
            entity.Property(e => e.Passo)
                .HasPrecision(10, 4)
                .HasColumnName("passo");
            entity.Property(e => e.Rm)
                .HasPrecision(10, 4)
                .HasColumnName("rm");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Mdfe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdfe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cancelado)
                .HasColumnType("datetime")
                .HasColumnName("cancelado");
            entity.Property(e => e.Capacidadekg)
                .HasPrecision(18, 2)
                .HasColumnName("capacidadekg");
            entity.Property(e => e.Capacidadem3)
                .HasPrecision(18, 2)
                .HasColumnName("capacidadem3");
            entity.Property(e => e.Carroceria)
                .HasMaxLength(20)
                .HasColumnName("carroceria");
            entity.Property(e => e.Cepcarregamento)
                .HasMaxLength(10)
                .HasColumnName("cepcarregamento");
            entity.Property(e => e.Cepdescarregamento)
                .HasMaxLength(10)
                .HasColumnName("cepdescarregamento");
            entity.Property(e => e.Chassi)
                .HasMaxLength(22)
                .HasComment("Numero do Chassi.")
                .HasColumnName("chassi");
            entity.Property(e => e.Chavenfe)
                .HasMaxLength(100)
                .HasColumnName("chavenfe");
            entity.Property(e => e.Ciot)
                .HasMaxLength(12)
                .HasColumnName("ciot");
            entity.Property(e => e.Cnpjipef)
                .HasMaxLength(25)
                .HasColumnName("cnpjipef");
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .HasColumnName("documento");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasColumnName("empresa");
            entity.Property(e => e.Encerramento)
                .HasMaxLength(200)
                .HasColumnName("encerramento");
            entity.Property(e => e.Formapagamento)
                .HasMaxLength(2)
                .HasColumnName("formapagamento");
            entity.Property(e => e.Justificativacancelamento)
                .HasMaxLength(1500)
                .HasColumnName("justificativacancelamento");
            entity.Property(e => e.Modo)
                .HasMaxLength(20)
                .HasColumnName("modo");
            entity.Property(e => e.Observacao)
                .HasMaxLength(150)
                .HasColumnName("observacao");
            entity.Property(e => e.Pesobruto)
                .HasPrecision(18, 2)
                .HasColumnName("pesobruto");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .HasColumnName("placa");
            entity.Property(e => e.ProcXml)
                .HasComment("Guarda arquivo xml resultante do mdfe emitido")
                .HasColumnName("proc_xml");
            entity.Property(e => e.Produto)
                .HasMaxLength(6)
                .HasColumnName("produto");
            entity.Property(e => e.Propriedade)
                .HasMaxLength(20)
                .HasColumnName("propriedade");
            entity.Property(e => e.Proprietariocnpj)
                .HasMaxLength(20)
                .HasColumnName("proprietariocnpj");
            entity.Property(e => e.Proprietarioinscricao)
                .HasMaxLength(20)
                .HasColumnName("proprietarioinscricao");
            entity.Property(e => e.Proprietarionome)
                .HasMaxLength(60)
                .HasColumnName("proprietarionome");
            entity.Property(e => e.Proprietariorntc)
                .HasMaxLength(50)
                .HasColumnName("proprietariorntc");
            entity.Property(e => e.Proprietariotipo)
                .HasMaxLength(20)
                .HasColumnName("proprietariotipo");
            entity.Property(e => e.Proprietariouf)
                .HasMaxLength(2)
                .HasColumnName("proprietariouf");
            entity.Property(e => e.Protocolo)
                .HasMaxLength(1000)
                .HasColumnName("protocolo");
            entity.Property(e => e.Recibo)
                .HasMaxLength(100)
                .HasColumnName("recibo");
            entity.Property(e => e.Responsavelpagamentocnpj)
                .HasMaxLength(25)
                .HasColumnName("responsavelpagamentocnpj");
            entity.Property(e => e.Responsavelpagamentonome)
                .HasMaxLength(100)
                .HasColumnName("responsavelpagamentonome");
            entity.Property(e => e.Rntc)
                .HasMaxLength(8)
                .HasColumnName("rntc");
            entity.Property(e => e.Serie)
                .HasMaxLength(5)
                .HasColumnName("serie");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Tara)
                .HasPrecision(18, 2)
                .HasColumnName("tara");
            entity.Property(e => e.Tipocarga)
                .HasMaxLength(2)
                .HasColumnName("tipocarga");
            entity.Property(e => e.Tipocomponente)
                .HasMaxLength(2)
                .HasColumnName("tipocomponente");
            entity.Property(e => e.Tiporodado)
                .HasMaxLength(20)
                .HasColumnName("tiporodado");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.Ufcarregamento)
                .HasMaxLength(2)
                .HasColumnName("ufcarregamento");
            entity.Property(e => e.Ufdescarregamento)
                .HasMaxLength(2)
                .HasColumnName("ufdescarregamento");
            entity.Property(e => e.Unidade)
                .HasMaxLength(10)
                .HasColumnName("unidade");
            entity.Property(e => e.Valorcarga)
                .HasPrecision(18, 2)
                .HasColumnName("valorcarga");
            entity.Property(e => e.Valorcomponente)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("valorcomponente");
            entity.Property(e => e.Valorcontrato)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("valorcontrato");
        });

        modelBuilder.Entity<Mdfecidadecarregamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdfecidadecarregamento");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Codigocidade)
                .HasMaxLength(15)
                .HasColumnName("codigocidade");
            entity.Property(e => e.Codigouf)
                .HasMaxLength(2)
                .HasColumnName("codigouf");
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .HasColumnName("documento");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasColumnName("empresa");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Mdfecidadedescarregamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdfecidadedescarregamento");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Codigocidade)
                .HasMaxLength(15)
                .HasColumnName("codigocidade");
            entity.Property(e => e.Codigouf)
                .HasMaxLength(2)
                .HasColumnName("codigouf");
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .HasColumnName("documento");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasColumnName("empresa");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Mdfelistanfe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdfelistanfe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Chavenfe)
                .HasMaxLength(100)
                .HasColumnName("chavenfe");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Codigocidade)
                .HasMaxLength(15)
                .HasColumnName("codigocidade");
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .HasColumnName("documento");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasColumnName("empresa");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Mdfemotorista>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdfemotoristas");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cpf)
                .HasMaxLength(20)
                .HasColumnName("cpf");
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .HasColumnName("documento");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasColumnName("empresa");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .HasColumnName("nome");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Mdfereboque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdfereboque");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Capacidadekg)
                .HasPrecision(18, 2)
                .HasColumnName("capacidadekg");
            entity.Property(e => e.Capacidadem3)
                .HasPrecision(18, 2)
                .HasColumnName("capacidadem3");
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .HasColumnName("documento");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasColumnName("empresa");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .HasColumnName("placa");
            entity.Property(e => e.Propriedade)
                .HasMaxLength(20)
                .HasColumnName("propriedade");
            entity.Property(e => e.Proprietariocnpj)
                .HasMaxLength(20)
                .HasColumnName("proprietariocnpj");
            entity.Property(e => e.Proprietarioinscricao)
                .HasMaxLength(20)
                .HasColumnName("proprietarioinscricao");
            entity.Property(e => e.Proprietarionome)
                .HasMaxLength(60)
                .HasColumnName("proprietarionome");
            entity.Property(e => e.Proprietariotipo)
                .HasMaxLength(20)
                .HasColumnName("proprietariotipo");
            entity.Property(e => e.Proprietariouf)
                .HasMaxLength(2)
                .HasColumnName("proprietariouf");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tara)
                .HasPrecision(18, 2)
                .HasColumnName("tara");
            entity.Property(e => e.Tiporodado)
                .HasMaxLength(20)
                .HasColumnName("tiporodado");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Mdfeufpercurso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdfeufpercurso");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .HasColumnName("documento");
            entity.Property(e => e.Empresa)
                .HasMaxLength(14)
                .HasColumnName("empresa");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PRIMARY");

            entity.ToTable("modelo");

            entity.Property(e => e.Codigo)
                .HasColumnType("int(11)")
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(20)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<Movimentocaixa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("movimentocaixa");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(5)
                .HasColumnName("auditoria");
            entity.Property(e => e.Banco)
                .HasMaxLength(25)
                .HasColumnName("banco");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasColumnName("cancelado");
            entity.Property(e => e.Chave)
                .HasMaxLength(30)
                .HasColumnName("chave");
            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .HasColumnName("codigo");
            entity.Property(e => e.Codigobanco)
                .HasMaxLength(5)
                .HasColumnName("codigobanco");
            entity.Property(e => e.Codigoplano)
                .HasMaxLength(50)
                .HasColumnName("codigoplano");
            entity.Property(e => e.Codigorecebimento)
                .HasMaxLength(4)
                .HasColumnName("codigorecebimento");
            entity.Property(e => e.Competencia)
                .HasColumnType("datetime")
                .HasColumnName("competencia");
            entity.Property(e => e.Concilacao)
                .HasMaxLength(5)
                .HasColumnName("concilacao");
            entity.Property(e => e.Contacorrente)
                .HasMaxLength(30)
                .HasColumnName("contacorrente");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Empresa)
                .HasMaxLength(10000)
                .HasColumnName("empresa");
            entity.Property(e => e.Historico)
                .HasMaxLength(100)
                .HasColumnName("historico");
            entity.Property(e => e.Numeroconta)
                .HasMaxLength(5)
                .HasColumnName("numeroconta");
            entity.Property(e => e.Origem)
                .HasMaxLength(3)
                .HasColumnName("origem");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(150)
                .HasColumnName("planocontas");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe")
                .HasColumnName("recebimento");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(30)
                .HasColumnName("usuario");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Municipiosibge>(entity =>
        {
            entity.HasKey(e => e.Ibgecidade).HasName("PRIMARY");

            entity.ToTable("municipiosibge");

            entity.Property(e => e.Ibgecidade)
                .HasMaxLength(7)
                .HasColumnName("ibgecidade");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Coduf)
                .HasMaxLength(2)
                .HasColumnName("coduf");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Mva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mva");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
            entity.Property(e => e.Icms1)
                .HasPrecision(10, 4)
                .HasColumnName("icms1");
            entity.Property(e => e.Icms10)
                .HasPrecision(10, 4)
                .HasColumnName("icms10");
            entity.Property(e => e.Icms2)
                .HasPrecision(10, 4)
                .HasColumnName("icms2");
            entity.Property(e => e.Icms3)
                .HasPrecision(10, 4)
                .HasColumnName("icms3");
            entity.Property(e => e.Icms4)
                .HasPrecision(10, 4)
                .HasColumnName("icms4");
            entity.Property(e => e.Icms5)
                .HasPrecision(10, 4)
                .HasColumnName("icms5");
            entity.Property(e => e.Icms6)
                .HasPrecision(10, 4)
                .HasColumnName("icms6");
            entity.Property(e => e.Icms7)
                .HasPrecision(10, 4)
                .HasColumnName("icms7");
            entity.Property(e => e.Icms8)
                .HasPrecision(10, 4)
                .HasColumnName("icms8");
            entity.Property(e => e.Icms9)
                .HasPrecision(10, 4)
                .HasColumnName("icms9");
            entity.Property(e => e.Mva1)
                .HasPrecision(10, 4)
                .HasColumnName("mva1");
            entity.Property(e => e.Mva10)
                .HasPrecision(10, 4)
                .HasColumnName("mva10");
            entity.Property(e => e.Mva2)
                .HasPrecision(10, 4)
                .HasColumnName("mva2");
            entity.Property(e => e.Mva3)
                .HasPrecision(10, 4)
                .HasColumnName("mva3");
            entity.Property(e => e.Mva4)
                .HasPrecision(10, 4)
                .HasColumnName("mva4");
            entity.Property(e => e.Mva5)
                .HasPrecision(10, 4)
                .HasColumnName("mva5");
            entity.Property(e => e.Mva6)
                .HasPrecision(10, 4)
                .HasColumnName("mva6");
            entity.Property(e => e.Mva7)
                .HasPrecision(10, 4)
                .HasColumnName("mva7");
            entity.Property(e => e.Mva8)
                .HasPrecision(10, 4)
                .HasColumnName("mva8");
            entity.Property(e => e.Mva9)
                .HasPrecision(10, 4)
                .HasColumnName("mva9");
            entity.Property(e => e.Reducao1)
                .HasPrecision(10, 4)
                .HasColumnName("reducao1");
            entity.Property(e => e.Reducao10)
                .HasPrecision(10, 4)
                .HasColumnName("reducao10");
            entity.Property(e => e.Reducao2)
                .HasPrecision(10, 4)
                .HasColumnName("reducao2");
            entity.Property(e => e.Reducao3)
                .HasPrecision(10, 4)
                .HasColumnName("reducao3");
            entity.Property(e => e.Reducao4)
                .HasPrecision(10, 4)
                .HasColumnName("reducao4");
            entity.Property(e => e.Reducao5)
                .HasPrecision(10, 4)
                .HasColumnName("reducao5");
            entity.Property(e => e.Reducao6)
                .HasPrecision(10, 4)
                .HasColumnName("reducao6");
            entity.Property(e => e.Reducao7)
                .HasPrecision(10, 4)
                .HasColumnName("reducao7");
            entity.Property(e => e.Reducao8)
                .HasPrecision(10, 4)
                .HasColumnName("reducao8");
            entity.Property(e => e.Reducao9)
                .HasPrecision(10, 4)
                .HasColumnName("reducao9");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Ncm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ncm");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cfop)
                .HasMaxLength(5)
                .HasColumnName("cfop");
            entity.Property(e => e.Cofins)
                .HasPrecision(10, 4)
                .HasColumnName("cofins");
            entity.Property(e => e.Cstcofins)
                .HasMaxLength(5)
                .HasColumnName("cstcofins");
            entity.Property(e => e.Cstpis)
                .HasMaxLength(5)
                .HasColumnName("cstpis");
            entity.Property(e => e.Icms)
                .HasPrecision(10, 4)
                .HasColumnName("icms");
            entity.Property(e => e.Icmsinterno)
                .HasPrecision(10, 4)
                .HasColumnName("icmsinterno");
            entity.Property(e => e.Mva)
                .HasPrecision(10, 4)
                .HasColumnName("mva");
            entity.Property(e => e.Ncm1)
                .HasMaxLength(10)
                .HasColumnName("ncm");
            entity.Property(e => e.Pis)
                .HasPrecision(10, 4)
                .HasColumnName("pis");
            entity.Property(e => e.Reducao)
                .HasPrecision(10, 4)
                .HasColumnName("reducao");
            entity.Property(e => e.St)
                .HasMaxLength(5)
                .HasColumnName("st");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<NfceCabecalho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nfce_cabecalho");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AutorizacaoCartao)
                .HasMaxLength(20)
                .HasColumnName("autorizacao_cartao");
            entity.Property(e => e.BaseCalculoIcms)
                .HasPrecision(18, 4)
                .HasColumnName("base_calculo_icms");
            entity.Property(e => e.BaseCalculoIcmsSt)
                .HasPrecision(18, 4)
                .HasColumnName("base_calculo_icms_st");
            entity.Property(e => e.ChaveAcesso)
                .HasMaxLength(50)
                .HasColumnName("chave_acesso");
            entity.Property(e => e.Cliente)
                .HasMaxLength(10)
                .HasColumnName("cliente");
            entity.Property(e => e.Cnfce)
                .HasMaxLength(15)
                .HasColumnName("cnfce");
            entity.Property(e => e.Cpfcnpj)
                .HasMaxLength(50)
                .HasColumnName("cpfcnpj");
            entity.Property(e => e.DataEmissao)
                .HasColumnType("datetime")
                .HasColumnName("data_emissao");
            entity.Property(e => e.Delivery)
                .HasColumnType("int(11)")
                .HasColumnName("delivery");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .HasColumnName("documento");
            entity.Property(e => e.Hfinal)
                .HasColumnType("datetime")
                .HasColumnName("hfinal");
            entity.Property(e => e.Hinicial)
                .HasColumnType("datetime")
                .HasColumnName("hinicial");
            entity.Property(e => e.HoraEmissao)
                .HasColumnType("datetime")
                .HasColumnName("hora_emissao");
            entity.Property(e => e.IdNfceMovimento)
                .HasColumnType("int(11)")
                .HasColumnName("id_nfce_movimento");
            entity.Property(e => e.IdOperador)
                .HasColumnType("int(11)")
                .HasColumnName("id_operador");
            entity.Property(e => e.Identregador)
                .HasColumnType("int(11)")
                .HasColumnName("identregador");
            entity.Property(e => e.Idsuitetipo)
                .HasColumnType("int(11)")
                .HasColumnName("idsuitetipo");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.NumeroProtocolo)
                .HasMaxLength(25)
                .HasColumnName("numero_protocolo");
            entity.Property(e => e.NumeroRecibo)
                .HasMaxLength(20)
                .HasColumnName("numero_recibo");
            entity.Property(e => e.NumeroSuite)
                .HasColumnType("int(11)")
                .HasColumnName("numero_suite");
            entity.Property(e => e.Observacao)
                .HasMaxLength(1000)
                .HasColumnName("observacao");
            entity.Property(e => e.Observacao2)
                .HasMaxLength(500)
                .HasColumnName("observacao2");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.StatusNota)
                .HasColumnType("int(11)")
                .HasColumnName("status_nota");
            entity.Property(e => e.Statusdelivery)
                .HasColumnType("int(11)")
                .HasColumnName("statusdelivery");
            entity.Property(e => e.Taxaacrescimo)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("taxaacrescimo");
            entity.Property(e => e.Taxadesconto)
                .HasPrecision(18, 4)
                .HasColumnName("taxadesconto");
            entity.Property(e => e.Tpentrega)
                .HasColumnType("int(11)")
                .HasColumnName("tpentrega");
            entity.Property(e => e.Troco)
                .HasPrecision(18, 4)
                .HasColumnName("troco");
            entity.Property(e => e.ValorCofins)
                .HasPrecision(18, 4)
                .HasColumnName("valor_cofins");
            entity.Property(e => e.ValorDesconto)
                .HasPrecision(18, 4)
                .HasColumnName("valor_desconto");
            entity.Property(e => e.ValorIcms)
                .HasPrecision(18, 4)
                .HasColumnName("valor_icms");
            entity.Property(e => e.ValorIcmsSt)
                .HasPrecision(18, 4)
                .HasColumnName("valor_icms_st");
            entity.Property(e => e.ValorIpi)
                .HasPrecision(18, 4)
                .HasColumnName("valor_ipi");
            entity.Property(e => e.ValorPis)
                .HasPrecision(18, 4)
                .HasColumnName("valor_pis");
            entity.Property(e => e.ValorTotal)
                .HasPrecision(18, 4)
                .HasColumnName("valor_total");
            entity.Property(e => e.ValorTotalProdutos)
                .HasPrecision(18, 4)
                .HasColumnName("valor_total_produtos");
            entity.Property(e => e.Valoracrescimo)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("valoracrescimo");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(4)
                .HasColumnName("vendedor");
            entity.Property(e => e.Viacartao)
                .HasMaxLength(5000)
                .HasColumnName("viacartao");
            entity.Property(e => e.XmlAssinado).HasColumnName("xml_assinado");
            entity.Property(e => e.XmlProc).HasColumnName("xml_proc");
        });

        modelBuilder.Entity<NfceDetalhe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nfce_detalhe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BaseIcms)
                .HasPrecision(18, 4)
                .HasColumnName("base_icms");
            entity.Property(e => e.BaseIcmsSt)
                .HasPrecision(18, 4)
                .HasColumnName("base_icms_st");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasColumnName("cancelado");
            entity.Property(e => e.Cfop)
                .HasMaxLength(5)
                .HasColumnName("cfop");
            entity.Property(e => e.CodigoProduto)
                .HasMaxLength(10)
                .HasColumnName("codigo_produto");
            entity.Property(e => e.Codigovendedor)
                .HasMaxLength(10)
                .HasColumnName("codigovendedor");
            entity.Property(e => e.Comissao)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("comissao");
            entity.Property(e => e.Custo)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasComment("Guarda o custo no dia da venda. Implementado em 11/01/2022")
                .HasColumnName("custo");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .HasColumnName("documento");
            entity.Property(e => e.Emitido)
                .HasMaxLength(1)
                .HasColumnName("emitido");
            entity.Property(e => e.Fichatecnica)
                .HasMaxLength(5)
                .HasColumnName("fichatecnica");
            entity.Property(e => e.Gtin)
                .HasMaxLength(25)
                .HasColumnName("gtin");
            entity.Property(e => e.Icms)
                .HasPrecision(18, 4)
                .HasColumnName("icms");
            entity.Property(e => e.IcmsReducao)
                .HasPrecision(18, 4)
                .HasColumnName("icms_reducao");
            entity.Property(e => e.IdNfeCabecalho)
                .HasColumnType("int(11)")
                .HasColumnName("id_nfe_cabecalho");
            entity.Property(e => e.Movimentaestoque)
                .HasMaxLength(5)
                .HasDefaultValueSql("'true'")
                .HasColumnName("movimentaestoque");
            entity.Property(e => e.Mva)
                .HasPrecision(18, 4)
                .HasColumnName("mva");
            entity.Property(e => e.MvaIcms)
                .HasPrecision(18, 4)
                .HasColumnName("mva_icms");
            entity.Property(e => e.MvaReducao)
                .HasPrecision(18, 4)
                .HasColumnName("mva_reducao");
            entity.Property(e => e.Ncm)
                .HasMaxLength(8)
                .HasColumnName("ncm");
            entity.Property(e => e.NomeProduto)
                .HasMaxLength(100)
                .HasColumnName("nome_produto");
            entity.Property(e => e.Nomevendedor)
                .HasMaxLength(30)
                .HasColumnName("nomevendedor");
            entity.Property(e => e.NumeroItem)
                .HasColumnType("int(11)")
                .HasColumnName("numero_item");
            entity.Property(e => e.Produtoficha)
                .HasMaxLength(6)
                .HasColumnName("produtoficha");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 4)
                .HasColumnName("quantidade");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Unidade)
                .HasMaxLength(5)
                .HasColumnName("unidade");
            entity.Property(e => e.ValorAcrescimo)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("valor_acrescimo");
            entity.Property(e => e.ValorDesconto)
                .HasPrecision(18, 4)
                .HasColumnName("valor_desconto");
            entity.Property(e => e.ValorIcms)
                .HasPrecision(18, 4)
                .HasColumnName("valor_icms");
            entity.Property(e => e.ValorIcmsSt)
                .HasPrecision(18, 4)
                .HasColumnName("valor_icms_st");
            entity.Property(e => e.ValorSubtotal)
                .HasPrecision(18, 4)
                .HasColumnName("valor_subtotal");
            entity.Property(e => e.ValorTotal)
                .HasPrecision(18, 4)
                .HasColumnName("valor_total");
            entity.Property(e => e.ValorTotalTributos)
                .HasPrecision(18, 4)
                .HasColumnName("valor_total_tributos");
            entity.Property(e => e.ValorUnitario)
                .HasPrecision(18, 4)
                .HasColumnName("valor_unitario");
        });

        modelBuilder.Entity<NfceMovimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nfce_movimento");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Dataabertura).HasColumnName("dataabertura");
            entity.Property(e => e.Datafechamento).HasColumnName("datafechamento");
            entity.Property(e => e.Fundocaixa)
                .HasPrecision(18, 4)
                .HasColumnName("fundocaixa");
            entity.Property(e => e.Horaabertura)
                .HasColumnType("datetime")
                .HasColumnName("horaabertura");
            entity.Property(e => e.Horafechamento)
                .HasColumnType("datetime")
                .HasColumnName("horafechamento");
            entity.Property(e => e.Idusuarioabertura)
                .HasColumnType("int(11)")
                .HasColumnName("idusuarioabertura");
            entity.Property(e => e.Idusuariofechamento)
                .HasColumnType("int(11)")
                .HasColumnName("idusuariofechamento");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
        });

        modelBuilder.Entity<NfceMovimentoOperador>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nfce_movimento_operador");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Datamovimento)
                .HasColumnType("datetime")
                .HasColumnName("datamovimento");
            entity.Property(e => e.Descricaorecebimento)
                .HasMaxLength(50)
                .HasColumnName("descricaorecebimento");
            entity.Property(e => e.IdMovimento)
                .HasColumnType("int(11)")
                .HasColumnName("id_movimento");
            entity.Property(e => e.IdOperador)
                .HasColumnType("int(11)")
                .HasColumnName("id_operador");
            entity.Property(e => e.IdRecebimento)
                .HasColumnType("int(11)")
                .HasColumnName("id_recebimento");
            entity.Property(e => e.Nomeoperador)
                .HasMaxLength(50)
                .HasColumnName("nomeoperador");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Total)
                .HasPrecision(18, 4)
                .HasColumnName("total");
            entity.Property(e => e.TotalCalculado)
                .HasPrecision(18, 4)
                .HasColumnName("total_calculado");
            entity.Property(e => e.TotalCancelado)
                .HasPrecision(18, 4)
                .HasColumnName("total_cancelado");
        });

        modelBuilder.Entity<NfceSangriaSuprimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nfce_sangria_suprimento");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.IdOperador)
                .HasColumnType("int(11)")
                .HasColumnName("id_operador");
            entity.Property(e => e.Idmovimento)
                .HasColumnType("int(11)")
                .HasColumnName("idmovimento");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .HasComment("Destinado a anotações ao comandar sangria ou suprimentos")
                .HasColumnName("observacao");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Numeracao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("numeracao");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Codigobanco)
                .HasMaxLength(2)
                .HasColumnName("codigobanco");
            entity.Property(e => e.Codigocliente)
                .HasMaxLength(6)
                .HasColumnName("codigocliente");
            entity.Property(e => e.Codigoequipamento)
                .HasMaxLength(6)
                .HasColumnName("codigoequipamento");
            entity.Property(e => e.Codigofornecedor)
                .HasMaxLength(6)
                .HasColumnName("codigofornecedor");
            entity.Property(e => e.Codigofuncionario)
                .HasMaxLength(3)
                .HasColumnName("codigofuncionario");
            entity.Property(e => e.Codigogrupoproduto)
                .HasMaxLength(6)
                .HasColumnName("codigogrupoproduto");
            entity.Property(e => e.Codigoproduto)
                .HasMaxLength(6)
                .HasColumnName("codigoproduto");
            entity.Property(e => e.Codigotippag)
                .HasMaxLength(3)
                .HasColumnName("codigotippag");
            entity.Property(e => e.Codigotransportador)
                .HasMaxLength(5)
                .HasColumnName("codigotransportador");
            entity.Property(e => e.Codigousuario)
                .HasMaxLength(2)
                .HasColumnName("codigousuario");
            entity.Property(e => e.Codigovendedor)
                .HasMaxLength(3)
                .HasColumnName("codigovendedor");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
        });

        modelBuilder.Entity<Numeracaocaixa>(entity =>
        {
            entity.HasKey(e => e.NCaixa).HasName("PRIMARY");

            entity.ToTable("numeracaocaixa");

            entity.Property(e => e.NCaixa)
                .HasMaxLength(9)
                .HasColumnName("n_caixa");
            entity.Property(e => e.Databertura)
                .HasColumnType("datetime")
                .HasColumnName("databertura");
            entity.Property(e => e.Fechado)
                .HasMaxLength(5)
                .HasColumnName("fechado");
        });

        modelBuilder.Entity<Numeracaofiscal>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("numeracaofiscal");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Docentrada)
                .HasMaxLength(15)
                .HasColumnName("docentrada");
            entity.Property(e => e.Docsaida)
                .HasMaxLength(15)
                .HasColumnName("docsaida");
            entity.Property(e => e.Empresa)
                .HasMaxLength(10000)
                .HasColumnName("empresa");
            entity.Property(e => e.Lotenfse)
                .HasMaxLength(15)
                .HasColumnName("lotenfse");
            entity.Property(e => e.Numeroloterps)
                .HasMaxLength(15)
                .HasColumnName("numeroloterps");
            entity.Property(e => e.Numeronotaentrada)
                .HasMaxLength(15)
                .HasColumnName("numeronotaentrada");
            entity.Property(e => e.Numeronotamdfe)
                .HasColumnType("int(11)")
                .HasColumnName("numeronotamdfe");
            entity.Property(e => e.Numeronotanfce)
                .HasColumnType("int(11)")
                .HasColumnName("numeronotanfce");
            entity.Property(e => e.Numeronotasaida)
                .HasMaxLength(15)
                .HasColumnName("numeronotasaida");
            entity.Property(e => e.Numeronotascan)
                .HasMaxLength(15)
                .HasColumnName("numeronotascan");
            entity.Property(e => e.Numeroromaneio)
                .HasColumnType("int(11)")
                .HasColumnName("numeroromaneio");
            entity.Property(e => e.Selofiscalentrada)
                .HasMaxLength(15)
                .HasColumnName("selofiscalentrada");
            entity.Property(e => e.Selofiscalsaida)
                .HasMaxLength(15)
                .HasColumnName("selofiscalsaida");
        });

        modelBuilder.Entity<Numeracaopedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("numeracaopedidos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Contrato)
                .HasColumnType("int(11)")
                .HasColumnName("contrato");
            entity.Property(e => e.Pedidocompra)
                .HasColumnType("int(11)")
                .HasColumnName("pedidocompra");
            entity.Property(e => e.Pedidovenda)
                .HasColumnType("int(11)")
                .HasColumnName("pedidovenda");
        });

        modelBuilder.Entity<Ordemservico>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("ordemservico");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Acessorio)
                .HasMaxLength(500)
                .HasColumnName("acessorio");
            entity.Property(e => e.Atendente)
                .HasMaxLength(5)
                .HasColumnName("atendente");
            entity.Property(e => e.Cancelado)
                .HasColumnType("datetime")
                .HasColumnName("cancelado");
            entity.Property(e => e.Cliente)
                .HasMaxLength(6)
                .HasColumnName("cliente");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Comissao1)
                .HasPrecision(10, 4)
                .HasColumnName("comissao1");
            entity.Property(e => e.Comissao2)
                .HasPrecision(10, 4)
                .HasColumnName("comissao2");
            entity.Property(e => e.Cor)
                .HasMaxLength(30)
                .HasColumnName("cor");
            entity.Property(e => e.Defeito)
                .HasMaxLength(500)
                .HasColumnName("defeito");
            entity.Property(e => e.Defeitoidentificado)
                .HasMaxLength(500)
                .HasColumnName("defeitoidentificado");
            entity.Property(e => e.Desconto)
                .HasPrecision(10, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Descricaorecebimento)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe")
                .HasColumnName("descricaorecebimento");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.Entrada)
                .HasColumnType("datetime")
                .HasColumnName("entrada");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(50)
                .HasColumnName("fantasia");
            entity.Property(e => e.Faturado)
                .HasMaxLength(1)
                .HasColumnName("faturado");
            entity.Property(e => e.Finalizada)
                .HasMaxLength(5)
                .HasColumnName("finalizada");
            entity.Property(e => e.Garantia)
                .HasColumnType("int(11)")
                .HasColumnName("garantia");
            entity.Property(e => e.Hodometro)
                .HasMaxLength(10)
                .HasColumnName("hodometro");
            entity.Property(e => e.Hodrometro)
                .HasMaxLength(10)
                .HasColumnName("hodrometro");
            entity.Property(e => e.Horaentrada)
                .HasMaxLength(10)
                .HasColumnName("horaentrada");
            entity.Property(e => e.Horasaida)
                .HasMaxLength(50)
                .HasColumnName("horasaida");
            entity.Property(e => e.Listaequipamentos)
                .HasMaxLength(500)
                .HasColumnName("listaequipamentos");
            entity.Property(e => e.Listafuncionarios)
                .HasMaxLength(500)
                .HasColumnName("listafuncionarios");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .HasColumnName("modelo");
            entity.Property(e => e.Mododesconto)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .HasColumnName("mododesconto");
            entity.Property(e => e.Nomeatendente)
                .HasMaxLength(50)
                .HasColumnName("nomeatendente");
            entity.Property(e => e.Nometecnico)
                .HasMaxLength(50)
                .HasColumnName("nometecnico");
            entity.Property(e => e.Nomeusuario)
                .HasMaxLength(30)
                .HasColumnName("nomeusuario");
            entity.Property(e => e.Numeroparcelas)
                .HasColumnType("int(11)")
                .HasColumnName("numeroparcelas");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .HasColumnName("observacao");
            entity.Property(e => e.Orcamento)
                .HasMaxLength(5)
                .HasColumnName("orcamento");
            entity.Property(e => e.Ordemap)
                .HasMaxLength(10)
                .HasColumnName("ordemap");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .HasColumnName("placa");
            entity.Property(e => e.Potencia)
                .HasMaxLength(15)
                .HasColumnName("potencia");
            entity.Property(e => e.PrevisaoSaida)
                .HasColumnType("datetime")
                .HasColumnName("previsao_saida");
            entity.Property(e => e.Prisma)
                .HasMaxLength(50)
                .HasColumnName("prisma");
            entity.Property(e => e.Razao)
                .HasMaxLength(150)
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(4)
                .HasColumnName("recebimento");
            entity.Property(e => e.Saida)
                .HasColumnType("datetime")
                .HasColumnName("saida");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .HasColumnName("serie");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Tecnico)
                .HasMaxLength(5)
                .HasColumnName("tecnico");
            entity.Property(e => e.Tipocombustivel)
                .HasMaxLength(50)
                .HasColumnName("tipocombustivel");
            entity.Property(e => e.Tipodesconto)
                .HasMaxLength(2)
                .HasColumnName("tipodesconto");
            entity.Property(e => e.Tombo)
                .HasMaxLength(50)
                .HasColumnName("tombo");
            entity.Property(e => e.Total)
                .HasPrecision(10, 4)
                .HasColumnName("total");
            entity.Property(e => e.Totalproduto)
                .HasPrecision(10, 4)
                .HasColumnName("totalproduto");
            entity.Property(e => e.Totalservico)
                .HasPrecision(10, 4)
                .HasColumnName("totalservico");
            entity.Property(e => e.Usuario)
                .HasMaxLength(5)
                .HasColumnName("usuario");
            entity.Property(e => e.Validadeproposta)
                .HasColumnType("int(11)")
                .HasColumnName("validadeproposta");
        });

        modelBuilder.Entity<Ordemservicomovimento>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("ordemservicomovimento");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Arquivobordado)
                .HasMaxLength(150)
                .HasColumnName("arquivobordado");
            entity.Property(e => e.Atendente)
                .HasMaxLength(5)
                .HasComment("Guarda codigo do funcionário definido como atendente na Ordem de Serviço")
                .HasColumnName("atendente");
            entity.Property(e => e.Baseicms)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("baseicms");
            entity.Property(e => e.Baseicmssub)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("baseicmssub");
            entity.Property(e => e.Baseiss)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("baseiss");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasDefaultValueSql("'false'")
                .HasColumnName("cancelado");
            entity.Property(e => e.Capacidadeextintora)
                .HasMaxLength(10)
                .HasColumnName("capacidadeextintora");
            entity.Property(e => e.ChaveOriginal)
                .HasMaxLength(10000)
                .HasColumnName("chave_original");
            entity.Property(e => e.Cliente)
                .HasMaxLength(6)
                .HasColumnName("cliente");
            entity.Property(e => e.Comissavendedor2)
                .HasPrecision(10, 4)
                .HasColumnName("comissavendedor2");
            entity.Property(e => e.Comissvendedor)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("comissvendedor");
            entity.Property(e => e.Comissvendedor2)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("comissvendedor2");
            entity.Property(e => e.Custo)
                .HasPrecision(10, 4)
                .HasComment("Guarda custo do produto na Ordem de Serviço. Decimal com duas casas")
                .HasColumnName("custo");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Desconto)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("desconto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasComment("Guarda descricao do produto na Ordem de Serviço")
                .HasColumnName("descricao");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasComment("Guarda Documento da Ordem de Serviço")
                .HasColumnName("documento");
            entity.Property(e => e.Fabricante)
                .HasMaxLength(100)
                .HasColumnName("fabricante");
            entity.Property(e => e.Icms)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("icms");
            entity.Property(e => e.Icmssub)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("icmssub");
            entity.Property(e => e.Iss)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("iss");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .HasColumnName("marca");
            entity.Property(e => e.Motivoreparo)
                .HasMaxLength(250)
                .HasColumnName("motivoreparo");
            entity.Property(e => e.Movimentaestoque)
                .HasMaxLength(5)
                .HasDefaultValueSql("'true'")
                .HasColumnName("movimentaestoque");
            entity.Property(e => e.Mva)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("mva");
            entity.Property(e => e.Nomeatendente)
                .HasMaxLength(50)
                .HasComment("Guarda nome do funcionário definido como atendente na Ordem de Serviço")
                .HasColumnName("nomeatendente");
            entity.Property(e => e.Nometecnico)
                .HasMaxLength(50)
                .HasColumnName("nometecnico");
            entity.Property(e => e.Numeropontos)
                .HasMaxLength(50)
                .HasColumnName("numeropontos");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .HasColumnName("observacao");
            entity.Property(e => e.Pendente)
                .HasMaxLength(50)
                .HasColumnName("pendente");
            entity.Property(e => e.Pgcomissao)
                .HasMaxLength(1)
                .HasColumnName("pgcomissao");
            entity.Property(e => e.Preco)
                .HasPrecision(10, 4)
                .HasComment("Guarda valor unitario do produto na Ordem de Serviço. Decimal com duas casas")
                .HasColumnName("preco");
            entity.Property(e => e.Produto)
                .HasMaxLength(20)
                .HasComment("Guarda código do produto na Ordem de Serviço")
                .HasColumnName("produto");
            entity.Property(e => e.Quantidade)
                .HasPrecision(10, 4)
                .HasComment("Guarda quantidade do produto na Ordem de Serviço. Decimal com duas casas")
                .HasColumnName("quantidade");
            entity.Property(e => e.Reducao)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("reducao");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .HasComment("Guarda referencia do produto na Ordem de Serviço")
                .HasColumnName("referencia");
            entity.Property(e => e.RegistroServico)
                .HasColumnType("int(11)")
                .HasColumnName("registro_servico");
            entity.Property(e => e.Servico)
                .HasMaxLength(5)
                .HasColumnName("servico");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tecnico)
                .HasMaxLength(5)
                .HasColumnName("tecnico");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");
            entity.Property(e => e.TipoServico)
                .HasMaxLength(255)
                .HasColumnName("tipo_servico");
            entity.Property(e => e.Total)
                .HasPrecision(10, 4)
                .HasColumnName("total");
            entity.Property(e => e.Unidade)
                .HasMaxLength(5)
                .HasColumnName("unidade");
            entity.Property(e => e.Valoricms)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("valoricms");
            entity.Property(e => e.Valoricmssub)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("valoricmssub");
            entity.Property(e => e.Valoriss)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("valoriss");
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("parametros");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Abrirpedidocomprafaturado)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasComment("Ativa faturamento de pedido de compra ao faturar abrir tela de compra automaticamente. Campo True/False")
                .HasColumnName("abrirpedidocomprafaturado");
            entity.Property(e => e.Abrirpedidovendafaturado)
                .HasMaxLength(5)
                .HasDefaultValueSql("'True'")
                .HasComment("Ativa faturamento de pedido de venda ao faturar abrir tela de venda automaticamente. Campo True/False")
                .HasColumnName("abrirpedidovendafaturado");
            entity.Property(e => e.Agruparproduto)
                .HasMaxLength(5)
                .HasColumnName("agruparproduto");
            entity.Property(e => e.Alteradescricaoproduto)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("alteradescricaoproduto");
            entity.Property(e => e.Alterarestoqueminimo)
                .HasMaxLength(1)
                .HasColumnName("alterarestoqueminimo");
            entity.Property(e => e.Alterartabelapreco)
                .HasMaxLength(1)
                .HasColumnName("alterartabelapreco");
            entity.Property(e => e.Apiboleto)
                .HasMaxLength(1)
                .HasComment("Habilita e desabilita uso do Safe2pay como cobrança no Antares")
                .HasColumnName("apiboleto");
            entity.Property(e => e.Apitoken)
                .HasMaxLength(100)
                .HasComment("Token de identificação Safe2pay")
                .HasColumnName("apitoken");
            entity.Property(e => e.Arquivoconsultapreco)
                .HasMaxLength(200)
                .HasColumnName("arquivoconsultapreco");
            entity.Property(e => e.Ativarlembrete)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ativarlembrete");
            entity.Property(e => e.Avisoatualizacliente)
                .HasMaxLength(1)
                .HasColumnName("avisoatualizacliente");
            entity.Property(e => e.Backup1)
                .HasMaxLength(500)
                .HasColumnName("backup1");
            entity.Property(e => e.Backup2)
                .HasMaxLength(500)
                .HasColumnName("backup2");
            entity.Property(e => e.Cabecalhoimpressaoopcional)
                .HasMaxLength(5)
                .HasColumnName("cabecalhoimpressaoopcional");
            entity.Property(e => e.Cadprodutoprecoobrigatorio)
                .HasMaxLength(1)
                .HasDefaultValueSql("'1'")
                .HasColumnName("cadprodutoprecoobrigatorio");
            entity.Property(e => e.Caixaspaf)
                .HasMaxLength(100)
                .HasColumnName("caixaspaf");
            entity.Property(e => e.Casasdecimais)
                .HasDefaultValueSql("'2'")
                .HasComment("controle geral de casas decimais")
                .HasColumnType("int(11)")
                .HasColumnName("casasdecimais");
            entity.Property(e => e.CasasdecimalOrdemservico)
                .HasDefaultValueSql("'2'")
                .HasComment("controle de casasdecimais para ordem de servico")
                .HasColumnType("int(11)")
                .HasColumnName("casasdecimal_ordemservico");
            entity.Property(e => e.CasasdecimalPedidocompraCompra)
                .HasDefaultValueSql("'2'")
                .HasComment("controle de casas decimais para telas de pedido de compra e compra")
                .HasColumnType("int(11)")
                .HasColumnName("casasdecimal_pedidocompra_compra");
            entity.Property(e => e.CasasdecimalPedidovendaVenda)
                .HasDefaultValueSql("'2'")
                .HasComment("controle de casas decimais para venda e pre-venda")
                .HasColumnType("int(11)")
                .HasColumnName("casasdecimal_pedidovenda_venda");
            entity.Property(e => e.Clienteobrigatorio)
                .HasMaxLength(1)
                .HasColumnName("clienteobrigatorio");
            entity.Property(e => e.Descontoisspagamento)
                .HasMaxLength(1)
                .HasColumnName("descontoisspagamento");
            entity.Property(e => e.Empresa)
                .HasColumnType("int(11)")
                .HasColumnName("empresa");
            entity.Property(e => e.Estoqueminimoavisar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("estoqueminimoavisar");
            entity.Property(e => e.Estoquenegativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'1'")
                .HasComment("Controle de estoque:\r\n0 - Sem estoque negativo\r\n1 - Permite estoque negativo")
                .HasColumnName("estoquenegativo");
            entity.Property(e => e.Faturamentopessoafisicajuridica)
                .HasPrecision(10, 2)
                .HasColumnName("faturamentopessoafisicajuridica");
            entity.Property(e => e.Faturargerartitulo)
                .HasMaxLength(1)
                .HasColumnName("faturargerartitulo");
            entity.Property(e => e.Fixavendedorconsultapedidovenda)
                .HasMaxLength(1)
                .HasColumnName("fixavendedorconsultapedidovenda");
            entity.Property(e => e.Fixavendedorconsultavenda)
                .HasMaxLength(1)
                .HasColumnName("fixavendedorconsultavenda");
            entity.Property(e => e.Freteporproduto)
                .HasMaxLength(5)
                .HasColumnName("freteporproduto");
            entity.Property(e => e.Inativarprodutosprevenda)
                .HasMaxLength(1)
                .HasColumnName("inativarprodutosprevenda");
            entity.Property(e => e.Lembraremailcar)
                .HasMaxLength(5)
                .HasColumnName("lembraremailcar");
            entity.Property(e => e.Letranumero)
                .HasMaxLength(1)
                .HasColumnName("letranumero");
            entity.Property(e => e.Logo)
                .HasMaxLength(500)
                .HasColumnName("logo");
            entity.Property(e => e.Logomarcacliente)
                .HasMaxLength(100)
                .HasColumnName("logomarcacliente");
            entity.Property(e => e.Loteobrigatorio)
                .HasMaxLength(5)
                .HasColumnName("loteobrigatorio");
            entity.Property(e => e.Manterpedidocompra)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("manterpedidocompra");
            entity.Property(e => e.Manterprevenda)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("manterprevenda");
            entity.Property(e => e.Matriz)
                .HasMaxLength(1)
                .HasColumnName("matriz");
            entity.Property(e => e.Maxdescontocsenha)
                .HasPrecision(10, 4)
                .HasColumnName("maxdescontocsenha");
            entity.Property(e => e.Maxdescontossenha)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'100.0000'")
                .HasColumnName("maxdescontossenha");
            entity.Property(e => e.Mensagemfixacomprovantecompra)
                .HasMaxLength(500)
                .HasColumnName("mensagemfixacomprovantecompra");
            entity.Property(e => e.Mensagemfixacomprovantevenda)
                .HasMaxLength(500)
                .HasColumnName("mensagemfixacomprovantevenda");
            entity.Property(e => e.Mensagemordemservico)
                .HasMaxLength(200)
                .HasColumnName("mensagemordemservico");
            entity.Property(e => e.Modelocomprovantevenda)
                .HasMaxLength(2)
                .HasColumnName("modelocomprovantevenda");
            entity.Property(e => e.Modelocotacao)
                .HasMaxLength(1)
                .HasColumnName("modelocotacao");
            entity.Property(e => e.Modelocusto)
                .HasMaxLength(20)
                .HasColumnName("modelocusto");
            entity.Property(e => e.Modeloimpressora)
                .HasMaxLength(15)
                .HasComment("Campo essencial para abertura do Antares. Não pode ser removido. Guarda Modelo de impressora Nfce utilizada com os seguintes códigos em uso:\nElgin i9 modeloimpressora=i9\n \n")
                .HasColumnName("modeloimpressora");
            entity.Property(e => e.Modelomapaseparacaopv)
                .HasMaxLength(2)
                .HasColumnName("modelomapaseparacaopv");
            entity.Property(e => e.Modeloordemservico)
                .HasMaxLength(2)
                .HasColumnName("modeloordemservico");
            entity.Property(e => e.Modelopedidovenda)
                .HasMaxLength(10)
                .HasColumnName("modelopedidovenda");
            entity.Property(e => e.Modelorecibo)
                .HasMaxLength(2)
                .HasColumnName("modelorecibo");
            entity.Property(e => e.Movimentarestoquenopedido)
                .HasMaxLength(5)
                .HasColumnName("movimentarestoquenopedido");
            entity.Property(e => e.Naoavisaritemduplicado)
                .HasMaxLength(5)
                .HasDefaultValueSql("'0'")
                .HasColumnName("naoavisaritemduplicado");
            entity.Property(e => e.Nfeentradaigualsaida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'1'")
                .HasColumnName("nfeentradaigualsaida");
            entity.Property(e => e.Nomecomprovantevenda)
                .HasMaxLength(50)
                .HasColumnName("nomecomprovantevenda");
            entity.Property(e => e.Nomeempresaemrelatorios)
                .HasMaxLength(1)
                .HasColumnName("nomeempresaemrelatorios");
            entity.Property(e => e.Nomemapaseparacao)
                .HasMaxLength(50)
                .HasColumnName("nomemapaseparacao");
            entity.Property(e => e.Nomepedido)
                .HasMaxLength(15)
                .HasColumnName("nomepedido");
            entity.Property(e => e.Nomesupervisor)
                .HasMaxLength(50)
                .HasColumnName("nomesupervisor");
            entity.Property(e => e.Nomevendapendente)
                .HasMaxLength(50)
                .HasColumnName("nomevendapendente");
            entity.Property(e => e.Obscfopvenda)
                .HasMaxLength(1)
                .HasColumnName("obscfopvenda");
            entity.Property(e => e.Patharquivos)
                .HasMaxLength(2000)
                .HasDefaultValueSql("'c:	rinity'")
                .HasColumnName("patharquivos");
            entity.Property(e => e.Pdvcodigobarras)
                .HasMaxLength(1)
                .HasColumnName("pdvcodigobarras");
            entity.Property(e => e.Pedidoclientelivre)
                .HasMaxLength(1)
                .HasColumnName("pedidoclientelivre");
            entity.Property(e => e.Pendenciafinanceira)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("pendenciafinanceira");
            entity.Property(e => e.Pendenciafinanceirasenha)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("pendenciafinanceirasenha");
            entity.Property(e => e.Planocontasobrigatorio)
                .HasMaxLength(1)
                .HasColumnName("planocontasobrigatorio");
            entity.Property(e => e.Prazocabecalhopedido)
                .HasMaxLength(1)
                .HasColumnName("prazocabecalhopedido");
            entity.Property(e => e.Preco2navenda)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'")
                .HasColumnName("preco2navenda");
            entity.Property(e => e.Precocustovenda)
                .HasMaxLength(1)
                .HasColumnName("precocustovenda");
            entity.Property(e => e.Previsualizarpv)
                .HasMaxLength(5)
                .HasColumnName("previsualizarpv");
            entity.Property(e => e.Previsualizarpvms)
                .HasMaxLength(5)
                .HasColumnName("previsualizarpvms");
            entity.Property(e => e.Previsualizarvd)
                .HasMaxLength(5)
                .HasColumnName("previsualizarvd");
            entity.Property(e => e.Previsualizarvdmp)
                .HasMaxLength(5)
                .HasColumnName("previsualizarvdmp");
            entity.Property(e => e.Produtoautomatico)
                .HasMaxLength(1)
                .HasDefaultValueSql("'1'")
                .HasComment("0-Codigo do produto manual; 1- Codigo do produto automatico")
                .HasColumnName("produtoautomatico");
            entity.Property(e => e.Rankingcomissaovenda)
                .HasMaxLength(3)
                .HasColumnName("rankingcomissaovenda");
            entity.Property(e => e.Separafrete)
                .HasMaxLength(5)
                .HasColumnName("separafrete");
            entity.Property(e => e.Separarimposto)
                .HasMaxLength(1)
                .HasColumnName("separarimposto");
            entity.Property(e => e.Sequencialetiqueta)
                .HasMaxLength(10)
                .HasColumnName("sequencialetiqueta");
            entity.Property(e => e.Supervisor)
                .HasMaxLength(5)
                .HasColumnName("supervisor");
            entity.Property(e => e.Tabelacomissao)
                .HasMaxLength(5)
                .HasColumnName("tabelacomissao");
            entity.Property(e => e.Telamodeloos)
                .HasMaxLength(2)
                .HasColumnName("telamodeloos");
            entity.Property(e => e.Tempobackup)
                .HasMaxLength(15)
                .HasColumnName("tempobackup");
            entity.Property(e => e.Tokenversao)
                .HasMaxLength(500)
                .HasColumnName("tokenversao");
            entity.Property(e => e.Utilizargrade)
                .HasMaxLength(5)
                .HasColumnName("utilizargrade");
            entity.Property(e => e.Utilizarlimitecliente)
                .HasMaxLength(5)
                .HasDefaultValueSql("'0'")
                .HasColumnName("utilizarlimitecliente");
            entity.Property(e => e.Utilizarpaf)
                .HasMaxLength(1)
                .HasColumnName("utilizarpaf");
            entity.Property(e => e.Validacnpj)
                .HasMaxLength(1)
                .HasDefaultValueSql("'1'")
                .HasColumnName("validacnpj");
            entity.Property(e => e.Vendedorobservacao)
                .HasMaxLength(1)
                .HasColumnName("vendedorobservacao");
            entity.Property(e => e.Visualizarestoqueav)
                .HasMaxLength(1)
                .HasColumnName("visualizarestoqueav");
            entity.Property(e => e.Volumeigualproduto)
                .HasMaxLength(6)
                .HasDefaultValueSql("'False'")
                .HasComment("Volume do transportador igual ao total dos volumes dos produtos.")
                .HasColumnName("volumeigualproduto");
            entity.Property(e => e.Volumepedidovenda)
                .HasMaxLength(5)
                .HasColumnName("volumepedidovenda");
        });

        modelBuilder.Entity<Peca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("peca");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(25)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Pedidocompra>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("pedidocompra");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(10, 4)
                .HasColumnName("acrescimo");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(25)
                .HasColumnName("auditoria");
            entity.Property(e => e.Bcicms)
                .HasPrecision(10, 4)
                .HasColumnName("bcicms");
            entity.Property(e => e.Bcipi)
                .HasPrecision(10, 4)
                .HasColumnName("bcipi");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(10)
                .HasColumnName("cancelado");
            entity.Property(e => e.Centrocusto)
                .HasMaxLength(50)
                .HasColumnName("centrocusto");
            entity.Property(e => e.Cfop)
                .HasMaxLength(50)
                .HasColumnName("cfop");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Codigocentro)
                .HasMaxLength(50)
                .HasColumnName("codigocentro");
            entity.Property(e => e.Codigocusto)
                .HasMaxLength(10)
                .HasColumnName("codigocusto");
            entity.Property(e => e.Codigotransportadora)
                .HasMaxLength(5)
                .HasColumnName("codigotransportadora");
            entity.Property(e => e.Cotacao)
                .HasMaxLength(5)
                .HasColumnName("cotacao");
            entity.Property(e => e.Desconto)
                .HasPrecision(10, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Descricaocfop)
                .HasMaxLength(50)
                .HasColumnName("descricaocfop");
            entity.Property(e => e.Descricaoplano)
                .HasMaxLength(30)
                .HasColumnName("descricaoplano");
            entity.Property(e => e.Descricaorecebimento)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe\n")
                .HasColumnName("descricaorecebimento");
            entity.Property(e => e.Devolucao)
                .HasMaxLength(5)
                .HasColumnName("devolucao");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
            entity.Property(e => e.Entrega)
                .HasMaxLength(10)
                .HasColumnName("entrega");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(150)
                .HasColumnName("fantasia");
            entity.Property(e => e.Faturado)
                .HasMaxLength(1)
                .HasColumnName("faturado");
            entity.Property(e => e.Faturamento)
                .HasColumnType("datetime")
                .HasColumnName("faturamento");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(5)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Frete)
                .HasMaxLength(3)
                .HasColumnName("frete");
            entity.Property(e => e.Fretevalor)
                .HasPrecision(10, 4)
                .HasColumnName("fretevalor");
            entity.Property(e => e.Icms)
                .HasPrecision(10, 4)
                .HasColumnName("icms");
            entity.Property(e => e.Icmssubst)
                .HasPrecision(10, 4)
                .HasColumnName("icmssubst");
            entity.Property(e => e.Ipi)
                .HasPrecision(10, 4)
                .HasColumnName("ipi");
            entity.Property(e => e.Liberado)
                .HasMaxLength(5)
                .HasColumnName("liberado");
            entity.Property(e => e.Nomeusuario)
                .HasMaxLength(20)
                .HasColumnName("nomeusuario");
            entity.Property(e => e.Numeroparcelas)
                .HasColumnType("int(11)")
                .HasColumnName("numeroparcelas");
            entity.Property(e => e.Observacao)
                .HasMaxLength(2000)
                .HasColumnName("observacao");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(20)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(20)
                .HasColumnName("planocontas");
            entity.Property(e => e.Prazoentrega)
                .HasMaxLength(20)
                .HasColumnName("prazoentrega");
            entity.Property(e => e.Qtdparcelas)
                .HasColumnType("int(11)")
                .HasColumnName("qtdparcelas");
            entity.Property(e => e.Razao)
                .HasMaxLength(150)
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(3)
                .HasColumnName("recebimento");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Total)
                .HasPrecision(10, 4)
                .HasColumnName("total");
            entity.Property(e => e.Totalprodutos)
                .HasPrecision(10, 4)
                .HasColumnName("totalprodutos");
            entity.Property(e => e.Transportadora)
                .HasMaxLength(100)
                .HasColumnName("transportadora");
            entity.Property(e => e.Usuario)
                .HasMaxLength(4)
                .HasColumnName("usuario");
            entity.Property(e => e.Valoricms)
                .HasPrecision(10, 4)
                .HasColumnName("valoricms");
            entity.Property(e => e.Valoripi)
                .HasPrecision(10, 4)
                .HasColumnName("valoripi");
            entity.Property(e => e.Valorsubtrib)
                .HasPrecision(10, 4)
                .HasColumnName("valorsubtrib");
        });

        modelBuilder.Entity<Pedidocompramovimento>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("pedidocompramovimento");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Atendido)
                .HasPrecision(10, 4)
                .HasColumnName("atendido");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(25)
                .HasColumnName("auditoria");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasColumnName("cancelado");
            entity.Property(e => e.Cf)
                .HasMaxLength(8)
                .HasColumnName("cf");
            entity.Property(e => e.Cfop)
                .HasMaxLength(8)
                .HasColumnName("cfop");
            entity.Property(e => e.Cliente)
                .HasMaxLength(5)
                .HasColumnName("cliente");
            entity.Property(e => e.Comissvendedor)
                .HasPrecision(10, 4)
                .HasColumnName("comissvendedor");
            entity.Property(e => e.Comissvendedor2)
                .HasPrecision(10, 4)
                .HasColumnName("comissvendedor2");
            entity.Property(e => e.Custo)
                .HasPrecision(10, 4)
                .HasColumnName("custo");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Desconto)
                .HasPrecision(10, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(10000)
                .HasColumnName("descricao");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(6)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Grupo)
                .HasMaxLength(10)
                .HasColumnName("grupo");
            entity.Property(e => e.Historico)
                .HasMaxLength(150)
                .HasColumnName("historico");
            entity.Property(e => e.Hora)
                .HasPrecision(10, 4)
                .HasColumnName("hora");
            entity.Property(e => e.Icms)
                .HasPrecision(10, 4)
                .HasColumnName("icms");
            entity.Property(e => e.Ipi)
                .HasPrecision(10, 4)
                .HasColumnName("ipi");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .HasColumnName("lote");
            entity.Property(e => e.Movimentaestoque)
                .HasMaxLength(5)
                .HasColumnName("movimentaestoque");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.Nomeusuario)
                .HasMaxLength(25)
                .HasColumnName("nomeusuario");
            entity.Property(e => e.Nomevendedor)
                .HasMaxLength(30)
                .HasColumnName("nomevendedor");
            entity.Property(e => e.Nomevendedor2)
                .HasMaxLength(25)
                .HasColumnName("nomevendedor2");
            entity.Property(e => e.Observacao)
                .HasMaxLength(30)
                .HasColumnName("observacao");
            entity.Property(e => e.Preco)
                .HasPrecision(10, 4)
                .HasColumnName("preco");
            entity.Property(e => e.Produto)
                .HasMaxLength(15)
                .HasColumnName("produto");
            entity.Property(e => e.Qtdvolume)
                .HasPrecision(10, 4)
                .HasColumnName("qtdvolume");
            entity.Property(e => e.Quantidade)
                .HasPrecision(10, 4)
                .HasColumnName("quantidade");
            entity.Property(e => e.Reducaobase)
                .HasPrecision(10, 4)
                .HasColumnName("reducaobase");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .HasColumnName("referencia");
            entity.Property(e => e.Registro)
                .HasColumnType("int(11)")
                .HasColumnName("registro");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(20)
                .HasColumnName("responsavel");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.St)
                .HasMaxLength(4)
                .HasColumnName("st");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("tipo");
            entity.Property(e => e.Total)
                .HasPrecision(18, 4)
                .HasColumnName("total");
            entity.Property(e => e.Unidade)
                .HasMaxLength(10)
                .HasColumnName("unidade");
            entity.Property(e => e.Upreco)
                .HasPrecision(10, 4)
                .HasColumnName("upreco");
            entity.Property(e => e.Valoricms)
                .HasPrecision(10, 4)
                .HasColumnName("valoricms");
            entity.Property(e => e.Valoripi)
                .HasPrecision(10, 4)
                .HasColumnName("valoripi");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(3)
                .HasColumnName("vendedor");
            entity.Property(e => e.Vendedor2)
                .HasMaxLength(2)
                .HasColumnName("vendedor2");
        });

        modelBuilder.Entity<Pedidomovimentograde>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pedidomovimentograde");

            entity.Property(e => e.Id)
                .HasComment("campo chave primária de controle auto-incrementada")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Arquivo)
                .HasMaxLength(50)
                .HasColumnName("arquivo");
            entity.Property(e => e.Artigo)
                .HasMaxLength(100)
                .HasColumnName("artigo");
            entity.Property(e => e.Eg)
                .HasComment("campo de tamanho na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("eg");
            entity.Property(e => e.Fita)
                .HasMaxLength(50)
                .HasComment("campo guarda fita utilizada no pedido")
                .HasColumnName("fita");
            entity.Property(e => e.G)
                .HasComment("campo de tamanho na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g");
            entity.Property(e => e.G1)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g1");
            entity.Property(e => e.G10)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g10");
            entity.Property(e => e.G12)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g12");
            entity.Property(e => e.G14)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g14");
            entity.Property(e => e.G2)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g2");
            entity.Property(e => e.G28)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g28");
            entity.Property(e => e.G29)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g29");
            entity.Property(e => e.G3)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g3");
            entity.Property(e => e.G30)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g30");
            entity.Property(e => e.G31)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g31");
            entity.Property(e => e.G32)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g32");
            entity.Property(e => e.G33)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g33");
            entity.Property(e => e.G34)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g34");
            entity.Property(e => e.G35)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g35");
            entity.Property(e => e.G36)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g36");
            entity.Property(e => e.G37)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g37");
            entity.Property(e => e.G38)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g38");
            entity.Property(e => e.G39)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g39");
            entity.Property(e => e.G3g)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g3g");
            entity.Property(e => e.G4)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g4");
            entity.Property(e => e.G40)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g40");
            entity.Property(e => e.G41)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g41");
            entity.Property(e => e.G42)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g42");
            entity.Property(e => e.G43)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g43");
            entity.Property(e => e.G44)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g44");
            entity.Property(e => e.G45)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g45");
            entity.Property(e => e.G46)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g46");
            entity.Property(e => e.G5)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g5");
            entity.Property(e => e.G6)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g6");
            entity.Property(e => e.G7)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g7");
            entity.Property(e => e.G8)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("g8");
            entity.Property(e => e.Gg)
                .HasComment("campo de tamanho na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("gg");
            entity.Property(e => e.Gg1)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("gg1");
            entity.Property(e => e.Gg2)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("gg2");
            entity.Property(e => e.Gg3)
                .HasComment("campo de tamanho e número na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("gg3");
            entity.Property(e => e.Iditempedido)
                .HasComment("campo guarda id do registro vinculado em pedidovendamovimento")
                .HasColumnType("int(11)")
                .HasColumnName("iditempedido");
            entity.Property(e => e.Logo)
                .HasMaxLength(500)
                .HasColumnName("logo");
            entity.Property(e => e.M)
                .HasComment("campo de tamanho na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("m");
            entity.Property(e => e.Modeloroupa)
                .HasMaxLength(50)
                .HasColumnName("modeloroupa");
            entity.Property(e => e.P)
                .HasComment("campo de tamanho na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("p");
            entity.Property(e => e.Pp)
                .HasComment("campo de tamanho  na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("pp");
            entity.Property(e => e.Tecido)
                .HasMaxLength(50)
                .HasComment("campo guarda tecido utilizada no pedido")
                .HasColumnName("tecido");
            entity.Property(e => e.U)
                .HasComment("campo de tamanho na grade de produtos")
                .HasColumnType("int(11)")
                .HasColumnName("u");
        });

        modelBuilder.Entity<Pedidovendadetalhebordado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pedidovendadetalhebordado");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasMaxLength(12)
                .HasColumnName("documento");
            entity.Property(e => e.Local)
                .HasMaxLength(50)
                .HasColumnName("local");
            entity.Property(e => e.Peca)
                .HasMaxLength(15)
                .HasColumnName("peca");
            entity.Property(e => e.Produto)
                .HasMaxLength(8)
                .HasColumnName("produto");
            entity.Property(e => e.Registro)
                .HasMaxLength(5)
                .HasColumnName("registro");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .HasColumnName("tipo");
            entity.Property(e => e.Tp)
                .HasMaxLength(15)
                .HasColumnName("tp");
        });

        modelBuilder.Entity<Pedidovendamovimento>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("pedidovendamovimento");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(18, 2)
                .HasComment("Valor de acréscimo por produto no pedido de venda")
                .HasColumnName("acrescimo");
            entity.Property(e => e.Aliquota)
                .HasMaxLength(50)
                .HasColumnName("aliquota");
            entity.Property(e => e.Arquivo)
                .HasMaxLength(50)
                .HasColumnName("arquivo");
            entity.Property(e => e.Artigo)
                .HasMaxLength(100)
                .HasColumnName("artigo");
            entity.Property(e => e.Atendido)
                .HasPrecision(10, 4)
                .HasColumnName("atendido");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(50)
                .HasColumnName("auditoria");
            entity.Property(e => e.Bcicms)
                .HasPrecision(18, 4)
                .HasColumnName("bcicms");
            entity.Property(e => e.Bcipi)
                .HasPrecision(18, 4)
                .HasColumnName("bcipi");
            entity.Property(e => e.Bicms)
                .HasPrecision(18, 4)
                .HasColumnName("bicms");
            entity.Property(e => e.Campo1)
                .HasMaxLength(50)
                .HasColumnName("campo1");
            entity.Property(e => e.Campo2)
                .HasMaxLength(50)
                .HasColumnName("campo2");
            entity.Property(e => e.Campo3)
                .HasMaxLength(50)
                .HasColumnName("campo3");
            entity.Property(e => e.Campo4)
                .HasMaxLength(50)
                .HasColumnName("campo4");
            entity.Property(e => e.Campo5)
                .HasMaxLength(100)
                .HasColumnName("campo5");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasColumnName("cancelado");
            entity.Property(e => e.Categoria)
                .HasMaxLength(100)
                .HasColumnName("categoria");
            entity.Property(e => e.Cbarra)
                .HasMaxLength(50)
                .HasColumnName("cbarra");
            entity.Property(e => e.Cf)
                .HasMaxLength(10)
                .HasColumnName("cf");
            entity.Property(e => e.Cfop)
                .HasMaxLength(8)
                .HasColumnName("cfop");
            entity.Property(e => e.Cliente)
                .HasMaxLength(10)
                .HasColumnName("cliente");
            entity.Property(e => e.Codigofornecedor)
                .HasMaxLength(5)
                .HasColumnName("codigofornecedor");
            entity.Property(e => e.Cofinsst)
                .HasMaxLength(2)
                .HasComment("ST do Cofins por produto no pedido de venda")
                .HasColumnName("cofinsst");
            entity.Property(e => e.Comissao)
                .HasPrecision(10, 4)
                .HasColumnName("comissao");
            entity.Property(e => e.Comissvendedor)
                .HasPrecision(10, 4)
                .HasColumnName("comissvendedor");
            entity.Property(e => e.Comissvendedor2)
                .HasPrecision(10, 4)
                .HasColumnName("comissvendedor2");
            entity.Property(e => e.Cor)
                .HasMaxLength(25)
                .HasColumnName("cor");
            entity.Property(e => e.Cotacao)
                .HasMaxLength(5)
                .HasColumnName("cotacao");
            entity.Property(e => e.Creditoicms)
                .HasPrecision(10, 4)
                .HasColumnName("creditoicms");
            entity.Property(e => e.Custo)
                .HasPrecision(10, 4)
                .HasColumnName("custo");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Desconto)
                .HasPrecision(10, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("descricao");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.Eg)
                .HasColumnType("int(11)")
                .HasColumnName("eg");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
            entity.Property(e => e.Entrega)
                .HasColumnType("datetime")
                .HasColumnName("entrega");
            entity.Property(e => e.Fabricacao)
                .HasColumnType("datetime")
                .HasColumnName("fabricacao");
            entity.Property(e => e.Fantasiafornecedor)
                .HasMaxLength(100)
                .HasColumnName("fantasiafornecedor");
            entity.Property(e => e.Fator)
                .HasPrecision(10, 4)
                .HasColumnName("fator");
            entity.Property(e => e.Fichatecnica)
                .HasMaxLength(10)
                .HasColumnName("fichatecnica");
            entity.Property(e => e.Fita)
                .HasMaxLength(50)
                .HasColumnName("fita");
            entity.Property(e => e.Freteproduto)
                .HasPrecision(10, 4)
                .HasColumnName("freteproduto");
            entity.Property(e => e.G)
                .HasColumnType("int(11)")
                .HasColumnName("g");
            entity.Property(e => e.G1)
                .HasPrecision(10, 4)
                .HasColumnName("g1");
            entity.Property(e => e.G10)
                .HasPrecision(10, 4)
                .HasColumnName("g10");
            entity.Property(e => e.G12)
                .HasPrecision(10, 4)
                .HasColumnName("g12");
            entity.Property(e => e.G14)
                .HasPrecision(10, 4)
                .HasColumnName("g14");
            entity.Property(e => e.G2)
                .HasPrecision(10, 4)
                .HasColumnName("g2");
            entity.Property(e => e.G28)
                .HasColumnType("int(11)")
                .HasColumnName("g28");
            entity.Property(e => e.G29)
                .HasColumnType("int(11)")
                .HasColumnName("g29");
            entity.Property(e => e.G3)
                .HasPrecision(10, 4)
                .HasColumnName("g3");
            entity.Property(e => e.G30)
                .HasColumnType("int(11)")
                .HasColumnName("g30");
            entity.Property(e => e.G31)
                .HasColumnType("int(11)")
                .HasColumnName("g31");
            entity.Property(e => e.G32)
                .HasColumnType("int(11)")
                .HasColumnName("g32");
            entity.Property(e => e.G33)
                .HasColumnType("int(11)")
                .HasColumnName("g33");
            entity.Property(e => e.G34)
                .HasColumnType("int(11)")
                .HasColumnName("g34");
            entity.Property(e => e.G35)
                .HasColumnType("int(11)")
                .HasColumnName("g35");
            entity.Property(e => e.G36)
                .HasColumnType("int(11)")
                .HasColumnName("g36");
            entity.Property(e => e.G37)
                .HasColumnType("int(11)")
                .HasColumnName("g37");
            entity.Property(e => e.G38)
                .HasColumnType("int(11)")
                .HasColumnName("g38");
            entity.Property(e => e.G39)
                .HasColumnType("int(11)")
                .HasColumnName("g39");
            entity.Property(e => e.G3G)
                .HasColumnType("int(11)")
                .HasColumnName("g3G");
            entity.Property(e => e.G4)
                .HasPrecision(10, 4)
                .HasColumnName("g4");
            entity.Property(e => e.G40)
                .HasColumnType("int(11)")
                .HasColumnName("g40");
            entity.Property(e => e.G41)
                .HasColumnType("int(11)")
                .HasColumnName("g41");
            entity.Property(e => e.G42)
                .HasColumnType("int(11)")
                .HasColumnName("g42");
            entity.Property(e => e.G43)
                .HasColumnType("int(11)")
                .HasColumnName("g43");
            entity.Property(e => e.G44)
                .HasColumnType("int(11)")
                .HasColumnName("g44");
            entity.Property(e => e.G45)
                .HasColumnType("int(11)")
                .HasColumnName("g45");
            entity.Property(e => e.G46)
                .HasColumnType("int(11)")
                .HasColumnName("g46");
            entity.Property(e => e.G5)
                .HasPrecision(10, 4)
                .HasColumnName("g5");
            entity.Property(e => e.G6)
                .HasPrecision(10, 4)
                .HasColumnName("g6");
            entity.Property(e => e.G7)
                .HasPrecision(10, 4)
                .HasColumnName("g7");
            entity.Property(e => e.G8)
                .HasPrecision(10, 4)
                .HasColumnName("g8");
            entity.Property(e => e.Gg)
                .HasColumnType("int(11)")
                .HasColumnName("gg");
            entity.Property(e => e.Gg1)
                .HasPrecision(10, 4)
                .HasColumnName("gg1");
            entity.Property(e => e.Gg2)
                .HasPrecision(10, 4)
                .HasColumnName("gg2");
            entity.Property(e => e.Gg3)
                .HasPrecision(10, 4)
                .HasColumnName("gg3");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .HasColumnName("grupo");
            entity.Property(e => e.Historico)
                .HasMaxLength(100)
                .HasColumnName("historico");
            entity.Property(e => e.Hora)
                .HasPrecision(10, 4)
                .HasColumnName("hora");
            entity.Property(e => e.Icms)
                .HasPrecision(10, 4)
                .HasColumnName("icms");
            entity.Property(e => e.Ipi)
                .HasPrecision(10, 4)
                .HasColumnName("ipi");
            entity.Property(e => e.Itemagrupador)
                .HasMaxLength(10)
                .HasColumnName("itemagrupador");
            entity.Property(e => e.Logo)
                .HasMaxLength(500)
                .HasColumnName("logo");
            entity.Property(e => e.Logomarca)
                .HasMaxLength(100)
                .HasColumnName("logomarca");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .HasColumnName("lote");
            entity.Property(e => e.M)
                .HasColumnType("int(11)")
                .HasColumnName("m");
            entity.Property(e => e.Matriz)
                .HasMaxLength(5)
                .HasColumnName("matriz");
            entity.Property(e => e.Modbcicms)
                .HasMaxLength(1)
                .HasComment("Modbc ICMS por produto no item do pedido de venda")
                .HasColumnName("modbcicms");
            entity.Property(e => e.Modbcicmsst)
                .HasMaxLength(1)
                .HasComment("Modbcst ICMS ST por produto no item do pedido de venda")
                .HasColumnName("modbcicmsst");
            entity.Property(e => e.Modelo)
                .HasMaxLength(25)
                .HasColumnName("modelo");
            entity.Property(e => e.Modeloroupa)
                .HasMaxLength(50)
                .HasColumnName("modeloroupa");
            entity.Property(e => e.Movimentaestoque)
                .HasMaxLength(10)
                .HasColumnName("movimentaestoque");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome");
            entity.Property(e => e.Nomeusuario)
                .HasMaxLength(50)
                .HasColumnName("nomeusuario");
            entity.Property(e => e.Nomevendedor)
                .HasMaxLength(50)
                .HasColumnName("nomevendedor");
            entity.Property(e => e.Nomevendedor2)
                .HasMaxLength(50)
                .HasColumnName("nomevendedor2");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .HasColumnName("observacao");
            entity.Property(e => e.Observacao2)
                .HasMaxLength(500)
                .HasColumnName("observacao2");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(50)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.P)
                .HasColumnType("int(11)")
                .HasColumnName("p");
            entity.Property(e => e.Pbruto)
                .HasPrecision(10, 4)
                .HasColumnName("pbruto");
            entity.Property(e => e.Pcofins)
                .HasPrecision(18, 2)
                .HasComment("Percentual do Cofins por produto no pedido de venda")
                .HasColumnName("pcofins");
            entity.Property(e => e.Pisst)
                .HasMaxLength(2)
                .HasComment("ST do Pis por produto no pedido de venda")
                .HasColumnName("pisst");
            entity.Property(e => e.Pliquido)
                .HasPrecision(10, 4)
                .HasColumnName("pliquido");
            entity.Property(e => e.Pp)
                .HasPrecision(10, 4)
                .HasColumnName("pp");
            entity.Property(e => e.Ppis)
                .HasPrecision(18, 2)
                .HasComment("Percentual do Pis por produto no pedido de venda")
                .HasColumnName("ppis");
            entity.Property(e => e.Preco)
                .HasPrecision(10, 4)
                .HasColumnName("preco");
            entity.Property(e => e.Precon)
                .HasPrecision(10, 4)
                .HasColumnName("precon");
            entity.Property(e => e.Precooriginal)
                .HasPrecision(10, 4)
                .HasColumnName("precooriginal");
            entity.Property(e => e.Precopauta)
                .HasPrecision(10, 4)
                .HasColumnName("precopauta");
            entity.Property(e => e.Produto)
                .HasMaxLength(20)
                .HasColumnName("produto");
            entity.Property(e => e.Produtoficha)
                .HasMaxLength(20)
                .HasColumnName("produtoficha");
            entity.Property(e => e.Qtdvolume)
                .HasPrecision(10, 4)
                .HasColumnName("qtdvolume");
            entity.Property(e => e.Quantidade)
                .HasPrecision(10, 4)
                .HasColumnName("quantidade");
            entity.Property(e => e.Reducaobase)
                .HasPrecision(10, 4)
                .HasColumnName("reducaobase");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.Registro)
                .HasMaxLength(15)
                .HasComment("Campo destinado tanto a guarda do número sequencial do pedido quanto do nitemped, quando necessário")
                .HasColumnName("registro");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.St)
                .HasMaxLength(5)
                .HasColumnName("st");
            entity.Property(e => e.Tecido)
                .HasMaxLength(50)
                .HasColumnName("tecido");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("tipo");
            entity.Property(e => e.Total)
                .HasPrecision(18, 4)
                .HasColumnName("total");
            entity.Property(e => e.U)
                .HasColumnType("int(11)")
                .HasColumnName("u");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.Unidade)
                .HasMaxLength(10)
                .HasColumnName("unidade");
            entity.Property(e => e.Vale)
                .HasMaxLength(5)
                .HasColumnName("vale");
            entity.Property(e => e.Validade)
                .HasColumnType("datetime")
                .HasColumnName("validade");
            entity.Property(e => e.Valoricms)
                .HasPrecision(10, 4)
                .HasColumnName("valoricms");
            entity.Property(e => e.Valoripi)
                .HasPrecision(10, 4)
                .HasColumnName("valoripi");
            entity.Property(e => e.Vcofins)
                .HasPrecision(18, 2)
                .HasComment("Valor de Cofins por produto no pedido de venda")
                .HasColumnName("vcofins");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(5)
                .HasColumnName("vendedor");
            entity.Property(e => e.Vendedor2)
                .HasMaxLength(5)
                .HasColumnName("vendedor2");
            entity.Property(e => e.Vpis)
                .HasPrecision(18, 2)
                .HasComment("Valor de Pis por produto no pedido de venda")
                .HasColumnName("vpis");
        });

        modelBuilder.Entity<Pedidovendum>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("pedidovenda");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(10, 4)
                .HasColumnName("acrescimo");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(25)
                .HasColumnName("auditoria");
            entity.Property(e => e.Bcicms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("bcicms");
            entity.Property(e => e.Bcipi)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("bcipi");
            entity.Property(e => e.Cancelado)
                .HasColumnType("datetime")
                .HasColumnName("cancelado");
            entity.Property(e => e.Categoria)
                .HasMaxLength(100)
                .HasColumnName("categoria");
            entity.Property(e => e.Centrocusto)
                .HasMaxLength(50)
                .HasColumnName("centrocusto");
            entity.Property(e => e.Cfop)
                .HasMaxLength(50)
                .HasColumnName("cfop");
            entity.Property(e => e.Cliente)
                .HasMaxLength(10)
                .HasColumnName("cliente");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Codigoauxiliar)
                .HasMaxLength(50)
                .HasColumnName("codigoauxiliar");
            entity.Property(e => e.Codigocusto)
                .HasMaxLength(10)
                .HasColumnName("codigocusto");
            entity.Property(e => e.Codigoendereco)
                .HasColumnType("int(11)")
                .HasColumnName("codigoendereco");
            entity.Property(e => e.Codigofornecedor)
                .HasMaxLength(5)
                .HasColumnName("codigofornecedor");
            entity.Property(e => e.Codigotransportadora)
                .HasMaxLength(5)
                .HasColumnName("codigotransportadora");
            entity.Property(e => e.Comissao1)
                .HasPrecision(10, 4)
                .HasColumnName("comissao1");
            entity.Property(e => e.Comissao2)
                .HasPrecision(10, 4)
                .HasColumnName("comissao2");
            entity.Property(e => e.Comissaorepresentante)
                .HasPrecision(10, 4)
                .HasColumnName("comissaorepresentante");
            entity.Property(e => e.Contato)
                .HasMaxLength(100)
                .HasColumnName("contato");
            entity.Property(e => e.Contrato)
                .HasMaxLength(100)
                .HasColumnName("contrato");
            entity.Property(e => e.Cotacao)
                .HasMaxLength(5)
                .HasColumnName("cotacao");
            entity.Property(e => e.Desconto)
                .HasPrecision(10, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Descricaocfop)
                .HasMaxLength(255)
                .HasColumnName("descricaocfop");
            entity.Property(e => e.Descricaoplano)
                .HasMaxLength(30)
                .HasColumnName("descricaoplano");
            entity.Property(e => e.Descricaorecebimento)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe\n")
                .HasColumnName("descricaorecebimento");
            entity.Property(e => e.Despesa)
                .HasPrecision(10, 4)
                .HasColumnName("despesa");
            entity.Property(e => e.Devolucao)
                .HasMaxLength(5)
                .HasColumnName("devolucao");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .HasColumnName("endereco");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(80)
                .HasColumnName("fantasia");
            entity.Property(e => e.Fantasiafornecedor)
                .HasMaxLength(50)
                .HasColumnName("fantasiafornecedor");
            entity.Property(e => e.Faturamento)
                .HasColumnType("datetime")
                .HasColumnName("faturamento");
            entity.Property(e => e.Faturamentominimo)
                .HasMaxLength(50)
                .HasColumnName("faturamentominimo");
            entity.Property(e => e.Fone)
                .HasMaxLength(30)
                .HasColumnName("fone");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(50)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Frete)
                .HasMaxLength(10)
                .HasColumnName("frete");
            entity.Property(e => e.Fretevalor)
                .HasPrecision(10, 4)
                .HasColumnName("fretevalor");
            entity.Property(e => e.Garantia)
                .HasMaxLength(5)
                .HasColumnName("garantia");
            entity.Property(e => e.Icms)
                .HasPrecision(10, 4)
                .HasColumnName("icms");
            entity.Property(e => e.Icmssubst)
                .HasPrecision(10, 4)
                .HasColumnName("icmssubst");
            entity.Property(e => e.Impostos)
                .HasMaxLength(20)
                .HasColumnName("impostos");
            entity.Property(e => e.Ipi)
                .HasPrecision(10, 4)
                .HasColumnName("ipi");
            entity.Property(e => e.Mododesconto)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .HasColumnName("mododesconto");
            entity.Property(e => e.Nomeusuario)
                .HasMaxLength(20)
                .HasColumnName("nomeusuario");
            entity.Property(e => e.Nomevendedor1)
                .HasMaxLength(50)
                .HasColumnName("nomevendedor1");
            entity.Property(e => e.Nomevendedor2)
                .HasMaxLength(50)
                .HasColumnName("nomevendedor2");
            entity.Property(e => e.Numeroparcelas)
                .HasColumnType("int(11)")
                .HasColumnName("numeroparcelas");
            entity.Property(e => e.Observacao)
                .HasMaxLength(10000)
                .HasColumnName("observacao");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(20)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.Pbruto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("pbruto");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .HasColumnName("placa");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(20)
                .HasColumnName("planocontas");
            entity.Property(e => e.Pliquido)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("pliquido");
            entity.Property(e => e.Qtdparcelas)
                .HasColumnType("int(11)")
                .HasColumnName("qtdparcelas");
            entity.Property(e => e.Razao)
                .HasMaxLength(80)
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(3)
                .HasColumnName("recebimento");
            entity.Property(e => e.Revisao)
                .HasColumnType("int(11)")
                .HasColumnName("revisao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasColumnName("situacao");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipodesconto)
                .HasMaxLength(2)
                .HasColumnName("tipodesconto");
            entity.Property(e => e.Total)
                .HasPrecision(10, 4)
                .HasColumnName("total");
            entity.Property(e => e.Totalproduto)
                .HasPrecision(10, 4)
                .HasColumnName("totalproduto");
            entity.Property(e => e.Transportadora)
                .HasMaxLength(100)
                .HasColumnName("transportadora");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.Ufplaca)
                .HasMaxLength(2)
                .HasColumnName("ufplaca");
            entity.Property(e => e.Usuario)
                .HasMaxLength(4)
                .HasColumnName("usuario");
            entity.Property(e => e.Vale)
                .HasMaxLength(5)
                .HasColumnName("vale");
            entity.Property(e => e.Validade)
                .HasMaxLength(5)
                .HasColumnName("validade");
            entity.Property(e => e.Valorcomissaorepresentante)
                .HasPrecision(10, 4)
                .HasColumnName("valorcomissaorepresentante");
            entity.Property(e => e.Vbcst)
                .HasPrecision(18, 2)
                .HasComment("Valor da base de cálculo do ICMS ST no pedido de venda")
                .HasColumnName("vbcst");
            entity.Property(e => e.Vcofins)
                .HasPrecision(18, 2)
                .HasComment("Valor do COFINS no pedido de venda")
                .HasColumnName("vcofins");
            entity.Property(e => e.Vendedor1)
                .HasMaxLength(5)
                .HasColumnName("vendedor1");
            entity.Property(e => e.Vendedor2)
                .HasMaxLength(5)
                .HasColumnName("vendedor2");
            entity.Property(e => e.Vicms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("vicms");
            entity.Property(e => e.Vicmsst)
                .HasPrecision(18, 2)
                .HasComment("Valor do ICMS ST no pedido de venda")
                .HasColumnName("vicmsst");
            entity.Property(e => e.Vipi)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("vipi");
            entity.Property(e => e.Vpis)
                .HasPrecision(18, 2)
                .HasComment("Valor do PIS no pedido de venda")
                .HasColumnName("vpis");
        });

        modelBuilder.Entity<Placa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("placas");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Placa1)
                .HasMaxLength(10)
                .HasColumnName("placa");
            entity.Property(e => e.Transportadora)
                .HasMaxLength(5)
                .HasColumnName("transportadora");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Planoconta>(entity =>
        {
            entity.HasKey(e => e.Codigoresumido).HasName("PRIMARY");

            entity.ToTable("planocontas");

            entity.Property(e => e.Codigoresumido)
                .HasColumnType("int(11)")
                .HasColumnName("codigoresumido");
            entity.Property(e => e.Centrocusto)
                .HasMaxLength(50)
                .HasColumnName("centrocusto");
            entity.Property(e => e.Codigocentrocusto)
                .HasMaxLength(5)
                .HasColumnName("codigocentrocusto");
            entity.Property(e => e.Codigocontabil)
                .HasMaxLength(50)
                .HasColumnName("codigocontabil");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Despesa)
                .HasMaxLength(5)
                .HasColumnName("despesa");
            entity.Property(e => e.Movimento)
                .HasMaxLength(5)
                .HasColumnName("movimento");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Precoespecialcliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("precoespecialcliente");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cliente)
                .HasMaxLength(50)
                .HasColumnName("cliente");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
            entity.Property(e => e.Produto)
                .HasMaxLength(40)
                .HasColumnName("produto");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Producao>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("producao");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cancelado)
                .HasColumnType("datetime")
                .HasColumnName("cancelado");
            entity.Property(e => e.Cristalizacao)
                .HasMaxLength(10)
                .HasColumnName("cristalizacao");
            entity.Property(e => e.Datafim)
                .HasColumnType("datetime")
                .HasColumnName("datafim");
            entity.Property(e => e.Datainicio)
                .HasColumnType("datetime")
                .HasColumnName("datainicio");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Espessura)
                .HasMaxLength(50)
                .HasColumnName("espessura");
            entity.Property(e => e.Horafim)
                .HasMaxLength(50)
                .HasColumnName("horafim");
            entity.Property(e => e.Horainicio)
                .HasMaxLength(10)
                .HasColumnName("horainicio");
            entity.Property(e => e.Horaintervalo)
                .HasMaxLength(50)
                .HasColumnName("horaintervalo");
            entity.Property(e => e.Idturma)
                .HasColumnType("int(11)")
                .HasColumnName("idturma");
            entity.Property(e => e.Liberado)
                .HasMaxLength(5)
                .HasColumnName("liberado");
            entity.Property(e => e.Observacao)
                .HasMaxLength(200)
                .HasColumnName("observacao");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");
            entity.Property(e => e.Tempo1)
                .HasColumnType("int(11)")
                .HasColumnName("tempo1");
            entity.Property(e => e.Tempo2)
                .HasColumnType("int(11)")
                .HasColumnName("tempo2");
            entity.Property(e => e.Totalcusto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("totalcusto");
            entity.Property(e => e.Totalperda)
                .HasPrecision(10, 4)
                .HasColumnName("totalperda");
        });

        modelBuilder.Entity<Producaocontrolequalidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("producaocontrolequalidade");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Aguacristalizacao)
                .HasMaxLength(10)
                .HasColumnName("aguacristalizacao");
            entity.Property(e => e.Agualivre)
                .HasMaxLength(10)
                .HasColumnName("agualivre");
            entity.Property(e => e.Analise)
                .HasColumnType("datetime")
                .HasColumnName("analise");
            entity.Property(e => e.Anedridosufurico)
                .HasMaxLength(10)
                .HasColumnName("anedridosufurico");
            entity.Property(e => e.Condicoeslaboratorio)
                .HasMaxLength(10)
                .HasColumnName("condicoeslaboratorio");
            entity.Property(e => e.Condicoestemperatura)
                .HasMaxLength(10)
                .HasColumnName("condicoestemperatura");
            entity.Property(e => e.Condicoesumidade)
                .HasMaxLength(10)
                .HasColumnName("condicoesumidade");
            entity.Property(e => e.Consistencia)
                .HasMaxLength(10)
                .HasColumnName("consistencia");
            entity.Property(e => e.Conteudoliquido)
                .HasPrecision(10, 4)
                .HasColumnName("conteudoliquido");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Dureza)
                .HasMaxLength(10)
                .HasColumnName("dureza");
            entity.Property(e => e.Embalagem)
                .HasMaxLength(20)
                .HasColumnName("embalagem");
            entity.Property(e => e.Especificacao)
                .HasMaxLength(10)
                .HasColumnName("especificacao");
            entity.Property(e => e.Fabricacao)
                .HasColumnType("datetime")
                .HasColumnName("fabricacao");
            entity.Property(e => e.Granulometria)
                .HasMaxLength(10)
                .HasColumnName("granulometria");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .HasColumnName("lote");
            entity.Property(e => e.Massaunitaria)
                .HasMaxLength(10)
                .HasColumnName("massaunitaria");
            entity.Property(e => e.Medicoes)
                .HasMaxLength(10)
                .HasColumnName("medicoes");
            entity.Property(e => e.Metodologia)
                .HasMaxLength(10)
                .HasColumnName("metodologia");
            entity.Property(e => e.Modulofinura)
                .HasMaxLength(10)
                .HasColumnName("modulofinura");
            entity.Property(e => e.Oxidocalcio)
                .HasMaxLength(10)
                .HasColumnName("oxidocalcio");
            entity.Property(e => e.Qtdanalisada)
                .HasPrecision(10, 4)
                .HasColumnName("qtdanalisada");
            entity.Property(e => e.Resistenciacomposicao)
                .HasMaxLength(10)
                .HasColumnName("resistenciacomposicao");
            entity.Property(e => e.Resultado)
                .HasMaxLength(10)
                .HasColumnName("resultado");
            entity.Property(e => e.Temperaturamediafinal)
                .HasMaxLength(10)
                .HasColumnName("temperaturamediafinal");
            entity.Property(e => e.Temperaturamediainicial)
                .HasMaxLength(10)
                .HasColumnName("temperaturamediainicial");
            entity.Property(e => e.Tempodepegafim)
                .HasMaxLength(10)
                .HasColumnName("tempodepegafim");
            entity.Property(e => e.Tempodepegainicio)
                .HasMaxLength(10)
                .HasColumnName("tempodepegainicio");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipoproduto)
                .HasMaxLength(100)
                .HasColumnName("tipoproduto");
            entity.Property(e => e.Trababilidade)
                .HasMaxLength(20)
                .HasColumnName("trababilidade");
            entity.Property(e => e.Turno)
                .HasMaxLength(10)
                .HasColumnName("turno");
            entity.Property(e => e.Unidade)
                .HasMaxLength(10)
                .HasColumnName("unidade");
        });

        modelBuilder.Entity<Producaocustosadicionai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("producaocustosadicionais");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasMaxLength(10)
                .HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
            entity.Property(e => e.Producao)
                .HasMaxLength(15)
                .HasColumnName("producao");
            entity.Property(e => e.Usuario)
                .HasMaxLength(5)
                .HasColumnName("usuario");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Producaodetalhe>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("producaodetalhe");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Atendido)
                .HasPrecision(10, 4)
                .HasColumnName("atendido");
            entity.Property(e => e.Cabideproducao)
                .HasMaxLength(5)
                .HasColumnName("cabideproducao");
            entity.Property(e => e.Custo)
                .HasPrecision(10, 4)
                .HasColumnName("custo");
            entity.Property(e => e.Custototal)
                .HasPrecision(10, 4)
                .HasColumnName("custototal");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("descricao");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Ficha)
                .HasMaxLength(5)
                .HasColumnName("ficha");
            entity.Property(e => e.Liberado)
                .HasMaxLength(5)
                .HasColumnName("liberado");
            entity.Property(e => e.Pbruto)
                .HasPrecision(10, 4)
                .HasColumnName("pbruto");
            entity.Property(e => e.Perda)
                .HasPrecision(10, 4)
                .HasColumnName("perda");
            entity.Property(e => e.Pliquido)
                .HasPrecision(10, 4)
                .HasColumnName("pliquido");
            entity.Property(e => e.Produto)
                .HasMaxLength(20)
                .HasColumnName("produto");
            entity.Property(e => e.Produtoficha)
                .HasMaxLength(15)
                .HasColumnName("produtoficha");
            entity.Property(e => e.Quantidade)
                .HasPrecision(10, 4)
                .HasColumnName("quantidade");
            entity.Property(e => e.Quantidadeproduzida)
                .HasPrecision(10, 4)
                .HasColumnName("quantidadeproduzida");
            entity.Property(e => e.Quantidadetotal)
                .HasPrecision(10, 4)
                .HasColumnName("quantidadetotal");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Volume)
                .HasPrecision(10, 4)
                .HasColumnName("volume");
        });

        modelBuilder.Entity<Producaooperadore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("producaooperadores");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Horafim)
                .HasMaxLength(10)
                .HasColumnName("horafim");
            entity.Property(e => e.Meta)
                .HasMaxLength(20)
                .HasColumnName("meta");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .HasColumnName("observacao");
            entity.Property(e => e.Operador)
                .HasMaxLength(50)
                .HasColumnName("operador");
            entity.Property(e => e.Producao)
                .HasPrecision(18, 2)
                .HasColumnName("producao");
            entity.Property(e => e.Producaohora)
                .HasPrecision(18, 2)
                .HasColumnName("producaohora");
            entity.Property(e => e.Temperaturaforno)
                .HasMaxLength(10)
                .HasColumnName("temperaturaforno");
            entity.Property(e => e.Tempoinicial)
                .HasMaxLength(10)
                .HasColumnName("tempoinicial");
            entity.Property(e => e.Tempointervalo)
                .HasMaxLength(10)
                .HasColumnName("tempointervalo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.Totalhoras)
                .HasMaxLength(10)
                .HasColumnName("totalhoras");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("produtos")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Aliquota)
                .HasMaxLength(50)
                .HasColumnName("aliquota");
            entity.Property(e => e.Aliquotacofins)
                .HasPrecision(10, 4)
                .HasColumnName("aliquotacofins");
            entity.Property(e => e.AliquotacofinsNfce)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("aliquotacofins_nfce");
            entity.Property(e => e.Aliquotapis)
                .HasPrecision(10, 4)
                .HasColumnName("aliquotapis");
            entity.Property(e => e.AliquotapisNfce)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("aliquotapis_nfce");
            entity.Property(e => e.Almoxarifado)
                .HasMaxLength(5)
                .HasColumnName("almoxarifado");
            entity.Property(e => e.Altura)
                .HasPrecision(10, 4)
                .HasColumnName("altura");
            entity.Property(e => e.Aplicacao)
                .HasMaxLength(255)
                .HasColumnName("aplicacao");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(20)
                .HasColumnName("auditoria");
            entity.Property(e => e.Balanca)
                .HasMaxLength(20)
                .HasColumnName("balanca");
            entity.Property(e => e.Calculacustost)
                .HasMaxLength(5)
                .HasColumnName("calculacustost");
            entity.Property(e => e.Cbarra)
                .HasMaxLength(20)
                .HasColumnName("cbarra");
            entity.Property(e => e.Centrocusto)
                .HasMaxLength(50)
                .HasColumnName("centrocusto");
            entity.Property(e => e.Cest)
                .HasMaxLength(7)
                .HasColumnName("cest");
            entity.Property(e => e.Cf)
                .HasMaxLength(8)
                .HasColumnName("cf");
            entity.Property(e => e.Cfopnfce)
                .HasMaxLength(5)
                .HasColumnName("cfopnfce");
            entity.Property(e => e.Codigo)
                .HasMaxLength(15)
                .HasColumnName("codigo");
            entity.Property(e => e.Codigoanvisa)
                .HasMaxLength(16)
                .HasColumnName("codigoanvisa");
            entity.Property(e => e.Codigofornecedor)
                .HasMaxLength(6)
                .HasColumnName("codigofornecedor");
            entity.Property(e => e.Codigogrupo)
                .HasMaxLength(6)
                .HasColumnName("codigogrupo");
            entity.Property(e => e.Codigomarca)
                .HasColumnType("int(11)")
                .HasColumnName("codigomarca");
            entity.Property(e => e.Codigounidade)
                .HasColumnType("int(11)")
                .HasColumnName("codigounidade");
            entity.Property(e => e.Comissao)
                .HasPrecision(10, 4)
                .HasColumnName("comissao");
            entity.Property(e => e.Composicao)
                .HasMaxLength(20)
                .HasColumnName("composicao");
            entity.Property(e => e.Comprimento)
                .HasPrecision(10, 4)
                .HasColumnName("comprimento");
            entity.Property(e => e.Cor)
                .HasMaxLength(25)
                .HasColumnName("cor");
            entity.Property(e => e.Creditoicms)
                .HasPrecision(10, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("creditoicms");
            entity.Property(e => e.Cstcofins)
                .HasMaxLength(5)
                .HasColumnName("cstcofins");
            entity.Property(e => e.CstcofinsNfce)
                .HasMaxLength(3)
                .HasColumnName("cstcofins_nfce");
            entity.Property(e => e.Cstipi)
                .HasMaxLength(2)
                .HasColumnName("cstipi");
            entity.Property(e => e.CstipiNfce)
                .HasMaxLength(3)
                .HasColumnName("cstipi_nfce");
            entity.Property(e => e.Cstpis)
                .HasMaxLength(5)
                .HasColumnName("cstpis");
            entity.Property(e => e.CstpisNfce)
                .HasMaxLength(3)
                .HasColumnName("cstpis_nfce");
            entity.Property(e => e.Cstpiscofins)
                .HasMaxLength(5)
                .HasColumnName("cstpiscofins");
            entity.Property(e => e.Custo)
                .HasPrecision(18, 4)
                .HasColumnName("custo");
            entity.Property(e => e.Custoadm)
                .HasPrecision(10, 4)
                .HasColumnName("custoadm");
            entity.Property(e => e.Custocomissao)
                .HasPrecision(10, 4)
                .HasColumnName("custocomissao");
            entity.Property(e => e.Custofrete)
                .HasPrecision(10, 4)
                .HasColumnName("custofrete");
            entity.Property(e => e.Custoicms)
                .HasPrecision(10, 4)
                .HasColumnName("custoicms");
            entity.Property(e => e.Custoicmsinterno)
                .HasPrecision(10, 4)
                .HasColumnName("custoicmsinterno");
            entity.Property(e => e.Custoimposto)
                .HasPrecision(10, 4)
                .HasColumnName("custoimposto");
            entity.Property(e => e.Custoipi)
                .HasPrecision(10, 4)
                .HasColumnName("custoipi");
            entity.Property(e => e.Custojuros)
                .HasPrecision(10, 4)
                .HasColumnName("custojuros");
            entity.Property(e => e.Customva)
                .HasPrecision(10, 4)
                .HasColumnName("customva");
            entity.Property(e => e.Custost)
                .HasPrecision(10, 4)
                .HasColumnName("custost");
            entity.Property(e => e.Dataatualizacao)
                .HasMaxLength(15)
                .HasColumnName("dataatualizacao");
            entity.Property(e => e.Datacadastro)
                .HasColumnType("datetime")
                .HasColumnName("datacadastro");
            entity.Property(e => e.Descontomax)
                .HasPrecision(10, 4)
                .HasColumnName("descontomax");
            entity.Property(e => e.Descontomaximo)
                .HasPrecision(10, 4)
                .HasColumnName("descontomaximo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(10000)
                .HasColumnName("descricao");
            entity.Property(e => e.Descricaoetq)
                .HasMaxLength(50)
                .HasColumnName("descricaoetq");
            entity.Property(e => e.Descricaogrupo)
                .HasMaxLength(50)
                .HasColumnName("descricaogrupo");
            entity.Property(e => e.Diasvalidade)
                .HasMaxLength(5)
                .HasColumnName("diasvalidade");
            entity.Property(e => e.Dimensoes)
                .HasMaxLength(5)
                .HasColumnName("dimensoes");
            entity.Property(e => e.Embalagem)
                .HasMaxLength(100)
                .HasColumnName("embalagem");
            entity.Property(e => e.Estoque)
                .HasPrecision(10, 4)
                .HasColumnName("estoque");
            entity.Property(e => e.Fabricado)
                .HasMaxLength(20)
                .HasColumnName("fabricado");
            entity.Property(e => e.Fator0).HasPrecision(10, 4);
            entity.Property(e => e.Fator1)
                .HasPrecision(10, 4)
                .HasColumnName("fator1");
            entity.Property(e => e.Fator10).HasPrecision(10, 4);
            entity.Property(e => e.Fator2)
                .HasPrecision(10, 4)
                .HasColumnName("fator2");
            entity.Property(e => e.Fator3)
                .HasPrecision(10, 4)
                .HasColumnName("fator3");
            entity.Property(e => e.Fator4)
                .HasPrecision(10, 4)
                .HasColumnName("fator4");
            entity.Property(e => e.Fator5)
                .HasPrecision(10, 4)
                .HasColumnName("fator5");
            entity.Property(e => e.Fator6)
                .HasPrecision(10, 4)
                .HasColumnName("fator6");
            entity.Property(e => e.Fator7)
                .HasPrecision(10, 4)
                .HasColumnName("fator7");
            entity.Property(e => e.Fator8)
                .HasPrecision(10, 4)
                .HasColumnName("fator8");
            entity.Property(e => e.Fator9).HasPrecision(10, 4);
            entity.Property(e => e.Fatorproducao)
                .HasPrecision(10, 4)
                .HasColumnName("fatorproducao");
            entity.Property(e => e.Fichatecnica)
                .HasMaxLength(5)
                .HasColumnName("fichatecnica");
            entity.Property(e => e.Filiais)
                .HasMaxLength(100)
                .HasColumnName("filiais");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(300)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Grade)
                .HasMaxLength(10)
                .HasColumnName("grade");
            entity.Property(e => e.Grosso)
                .HasPrecision(18, 4)
                .HasColumnName("grosso");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .HasColumnName("grupo");
            entity.Property(e => e.Ibptcofins)
                .HasPrecision(10, 2)
                .HasColumnName("ibptcofins");
            entity.Property(e => e.Ibptcsll)
                .HasPrecision(10, 2)
                .HasColumnName("ibptcsll");
            entity.Property(e => e.Ibpticms)
                .HasPrecision(10, 2)
                .HasColumnName("ibpticms");
            entity.Property(e => e.Ibptirpj)
                .HasPrecision(10, 2)
                .HasColumnName("ibptirpj");
            entity.Property(e => e.Ibptpis)
                .HasPrecision(10, 2)
                .HasColumnName("ibptpis");
            entity.Property(e => e.Icms)
                .HasPrecision(18, 2)
                .HasColumnName("icms");
            entity.Property(e => e.IcmsNfce)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11) unsigned")
                .HasColumnName("icms_nfce");
            entity.Property(e => e.Icmssub)
                .HasPrecision(18, 2)
                .HasColumnName("icmssub");
            entity.Property(e => e.IcmssubNfce)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("icmssub_nfce");
            entity.Property(e => e.Importado)
                .HasMaxLength(15)
                .HasColumnName("importado");
            entity.Property(e => e.Inativo)
                .HasMaxLength(5)
                .HasColumnName("inativo");
            entity.Property(e => e.Informacoesadicionais)
                .HasMaxLength(4000)
                .HasColumnName("informacoesadicionais");
            entity.Property(e => e.IpEstadual)
                .HasPrecision(10, 2)
                .HasColumnName("ip_estadual");
            entity.Property(e => e.IpImportado)
                .HasPrecision(10, 2)
                .HasColumnName("ip_importado");
            entity.Property(e => e.IpMunicipal)
                .HasPrecision(10, 2)
                .HasColumnName("ip_municipal");
            entity.Property(e => e.IpNacional)
                .HasPrecision(10, 2)
                .HasColumnName("ip_nacional");
            entity.Property(e => e.IpTipo)
                .HasPrecision(10, 2)
                .HasColumnName("ip_tipo");
            entity.Property(e => e.IpVersao)
                .HasMaxLength(8)
                .HasColumnName("ip_versao");
            entity.Property(e => e.IpVigenciafim)
                .HasColumnType("datetime")
                .HasColumnName("ip_vigenciafim");
            entity.Property(e => e.IpVigenciainicio)
                .HasColumnType("datetime")
                .HasColumnName("ip_vigenciainicio");
            entity.Property(e => e.Ipi)
                .HasPrecision(10, 2)
                .HasColumnName("ipi");
            entity.Property(e => e.IpiNfce)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("ipi_nfce");
            entity.Property(e => e.Ipivalor)
                .HasPrecision(10, 4)
                .HasColumnName("ipivalor");
            entity.Property(e => e.Iss)
                .HasPrecision(10, 4)
                .HasColumnName("iss");
            entity.Property(e => e.Largura)
                .HasPrecision(10, 4)
                .HasColumnName("largura");
            entity.Property(e => e.Localimpressao)
                .HasMaxLength(100)
                .HasColumnName("localimpressao");
            entity.Property(e => e.Lote)
                .HasMaxLength(1)
                .HasColumnName("lote");
            entity.Property(e => e.Lotepaf)
                .HasMaxLength(1)
                .HasColumnName("lotepaf");
            entity.Property(e => e.M3)
                .HasPrecision(10, 4)
                .HasColumnName("m3");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .HasColumnName("marca");
            entity.Property(e => e.Margem)
                .HasPrecision(10, 4)
                .HasColumnName("margem");
            entity.Property(e => e.Margem1)
                .HasPrecision(10, 4)
                .HasColumnName("margem1");
            entity.Property(e => e.Margem2)
                .HasPrecision(10, 4)
                .HasColumnName("margem2");
            entity.Property(e => e.Margem3)
                .HasPrecision(10, 4)
                .HasColumnName("margem3");
            entity.Property(e => e.Margem4)
                .HasPrecision(10, 4)
                .HasColumnName("margem4");
            entity.Property(e => e.Margem5)
                .HasPrecision(10, 4)
                .HasColumnName("margem5");
            entity.Property(e => e.Margem6)
                .HasPrecision(10, 4)
                .HasColumnName("margem6");
            entity.Property(e => e.Margem7)
                .HasPrecision(10, 4)
                .HasColumnName("margem7");
            entity.Property(e => e.Margem8)
                .HasPrecision(10, 4)
                .HasColumnName("margem8");
            entity.Property(e => e.Mensagem)
                .HasMaxLength(200)
                .HasColumnName("mensagem");
            entity.Property(e => e.Mensagempiscofins)
                .HasMaxLength(2000)
                .HasColumnName("mensagempiscofins");
            entity.Property(e => e.Minimo)
                .HasPrecision(18, 4)
                .HasColumnName("minimo");
            entity.Property(e => e.Modbcicms)
                .HasMaxLength(1)
                .HasColumnName("modbcicms");
            entity.Property(e => e.Modbcicmsst)
                .HasMaxLength(1)
                .HasColumnName("modbcicmsst");
            entity.Property(e => e.Modelo)
                .HasMaxLength(20)
                .HasDefaultValueSql("'2'")
                .HasComment("Campo que define se produto sincroniza com MeuMenu:\r\n0 sincroniza produto no MeuMenu\r\n1 desabilita produto noMeuMenu\r\n2 nao sincroniza produto no MeuMenu")
                .HasColumnName("modelo");
            entity.Property(e => e.Movimentaestoque)
                .HasMaxLength(5)
                .HasDefaultValueSql("'true'")
                .HasColumnName("movimentaestoque");
            entity.Property(e => e.Nomeimpressora)
                .HasMaxLength(25)
                .HasColumnName("nomeimpressora");
            entity.Property(e => e.Observacao)
                .HasMaxLength(150)
                .HasColumnName("observacao");
            entity.Property(e => e.Pathimagem)
                .HasMaxLength(5000)
                .HasColumnName("pathimagem");
            entity.Property(e => e.Pbruto)
                .HasPrecision(10, 2)
                .HasColumnName("pbruto");
            entity.Property(e => e.Pendencia)
                .HasPrecision(10, 4)
                .HasColumnName("pendencia");
            entity.Property(e => e.Peso)
                .HasMaxLength(1)
                .HasColumnName("peso");
            entity.Property(e => e.Pesoespecifico)
                .HasMaxLength(50)
                .HasColumnName("pesoespecifico");
            entity.Property(e => e.Pesorm)
                .HasMaxLength(50)
                .HasColumnName("pesorm");
            entity.Property(e => e.Pfcpufdest)
                .HasPrecision(10, 4)
                .HasColumnName("pfcpufdest");
            entity.Property(e => e.Picmsinter)
                .HasPrecision(10, 4)
                .HasColumnName("picmsinter");
            entity.Property(e => e.Picmsinterpart)
                .HasPrecision(10, 4)
                .HasColumnName("picmsinterpart");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(20)
                .HasColumnName("planocontas");
            entity.Property(e => e.Pliquido)
                .HasPrecision(10, 2)
                .HasColumnName("pliquido");
            entity.Property(e => e.Preco1)
                .HasPrecision(10, 4)
                .HasColumnName("preco1");
            entity.Property(e => e.Preco10)
                .HasPrecision(10, 4)
                .HasColumnName("preco10");
            entity.Property(e => e.Preco2)
                .HasPrecision(10, 4)
                .HasColumnName("preco2");
            entity.Property(e => e.Preco3)
                .HasPrecision(10, 4)
                .HasColumnName("preco3");
            entity.Property(e => e.Preco4)
                .HasPrecision(10, 4)
                .HasColumnName("preco4");
            entity.Property(e => e.Preco5)
                .HasPrecision(10, 4)
                .HasColumnName("preco5");
            entity.Property(e => e.Preco6)
                .HasPrecision(10, 4)
                .HasColumnName("preco6");
            entity.Property(e => e.Preco7)
                .HasPrecision(10, 4)
                .HasColumnName("preco7");
            entity.Property(e => e.Preco8)
                .HasPrecision(10, 4)
                .HasColumnName("preco8");
            entity.Property(e => e.Preco9)
                .HasPrecision(10, 4)
                .HasColumnName("preco9");
            entity.Property(e => e.Precopauta)
                .HasPrecision(10, 4)
                .HasColumnName("precopauta");
            entity.Property(e => e.Precotmp)
                .HasPrecision(10, 4)
                .HasColumnName("precotmp");
            entity.Property(e => e.Precovenda)
                .HasPrecision(18, 4)
                .HasColumnName("precovenda");
            entity.Property(e => e.Prestacao)
                .HasMaxLength(10000)
                .HasColumnName("prestacao");
            entity.Property(e => e.Previsao)
                .HasPrecision(10, 4)
                .HasColumnName("previsao");
            entity.Property(e => e.Produto1)
                .HasMaxLength(40)
                .HasColumnName("produto");
            entity.Property(e => e.Proporcaounitaria)
                .HasPrecision(10, 4)
                .HasColumnName("proporcaounitaria");
            entity.Property(e => e.Qtd)
                .HasPrecision(10, 4)
                .HasColumnName("qtd");
            entity.Property(e => e.Qtdminima)
                .HasPrecision(10, 2)
                .HasColumnName("qtdminima");
            entity.Property(e => e.Qtdvolume)
                .HasPrecision(10, 4)
                .HasColumnName("qtdvolume");
            entity.Property(e => e.Qtdvolumecompra)
                .HasPrecision(10, 4)
                .HasColumnName("qtdvolumecompra");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .HasColumnName("referencia");
            entity.Property(e => e.Servico)
                .HasMaxLength(5)
                .HasColumnName("servico");
            entity.Property(e => e.Servicomunicipal)
                .HasMaxLength(10)
                .HasColumnName("servicomunicipal");
            entity.Property(e => e.Similar)
                .HasMaxLength(10)
                .HasColumnName("similar");
            entity.Property(e => e.Sincpaf)
                .HasMaxLength(100)
                .HasColumnName("sincpaf");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("sincronizado");
            entity.Property(e => e.St)
                .HasMaxLength(4)
                .HasColumnName("st");
            entity.Property(e => e.StNfce)
                .HasMaxLength(4)
                .HasColumnName("st_nfce");
            entity.Property(e => e.Supergrupo)
                .HasMaxLength(2)
                .HasColumnName("supergrupo");
            entity.Property(e => e.Tabela)
                .HasMaxLength(25)
                .HasColumnName("tabela");
            entity.Property(e => e.Ultimacompra)
                .HasColumnType("datetime")
                .HasColumnName("ultimacompra");
            entity.Property(e => e.Ultimavenda)
                .HasColumnType("datetime")
                .HasColumnName("ultimavenda");
            entity.Property(e => e.Ultimocusto)
                .HasPrecision(10, 4)
                .HasColumnName("ultimocusto");
            entity.Property(e => e.Ultimopreco)
                .HasPrecision(10, 4)
                .HasColumnName("ultimopreco");
            entity.Property(e => e.Unidade)
                .HasMaxLength(15)
                .HasColumnName("unidade");
            entity.Property(e => e.Validacao)
                .HasColumnType("datetime")
                .HasColumnName("validacao");
            entity.Property(e => e.Validade)
                .HasColumnType("datetime")
                .HasColumnName("validade");
            entity.Property(e => e.Valorsugerido)
                .HasPrecision(18, 2)
                .HasColumnName("valorsugerido");
            entity.Property(e => e.Venda)
                .HasMaxLength(5)
                .HasDefaultValueSql("'true'")
                .HasColumnName("venda");
            entity.Property(e => e.Vendedores)
                .HasMaxLength(1000)
                .HasColumnName("vendedores");
        });

        modelBuilder.Entity<Produtodetalhe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produtodetalhe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(11)
                .HasColumnName("cep");
            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasColumnName("cnpj");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("descricao");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasColumnName("endereco");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(50)
                .HasColumnName("fantasia");
            entity.Property(e => e.Ie)
                .HasMaxLength(18)
                .HasColumnName("ie");
            entity.Property(e => e.Lembrar)
                .HasMaxLength(10)
                .HasColumnName("lembrar");
            entity.Property(e => e.Produto)
                .HasMaxLength(20)
                .HasColumnName("produto");
            entity.Property(e => e.Produtoorigem)
                .HasMaxLength(50)
                .HasColumnName("produtoorigem");
            entity.Property(e => e.Qtd)
                .HasPrecision(10, 4)
                .HasColumnName("qtd");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.Unidade)
                .HasMaxLength(5)
                .HasColumnName("unidade");
        });

        modelBuilder.Entity<Produtoimagen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produtoimagens");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Idproduto)
                .HasColumnType("int(11)")
                .HasColumnName("idproduto");
            entity.Property(e => e.Imagem).HasColumnName("imagem");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Tipo1)
                .HasMaxLength(50)
                .HasColumnName("tipo1");
            entity.Property(e => e.Tipo2)
                .HasMaxLength(50)
                .HasColumnName("tipo2");
        });

        modelBuilder.Entity<Produtoslinkfornecedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produtoslinkfornecedores");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cnpjfornecedor)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("cnpjfornecedor");
            entity.Property(e => e.Idproduto)
                .HasColumnType("int(11)")
                .HasColumnName("idproduto");
            entity.Property(e => e.Produtofornecedor)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("produtofornecedor");
        });

        modelBuilder.Entity<Produtosrankingcomissao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("produtosrankingcomissao");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ComissaoP)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("comissao_p");
            entity.Property(e => e.ComissaoV)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("comissao_v");
            entity.Property(e => e.DataAtualizacao)
                .HasColumnType("datetime")
                .HasColumnName("data_atualizacao");
            entity.Property(e => e.Idproduto)
                .HasColumnType("int(11)")
                .HasColumnName("idproduto");
            entity.Property(e => e.MargemfinalP)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("margemfinal_p");
            entity.Property(e => e.MargemfinalV)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("margemfinal_v");
            entity.Property(e => e.MargeminicialP)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("margeminicial_p");
            entity.Property(e => e.MargeminicialV)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("margeminicial_v");
            entity.Property(e => e.Valorpadrao)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("valorpadrao");
        });

        modelBuilder.Entity<Prospeccao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prospeccao");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(11)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .HasColumnName("cidade");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasColumnName("cnpj");
            entity.Property(e => e.Contato)
                .HasMaxLength(20)
                .HasColumnName("contato");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasColumnName("endereco");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(50)
                .HasColumnName("fantasia");
            entity.Property(e => e.Fax)
                .HasMaxLength(16)
                .HasColumnName("fax");
            entity.Property(e => e.Ie)
                .HasMaxLength(18)
                .HasColumnName("ie");
            entity.Property(e => e.Lembrar)
                .HasMaxLength(10)
                .HasColumnName("lembrar");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Produtoservico)
                .HasMaxLength(50)
                .HasColumnName("produtoservico");
            entity.Property(e => e.Removerlembrete)
                .HasMaxLength(1)
                .HasColumnName("removerlembrete");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Telefone)
                .HasMaxLength(16)
                .HasColumnName("telefone");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Prospeccaocontato>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prospeccaocontato");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cargo)
                .HasMaxLength(30)
                .HasColumnName("cargo");
            entity.Property(e => e.Contato)
                .HasMaxLength(50)
                .HasColumnName("contato");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fone)
                .HasMaxLength(50)
                .HasColumnName("fone");
            entity.Property(e => e.Nomecliente)
                .HasMaxLength(50)
                .HasColumnName("nomecliente");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Prospeccaodetalhe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("prospeccaodetalhe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Cargo)
                .HasMaxLength(30)
                .HasColumnName("cargo");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Idprospeccao)
                .HasColumnType("int(11)")
                .HasColumnName("idprospeccao");
            entity.Property(e => e.Lembrar)
                .HasColumnType("datetime")
                .HasColumnName("lembrar");
            entity.Property(e => e.Observacao)
                .HasMaxLength(500)
                .HasColumnName("observacao");
            entity.Property(e => e.Prioridade)
                .HasMaxLength(50)
                .HasColumnName("prioridade");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(20)
                .HasColumnName("responsavel");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Reajustepreco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("reajustepreco");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Precoatual)
                .HasPrecision(10, 4)
                .HasColumnName("precoatual");
            entity.Property(e => e.Preconovo)
                .HasPrecision(10, 4)
                .HasColumnName("preconovo");
            entity.Property(e => e.Produto)
                .HasMaxLength(50)
                .HasColumnName("produto");
            entity.Property(e => e.Usuario)
                .HasMaxLength(4)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Recebimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("recebimento");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Aliquota1)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota1");
            entity.Property(e => e.Aliquota10)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota10");
            entity.Property(e => e.Aliquota2)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota2");
            entity.Property(e => e.Aliquota3)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota3");
            entity.Property(e => e.Aliquota4)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota4");
            entity.Property(e => e.Aliquota5)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota5");
            entity.Property(e => e.Aliquota6)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota6");
            entity.Property(e => e.Aliquota7)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota7");
            entity.Property(e => e.Aliquota8)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota8");
            entity.Property(e => e.Aliquota9)
                .HasPrecision(10, 4)
                .HasColumnName("aliquota9");
            entity.Property(e => e.Ativfinanceira)
                .HasMaxLength(5)
                .HasColumnName("ativfinanceira");
            entity.Property(e => e.AtividadeFinanceira)
                .HasMaxLength(25)
                .HasColumnName("atividade_financeira");
            entity.Property(e => e.Ativo)
                .HasMaxLength(5)
                .HasColumnName("ativo");
            entity.Property(e => e.Baixaautomatica)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("baixaautomatica");
            entity.Property(e => e.CnpjOperadora)
                .HasMaxLength(20)
                .HasColumnName("cnpj_operadora");
            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .HasColumnName("codigo");
            entity.Property(e => e.CodigoGrupo)
                .HasMaxLength(5)
                .HasColumnName("codigo_grupo");
            entity.Property(e => e.Condicoes)
                .HasMaxLength(30)
                .HasColumnName("condicoes");
            entity.Property(e => e.DataAlteracao)
                .HasComment("Guarda data de modificação do tipo de recebimento")
                .HasColumnType("datetime")
                .HasColumnName("data_alteracao");
            entity.Property(e => e.DataCadastro)
                .HasColumnType("datetime")
                .HasColumnName("data_cadastro");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe")
                .HasColumnName("descricao");
            entity.Property(e => e.DescricaoGrupo)
                .HasMaxLength(25)
                .HasColumnName("descricao_grupo");
            entity.Property(e => e.Forma)
                .HasMaxLength(100)
                .HasColumnName("forma");
            entity.Property(e => e.Integracao)
                .HasMaxLength(5)
                .HasComment("Define se o recebimento tem ou não integração")
                .HasColumnName("integracao");
            entity.Property(e => e.Limitetroco)
                .HasPrecision(10, 4)
                .HasColumnName("limitetroco");
            entity.Property(e => e.ParcelasLivre)
                .HasMaxLength(5)
                .HasComment("Permite que o recebimento em questão seja manipulado livremente nos lançamentos sem precisar configurar as parcelas. Campo true ou false")
                .HasColumnName("parcelas_livre");
            entity.Property(e => e.Permissoes)
                .HasMaxLength(500)
                .HasColumnName("permissoes");
            entity.Property(e => e.Prazo1)
                .HasMaxLength(4)
                .HasColumnName("prazo1");
            entity.Property(e => e.Prazo10)
                .HasMaxLength(4)
                .HasColumnName("prazo10");
            entity.Property(e => e.Prazo11)
                .HasMaxLength(4)
                .HasColumnName("prazo11");
            entity.Property(e => e.Prazo12)
                .HasMaxLength(4)
                .HasColumnName("prazo12");
            entity.Property(e => e.Prazo2)
                .HasMaxLength(4)
                .HasColumnName("prazo2");
            entity.Property(e => e.Prazo3)
                .HasMaxLength(4)
                .HasColumnName("prazo3");
            entity.Property(e => e.Prazo4)
                .HasMaxLength(4)
                .HasColumnName("prazo4");
            entity.Property(e => e.Prazo5)
                .HasMaxLength(4)
                .HasColumnName("prazo5");
            entity.Property(e => e.Prazo6)
                .HasMaxLength(4)
                .HasColumnName("prazo6");
            entity.Property(e => e.Prazo7)
                .HasMaxLength(4)
                .HasColumnName("prazo7");
            entity.Property(e => e.Prazo8)
                .HasMaxLength(4)
                .HasColumnName("prazo8");
            entity.Property(e => e.Prazo9)
                .HasMaxLength(4)
                .HasColumnName("prazo9");
            entity.Property(e => e.Sigla)
                .HasMaxLength(10)
                .HasColumnName("sigla");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.Tabela)
                .HasMaxLength(10)
                .HasColumnName("tabela");
            entity.Property(e => e.Tipopagamento)
                .HasMaxLength(30)
                .HasColumnName("tipopagamento");
            entity.Property(e => e.Usuario)
                .HasComment("Guarda data de inserção ou atualização do tipo de recebimento")
                .HasColumnType("int(11)")
                .HasColumnName("usuario");
            entity.Property(e => e.Visualizar)
                .HasMaxLength(10)
                .HasDefaultValueSql("'CVS'")
                .HasColumnName("visualizar");
        });

        modelBuilder.Entity<Relatorio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("relatorios");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Controle)
                .HasMaxLength(100)
                .HasColumnName("controle");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Modulo)
                .HasMaxLength(50)
                .HasColumnName("modulo");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("status");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Statusfinanceiro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("statusfinanceiro");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao).HasMaxLength(25);
        });

        modelBuilder.Entity<Suite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("suites");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ativo)
                .HasColumnType("int(11)")
                .HasColumnName("ativo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("descricao");
            entity.Property(e => e.Idproduto)
                .HasColumnType("int(11)")
                .HasColumnName("idproduto");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .HasColumnName("numero");
            entity.Property(e => e.Reserva)
                .HasColumnType("int(11)")
                .HasColumnName("reserva");
            entity.Property(e => e.Tempo)
                .HasColumnType("datetime")
                .HasColumnName("tempo");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 2)
                .HasColumnName("valor");
            entity.Property(e => e.ValorAdicional)
                .HasPrecision(10, 2)
                .HasColumnName("valor_adicional");
        });

        modelBuilder.Entity<Suitetipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("suitetipos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasComment("Descrição da suite - específico hospedagem")
                .HasColumnName("descricao");
            entity.Property(e => e.Idsuite)
                .HasComment("Identificador da suite - específico hospedagem")
                .HasColumnType("int(11)")
                .HasColumnName("idsuite");
            entity.Property(e => e.Tempo)
                .HasComment("Tempo de permanência da suite - específico hospedagem")
                .HasColumnType("datetime")
                .HasColumnName("tempo");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 2)
                .HasComment("Valor padrão da suite - específico hospedagem")
                .HasColumnName("valor");
            entity.Property(e => e.Valorexcedente)
                .HasPrecision(10, 2)
                .HasComment("Valor excedente da suite - específico hospedagem")
                .HasColumnName("valorexcedente");
        });

        modelBuilder.Entity<Tabelaprecocliente>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("tabelaprecoclientes");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cliente)
                .HasMaxLength(6)
                .HasColumnName("cliente");
            entity.Property(e => e.Preco)
                .HasPrecision(10, 4)
                .HasColumnName("preco");
            entity.Property(e => e.Produto)
                .HasMaxLength(15)
                .HasColumnName("produto");
        });

        modelBuilder.Entity<Tabelapreconome>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("tabelapreconome");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Descricao)
                .HasMaxLength(20)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .HasColumnName("nome");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Tecido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tecido");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Transportadora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("transportadora");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasComment("Bairro do transportador")
                .HasColumnName("bairro");
            entity.Property(e => e.Celular)
                .HasMaxLength(30)
                .HasColumnName("celular");
            entity.Property(e => e.Cep)
                .HasMaxLength(15)
                .HasComment("CEP do transportador de acordo com IBGE ")
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(100)
                .HasComment("Cidade do transportador")
                .HasColumnName("cidade");
            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .HasColumnName("codigo");
            entity.Property(e => e.Codigocidade)
                .HasMaxLength(10)
                .HasComment("Código da cidade do transportador de acordo com IBGE ")
                .HasColumnName("codigocidade");
            entity.Property(e => e.Codigouf)
                .HasMaxLength(10)
                .HasComment("Código da UF(Estado) do transportador de acordo com IBGE ")
                .HasColumnName("codigouf");
            entity.Property(e => e.Contato)
                .HasMaxLength(20)
                .HasColumnName("contato");
            entity.Property(e => e.CpfCnpj)
                .HasMaxLength(20)
                .HasComment("CNPJ OU CPF do transportador")
                .HasColumnName("cpf_cnpj");
            entity.Property(e => e.Datacad)
                .HasComment("Data de cadastro dotransportador")
                .HasColumnType("datetime")
                .HasColumnName("datacad");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasComment("Email do transportador")
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(100)
                .HasComment("Endereço do transportador")
                .HasColumnName("endereco");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(60)
                .HasComment("Nome fantasia do transportador. 60 caracteres conforme manual da nfe.")
                .HasColumnName("fantasia");
            entity.Property(e => e.Homepage)
                .HasMaxLength(50)
                .HasColumnName("homepage");
            entity.Property(e => e.Observacao)
                .HasMaxLength(150)
                .HasColumnName("observacao");
            entity.Property(e => e.Plano)
                .HasMaxLength(20)
                .HasColumnName("plano");
            entity.Property(e => e.Razao)
                .HasMaxLength(60)
                .HasComment("Razão social do transportador. 60 caracteres conforme manual da nfe.")
                .HasColumnName("razao");
            entity.Property(e => e.RgInsc)
                .HasMaxLength(20)
                .HasComment("Número da inscrição estadual do transportador. Caso seja pessoa física deve ser ISENTO")
                .HasColumnName("rg_insc");
            entity.Property(e => e.Rntrc)
                .HasMaxLength(50)
                .HasComment("RNTRC do Transportador.")
                .HasColumnName("rntrc");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'n'")
                .HasColumnName("sincronizado");
            entity.Property(e => e.Status)
                .HasMaxLength(7)
                .HasColumnName("status");
            entity.Property(e => e.Telefone1)
                .HasMaxLength(30)
                .HasColumnName("telefone1");
            entity.Property(e => e.Telefone2)
                .HasMaxLength(30)
                .HasColumnName("telefone2");
            entity.Property(e => e.Tipotransportador)
                .HasMaxLength(8)
                .HasColumnName("tipotransportador");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasComment("UF do transportador")
                .HasColumnName("uf");
        });

        modelBuilder.Entity<Turma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("turma");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ativo)
                .HasColumnType("bit(1)")
                .HasColumnName("ativo");
            entity.Property(e => e.Dataatualizacao)
                .HasColumnType("datetime")
                .HasColumnName("dataatualizacao");
            entity.Property(e => e.Datacadastro)
                .HasColumnType("datetime")
                .HasColumnName("datacadastro");
            entity.Property(e => e.Meta)
                .HasPrecision(10, 4)
                .HasColumnName("meta");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .HasColumnName("nome");
            entity.Property(e => e.Usuarioalteracao)
                .HasMaxLength(50)
                .HasColumnName("usuarioalteracao");
            entity.Property(e => e.Usuariocadastro)
                .HasMaxLength(50)
                .HasColumnName("usuariocadastro");
        });

        modelBuilder.Entity<Unidade>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("unidades");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Descricao)
                .HasMaxLength(5)
                .HasColumnName("descricao");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<Veiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("veiculos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Capacidadekg)
                .HasPrecision(8, 2)
                .HasComment("Capacidade do Veiculo em KG.")
                .HasColumnName("capacidadekg");
            entity.Property(e => e.Capacidadekgreboque)
                .HasPrecision(8, 2)
                .HasColumnName("capacidadekgreboque");
            entity.Property(e => e.Capacidademetrocubico)
                .HasPrecision(8, 2)
                .HasComment("Capacidade do Veiculo em M3.")
                .HasColumnName("capacidademetrocubico");
            entity.Property(e => e.Capacidademetrocubicoreboque)
                .HasPrecision(8, 2)
                .HasColumnName("capacidademetrocubicoreboque");
            entity.Property(e => e.Carroceria)
                .HasMaxLength(2)
                .HasComment("00, 01, 02, 03, 04, 05 - Codigo da Carroceria.")
                .HasColumnName("carroceria");
            entity.Property(e => e.Carroceriareboque)
                .HasMaxLength(12)
                .HasColumnName("carroceriareboque");
            entity.Property(e => e.Chassi)
                .HasMaxLength(22)
                .HasComment("Chassi do Veiculo.")
                .HasColumnName("chassi");
            entity.Property(e => e.Chassireboque)
                .HasMaxLength(22)
                .HasColumnName("chassireboque");
            entity.Property(e => e.Nomedoveiculo)
                .HasMaxLength(50)
                .HasComment("Nome do Veiculo")
                .HasColumnName("nomedoveiculo");
            entity.Property(e => e.Placa)
                .HasMaxLength(12)
                .HasComment("Placa do Veiculo.")
                .HasColumnName("placa");
            entity.Property(e => e.Placareboque)
                .HasMaxLength(12)
                .HasColumnName("placareboque");
            entity.Property(e => e.Proprietario)
                .HasMaxLength(2)
                .HasComment("01 - Próprio, 02 - Terceiro.")
                .HasColumnName("proprietario");
            entity.Property(e => e.Proprietarioreboque)
                .HasMaxLength(2)
                .HasColumnName("proprietarioreboque");
            entity.Property(e => e.Tara)
                .HasPrecision(8, 2)
                .HasComment("Tara do Veiculo.")
                .HasColumnName("tara");
            entity.Property(e => e.Tarareboque)
                .HasPrecision(8, 2)
                .HasColumnName("tarareboque");
            entity.Property(e => e.Tiporodado)
                .HasMaxLength(2)
                .HasComment("00, 01, 02, 03, 04, 05, 06 - Codigo do tipo rodado.")
                .HasColumnName("tiporodado");
            entity.Property(e => e.Tiporodadoreboque)
                .HasMaxLength(2)
                .HasColumnName("tiporodadoreboque");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasComment("Estado da Placa.")
                .HasColumnName("uf");
            entity.Property(e => e.Ufreboque)
                .HasMaxLength(2)
                .HasColumnName("ufreboque");
        });

        modelBuilder.Entity<Vendedore>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("vendedores");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Ag)
                .HasMaxLength(10)
                .HasColumnName("ag");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.Banco)
                .HasMaxLength(20)
                .HasColumnName("banco");
            entity.Property(e => e.Cc)
                .HasMaxLength(10)
                .HasColumnName("cc");
            entity.Property(e => e.Celular)
                .HasMaxLength(30)
                .HasColumnName("celular");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(100)
                .HasColumnName("cidade");
            entity.Property(e => e.CodigoGrupo)
                .HasMaxLength(5)
                .HasColumnName("codigo_grupo");
            entity.Property(e => e.Codigosupervisor)
                .HasMaxLength(10)
                .HasColumnName("codigosupervisor");
            entity.Property(e => e.Comissao)
                .HasPrecision(10, 4)
                .HasColumnName("comissao");
            entity.Property(e => e.Cpf)
                .HasMaxLength(18)
                .HasColumnName("cpf");
            entity.Property(e => e.DescricaoGrupo)
                .HasMaxLength(15)
                .HasColumnName("descricao_grupo");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Endereco)
                .HasMaxLength(55)
                .HasColumnName("endereco");
            entity.Property(e => e.Fone)
                .HasMaxLength(30)
                .HasColumnName("fone");
            entity.Property(e => e.Inativo)
                .HasMaxLength(5)
                .HasColumnName("inativo");
            entity.Property(e => e.Meta)
                .HasPrecision(10, 4)
                .HasColumnName("meta");
            entity.Property(e => e.Nome)
                .HasMaxLength(45)
                .HasColumnName("nome");
            entity.Property(e => e.Relatoriocomissao)
                .HasMaxLength(1)
                .HasColumnName("relatoriocomissao");
            entity.Property(e => e.Rg)
                .HasMaxLength(18)
                .HasColumnName("rg");
            entity.Property(e => e.Sup)
                .HasMaxLength(5)
                .HasColumnName("sup");
            entity.Property(e => e.Supervisor)
                .HasMaxLength(100)
                .HasColumnName("supervisor");
            entity.Property(e => e.Tabelavendedor)
                .HasMaxLength(200)
                .HasColumnName("tabelavendedor");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(3)
                .HasColumnName("vendedor");
        });

        modelBuilder.Entity<Vendum>(entity =>
        {
            entity.HasKey(e => e.Chave).HasName("PRIMARY");

            entity.ToTable("venda");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(18, 4)
                .HasColumnName("acrescimo");
            entity.Property(e => e.Almoxarifado)
                .HasMaxLength(5)
                .HasColumnName("almoxarifado");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Auditoria)
                .HasMaxLength(25)
                .HasColumnName("auditoria");
            entity.Property(e => e.Basecalculoicms)
                .HasPrecision(18, 2)
                .HasColumnName("basecalculoicms");
            entity.Property(e => e.Basecalculoicmsst)
                .HasPrecision(18, 2)
                .HasColumnName("basecalculoicmsst");
            entity.Property(e => e.Campo1)
                .HasMaxLength(100)
                .HasColumnName("campo1");
            entity.Property(e => e.Campo2)
                .HasMaxLength(100)
                .HasColumnName("campo2");
            entity.Property(e => e.Campo3)
                .HasMaxLength(100)
                .HasColumnName("campo3");
            entity.Property(e => e.Campo4)
                .HasMaxLength(100)
                .HasColumnName("campo4");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(30)
                .HasColumnName("cancelado");
            entity.Property(e => e.Centrocusto)
                .HasMaxLength(50)
                .HasColumnName("centrocusto");
            entity.Property(e => e.Cfop)
                .HasMaxLength(50)
                .HasColumnName("cfop");
            entity.Property(e => e.Cfoptrasnportador)
                .HasMaxLength(5)
                .HasColumnName("cfoptrasnportador");
            entity.Property(e => e.Chavenfe)
                .HasMaxLength(200)
                .HasColumnName("chavenfe");
            entity.Property(e => e.Cliente)
                .HasMaxLength(10)
                .HasColumnName("cliente");
            entity.Property(e => e.Cliente2)
                .HasMaxLength(8)
                .HasColumnName("cliente2");
            entity.Property(e => e.Cnfe)
                .HasMaxLength(15)
                .HasColumnName("cnfe");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Codigoantt)
                .HasMaxLength(50)
                .HasColumnName("codigoantt");
            entity.Property(e => e.Codigocusto)
                .HasMaxLength(10)
                .HasColumnName("codigocusto");
            entity.Property(e => e.Codigoendereco)
                .HasColumnType("int(11)")
                .HasColumnName("codigoendereco");
            entity.Property(e => e.Codigofornecedor)
                .HasMaxLength(5)
                .HasColumnName("codigofornecedor");
            entity.Property(e => e.Codigotransportador)
                .HasMaxLength(5)
                .HasColumnName("codigotransportador");
            entity.Property(e => e.Codigoverificacaonfse)
                .HasMaxLength(50)
                .HasColumnName("codigoverificacaonfse");
            entity.Property(e => e.Cofins)
                .HasPrecision(18, 2)
                .HasColumnName("cofins");
            entity.Property(e => e.Comissao1)
                .HasPrecision(18, 2)
                .HasColumnName("comissao1");
            entity.Property(e => e.Comissao2)
                .HasPrecision(18, 2)
                .HasColumnName("comissao2");
            entity.Property(e => e.Comissaorepresentante)
                .HasPrecision(18, 2)
                .HasColumnName("comissaorepresentante");
            entity.Property(e => e.Contrato)
                .HasMaxLength(250)
                .HasColumnName("contrato");
            entity.Property(e => e.Csll)
                .HasPrecision(18, 2)
                .HasColumnName("csll");
            entity.Property(e => e.Denegada)
                .HasMaxLength(100)
                .HasColumnName("denegada");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.Desconto2)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("'0.0000'")
                .HasColumnName("desconto2");
            entity.Property(e => e.Descricaocfop)
                .HasMaxLength(255)
                .HasColumnName("descricaocfop");
            entity.Property(e => e.Descricaoplano)
                .HasMaxLength(150)
                .HasColumnName("descricaoplano");
            entity.Property(e => e.Descricaorecebimento)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe")
                .HasColumnName("descricaorecebimento");
            entity.Property(e => e.Despesa)
                .HasPrecision(18, 4)
                .HasColumnName("despesa");
            entity.Property(e => e.Devolucao)
                .HasMaxLength(5)
                .HasColumnName("devolucao");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Documentomdfe)
                .HasMaxLength(20)
                .HasColumnName("documentomdfe");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Emitido)
                .HasMaxLength(5)
                .HasColumnName("emitido");
            entity.Property(e => e.Empresa)
                .HasMaxLength(25)
                .HasColumnName("empresa");
            entity.Property(e => e.Entregaromaneio)
                .HasColumnType("datetime")
                .HasColumnName("entregaromaneio");
            entity.Property(e => e.Especie)
                .HasMaxLength(15)
                .HasColumnName("especie");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(150)
                .HasColumnName("fantasia");
            entity.Property(e => e.Fantasiafornecedor)
                .HasMaxLength(50)
                .HasColumnName("fantasiafornecedor");
            entity.Property(e => e.Fat)
                .HasMaxLength(5)
                .HasColumnName("fat");
            entity.Property(e => e.Faturado)
                .HasMaxLength(5)
                .HasColumnName("faturado");
            entity.Property(e => e.Faturamento)
                .HasMaxLength(50)
                .HasColumnName("faturamento");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(50)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Frete)
                .HasMaxLength(10)
                .HasColumnName("frete");
            entity.Property(e => e.Fretevalor)
                .HasPrecision(18, 4)
                .HasColumnName("fretevalor");
            entity.Property(e => e.Gnre)
                .HasMaxLength(5)
                .HasColumnName("gnre");
            entity.Property(e => e.Hidrometro)
                .HasMaxLength(24)
                .HasColumnName("hidrometro");
            entity.Property(e => e.Historicoremoverfinanceiro)
                .HasMaxLength(50)
                .HasColumnName("historicoremoverfinanceiro");
            entity.Property(e => e.Icms)
                .HasPrecision(18, 2)
                .HasColumnName("icms");
            entity.Property(e => e.Icmsfrete)
                .HasMaxLength(2)
                .HasColumnName("icmsfrete");
            entity.Property(e => e.Icmssubst)
                .HasPrecision(18, 2)
                .HasColumnName("icmssubst");
            entity.Property(e => e.Impostoaproximado)
                .HasPrecision(18, 2)
                .HasColumnName("impostoaproximado");
            entity.Property(e => e.Inss)
                .HasPrecision(18, 2)
                .HasColumnName("inss");
            entity.Property(e => e.Ipi)
                .HasPrecision(18, 2)
                .HasColumnName("ipi");
            entity.Property(e => e.IpiBcicms)
                .HasMaxLength(5)
                .HasColumnName("ipi_bcicms");
            entity.Property(e => e.Irpj)
                .HasPrecision(18, 2)
                .HasColumnName("irpj");
            entity.Property(e => e.Kmandamento)
                .HasMaxLength(24)
                .HasColumnName("kmandamento");
            entity.Property(e => e.Lacre1)
                .HasMaxLength(20)
                .HasColumnName("lacre1");
            entity.Property(e => e.Lacre2)
                .HasMaxLength(20)
                .HasColumnName("lacre2");
            entity.Property(e => e.Localentrega)
                .HasColumnType("int(11)")
                .HasColumnName("localentrega");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .HasColumnName("marca");
            entity.Property(e => e.Modelobc)
                .HasMaxLength(2)
                .HasColumnName("modelobc");
            entity.Property(e => e.Mododesconto)
                .HasMaxLength(1)
                .HasColumnName("mododesconto");
            entity.Property(e => e.Motivocancelamento)
                .HasMaxLength(255)
                .HasColumnName("motivocancelamento");
            entity.Property(e => e.Municipioprestacaoservico)
                .HasMaxLength(50)
                .HasColumnName("municipioprestacaoservico");
            entity.Property(e => e.Nferef)
                .HasMaxLength(44)
                .HasColumnName("nferef");
            entity.Property(e => e.Nfse)
                .HasMaxLength(1)
                .HasColumnName("nfse");
            entity.Property(e => e.Nomeusuario)
                .HasMaxLength(20)
                .HasColumnName("nomeusuario");
            entity.Property(e => e.Nomevendedor1)
                .HasMaxLength(50)
                .HasColumnName("nomevendedor1");
            entity.Property(e => e.Nomevendedor2)
                .HasMaxLength(50)
                .HasColumnName("nomevendedor2");
            entity.Property(e => e.Numeroparcelas)
                .HasColumnType("int(11)")
                .HasColumnName("numeroparcelas");
            entity.Property(e => e.Numerovolume)
                .HasMaxLength(10)
                .HasColumnName("numerovolume");
            entity.Property(e => e.Observacao)
                .HasMaxLength(1000)
                .HasColumnName("observacao");
            entity.Property(e => e.Observacaofisco)
                .HasMaxLength(500)
                .HasColumnName("observacaofisco");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(20)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.Origem)
                .HasMaxLength(50)
                .HasColumnName("origem");
            entity.Property(e => e.Pbruto)
                .HasPrecision(18, 2)
                .HasColumnName("pbruto");
            entity.Property(e => e.Pedido)
                .HasMaxLength(50)
                .HasColumnName("pedido");
            entity.Property(e => e.Percentual)
                .HasPrecision(18, 2)
                .HasColumnName("percentual_");
            entity.Property(e => e.Percentualissretido)
                .HasPrecision(18, 2)
                .HasColumnName("percentualissretido");
            entity.Property(e => e.Pis)
                .HasPrecision(18, 2)
                .HasColumnName("pis");
            entity.Property(e => e.Placa)
                .HasMaxLength(8)
                .HasColumnName("placa");
            entity.Property(e => e.Placa1)
                .HasMaxLength(8)
                .HasColumnName("placa1");
            entity.Property(e => e.Placa2)
                .HasMaxLength(8)
                .HasColumnName("placa2");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(20)
                .HasColumnName("planocontas");
            entity.Property(e => e.Pliquido)
                .HasPrecision(18, 2)
                .HasColumnName("pliquido");
            entity.Property(e => e.Protocolo)
                .HasMaxLength(20)
                .HasColumnName("protocolo");
            entity.Property(e => e.Qtdparcelas)
                .HasColumnType("int(11)")
                .HasColumnName("qtdparcelas");
            entity.Property(e => e.Quantidadevol)
                .HasMaxLength(50)
                .HasColumnName("quantidadevol");
            entity.Property(e => e.Razao)
                .HasMaxLength(150)
                .HasColumnName("razao");
            entity.Property(e => e.Razao2)
                .HasMaxLength(150)
                .HasColumnName("razao2");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(3)
                .HasColumnName("recebimento");
            entity.Property(e => e.Recibonfe)
                .HasMaxLength(50)
                .HasColumnName("recibonfe");
            entity.Property(e => e.Romaneio)
                .HasMaxLength(50)
                .HasColumnName("romaneio");
            entity.Property(e => e.Saida)
                .HasColumnType("datetime")
                .HasColumnName("saida");
            entity.Property(e => e.Saidaromaneio)
                .HasColumnType("datetime")
                .HasColumnName("saidaromaneio");
            entity.Property(e => e.Seqcce)
                .HasColumnType("int(11)")
                .HasColumnName("seqcce");
            entity.Property(e => e.Serie)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("serie");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.St)
                .HasMaxLength(5)
                .HasColumnName("st");
            entity.Property(e => e.Statusvenda)
                .HasMaxLength(50)
                .HasColumnName("statusvenda");
            entity.Property(e => e.Tabela)
                .HasMaxLength(50)
                .HasColumnName("tabela");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipocfop)
                .HasMaxLength(50)
                .HasColumnName("tipocfop");
            entity.Property(e => e.Tipodesconto)
                .HasMaxLength(2)
                .HasColumnName("tipodesconto");
            entity.Property(e => e.Tipoemissao)
                .HasMaxLength(50)
                .HasColumnName("tipoemissao");
            entity.Property(e => e.Tipofrete)
                .HasMaxLength(10)
                .HasColumnName("tipofrete");
            entity.Property(e => e.Total)
                .HasPrecision(18, 2)
                .HasColumnName("total");
            entity.Property(e => e.Total2)
                .HasPrecision(18, 2)
                .HasColumnName("total2");
            entity.Property(e => e.Totalproduto)
                .HasPrecision(18, 2)
                .HasColumnName("totalproduto");
            entity.Property(e => e.Totalproduto2)
                .HasPrecision(18, 2)
                .HasColumnName("totalproduto2");
            entity.Property(e => e.Transportadora)
                .HasMaxLength(100)
                .HasColumnName("transportadora");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.Ufplaca)
                .HasMaxLength(2)
                .HasColumnName("ufplaca");
            entity.Property(e => e.Usuario)
                .HasMaxLength(4)
                .HasColumnName("usuario");
            entity.Property(e => e.Vale)
                .HasMaxLength(5)
                .HasColumnName("vale");
            entity.Property(e => e.Valorcomissaorepresentante)
                .HasPrecision(18, 2)
                .HasColumnName("valorcomissaorepresentante");
            entity.Property(e => e.Valoricms)
                .HasPrecision(18, 2)
                .HasColumnName("valoricms");
            entity.Property(e => e.Valoricmsst)
                .HasPrecision(18, 2)
                .HasColumnName("valoricmsst");
            entity.Property(e => e.Valoripi)
                .HasPrecision(18, 2)
                .HasColumnName("valoripi");
            entity.Property(e => e.Valorissretido)
                .HasPrecision(18, 2)
                .HasColumnName("valorissretido");
            entity.Property(e => e.Vbcipi)
                .HasPrecision(18, 2)
                .HasColumnName("vbcipi");
            entity.Property(e => e.Vbsipi)
                .HasPrecision(18, 2)
                .HasColumnName("vbsipi");
            entity.Property(e => e.Vendedor1)
                .HasMaxLength(5)
                .HasColumnName("vendedor1");
            entity.Property(e => e.Vendedor2)
                .HasMaxLength(5)
                .HasColumnName("vendedor2");
            entity.Property(e => e.XmlAssinado).HasColumnName("xml_assinado");
            entity.Property(e => e.XmlProc).HasColumnName("xml_proc");
        });

        modelBuilder.Entity<VwComisliquidez1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_comisliquidez1");

            entity.Property(e => e.Chave1)
                .HasColumnType("int(11)")
                .HasColumnName("chave1");
            entity.Property(e => e.Codigovendedor)
                .HasMaxLength(5)
                .HasColumnName("codigovendedor");
            entity.Property(e => e.Comissao)
                .HasPrecision(18, 2)
                .HasColumnName("comissao");
            entity.Property(e => e.Diferenca)
                .HasPrecision(19, 2)
                .HasColumnName("diferenca");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Documento3)
                .HasMaxLength(50)
                .HasColumnName("documento3");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(25)
                .HasColumnName("empresa");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(150)
                .HasColumnName("fantasia");
            entity.Property(e => e.Nomevendedor)
                .HasMaxLength(50)
                .HasColumnName("nomevendedor");
            entity.Property(e => e.Pagamento)
                .HasColumnType("datetime")
                .HasColumnName("pagamento");
            entity.Property(e => e.Percentualdiferenca)
                .HasPrecision(31, 10)
                .HasColumnName("percentualdiferenca");
            entity.Property(e => e.Razao)
                .HasMaxLength(150)
                .HasColumnName("razao");
            entity.Property(e => e.Total)
                .HasPrecision(18, 2)
                .HasColumnName("total");
            entity.Property(e => e.Totalprodutos)
                .HasPrecision(18, 2)
                .HasColumnName("totalprodutos");
            entity.Property(e => e.Valor)
                .HasPrecision(51, 12)
                .HasColumnName("valor");
            entity.Property(e => e.Valorbruto)
                .HasPrecision(18, 2)
                .HasColumnName("valorbruto");
            entity.Property(e => e.Valorparcial).HasColumnName("valorparcial");
            entity.Property(e => e.Vencimento)
                .HasColumnType("datetime")
                .HasColumnName("vencimento");
        });

        modelBuilder.Entity<VwContaspagar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_contaspagar");

            entity.Property(e => e.Acompanhamento)
                .HasMaxLength(5)
                .HasColumnName("acompanhamento");
            entity.Property(e => e.Ag)
                .HasMaxLength(15)
                .HasColumnName("ag");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasColumnName("banco");
            entity.Property(e => e.Bb)
                .HasMaxLength(5)
                .HasColumnName("bb");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasColumnName("cancelado");
            entity.Property(e => e.Cc)
                .HasMaxLength(15)
                .HasColumnName("cc");
            entity.Property(e => e.Centrocusto)
                .HasMaxLength(50)
                .HasColumnName("centrocusto");
            entity.Property(e => e.Chave1)
                .HasColumnType("int(11)")
                .HasColumnName("chave1");
            entity.Property(e => e.Chave2)
                .HasMaxLength(5)
                .HasColumnName("chave2");
            entity.Property(e => e.Cheque)
                .HasMaxLength(15)
                .HasColumnName("cheque");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(25)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codigobanco)
                .HasMaxLength(3)
                .HasColumnName("codigobanco");
            entity.Property(e => e.Codigorecebimento)
                .HasMaxLength(5)
                .HasColumnName("codigorecebimento");
            entity.Property(e => e.Compra)
                .HasMaxLength(10)
                .HasColumnName("compra");
            entity.Property(e => e.Datacancelamento)
                .HasColumnType("datetime")
                .HasColumnName("datacancelamento");
            entity.Property(e => e.Descricaoplano)
                .HasMaxLength(50)
                .HasColumnName("descricaoplano");
            entity.Property(e => e.Dias)
                .HasMaxLength(10)
                .HasColumnName("dias");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Documento3)
                .HasMaxLength(50)
                .HasColumnName("documento3");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(10000)
                .HasColumnName("empresa");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasColumnName("estado");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(250)
                .HasColumnName("fantasia");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(5)
                .HasColumnName("fornecedor");
            entity.Property(e => e.Historico)
                .HasMaxLength(250)
                .HasColumnName("historico");
            entity.Property(e => e.Idmultibaixas)
                .HasColumnType("int(11)")
                .HasColumnName("idmultibaixas");
            entity.Property(e => e.Liberacaodesconto)
                .HasMaxLength(25)
                .HasColumnName("liberacaodesconto");
            entity.Property(e => e.Observacao)
                .HasMaxLength(250)
                .HasColumnName("observacao");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(20)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.Origem)
                .HasMaxLength(3)
                .HasColumnName("origem");
            entity.Property(e => e.Pagamento)
                .HasColumnType("datetime")
                .HasColumnName("pagamento");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(50)
                .HasColumnName("planocontas");
            entity.Property(e => e.Razao)
                .HasMaxLength(250)
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe")
                .HasColumnName("recebimento");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.ResponsavelBanco)
                .HasMaxLength(25)
                .HasColumnName("responsavel_banco");
            entity.Property(e => e.Seqpagparcial)
                .HasColumnType("int(11)")
                .HasColumnName("seqpagparcial");
            entity.Property(e => e.Tipo)
                .HasMaxLength(11)
                .HasColumnName("tipo")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.Unificado)
                .HasMaxLength(20)
                .HasColumnName("unificado");
            entity.Property(e => e.Usuariobaixa)
                .HasMaxLength(50)
                .HasColumnName("usuariobaixa");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 4)
                .HasColumnName("valor");
            entity.Property(e => e.Valordesconto)
                .HasPrecision(10, 4)
                .HasColumnName("valordesconto");
            entity.Property(e => e.Valorparcial)
                .HasPrecision(10, 4)
                .HasColumnName("valorparcial");
            entity.Property(e => e.Vencimento)
                .HasColumnType("datetime")
                .HasColumnName("vencimento");
        });

        modelBuilder.Entity<VwContasreceber>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_contasreceber");

            entity.Property(e => e.Acompanhamento)
                .HasMaxLength(5)
                .HasColumnName("acompanhamento");
            entity.Property(e => e.Ag)
                .HasMaxLength(50)
                .HasColumnName("ag");
            entity.Property(e => e.Au)
                .HasMaxLength(5)
                .HasColumnName("au");
            entity.Property(e => e.Backcampodocumento)
                .HasMaxLength(20)
                .HasColumnName("backcampodocumento");
            entity.Property(e => e.Banco)
                .HasMaxLength(50)
                .HasColumnName("banco");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasColumnName("cancelado");
            entity.Property(e => e.Cc)
                .HasMaxLength(50)
                .HasColumnName("cc");
            entity.Property(e => e.Ch)
                .HasMaxLength(1)
                .HasColumnName("ch");
            entity.Property(e => e.Chave1)
                .HasColumnType("int(11)")
                .HasColumnName("chave1");
            entity.Property(e => e.Chave2)
                .HasMaxLength(10)
                .HasColumnName("chave2");
            entity.Property(e => e.Cheque)
                .HasMaxLength(50)
                .HasColumnName("cheque");
            entity.Property(e => e.Cliente)
                .HasMaxLength(6)
                .HasColumnName("cliente");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(25)
                .HasColumnName("cnpj");
            entity.Property(e => e.Codigobanco)
                .HasMaxLength(3)
                .HasColumnName("codigobanco");
            entity.Property(e => e.Codigorecebimento)
                .HasMaxLength(5)
                .HasColumnName("codigorecebimento");
            entity.Property(e => e.Compra)
                .HasMaxLength(10)
                .HasColumnName("compra");
            entity.Property(e => e.DataPgComissao)
                .HasColumnType("datetime")
                .HasColumnName("data_pg_comissao");
            entity.Property(e => e.Datacancelamento)
                .HasColumnType("datetime")
                .HasColumnName("datacancelamento");
            entity.Property(e => e.Dataremessa)
                .HasMaxLength(10)
                .HasColumnName("dataremessa");
            entity.Property(e => e.Dataretorno)
                .HasMaxLength(10)
                .HasColumnName("dataretorno");
            entity.Property(e => e.Descricaoplano)
                .HasMaxLength(250)
                .HasColumnName("descricaoplano");
            entity.Property(e => e.Dias)
                .HasMaxLength(10)
                .HasColumnName("dias");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Documento2)
                .HasMaxLength(50)
                .HasColumnName("documento2");
            entity.Property(e => e.Documento3)
                .HasMaxLength(50)
                .HasColumnName("documento3");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(25)
                .HasColumnName("empresa");
            entity.Property(e => e.Enviolembrete)
                .HasMaxLength(1)
                .HasColumnName("enviolembrete");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .HasColumnName("estado");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(250)
                .HasColumnName("fantasia");
            entity.Property(e => e.Forma)
                .HasMaxLength(100)
                .HasColumnName("forma");
            entity.Property(e => e.Historico)
                .HasMaxLength(500)
                .HasColumnName("historico");
            entity.Property(e => e.Lembraremailcar)
                .HasMaxLength(5)
                .HasColumnName("lembraremailcar");
            entity.Property(e => e.Liberacaodesconto)
                .HasMaxLength(25)
                .HasColumnName("liberacaodesconto");
            entity.Property(e => e.Modelobanco)
                .HasMaxLength(5)
                .HasColumnName("modelobanco");
            entity.Property(e => e.Observacao)
                .HasMaxLength(150)
                .HasColumnName("observacao");
            entity.Property(e => e.Observacaoboleto)
                .HasMaxLength(255)
                .HasColumnName("observacaoboleto");
            entity.Property(e => e.Ordemcompra)
                .HasMaxLength(50)
                .HasColumnName("ordemcompra");
            entity.Property(e => e.Origem)
                .HasMaxLength(3)
                .HasColumnName("origem");
            entity.Property(e => e.Pagamento)
                .HasColumnType("datetime")
                .HasColumnName("pagamento");
            entity.Property(e => e.Pedido)
                .HasMaxLength(50)
                .HasColumnName("pedido");
            entity.Property(e => e.Planocontas)
                .HasMaxLength(50)
                .HasColumnName("planocontas");
            entity.Property(e => e.Razao)
                .HasMaxLength(250)
                .HasColumnName("razao");
            entity.Property(e => e.Recebimento)
                .HasMaxLength(60)
                .HasComment("Descrição de recebimento com no máximo 60 caracteres de acordo com manual nfe")
                .HasColumnName("recebimento");
            entity.Property(e => e.Referencias)
                .HasMaxLength(500)
                .HasColumnName("referencias");
            entity.Property(e => e.Remessa)
                .HasMaxLength(5)
                .HasColumnName("remessa");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(50)
                .HasColumnName("responsavel");
            entity.Property(e => e.ResponsavelBanco)
                .HasMaxLength(50)
                .HasColumnName("responsavel_banco");
            entity.Property(e => e.Retorno)
                .HasMaxLength(5)
                .HasColumnName("retorno");
            entity.Property(e => e.Romaneio)
                .HasMaxLength(50)
                .HasColumnName("romaneio");
            entity.Property(e => e.Seqpagparcial)
                .HasColumnType("int(11)")
                .HasColumnName("seqpagparcial");
            entity.Property(e => e.Situacao)
                .HasMaxLength(5)
                .HasColumnName("situacao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(11)
                .HasColumnName("tipo")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.Ultimaparcela)
                .HasMaxLength(5)
                .HasColumnName("ultimaparcela");
            entity.Property(e => e.Unificado)
                .HasMaxLength(5)
                .HasColumnName("unificado");
            entity.Property(e => e.Usuariobaixa)
                .HasMaxLength(50)
                .HasColumnName("usuariobaixa");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasColumnName("valor");
            entity.Property(e => e.Valordesconto)
                .HasPrecision(18, 2)
                .HasColumnName("valordesconto");
            entity.Property(e => e.Valorparcial)
                .HasPrecision(18, 2)
                .HasColumnName("valorparcial");
            entity.Property(e => e.Vencimento)
                .HasColumnType("datetime")
                .HasColumnName("vencimento");
        });

        modelBuilder.Entity<VwEstoque>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_estoque");

            entity.Property(e => e.Almoxarifado)
                .HasMaxLength(5)
                .HasColumnName("almoxarifado")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Aplicacao)
                .HasMaxLength(255)
                .HasColumnName("aplicacao")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Calculacustost)
                .HasMaxLength(5)
                .HasColumnName("calculacustost")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Cbarra)
                .HasMaxLength(20)
                .HasColumnName("cbarra")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Cf)
                .HasMaxLength(8)
                .HasColumnName("cf")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Codigofornecedor)
                .HasMaxLength(6)
                .HasColumnName("codigofornecedor")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Dataatualizacao)
                .HasMaxLength(15)
                .HasColumnName("dataatualizacao")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Descricao)
                .HasMaxLength(10000)
                .HasColumnName("descricao")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Estoque)
                .HasPrecision(14, 2)
                .HasColumnName("estoque");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(300)
                .HasColumnName("fornecedor")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Inativo)
                .HasMaxLength(5)
                .HasColumnName("inativo")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Informacoesadicionais)
                .HasMaxLength(4000)
                .HasColumnName("informacoesadicionais")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .HasColumnName("marca")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Pendencia)
                .HasColumnType("int(1)")
                .HasColumnName("pendencia");
            entity.Property(e => e.Preco1)
                .HasPrecision(10, 4)
                .HasColumnName("preco1");
            entity.Property(e => e.Preco10)
                .HasPrecision(10, 4)
                .HasColumnName("preco10");
            entity.Property(e => e.Preco2)
                .HasPrecision(10, 4)
                .HasColumnName("preco2");
            entity.Property(e => e.Preco3)
                .HasPrecision(10, 4)
                .HasColumnName("preco3");
            entity.Property(e => e.Preco4)
                .HasPrecision(10, 4)
                .HasColumnName("preco4");
            entity.Property(e => e.Preco5)
                .HasPrecision(10, 4)
                .HasColumnName("preco5");
            entity.Property(e => e.Preco6)
                .HasPrecision(10, 4)
                .HasColumnName("preco6");
            entity.Property(e => e.Preco7)
                .HasPrecision(10, 4)
                .HasColumnName("preco7");
            entity.Property(e => e.Preco8)
                .HasPrecision(10, 4)
                .HasColumnName("preco8");
            entity.Property(e => e.Preco9)
                .HasPrecision(10, 4)
                .HasColumnName("preco9");
            entity.Property(e => e.Precovenda)
                .HasPrecision(18, 4)
                .HasColumnName("precovenda");
            entity.Property(e => e.Previsao)
                .HasColumnType("int(1)")
                .HasColumnName("previsao");
            entity.Property(e => e.Produto)
                .HasMaxLength(40)
                .HasColumnName("produto")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Qtd)
                .HasPrecision(10, 4)
                .HasColumnName("qtd");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .HasColumnName("referencia")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Servico)
                .HasMaxLength(5)
                .HasColumnName("servico")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Similar)
                .HasMaxLength(10)
                .HasColumnName("similar")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Unidade)
                .HasMaxLength(15)
                .HasColumnName("unidade")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Validade)
                .HasColumnType("datetime")
                .HasColumnName("validade");
            entity.Property(e => e.Venda)
                .HasMaxLength(5)
                .HasDefaultValueSql("'true'")
                .HasColumnName("venda")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Vendedores)
                .HasMaxLength(1000)
                .HasColumnName("vendedores")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
        });

        modelBuilder.Entity<VwEstoqueatual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_estoqueatual");

            entity.Property(e => e.Aplicacao)
                .HasMaxLength(255)
                .HasColumnName("aplicacao")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Codigofornecedor)
                .HasMaxLength(6)
                .HasColumnName("codigofornecedor")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Codigogrupo)
                .HasMaxLength(6)
                .HasColumnName("codigogrupo")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Custo)
                .HasPrecision(18, 4)
                .HasColumnName("custo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(10000)
                .HasColumnName("descricao")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Descricaogrupo)
                .HasMaxLength(50)
                .HasColumnName("descricaogrupo")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Estoque)
                .HasPrecision(14, 2)
                .HasColumnName("estoque");
            entity.Property(e => e.Fornecedor)
                .HasMaxLength(300)
                .HasColumnName("fornecedor")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Pliquido)
                .HasPrecision(10, 2)
                .HasColumnName("pliquido");
            entity.Property(e => e.Preco1)
                .HasPrecision(10, 4)
                .HasColumnName("preco1");
            entity.Property(e => e.Precovenda)
                .HasPrecision(18, 4)
                .HasColumnName("precovenda");
            entity.Property(e => e.Produto)
                .HasMaxLength(40)
                .HasColumnName("produto")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Qtdminima)
                .HasPrecision(10, 2)
                .HasColumnName("qtdminima");
            entity.Property(e => e.Qtdvolume)
                .HasPrecision(10, 4)
                .HasColumnName("qtdvolume");
            entity.Property(e => e.Referencia)
                .HasMaxLength(50)
                .HasColumnName("referencia")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Total)
                .HasColumnType("int(1)")
                .HasColumnName("total");
            entity.Property(e => e.Unidade)
                .HasMaxLength(15)
                .HasColumnName("unidade")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
        });

        modelBuilder.Entity<VwEstoquelote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_estoquelote");

            entity.Property(e => e.Cancelado)
                .HasMaxLength(5)
                .HasColumnName("cancelado");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("descricao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(25)
                .HasColumnName("empresa");
            entity.Property(e => e.Fabricacao)
                .HasColumnType("datetime")
                .HasColumnName("fabricacao");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Localizacao)
                .HasMaxLength(50)
                .HasColumnName("localizacao");
            entity.Property(e => e.Lote)
                .HasMaxLength(50)
                .HasColumnName("lote");
            entity.Property(e => e.Movimentaestoque)
                .HasMaxLength(5)
                .HasColumnName("movimentaestoque");
            entity.Property(e => e.Produto)
                .HasMaxLength(40)
                .HasColumnName("produto");
            entity.Property(e => e.Quantidade)
                .HasPrecision(40, 4)
                .HasColumnName("quantidade");
            entity.Property(e => e.Validade)
                .HasColumnType("datetime")
                .HasColumnName("validade");
        });

        modelBuilder.Entity<VwLegendaproducao>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_legendaproducao");

            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .HasColumnName("descricao");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Ficha)
                .HasMaxLength(5)
                .HasColumnName("ficha");
            entity.Property(e => e.Liberado)
                .HasMaxLength(5)
                .HasColumnName("liberado");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .HasColumnName("marca")
                .UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");
            entity.Property(e => e.Produto)
                .HasMaxLength(20)
                .HasColumnName("produto");
            entity.Property(e => e.Quantidade)
                .HasPrecision(32, 4)
                .HasColumnName("quantidade");
        });

        modelBuilder.Entity<VwListaCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_lista_compras");

            entity.Property(e => e.Cancelado)
                .HasMaxLength(10)
                .HasColumnName("cancelado");
            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Denegada)
                .HasPrecision(18, 4)
                .HasColumnName("denegada");
            entity.Property(e => e.Documento)
                .HasMaxLength(15)
                .HasComment("Guarda documento de compra")
                .HasColumnName("documento");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Emitido)
                .HasMaxLength(5)
                .HasColumnName("emitido");
            entity.Property(e => e.Empresa)
                .HasMaxLength(10000)
                .HasColumnName("empresa");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(150)
                .HasColumnName("fantasia");
            entity.Property(e => e.Razao)
                .HasMaxLength(150)
                .HasColumnName("razao");
            entity.Property(e => e.Total)
                .HasPrecision(10, 4)
                .HasColumnName("total");
        });

        modelBuilder.Entity<VwListaOrdemservico>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_lista_ordemservico");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.Entrada)
                .HasColumnType("datetime")
                .HasColumnName("entrada");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(50)
                .HasColumnName("fantasia");
            entity.Property(e => e.Faturado)
                .HasMaxLength(1)
                .HasColumnName("faturado");
            entity.Property(e => e.Finalizada)
                .HasMaxLength(5)
                .HasColumnName("finalizada");
            entity.Property(e => e.Razao)
                .HasMaxLength(150)
                .HasColumnName("razao");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");
            entity.Property(e => e.Total)
                .HasPrecision(10, 4)
                .HasColumnName("total");
        });

        modelBuilder.Entity<VwListaPedidocompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_lista_pedidocompra");

            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("documento");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(150)
                .HasColumnName("fantasia");
            entity.Property(e => e.Razao)
                .HasMaxLength(150)
                .HasColumnName("razao");
            entity.Property(e => e.Total)
                .HasPrecision(10, 4)
                .HasColumnName("total");
        });

        modelBuilder.Entity<VwListaPedidovendum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_lista_pedidovenda");

            entity.Property(e => e.Cancelado)
                .HasColumnType("datetime")
                .HasColumnName("cancelado");
            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Empresa)
                .HasMaxLength(20)
                .HasColumnName("empresa");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(80)
                .HasColumnName("fantasia");
            entity.Property(e => e.Razao)
                .HasMaxLength(80)
                .HasColumnName("razao");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasColumnName("situacao");
            entity.Property(e => e.Total)
                .HasPrecision(10, 4)
                .HasColumnName("total");
            entity.Property(e => e.Vendedor1)
                .HasMaxLength(5)
                .HasColumnName("vendedor1");
        });

        modelBuilder.Entity<VwListaVenda>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_lista_vendas");

            entity.Property(e => e.Cancelado)
                .HasMaxLength(30)
                .HasColumnName("cancelado");
            entity.Property(e => e.Chave)
                .HasColumnType("int(11)")
                .HasColumnName("chave");
            entity.Property(e => e.Cnpjcpf)
                .HasMaxLength(25)
                .HasColumnName("cnpjcpf");
            entity.Property(e => e.Denegada)
                .HasMaxLength(100)
                .HasColumnName("denegada");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .HasColumnName("documento");
            entity.Property(e => e.Emissao)
                .HasColumnType("datetime")
                .HasColumnName("emissao");
            entity.Property(e => e.Emitido)
                .HasMaxLength(5)
                .HasColumnName("emitido");
            entity.Property(e => e.Empresa)
                .HasMaxLength(25)
                .HasColumnName("empresa");
            entity.Property(e => e.Fantasia)
                .HasMaxLength(150)
                .HasColumnName("fantasia");
            entity.Property(e => e.Razao)
                .HasMaxLength(150)
                .HasColumnName("razao");
            entity.Property(e => e.Total)
                .HasPrecision(18, 2)
                .HasColumnName("total");
        });

        modelBuilder.Entity<VwSomaestoque>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_somaestoque");

            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Empresa)
                .HasMaxLength(25)
                .HasColumnName("empresa");
            entity.Property(e => e.Estoque)
                .HasPrecision(40, 4)
                .HasColumnName("estoque");
            entity.Property(e => e.Produto)
                .HasMaxLength(40)
                .HasColumnName("produto");
        });

        modelBuilder.Entity<VwSomanfce>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_somanfce");

            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Estoque)
                .HasPrecision(40, 4)
                .HasColumnName("estoque");
            entity.Property(e => e.Produto)
                .HasMaxLength(10)
                .HasColumnName("produto");
        });

        modelBuilder.Entity<VwSomaordemservico>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_somaordemservico");

            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("data");
            entity.Property(e => e.Estoque)
                .HasPrecision(32, 4)
                .HasColumnName("estoque");
            entity.Property(e => e.Produto)
                .HasMaxLength(20)
                .HasComment("Guarda código do produto na Ordem de Serviço")
                .HasColumnName("produto");
        });

        modelBuilder.Entity<Webservice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("webservices");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ambiente)
                .HasColumnType("int(11)")
                .HasColumnName("ambiente");
            entity.Property(e => e.Consultaprotocolo)
                .HasMaxLength(500)
                .HasColumnName("consultaprotocolo");
            entity.Property(e => e.Consultastatus)
                .HasMaxLength(500)
                .HasColumnName("consultastatus");
            entity.Property(e => e.Inutilizacao)
                .HasMaxLength(500)
                .HasColumnName("inutilizacao");
            entity.Property(e => e.Recepcao)
                .HasMaxLength(500)
                .HasColumnName("recepcao");
            entity.Property(e => e.Recepcaoevento)
                .HasMaxLength(500)
                .HasColumnName("recepcaoevento");
            entity.Property(e => e.Retrecepcao)
                .HasMaxLength(500)
                .HasColumnName("retrecepcao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .HasColumnName("tipo");
            entity.Property(e => e.Uf)
                .HasMaxLength(20)
                .HasColumnName("uf");
            entity.Property(e => e.Versao)
                .HasMaxLength(5)
                .HasColumnName("versao");
        });

        modelBuilder.Entity<Y1>(entity =>
        {
            entity.HasKey(e => e.Sh).HasName("PRIMARY");

            entity.ToTable("y1");

            entity.Property(e => e.Sh)
                .HasMaxLength(150)
                .HasColumnName("sh");
        });

        modelBuilder.Entity<Y2>(entity =>
        {
            entity.HasKey(e => e.Inscricao).HasName("PRIMARY");

            entity.ToTable("y2");

            entity.Property(e => e.Inscricao)
                .HasMaxLength(100)
                .HasColumnName("inscricao");
            entity.Property(e => e.Valida)
                .HasMaxLength(5)
                .HasColumnName("valida");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
