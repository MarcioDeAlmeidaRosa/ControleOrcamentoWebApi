using System;
using System.Collections.Generic;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.ContextoUsuario.Domain.Entidades
{
    /// <summary>
    /// Representa um usuário master da conta principal da aplicação
    /// </summary>
    public sealed class UsuarioMaster : UsuarioBase
    {
        /// <summary>
        /// Representa os usuários convidados pela conta principal
        /// para contribuírem no controle do orçamento
        /// Exemplo seria uma família, responsável financeiro da casa,
        /// convida os interessados para compartilhar os gastos da casa,
        /// assim você cria uma conciência financeira na família, de quais
        /// os custos para manter a casa
        /// </summary>
        public IList<UsuarioBase> Convidados { get; private set; }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public UsuarioMaster()
        {

        }
    }
}
