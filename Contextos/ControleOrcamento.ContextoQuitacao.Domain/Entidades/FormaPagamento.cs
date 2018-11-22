namespace ControleOrcamento.ContextoQuitacao.Domain.Entidades
{
    /// <summary>
    /// Representa a forma de pagamento de um lançamento na aplicação
    /// </summary>
    public sealed class FormaPagamento : Quitacao
    {
        /// <summary>
        /// Representa a quantidade de dias que antecede a fatura para efetuar o calculo do vencimento do lançamento
        /// </summary>
        public int? QuantidadeDiasAntecedeFatura { get; private set; }

        /// <summary>
        /// Representa o dia de vencimento da fatura para efetuar o calculo do vencimento do lançamento
        /// </summary>
        public int? DiaVenciamentoFatura { get; private set; }
    }
}
