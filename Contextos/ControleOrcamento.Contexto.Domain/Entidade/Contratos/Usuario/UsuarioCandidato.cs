using ControleOrcamento.Contexto.Domain.ObjetosValor;
using System;

namespace ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario
{
    /// <summary>
    /// Representa as informações básicas de um usuário da aplicação
    /// </summary>
    public abstract class UsuarioCandidato : EntidadeBase
    {
        /// <summary>
        /// Representa o e-mail da conta do usuário da aplicaçãao
        /// </summary>
        public Email Email { get; private set; }

        /// <summary>
        /// Cria um usuário candidato garantindo seu estado válido
        /// </summary>
        /// <param name="usuarioCriacao">Usuário responsável pelo registro</param>
        /// <param name="email"></param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="email"/></exception>
        /// <exception cref="ArgumentException">Lançado quando o <paramref name="email"/> informado náo é válido</exception>
        protected UsuarioCandidato(UsuarioBase usuarioCriacao, Email email)
        {
            UsuarioCriacao = usuarioCriacao;
            Email = email ?? throw new ArgumentNullException(nameof(email), "E-mail do usuário não informado");
            if (email.Invalid)
            {
                throw new ArgumentException(email.Notifications.ToString(), nameof(email));
            }
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        protected UsuarioCandidato()
        {

        }
    }
}
