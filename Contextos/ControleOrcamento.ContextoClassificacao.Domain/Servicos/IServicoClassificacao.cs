using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace ControleOrcamento.ContextoClassificacao.Domain.Servicos
{
    /// <summary>
    /// Responsável por determinar os serviços da classificação
    /// </summary>
    public interface IServicoClassificacao
    {
        /// <summary>
        /// Responsável por listar as classificações do usuário
        /// </summary>
        /// <param name="usuario">Usuário responsável pelo cadastro do registro</param>
        /// <returns>Lista de classificação do usuário informado</returns>
        IList<Classificacao> ListaClassificacaoDoUsuario(UsuarioBase usuario);

        /// <summary>
        /// Responsável por buscar a classificação por ID
        /// </summary>
        /// <param name="usuario">Usuário responsável pelo cadastro do registro</param>
        /// <param name="id">ID da classificação</param>
        /// <returns>Classificação encontrada</returns>
        Classificacao ClassificacaoDoUsuarioPorID(UsuarioBase usuario, Guid id);
    }
}
