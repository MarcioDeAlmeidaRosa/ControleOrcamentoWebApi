using ControleOrcamento.Contexto.Domain.Entidade;

namespace ControleOrcamento.ContextoClassificacao.Domain.Entidades
{
    /// <summary>
    /// Representa a finalidade do lançamento na aplicação
    /// </summary>
    public sealed class Finalidade : EntidadeBase
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
