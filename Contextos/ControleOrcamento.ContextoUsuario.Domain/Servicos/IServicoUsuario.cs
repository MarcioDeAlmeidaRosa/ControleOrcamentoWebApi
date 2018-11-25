using System;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.ContextoUsuario.Domain.Servicos
{
    /// <summary>
    /// Responsável por determinar os serviços de usuário
    /// </summary>
    public interface IServicoUsuario
    {
        /// <summary>
        /// Reponsável por buscar dados do usuário pelo seu ID
        /// </summary>
        /// <param name="guid">Id do usuário para pesquisa</param>
        /// <returns>Retornado o usuário encontrado</returns>
        UsuarioBase BuscarPorId(Guid guid);
    }
}
