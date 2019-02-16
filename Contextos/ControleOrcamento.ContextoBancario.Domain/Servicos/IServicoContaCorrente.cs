namespace ControleOrcamento.ContextoBancario.Domain.Servicos
{
    /// <summary>
    /// Reponsável por definir funcionalidades possíveis de uma conta corrente
    /// </summary>
    public interface IServicoContaCorrente
    {
        /// <summary>
        /// Define contrato para depósito de valores em conta corrente
        /// </summary>
        /// <param name="valor"></param>
        void Depositar(decimal valor);

        /// <summary>
        /// Define contrato para efetuar saque em conta corrente
        /// </summary>
        /// <param name="valor"></param>
        void Sacar(decimal valor);
    }
}
