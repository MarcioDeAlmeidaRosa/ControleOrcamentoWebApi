using ControleOrcamento.Contexto.Domain.Entidade;

namespace ControleOrcamento.ContextoClassificacao.Domain.Entidades
{
    /// <summary>
    /// Representa a opção de lançamento na aplicação
    /// </summary>
    public sealed class Lancamento : EntidadeBase
    {
        /// <summary>
        /// Representa a descrição da finalidade do lançamento
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Representa a classificação da finalidade do lançamento
        /// </summary>
        public Classificacao Classificacao { get; set; }
    }
}
