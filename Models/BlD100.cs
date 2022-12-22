namespace AntaresAPI.Models;

/// <summary>
/// Este registro deve ser apresentado por todos os contribuintes adquirentes ou prestadores dos serviços que utilizem os
/// documentos especificados.
/// O campo CHV_CTE passa a ser de preenchimento obrigatório a partir de abril de 2012 em todas as situações, exceto para
/// COD_SIT = 5 (numeração inutilizada).
/// IMPORTANTE: para documentos de entrada, os campos de valor de imposto/contribuição, base de cálculo e alíquota só devem
/// ser informados se o adquirente tiver direito à apropriação do crédito (enfoque do declarante).
/// Validação do Registro: não podem ser informados dois ou mais registros com a combinação de mesmos valores
/// dos campos:
/// 1. emissão de terceiros: IND_EMIT+NUM_DOC+COD_MOD+SER+SUB+COD_PART;
/// 2. emissão própria: IND_EMIT+NUM_DOC+COD_MOD+SER+SUB.
/// 3. A partir de 01/01/2014, foi incluído o campo CHV_CTE para compor a chave do registro.
/// </summary>
public partial class BlD100
{
    /// <summary>
    /// Campo chave primária de controle auto-incrementada
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Texto fixo contendo &quot;D100&quot; 
    /// </summary>
    public string? Reg { get; set; }

    /// <summary>
    /// Indicador do tipo de operação:
    /// 0 - Aquisição;
    /// 1 - Prestação
    /// 1 caractere
    /// </summary>
    public string? IndOper { get; set; }

    /// <summary>
    /// Indicador do emitente do documento fiscal:
    /// 0 - Emissão própria;
    /// 1 - Terceiros
    /// 1 caractere
    /// </summary>
    public string? IndEmit { get; set; }

    /// <summary>
    /// Código do participante (campo 02 do Registro 0150):
    /// - do prestador de serviço, no caso de aquisição de
    /// serviço;
    /// - do tomador do serviço, no caso de prestação de
    /// serviços.
    /// 60 caracteres
    /// </summary>
    public string? CodPart { get; set; }

    /// <summary>
    /// Código do modelo do documento fiscal, conforme a
    /// Tabela 4.1.1 - 2 caracteres
    /// </summary>
    public string? CodMod { get; set; }

    /// <summary>
    /// Código da situação do documento fiscal, conforme a
    /// Tabela 4.1.2 - 2 caracteres
    /// </summary>
    public string? CodSit { get; set; }

    /// <summary>
    /// Série do documento fiscal - 4 caracteres
    /// </summary>
    public string? Ser { get; set; }

    /// <summary>
    /// Subsérie do documento fiscal - 4 caracteres
    /// </summary>
    public string? Sub { get; set; }

    /// <summary>
    /// Número do documento fiscal - 9 caracteres
    /// </summary>
    public string? NumDoc { get; set; }

    /// <summary>
    /// Chave do Conhecimento de Transporte Eletrônico ou
    /// do Bilhete de Passagem Eletrônico - 44 caracteres
    /// </summary>
    public string? ChvCte { get; set; }

    /// <summary>
    /// Data da emissão do documento fiscal - 8 caracteres
    /// </summary>
    public string? DtDoc { get; set; }

    /// <summary>
    /// Data da aquisição ou da prestação do serviço - 8 caracteres
    /// </summary>
    public string? DtAP { get; set; }

    /// <summary>
    /// Tipo de Conhecimento de Transporte Eletrônico
    /// conforme definido no Manual de Integração do CT-e ou
    /// do Bilhete de Passagem Eletrônico conforme definido
    /// no Manual de Integração do BP-e
    /// 1 caracteres
    /// </summary>
    public string? TpCte { get; set; }

    /// <summary>
    /// Chave do Bilhete de Passagem Eletrônico substituído - 44 caracteres
    /// </summary>
    public string? ChvCteRef { get; set; }

    /// <summary>
    /// Valor total do documento fiscal - decimal com 2 casas
    /// </summary>
    public decimal? VlDoc { get; set; }

    /// <summary>
    /// Valor total do desconto - decimal com 2 casas
    /// </summary>
    public decimal? VlDesc { get; set; }

    /// <summary>
    /// Indicador do tipo do frete:
    /// 0 - Por conta de terceiros;
    /// 1 - Por conta do emitente;
    /// 2 - Por conta do destinatário;
    /// 9 - Sem cobrança de frete.
    /// Obs.: A partir de 01/07/2012 passará a ser:
    /// Indicador do tipo do frete:
    /// 0 - Por conta do emitente;
    /// 1 - Por conta do destinatário/remetente;
    /// 2 - Por conta de terceiros;
    /// 9 - Sem cobrança de frete.
    /// 1 caractere
    /// </summary>
    public string? IndFrt { get; set; }

    /// <summary>
    /// Valor total da prestação de serviço 
    /// Decimal com 2 casas
    /// </summary>
    public decimal? VlServ { get; set; }

    /// <summary>
    /// Valor da base de cálculo do ICMS 
    /// Decimal com 2 casas
    /// </summary>
    public decimal? VlBcIcms { get; set; }

    /// <summary>
    /// Valor do ICMS - decimal com 2 casas
    /// </summary>
    public decimal? VlIcms { get; set; }

    /// <summary>
    /// Valor não-tributado - decimal com 2 casas
    /// </summary>
    public decimal? VlNt { get; set; }

    /// <summary>
    /// Código da informação complementar do documento
    /// fiscal (campo 02 do Registro 0450) - 6 caracteres
    /// </summary>
    public string? CodInf { get; set; }

    /// <summary>
    /// Código da conta analítica contábil debitada/creditada
    /// </summary>
    public string? CodCta { get; set; }

    /// <summary>
    /// Código do município de origem do serviço, conforme a
    /// tabela IBGE (Preencher com 9999999, se Exterior) - 7 caracteres
    /// </summary>
    public string? CodMunOrig { get; set; }

    /// <summary>
    /// Código do município de destino, conforme a tabela
    /// IBGE (Preencher com 9999999, se Exterior) - 7 carcacteres
    /// </summary>
    public string? CodMunDest { get; set; }

    /// <summary>
    /// Data de entrada do registro no sped para gerar arquivo
    /// </summary>
    public DateTime? Data { get; set; }

    /// <summary>
    /// Chave primária da compra informada no registro
    /// </summary>
    public int? IdCompra { get; set; }

    /// <summary>
    /// Guarda Cnpj da empresa no lançamento do bloco
    /// </summary>
    public string? Empresa { get; set; }
}
