using System.ComponentModel;

namespace ControleOrcamento.ContextoClassificacao.Domain.Enums
{
    /// <summary>
    /// Determina o tipo de lançamento na aplicação
    /// </summary>
    public enum Natureza
    {
        /// <summary>
        /// Determina o lançamento como entrada de valor
        /// </summary>
        [Description("Crédito")]
        Credito,
        /// <summary>
        /// Determina o lançamento como saída de valor
        /// </summary>
        [Description("Débito")]
        Debito,
    }
}
