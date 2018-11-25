using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor;

namespace ControleOrcamento.ContextoClassificacao.Domain.Teste.ObjetosValor
{
    [TestClass]
    public class NomeLancamentoPadraoTeste
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("Aluguel")]
        [DataRow("Taxa do condomínio")]
        [DataRow("Financiamento do imóvel")]
        [DataRow("Impostos do imóvel")]
        [DataRow("Remoção de lixo")]
        [DataRow("Manutenção/ reforma")]
        [DataRow("Seguro")]
        [DataRow("Luz")]
        [DataRow("Água/ esgoto")]
        [DataRow("Telefone")]
        [DataRow("Tv por assinatura")]
        [DataRow("Netflix")]
        [DataRow("Celular")]
        public void DeveRetornarNomeValido(string nome)
        {
            var objeto = new NomeLancamentoPadrao(nome);
            Assert.IsTrue(!objeto.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("")]
        [DataRow("P")]
        [DataRow("Po")]
        public void DeveRetornarNomeInvalido(string nome)
        {
            var objeto = new NomeClassificacaoPadrao(nome);
            Assert.IsTrue(objeto.Invalid);
        }
    }
}
