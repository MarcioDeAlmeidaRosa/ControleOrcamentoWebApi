using System.ComponentModel;

namespace ControleOrcamento.ContextoClassificacao.Domain.Enums
{
    /// <summary>
    /// Representa os tipo de propósito permitido na aplicação
    /// </summary>
    public enum TipoClassificacao
    {
        /// <summary>
        /// Determina o propósito que a classificação é de entrada de valor
        /// </summary>
        [Description("Receita")]
        Receita,
        /// <summary>
        /// Representa que a classificação é de saída de valor
        /// </summary>
        [Description("Despesa")]
        Despesa,
    }
}
