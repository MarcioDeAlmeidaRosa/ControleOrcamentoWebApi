using System;
using ControleOrcamento.Contexto.Domain.ObjetosValor;

namespace ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario
{
    /// <summary>
    /// Representa um usuário registrado na aplicação
    /// </summary>
    public abstract class UsuarioBase : UsuarioCandidato
    {
        /// <summary>
        /// Representa o nome do usuário da aplicação
        /// </summary>
        public NomePessoa Nome { get; private set; }

        /// <summary>
        /// Cria um usuário candidato garantindo seu estado válido
        /// </summary>
        /// <param name="email">E-mail do usuário da aplicação</param>
        /// <param name="nome">Nome do usuário da aplicação</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="email"/></exception>
        /// <exception cref="ArgumentException">Lançado quando o <paramref name="email"/> informado náo é válido</exception>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="nome"/></exception>
        /// <exception cref="ArgumentException">Lançado quando o <paramref name="nome"/> informado náo é válido</exception>
        protected UsuarioBase(Email email, NomePessoa nome) : base(email)
        {
            nome = nome ?? throw new ArgumentNullException(nameof(nome), "Nome do usuário não informado");
            if (nome.Invalid)
            {
                throw new ArgumentException(nome.Notifications.ToString(), nameof(nome));
            }
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        protected UsuarioBase()
        {

        }
    }
}
