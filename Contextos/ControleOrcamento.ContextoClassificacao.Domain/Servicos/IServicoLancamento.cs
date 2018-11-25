﻿using System.Collections.Generic;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.ContextoClassificacao.Domain.Servicos
{
    /// <summary>
    /// Responsável por determinar os serviços do lançamento
    /// </summary>
    public interface IServicoLancamento
    {
        /// <summary>
        /// Responsável por listar os lançamentos do usuário
        /// </summary>
        /// <param name="usuario">Usuário responsável pelo cadastro do registro</param>
        /// <returns>Lista de lancçamento do usuário informado</returns>
        IList<Lancamento> ListaLancamentoDoUsuario(UsuarioBase usuario);
    }
}
