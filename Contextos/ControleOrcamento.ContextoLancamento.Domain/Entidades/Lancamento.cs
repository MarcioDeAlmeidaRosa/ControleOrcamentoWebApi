using System.Collections.Generic;
using ControleOrcamento.Contexto.Domain.Entidade;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;

namespace ControleOrcamento.ContextoLancamento.Domain.Entidades
{
    /// <summary>
    /// Representa o lançamento na aplicação
    /// </summary>
    public abstract class Lancamento : EntidadeBase
    {
        /// <summary>
        /// Representa a finalidade do lançamento na aplicação
        /// </summary>
        public Lancamento Finalida { get; set; }

        public IList<Prestacoes> Prestacoes { get; set; }
    }
}
