namespace AntaresAPI.Models;

/// <summary>
/// Este registro tem por objetivo codificar os textos das diferentes naturezas da operação/prestações discriminadas nos
/// documentos fiscais. Esta codificação e suas descrições são livremente criadas e mantidas pelo contribuinte.
/// Este registro não se refere ao CFOP. Algumas empresas utilizam outra classificação além das apresentadas nos
/// CFOP. Esta codificação permite informar estes agrupamentos próprios.
/// Validação do Registro: Não podem ser informados dois ou mais registros com o mesmo conteúdo no campo COD_NAT.
/// </summary>
public partial class Bl00400
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo 0400
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Código da natureza da operação/prestação - 10 caracteres
    /// </summary>
    public string? CodNat { get; set; }

    /// <summary>
    /// Descrição da natureza da operação/prestação
    /// </summary>
    public string? DescrNat { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
