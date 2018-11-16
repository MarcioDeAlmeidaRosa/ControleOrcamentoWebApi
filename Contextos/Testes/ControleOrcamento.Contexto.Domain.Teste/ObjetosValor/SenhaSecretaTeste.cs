using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.Contexto.Domain.ObjetosValor;

namespace ControleOrcamento.Contexto.Domain.Teste.ObjetosValor
{
    [TestClass]
    public class SenhaSecretaTeste
    {
        [DataTestMethod]
        [DataRow("123456")]
        public void DeveRetornarErroPorSomenteNumero(string senhaTeste)
        {
            var senha = new SenhaSecreta(senhaTeste);
            Assert.IsTrue(senha.Invalid);
        }

        [DataTestMethod]
        [DataRow("asdfgh")]
        public void DeveRetornarErroPorSomenteLetras(string senhaTeste)
        {
            var senha = new SenhaSecreta(senhaTeste);
            Assert.IsTrue(senha.Invalid);
        }

        [DataTestMethod]
        [DataRow("123456*")]
        public void DeveRetornarErroPorNaoConterLetras(string senhaTeste)
        {
            var senha = new SenhaSecreta(senhaTeste);
            Assert.IsTrue(senha.Invalid);
        }

        [DataTestMethod]
        [DataRow("asdfgh*")]
        public void DeveRetornarErroPorNaoConterNumeros(string senhaTeste)
        {
            var senha = new SenhaSecreta(senhaTeste);
            Assert.IsTrue(senha.Invalid);
        }

        [DataTestMethod]
        [DataRow("asdfg1")]
        public void DeveRetornarSucessoLetrasESomenteUmNumero(string senhaTeste)
        {
            var senha = new SenhaSecreta(senhaTeste);
            Assert.IsTrue(!senha.Invalid);
        }

        [DataTestMethod]
        [DataRow("12345A")]
        public void DeveRetornarSucessoNumerosESomenteUmaLetra(string senhaTeste)
        {
            var senha = new SenhaSecreta(senhaTeste);
            Assert.IsTrue(!senha.Invalid);
        }
    }
}
