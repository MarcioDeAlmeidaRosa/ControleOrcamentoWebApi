using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.Contexto.Domain.ObjetosValor;

namespace ControleOrcamento.Contexto.Domain.Teste.ObjetosValor
{
    [TestClass]
    public class EmailTeste
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("marcio@gmail")]
        [DataRow("marcio@hotmail.")]
        [DataRow("asda sdasd@gmail.com.br")]
        [DataRow("marcio@rosa@yahoo.com.br")]
        [DataRow("marcio;rosa@yahoo.com.br")]
        [DataRow("@gmail.com")]
        public void DeveRetornarEmailInvalido(string emailTeste)
        {
            var email = new Email(emailTeste);
            Assert.IsTrue(email.Invalid);
        }

        [DataTestMethod]
        [DataRow("")]
        public void DeveRetornarEmailObrigatorio(string emailTeste)
        {
            var email = new Email(emailTeste);
            Assert.IsTrue(email.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("marcio.rosa@gmail.com")]
        [DataRow("marcio.rosa@hotmail.com")]
        [DataRow("marcio.rosa@ig.com.br")]
        [DataRow("marcio.rosa@yahoo.com.br")]
        [DataRow("marcio_rosa@yahoo.com.br")]
        public void DeveRetornarEmailValido(string emailTeste)
        {
            var email = new Email(emailTeste);
            Assert.IsTrue(!email.Invalid);
        }
    }
}
