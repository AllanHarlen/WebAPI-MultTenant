namespace AntaresAPI.Models;

public partial class BlH005
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;H005&quot; 
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Data do inventário
    /// </summary>
    public DateTime? DtInv { get; set; }

    /// <summary>
    /// Valor total do estoque - decimal com 2 casas
    /// </summary>
    public decimal? VlInv { get; set; }

    /// <summary>
    /// nforme o motivo do Inventário:
    /// 01 – No final no período;
    /// 02 – Na mudança de forma de tributação da mercadoria (ICMS);
    /// 03 – Na solicitação da baixa cadastral, paralisação temporária e
    /// outras situações;
    /// 04 – Na alteração de regime de pagamento – condição do
    /// contribuinte;
    /// 05 – Por determinação dos fiscos;
    /// 06 – Para controle das mercadorias sujeitas ao regime de substituição
    /// tributária – restituição/ ressarcimento/ complementação
    /// 2 caracteres
    /// </summary>
    public string? MotInv { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
