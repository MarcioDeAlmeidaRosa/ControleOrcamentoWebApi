using Flunt.Validations;

namespace ControleOrcamento.Contexto.Domain.ObjetosValor
{
    /// <summary>
    /// Representa um e-mail válido na aplicação
    /// </summary>
    public sealed class Email : ObjetoValor
    {
        /// <summary>
        /// Representa um endereço de e-mail válido
        /// </summary>
        public string Endereco { get; private set; }

        /// <summary>
        /// Cria um endereço de e-mail válido
        /// </summary>
        /// <param name="endereco">Endereço de e-mail</param>
        public Email(string endereco)
        {
            Endereco = endereco;
            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Endereco, "Email.Endereco", "E-mail inválido")
            );
        }
    }
}
