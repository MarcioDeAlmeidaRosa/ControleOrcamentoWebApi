using System.Collections.Generic;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

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
        IList<Classificacao> ListaClassificacaoPorUsuario(UsuarioBase usuario);
    }
}
