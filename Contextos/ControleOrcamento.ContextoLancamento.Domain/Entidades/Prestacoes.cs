using System;
using ControleOrcamento.Contexto.Domain.Enums;

namespace ControleOrcamento.ContextoLancamento.Domain.Entidades
{
    /// <summary>
    /// Representa a composição dos itens do lançamento
    /// </summary>
    public sealed class Prestacoes
    {
        /// <summary>
        /// Representa a natureza do lançamento
        /// </summary>
        public Natureza Natureza { get; set; }

        /// <summary>
        /// Representa a date de vencimento do lançamento
        /// </summary>
        public DateTimeOffset DataVencimento { get; set; }

        /// <summary>
        /// Representa o valor do lançamento
        /// </summary>
        public decimal ValorAVencer { get; set; }

        /// <summary>
        /// Representa a do pagamento do lançamento
        /// </summary>
        public DateTimeOffset? DataPagamento { get; set; }

        /// <summary>
        /// Representa o valor pago do lançamento
        /// </summary>
        public decimal? ValorPago { get; set; }
    }
}
