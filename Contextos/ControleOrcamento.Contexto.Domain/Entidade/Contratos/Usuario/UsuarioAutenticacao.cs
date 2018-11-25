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
        /// <param name="usuario">Usuário responsável pelo registro</param>
        /// <param name="email">E-mail do usuário da aplicação</param>
        /// <param name="nome">Nome do usuário da aplicação</param>
        /// <param name="login">Login do usuário para acessar a aplicação</param>
        /// <param name="senha">Senha do usuário para acessar a aplicação</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="email"/></exception>
        /// <exception cref="ArgumentException">Lançado quando o <paramref name="email"/> informado náo é válido</exception>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="nome"/></exception>
        /// <exception cref="ArgumentException">Lançado quando o <paramref name="nome"/> informado náo é válido</exception>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="login"/></exception>
        /// <exception cref="ArgumentNullException">Lançado quando não for informada <paramref name="senha"/></exception>
        /// <exception cref="ArgumentException">Lançado quando a <paramref name="senha"/> informada náo é válida</exception>
        public UsuarioAutenticacao(UsuarioBase usuario, Email email, NomePessoa nome, string login, SenhaSecreta senha) : base(usuario, email, nome)
        {
            Login = login ?? throw new ArgumentNullException(nameof(login), "Não informado login do usuário");
            Senha = senha ?? throw new ArgumentNullException(nameof(senha), "Não informada senha");
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
