using System;
using ControleOrcamento.Mocks.Teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;
using ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor;

namespace ControleOrcamento.ContextoClassificacao.Domain.Teste.Entidade
{
    [TestClass]
    public class LancamentoTeste
    {
        private UsuarioBase usuario { get; set; }

        private Classificacao classificacao;

        [TestInitialize]
        public void Inicializar()
        {
            usuario = new ServicoUsuario().BuscarPorId(Guid.NewGuid());
            classificacao = new ServicoClassificacao().ClassificacaoDoUsuarioPorID(usuario, Guid.NewGuid());
        }

        [TestCleanup]
        public void Encerrar()
        {
            usuario = null;
        }

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
        public void DeveCriarLancamentoComSucesso(string nome)
        {
            var objeto = new Lancamento(usuario, new NomeLancamentoPadrao(nome), classificacao);
            Assert.IsNotNull(objeto.Id);
        }

        [TestMethod]
        [DataTestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeveFalharPorArgumentNullException()
        {
            new Lancamento(usuario, null, classificacao);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("")]
        [DataRow("P")]
        [DataRow("Po")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveFalharNaCriacaoDLancamento(string nome)
        {
            new Lancamento(usuario, new NomeLancamentoPadrao(nome), classificacao);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeveFalharNaoInformadoUsuario()
        {
            new Lancamento(null, null, classificacao);
        }
    }
}
