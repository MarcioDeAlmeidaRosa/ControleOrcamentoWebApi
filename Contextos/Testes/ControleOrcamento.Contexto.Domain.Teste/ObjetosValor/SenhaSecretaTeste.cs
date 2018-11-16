using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.Contexto.Domain.ObjetosValor;

namespace ControleOrcamento.Contexto.Domain.Teste.ObjetosValor
{
    [TestClass]
    public class SenhaSecretaTeste
    {
        [DataTestMethod]
        [DataRow("123456")]
        [DataRow("asdfgh")]
        [DataRow("12345A")]
        [DataRow("asdfgh*")]
        [DataRow("123456*")]
        public void DeveRetornarErroPorSomenteNumero(string senhaTeste)
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
    }
}
