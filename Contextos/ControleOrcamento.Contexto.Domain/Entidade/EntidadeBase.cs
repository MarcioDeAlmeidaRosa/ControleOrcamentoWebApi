using System;
using Flunt.Notifications;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.Contexto.Domain.Entidade
{
    /// <summary>
    /// Representa a definição de uma entidade
    /// </summary>
    public abstract class EntidadeBase : Notifiable
    {
        /// <summary>
        /// Contrutor de uma entidade
        /// </summary>
        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Representa o identificador do registro na aplicação
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Representa a data de criação do registro na aplicação
        /// </summary>
        public DateTimeOffset DataCriacao { get; set; }

        /// <summary>
        /// Representa o usuário que criou o registro na aplicação
        /// </summary>
        public UsuarioBase UsuarioCriacao { get; set; }

        /// <summary>
        /// Representa a data de alteração do registro na aplicação
        /// </summary>
        public DateTimeOffset? DataAlteracao { get; set; }

        /// <summary>
        /// Representa o usuário que alterou o registro na aplicação
        /// </summary>
        public UsuarioBase UsuarioAlteracao { get; set; }

        /// <summary>
        /// Representa a data de exclusão do registro na aplicação
        /// </summary>
        public DateTimeOffset? DataExclusao { get; set; }

        /// <summary>
        /// Representa o usuário que excluiu o registro na aplicação
        /// </summary>
        public UsuarioBase UsuarioExclusao { get; set; }
    }
}
