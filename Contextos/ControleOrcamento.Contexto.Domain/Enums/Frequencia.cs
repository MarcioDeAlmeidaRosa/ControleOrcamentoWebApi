using System.ComponentModel;

namespace ControleOrcamento.Contexto.Domain.Enums
{
    /// <summary>
    /// Determina a frequencia que será considerada
    /// </summary>
    public enum Frequencia
    {
        /// <summary>
        /// Determina a frequencia diária
        /// </summary>
        [Description("Diária")]
        Diária,
        /// <summary>
        /// Determina a frequencia semanal
        /// </summary>
        [Description("Semanal")]
        Semanal,
        /// <summary>
        /// Determina a frequencia Quinzenal
        /// </summary>
        [Description("Quinzenal")]
        Quinzenal,
        /// <summary>
        /// Determina a frequencia Mensal
        /// </summary>
        [Description("Mensal")]
        Mensal,
        /// <summary>
        /// Determina a frequencia Bimestral
        /// </summary>
        [Description("Bimestral")]
        Bimestral,
        /// <summary>
        /// Determina a frequencia Semestral
        /// </summary>
        [Description("Semestral")]
        Semestral,
        /// <summary>
        /// Determina a frequencia Anual
        /// </summary>
        [Description("Anual")]
        Anual
    }
}
