using System;
using ControleOrcamento.ContextoClassificacao.Domain.Enums;

namespace ControleOrcamento.ContextoLancamento.Domain.Entidades
{
    /// <summary>
    /// Representa os vencimentos do lançamento na aplicação
    /// </summary>
    public sealed class Prestacoes
    {
        public Natureza Natureza { get; set; }

        public DateTimeOffset DataVencimento { get; set; }

        public decimal ValorAVencer { get; set; }

        public DateTimeOffset? DataPagamento { get; set; }

        public decimal? ValorPago { get; set; }
    }
}
