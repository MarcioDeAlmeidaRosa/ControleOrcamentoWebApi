using System;
using ControleOrcamento.Contexto.Domain.Enums;
using ControleOrcamento.Contexto.Domain.Entidade;
using ControleOrcamento.ContextoClassificacao.Domain.Enums;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;
using ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor;

namespace ControleOrcamento.ContextoClassificacao.Domain.Entidades
{
    /// <summary>
    /// Representa os tipos de despesas/receitas do mundo real
    /// </summary>
    public sealed class Classificacao : EntidadeBase
    {
        /// <summary>
        /// Nome da classificação do lançamento no mundo real
        /// </summary>
        public NomeClassificacaoPadrao Nome { get; private set; }

        /// <summary>
        /// Determina um valor limite que será levado em consideração para verificação dos lançamentos
        /// </summary>
        public decimal? LimiteEstipulado { get; private set; }

        /// <summary>
        /// Determina a frequencia que será levada em consideração para verificação dos lançamentos
        /// </summary>
        public Frequencia? Frequencia { get; private set; }

        /// <summary>
        /// Determina a categoria da classificação no mundo real
        /// </summary>
        public Categoria Categoria { get; private set; }

        /// <summary>
        /// Cria uma classificação garantindo seu estado válido
        /// </summary>
        /// <param name="usuario">Usuário responsável pelo registro</param>
        /// <param name="nome">Determina o nome da classificação</param>
        /// <param name="categoria">Determina a categoria da classificação</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="nome"/></exception>
        /// <exception cref="ArgumentException">Lançado quando o <paramref name="nome"/> informado náo é válido</exception>
        public Classificacao(UsuarioBase usuario, NomeClassificacaoPadrao nome, Categoria categoria) : this(usuario, nome, categoria, null, null)
        {

        }

        /// <summary>
        /// Cria uma classificação garantindo seu estado válido
        /// </summary>
        /// <param name="usuario">Usuário responsável pelo registro</param>
        /// <param name="nome">Determina o nome da classificação</param>
        /// <param name="categoria">Determina a categoria da classificação</param>
        /// <param name="limiteEstipulado">Estipula um vaor de limite para o total do lançamento</param>
        /// <param name="frequencia">Estipula a frequencia para considerar o período</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="usuario"/></exception>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado <paramref name="nome"/></exception>
        /// <exception cref="ArgumentException">Lançado quando o <paramref name="nome"/> informado náo é válido</exception>
        public Classificacao(UsuarioBase usuario, NomeClassificacaoPadrao nome, Categoria categoria, decimal? limiteEstipulado, Frequencia? frequencia)
        {
            UsuarioCriacao = usuario ?? throw new ArgumentNullException(nameof(usuario), "Não informado usuário do registro");
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), "Não informado descrição da classificação");
            if (nome.Invalid)
            {
                throw new ArgumentException(nome.Notifications.ToString(), nameof(nome));
            }
            Categoria = categoria;
            LimiteEstipulado = limiteEstipulado;
            if ((limiteEstipulado.HasValue) && (limiteEstipulado.Value < 1))
            {
                throw new ArgumentException("Valor mínimo para o limite quando informado é 1.", nameof(limiteEstipulado));
            }
            Frequencia = frequencia;
            if ((limiteEstipulado.HasValue) && (!frequencia.HasValue))
            {
                throw new ArgumentException("Frequencia não informada.", nameof(limiteEstipulado));
            }
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public Classificacao()
        {

        }
    }
}
