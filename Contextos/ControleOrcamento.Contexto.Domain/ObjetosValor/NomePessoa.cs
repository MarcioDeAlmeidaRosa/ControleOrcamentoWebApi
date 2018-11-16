using Flunt.Validations;

namespace ControleOrcamento.Contexto.Domain.ObjetosValor
{
    /// <summary>
    /// Representa um nome válido na aplicação
    /// </summary>
    public sealed class NomePessoa : ObjetoValor
    {
        /// <summary>
        /// Representa o primeiro nome da pessoa
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Representa o sobrenome da pessoa
        /// </summary>
        public string SobreNome { get; private set; }

        /// <summary>
        /// Cria um nome válido para a aplicação
        /// </summary>
        /// <param name="nome">Primeiro nome da pessoa</param>
        /// <param name="sobrenome">Sobrenome da pessoa</param>
        public NomePessoa(string nome, string sobrenome)
        {
            Nome = nome;
            SobreNome = sobrenome;
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Nome, 3, "NomePessoa.Nome", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(SobreNome, 3, "NomePessoa.SobreNome", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(Nome, 40, "NomePessoa.Nome", "Nome deve conter até 40 caracteres")
            );
        }

        /// <summary>
        /// Concatena <see cref="Nome"/> e <see cref="SobreNome"/>
        /// </summary>
        /// <returns>Retorna o nome completo da pessoa</returns>
        public override string ToString()
        {
            return $"{Nome} {SobreNome}";
        }
    }
}
