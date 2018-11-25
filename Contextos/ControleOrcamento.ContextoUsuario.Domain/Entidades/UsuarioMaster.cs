using System;
using System.Collections.Generic;
using ControleOrcamento.Contexto.Domain.ObjetosValor;
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
        public IList<UsuarioBase> Convidados { get; set; }

        /// <summary>
        /// Cria um usuário candidato garantindo seu estado válido
        /// </summary>
        /// <param name="usuario">Usuário responsável pelo registro</param>
        /// <param name="email"></param>
        /// <param name="nome"></param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="email"/></exception>
        /// <exception cref="ArgumentException">Lançado quando o <paramref name="email"/> informado náo é válido</exception>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="nome"/></exception>
        /// <exception cref="ArgumentException">Lançado quando o <paramref name="nome"/> informado náo é válido</exception>
        public UsuarioMaster(UsuarioBase usuario, Email email, NomePessoa nome) : base(usuario, email, nome)
        {

        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public UsuarioMaster()
        {

        }
    }
}
