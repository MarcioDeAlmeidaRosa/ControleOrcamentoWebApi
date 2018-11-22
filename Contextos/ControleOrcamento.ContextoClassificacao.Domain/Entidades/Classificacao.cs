using ControleOrcamento.Contexto.Domain.Entidade;
using ControleOrcamento.ContextoClassificacao.Domain.Enums;

namespace ControleOrcamento.ContextoClassificacao.Domain.Entidades
{
    /// <summary>
    /// Representa o propósito do lançamento
    /// </summary>
    public sealed class Classificacao : EntidadeBase
    {
        /// <summary>
        /// Descrição da classificação para agrupar as possibilidades de lançamentos da aplicação
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Determina o tipo da classificação
        /// </summary>
        public TipoClassificacao Tipo { get; set; }
    }
}
