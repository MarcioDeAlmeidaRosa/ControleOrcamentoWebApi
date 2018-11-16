using System;
using ControleOrcamento.Contexto.Domain.ObjetosValor;

namespace ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario
{
    /// <summary>
    /// Representa um usuário que quer se autenticar na aplicação
    /// </summary>
    public sealed class UsuarioAutenticacao : UsuarioBase
    {
        /// <summary>
        /// Representa o usuário para autenticação na aplicação
        /// </summary>
        public string Login { get; private set; }

        /// <summary>
        /// Representa a senha do usuário para autenticação na aplicação
        /// </summary>
        public SenhaSecreta Senha { get; private set; }

        /// <summary>
        /// Representa o hash usado para a criptografica da senha
        /// </summary>
        public string HashAutenticacao { get; set; }

        /// <summary>
        /// Cria usuário para efetuar login na aplicação
        /// </summary>
        /// <param name="login">Login do usuário para acessar a aplicação</param>
        /// <param name="senha">Senha do usuário para acessar a aplicação</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado qualquer das propriedades:
        /// <paramref name="login"/>
        /// <paramref name="senha"/>
        /// </exception>
        public UsuarioAutenticacao(string login, SenhaSecreta senha)
        {
            Login = login ?? throw new ArgumentNullException("Não informado login do usuário", nameof(login));
            Senha = senha ?? throw new ArgumentNullException("Não informada senha", nameof(senha));
            if (senha.Invalid)
            {
                throw new ArgumentException(senha.Notifications.ToString(), nameof(senha));
            }
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public UsuarioAutenticacao()
        {

        }
    }
}
