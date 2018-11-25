using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor;

namespace ControleOrcamento.ContextoClassificacao.Domain.Teste.ObjetosValor
{
    [TestClass]
    public class NomeClassificacaoPadraoTeste
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("Moradia")]
        [DataRow("Transporte")]
        [DataRow("Saúde")]
        [DataRow("Alimentação")]
        [DataRow("Filhos")]
        [DataRow("Educação")]
        [DataRow("Obrigações bancárias")]
        [DataRow("Entretenimento")]
        [DataRow("Cuidados pessoais")]
        [DataRow("Animais domésticos")]
        [DataRow("Presentes e doações")]
        [DataRow("Poupança/Investimentos")]
        [DataRow("Salário")]
        public void DeveRetornarNomeValido(string nome)
        {
            var objeto = new NomeClassificacaoPadrao(nome);
            Assert.IsTrue(!objeto.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("")]
        [DataRow("P")]
        [DataRow("Po")]
        [DataRow("Pou")]
        [DataRow("Poup")]
        public void DeveRetornarNomeInvalido(string nome)
        {
            var objeto = new NomeClassificacaoPadrao(nome);
            Assert.IsTrue(objeto.Invalid);
        }
    }
}
