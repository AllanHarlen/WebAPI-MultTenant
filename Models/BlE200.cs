namespace AntaresAPI.Models;

/// <summary>
/// Este registro tem por objetivo informar o(s) período(s) de apuração do ICMS – Substituição Tributária para cada UF
/// onde o informante seja inscrito como substituto tributário, inclusive para o seu estado, nas operações internas que envolvam
/// substituição, e também para UF para a qual o declarante tenha comercializado e que não tenha inscrição como substituto. Os
/// períodos informados devem abranger todo o período previsto no registro 0000, sem haver sobreposição ou omissão de datas,
/// por UF.
/// Este registro também deve ser informado pelo substituído, se este for o responsável pelo recolhimento do imposto
/// devido nas operações subsequentes, quando recebe mercadoria de outra unidade da federação, sujeita ao regime de
/// substituição tributária, na hipótese de o remetente não estar obrigado à retenção do imposto.
/// Validação do Registro: o registro é obrigatório se a soma, por UF, dos valores do campo VL_ICMS_ST dos
/// registros C190, C590, C597, C690, C791, for maior que “0” (zero), ou se existir registro 0015 (substituto tributário) para a
/// UF, ou se existir algum registro C197 ou D197, onde o quarto caractere do código de ajuste (campo COD_AJ) for igual
/// &quot;1&quot;.Não pode haver mais de um registro com a mesma combinação de valores para os campos UF, DT_INI e DT_FIN, nem
/// sobreposição ou omissão de períodos para a combinação.
/// </summary>
public partial class BlE200
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;E200&quot; 
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Sigla da unidade da federação a que se refere a apuração do ICMS ST - 2 caracteres
    /// </summary>
    public string? Uf { get; set; }

    /// <summary>
    /// Data inicial a que a apuração se refere - 8 caracteres
    /// </summary>
    public string? DtIni { get; set; }

    /// <summary>
    /// Data final a que a apuração se refere - 8 caracteres
    /// </summary>
    public string? DtFin { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Orienta sobre se o registro é de entrada ou saída na contabilização do arquivo
    /// </summary>
    public string? Origem { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
