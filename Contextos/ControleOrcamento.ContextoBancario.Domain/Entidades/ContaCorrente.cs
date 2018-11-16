using System;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.ContextoBancario.Domain.Entidades
{
    /// <summary>
    /// Representa uma conta corrente no mundo real
    /// </summary>
    public sealed class ContaCorrente
    {
        /// <summary>
        /// Representa o usuário do registro
        /// </summary>
        public UsuarioBase Usuario { get; private set; }

        /// <summary>
        /// Representa a agência bancária da conta corrente no mundo real
        /// </summary>
        public Agencia Agencia { get; private set; }

        /// <summary>
        /// Representa o número da conta corrente no mundo real
        /// </summary>
        public string Numero { get; private set; }

        /// <summary>
        /// Representa o DV da conta corrente no mundo real
        /// </summary>
        public string DV { get; private set; }

        /// <summary>
        /// Cria nova conta corrente garantindo seu estado válido
        /// </summary>
        /// <param name="usuario">Usuário responsável pela conta corrente</param>
        /// <param name="agencia">Agência da conta corrente</param>
        /// <param name="numero">Número da conta corrente</param>
        /// <param name="dv">DV da conta corrente</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado qualquer das propriedades:
        /// <paramref name="usuario"/>
        /// <paramref name="agencia"/>
        /// <paramref name="numero"/>
        /// <paramref name="dv"/>
        /// </exception>
        public ContaCorrente(UsuarioBase usuario, Agencia agencia, string numero, string dv)
        {
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario), "Não informado usuário da conta corrente");
            Agencia = agencia ?? throw new ArgumentNullException(nameof(agencia), "Não informada agência da conta corrente");
            Numero = numero ?? throw new ArgumentNullException(nameof(numero), "Não informado número da conta corrente");
            DV = dv ?? throw new ArgumentNullException(nameof(dv), "Não informado o DV da conta corrente");
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public ContaCorrente()
        {

        }
    }
}
