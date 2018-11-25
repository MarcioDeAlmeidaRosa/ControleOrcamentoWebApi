using System;
using ControleOrcamento.Contexto.Domain.Entidade;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;
using ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor;

namespace ControleOrcamento.ContextoClassificacao.Domain.Entidades
{
    /// <summary>
    /// Representa a opção de lançamento na aplicação
    /// </summary>
    public sealed class Lancamento : EntidadeBase
    {
        /// <summary>
        /// Representa o nome do lançamento
        /// </summary>
        public NomeLancamentoPadrao Nome { get; private set; }

        /// <summary>
        /// Representa a classificação da finalidade do lançamento
        /// </summary>
        public Classificacao Classificacao { get; private set; }

        /// <summary>
        /// Cria um lançamento garantindo seu estado válido
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="nome"></param>
        /// <param name="classificacao"></param>
        public Lancamento(UsuarioBase usuario, NomeLancamentoPadrao nome, Classificacao classificacao)
        {
            UsuarioCriacao = usuario ?? throw new ArgumentNullException(nameof(usuario), "Não informado usuário do registro");
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), "Não informado nome do lançamento");
            if (nome.Invalid)
            {
                throw new ArgumentException(nome.Notifications.ToString(), nameof(nome));
            }
            Classificacao = classificacao ?? throw new ArgumentNullException(nameof(nome), "Não informado nome do lançamento");
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public Lancamento()
        {

        }
    }
}
