using System;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.ContextoBancario.Domain.Entidades
{
    /// <summary>
    /// Representa uma agência bancária no mundo real
    /// </summary>
    public sealed class Agencia
    {
        /// <summary>
        /// Representa o usuário do registro
        /// </summary>
        public UsuarioBase Usuario { get; private set; }

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
        /// <param name="usuario">Usuário responsável pela agência</param>
        /// <param name="banco">Banco da agência</param>
        /// <param name="numero">Número da agência</param>
        /// <param name="dv">DV da agência</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado qualquer das propriedades:
        /// <paramref name="usuario"/>
        /// <paramref name="banco"/>
        /// <paramref name="numero"/>
        /// </exception>
        public Agencia(UsuarioBase usuario, Banco banco, string numero, string dv)
        {
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario), "Não informado usuário da agência");
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
