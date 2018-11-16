using System;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.ContextoBancario.Domain.Entidades
{
    /// <summary>
    /// Representa um banco no mundo real
    /// </summary>
    public sealed class Banco
    {
        /// <summary>
        /// Representa o usuário do registro
        /// </summary>
        public UsuarioBase Usuario { get; private set; }

        /// <summary>
        /// Representa o número do banco no mundo real
        /// </summary>
        public string Numero { get; private set; }

        /// <summary>
        /// Representa o nome do banco no mundo real
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Cria novo banco garantindo seu estado válido
        /// </summary>
        /// <param name="usuario">Usuário responsável pelo banco</param>
        /// <param name="numero">Número do banco</param>
        /// <param name="nome">Nome do banco</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado qualquer das propriedades:
        /// <paramref name="usuario"/>
        /// <paramref name="numero"/>
        /// <paramref name="nome"/>
        /// </exception>
        public Banco(UsuarioBase usuario, string numero, string nome)
        {
            Usuario = usuario ?? throw new ArgumentNullException("Não informado usuário do banco", nameof(usuario));
            Numero = numero ?? throw new ArgumentNullException("Não informado número do banco", nameof(numero));
            Nome = nome ?? throw new ArgumentNullException("Não informado nome do banco", nameof(nome));
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public Banco()
        {

        }
    }
}
