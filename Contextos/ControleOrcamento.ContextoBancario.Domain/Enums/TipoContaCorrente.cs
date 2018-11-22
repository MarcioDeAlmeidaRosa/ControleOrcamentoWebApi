using System.ComponentModel;

namespace ControleOrcamento.ContextoBancario.Domain.Enums
{
    /// <summary>
    /// Representa o tipo de conta corrente no mundo real
    /// </summary>
    public enum TipoContaCorrente
    {
        /// <summary>
        /// Representa uma conta corrente do mundo real
        /// </summary>
        [Description("Conta Corrente")]
        Corrente,
        /// <summary>
        /// Representa uma conta poupança do mundo real
        /// </summary>
        [Description("Conta Poupança")]
        Poupanca,
        /// <summary>
        /// Representa uma conta salário do mundo real
        /// </summary>
        [Description("Conta Salário")]
        Salario,
    }
}
