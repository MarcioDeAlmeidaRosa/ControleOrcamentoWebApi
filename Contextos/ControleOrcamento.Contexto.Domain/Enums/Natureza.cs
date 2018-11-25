using System.ComponentModel;

namespace ControleOrcamento.Contexto.Domain.Enums
{
    /// <summary>
    /// Determina as naturezas de lançamento possíveis na apliçao
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
