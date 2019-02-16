using ControleOrcamento.Contexto.Domain.ObjetosValor;
using Flunt.Validations;

namespace ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor
{
    /// <summary>
    /// Representa um nome válido no contexto de classificação
    /// </summary>
    public sealed class NomeClassificacaoPadrao : ObjetoValor
    {
        /// <summary>
        /// Representa o nome do lançamento
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Cria um nome válido para a aplicação
        /// </summary>
        /// <param name="nome">Nome para atribuição</param>
        public NomeClassificacaoPadrao(string nome)
        {
            Nome = nome;
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Nome, 5, "NomeClassificacaoPadrao.Nome", "Nome da classificação deve conter pelo menos 5 caracteres")
                .HasMaxLen(Nome, 50, "NomeClassificacaoPadrao.Nome", "Nome da classificação deve conter até 50 caracteres")
            );
        }

        /// <summary>
        /// Retorna conteúdo do objeto em string
        /// </summary>
        /// <returns>Retorna o nome do lançamento</returns>
        public override string ToString()
        {
            return Nome;
        }
    }
}
