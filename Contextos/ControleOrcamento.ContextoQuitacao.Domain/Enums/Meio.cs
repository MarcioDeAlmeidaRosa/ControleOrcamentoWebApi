using System.ComponentModel;

namespace ControleOrcamento.ContextoQuitacao.Domain.Enums
{
    /// <summary>
    /// Representa o meio de pagamento/recebimento no mundo real
    /// </summary>
    public enum Meio
    {
        /// <summary>
        /// Representa quando feito em espécie
        /// </summary>
        [Description("Dinheiro")]
        Dinheiro,
        /// <summary>
        /// Representa quando feito via DOC bancário
        /// </summary>
        [Description("Documento de Crédito (DOC)")]
        DOC,
        /// <summary>
        /// Representa quando feito via TED bancário
        /// </summary>
        [Description("Eletrônica Disponível (TED)")]
        TED,
        /// <summary>
        /// Representa quando feito via filha de cheque
        /// </summary>
        [Description("Cheque")]
        Cheque,
        /// <summary>
        /// Representa quando feito via cartão de crédito
        /// </summary>
        [Description("Cartão de Crédito")]
        CartaoDeCredito,
        /// <summary>
        /// Representa quando feito via cartão de débito
        /// </summary>
        [Description("Cartão de Débito")]
        CartaoDeDebito,
        /// <summary>
        /// Representa quando feito via empresa de pagamento online (podendo ser via PayPal / Pic Pay ou etc)
        /// </summary>
        [Description("Meios de Pagamento On-line")]
        MeioDePagamentoOline,
    }
}
