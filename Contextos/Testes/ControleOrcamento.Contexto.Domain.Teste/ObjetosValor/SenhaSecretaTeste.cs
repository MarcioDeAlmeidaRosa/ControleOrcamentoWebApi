using ControleOrcamento.Contexto.Domain.ObjetosValor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControleOrcamento.Contexto.Domain.Teste.ObjetosValor
{
    [TestClass]
    public class SenhaSecretaTeste
    {
        [DataTestMethod]
        [DataRow("123456")]
        [DataRow("asdfgh")]
        [DataRow("asdfgh*")]
        [DataRow("123456*")]
        public void DeveRetornarErroPorSomenteNumero(string senhaTeste)
        {
            var senha = new SenhaSecreta(senhaTeste);
            Assert.IsTrue(senha.Invalid);
        }

        [DataTestMethod]
        [DataRow("asdfg1")]
        [DataRow("12345A")]
        public void DeveRetornarSucessoLetrasESomenteUmNumero(string senhaTeste)
        {
            var senha = new SenhaSecreta(senhaTeste);
            Assert.IsTrue(!senha.Invalid);
        }
    }
}
