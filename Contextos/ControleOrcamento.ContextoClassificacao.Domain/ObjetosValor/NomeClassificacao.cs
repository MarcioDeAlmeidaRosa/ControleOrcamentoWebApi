using Flunt.Validations;
using ControleOrcamento.Contexto.Domain.ObjetosValor;

namespace ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor
{
    /// <summary>
    /// Representa um nome válido na aplicação
    /// </summary>
    public sealed class NomeClassificacao : ObjetoValor
    {
        /// <summary>
        /// Representa o nome da classificação
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Cria um nome válido para a aplicação
        /// </summary>
        /// <param name="nome">Nome para classificacao</param>
        public NomeClassificacao(string nome)
        {
            Nome = nome;
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Nome, 5, "DescricaoClassificacao.DescricaoClassificacao", "Nome deve conter pelo menos 5 caracteres")
                .HasMaxLen(Nome, 50, "NomePessoa.Nome", "Nome deve conter até 50 caracteres")
            );
        }

        /// <summary>
        /// Retorna conteúdo do objeto em string
        /// </summary>
        /// <returns>Retorna o nome da classificação</returns>
        public override string ToString()
        {
            return Nome;
        }
    }
}
