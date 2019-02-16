using ControleOrcamento.Contexto.Domain.Entidade;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;
using System;

namespace ControleOrcamento.ContextoBancario.Domain.Entidades
{
    /// <summary>
    /// Representa uma agência bancária no mundo real
    /// </summary>
    public sealed class Agencia : EntidadeBase
    {
        /// <summary>
        /// Representa o banco da agência bancária no mundo real
        /// </summary>
        public Banco Banco { get; private set; }

        /// <summary>
        /// Representa o número da agência bancária no mundo real
        /// </summary>
        public string Numero { get; private set; }

        /// <summary>
        /// Representa o dígito verificador da agência bancária no mundo real
        /// </summary>
        public string DV { get; private set; }

        /// <summary>
        /// Cria nova agência garantindo seu estado válido
        /// </summary>
        /// <param name="usuarioCriacao">Usuário responsável pelo registro</param>
        /// <param name="banco">Banco da agência</param>
        /// <param name="numero">Número da agência</param>
        /// <param name="dv">DV da agência</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado qualquer das propriedades:
        /// <paramref name="usuarioCriacao"/>
        /// <paramref name="banco"/>
        /// <paramref name="numero"/>
        /// </exception>
        public Agencia(UsuarioBase usuarioCriacao, Banco banco, string numero, string dv)
        {
            UsuarioCriacao = usuarioCriacao ?? throw new ArgumentNullException(nameof(usuarioCriacao), "Não informado usuário do registro");
            Banco = banco ?? throw new ArgumentNullException(nameof(banco), "Não informado banco da agência");
            Numero = numero ?? throw new ArgumentNullException(nameof(numero), "Não informado número da agência");
            DV = dv;
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public Agencia()
        {

        }
    }
}
