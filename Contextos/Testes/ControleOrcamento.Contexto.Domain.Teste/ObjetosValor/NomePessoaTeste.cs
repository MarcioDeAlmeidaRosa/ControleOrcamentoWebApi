using ControleOrcamento.Contexto.Domain.ObjetosValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControleOrcamento.Contexto.Domain.Teste.ObjetosValor
{
    [TestClass]
    public class NomePessoaTeste
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("Ma", "")]
        [DataRow("Marcio", "")]
        [DataRow("", "de Almeida Rosa")]
        [DataRow("Marcio de Almeida Rosa da Silva Junior", "")]
        public void DeveRetornarNomeInvalido(string primeiroNome, string segundoNome)
        {
            var nome = new NomePessoa(primeiroNome, segundoNome);
            Assert.IsTrue(nome.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("Marcio", "de Almeida Rosa")]
        [DataRow("Mar", "de Almeida")]
        [DataRow("Marcio", "Rosa")]
        [DataRow("Marcio", "Almeida")]
        public void DeveRetornarNomeValido(string primeiroNome, string segundoNome)
        {
            var nome = new NomePessoa(primeiroNome, segundoNome);
            Assert.IsTrue(!nome.Invalid);
        }
    }
}
