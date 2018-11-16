using System;
using Flunt.Notifications;

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
    }
}
