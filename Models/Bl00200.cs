namespace AntaresAPI.Models;

/// <summary>
/// Tabela de Identificação do Item (Produtos e Serviços) no SPED
/// Este registro tem por objetivo informar as mercadorias, serviços, produtos ou quaisquer outros itens concernentes às
/// transações representativas de receitas e/ou geradoras de créditos, objeto de escrituração nos Blocos A, C, D, F ou 1.
/// </summary>
public partial class Bl00200
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo 0200 - 4 caracteres
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Código do item - 60 caracteres
    /// </summary>
    public string? CodItem { get; set; }

    /// <summary>
    /// Descrição do item
    /// </summary>
    public string? DescrItem { get; set; }

    /// <summary>
    /// Representação alfanumérico do código de barra do
    /// produto, se houver- 60 caracteres
    /// </summary>
    public string? CodBarra { get; set; }

    /// <summary>
    /// Código anterior do item com relação à última informação - 60 caracteres
    /// </summary>
    public string? CodAntItem { get; set; }

    /// <summary>
    /// Unidade de medida utilizada na quantificação de
    /// estoques - 6 caracteres
    /// </summary>
    public string? UnidInv { get; set; }

    /// <summary>
    /// Tipo do item – Atividades Industriais, Comerciais e
    /// Serviços:
    /// 00 – Mercadoria para Revenda;
    /// 01 – Matéria-Prima;
    /// 02 – Embalagem;
    /// 03 – Produto em Processo;
    /// 04 – Produto Acabado;
    /// 05 – Subproduto;
    /// 06 – Produto Intermediário;
    /// 07 – Material de Uso e Consumo;
    /// 08 – Ativo Imobilizado;
    /// 09 – Serviços;
    /// 10 – Outros insumos;
    /// 99 – Outras
    /// 2 caracteres
    /// </summary>
    public string? TipoItem { get; set; }

    /// <summary>
    /// Código da Nomenclatura Comum do Mercosul - 8 caracteres
    /// </summary>
    public string? CodNcm { get; set; }

    /// <summary>
    /// Código EX, conforme a TIPI - 3 caracteres
    /// </summary>
    public string? ExIpi { get; set; }

    /// <summary>
    /// Código do gênero do item, conforme a Tabela 4.2.1. - 2 caracteres
    /// </summary>
    public string? CodGen { get; set; }

    /// <summary>
    /// Código do serviço conforme lista do Anexo I da Lei
    /// Complementar Federal nº 116/03. Obs: A partir do período de apuração maio de 2015
    /// (versão 2.11 do PVA), o código a ser informado neste
    /// campo poderá ser informado 05 (cinco) caracteres, no
    /// formato “XX.XX”, conforme a codificação adotada na
    /// Lei Complementar nº 116/2003 e na EFD-ICMS/IPI - 5 caracteres
    /// </summary>
    public string? CodLst { get; set; }

    /// <summary>
    /// Alíquota de ICMS aplicável ao item naoperações
    /// internas - 6 caracteres
    /// </summary>
    public decimal? AliqIcms { get; set; }

    /// <summary>
    /// Código Especificador da Substituição Tributária - 7 caracteres
    /// </summary>
    public string? Cest { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo.
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
