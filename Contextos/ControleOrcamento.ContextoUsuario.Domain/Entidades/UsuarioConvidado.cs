using System;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.ContextoUsuario.Domain.Entidades
{
    /// <summary>
    /// Representa um usuário comum da aplicação
    /// </summary>
    public sealed class UsuarioConvidado : UsuarioBase
    {
        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public UsuarioConvidado()
        {

        }
    }
}
