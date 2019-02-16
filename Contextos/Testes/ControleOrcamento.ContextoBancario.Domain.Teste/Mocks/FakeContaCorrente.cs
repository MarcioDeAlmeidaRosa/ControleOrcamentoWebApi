using System;
using ControleOrcamento.ContextoBancario.Domain.Servicos;

namespace ControleOrcamento.ContextoBancario.Domain.Teste.Mocks
{
    public class FakeContaCorrente : IServicoContaCorrente
    {
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor para depósito não é válido", nameof(valor));
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor para saque não é válido", nameof(valor));
            }
        }
    }
}
