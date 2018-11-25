using System;
using ControleOrcamento.Mocks.Teste;
using ControleOrcamento.Contexto.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.ContextoClassificacao.Domain.Enums;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;
using ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.ContextoClassificacao.Domain.Teste.Entidade
{
    [TestClass]
    public class ClassificacaoTeste
    {
        private UsuarioBase usuario { get; set; }

        [TestInitialize]
        public void Inicializar()
        {
            usuario = new ServicoUsuario().BuscarPorId(Guid.NewGuid());
        }

        [TestCleanup]
        public void Encerrar()
        {
            usuario = null;
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("Moradia", Categoria.Despesa)]
        [DataRow("Transporte", Categoria.Despesa)]
        [DataRow("Saúde", Categoria.Despesa)]
        [DataRow("Alimentação", Categoria.Despesa)]
        [DataRow("Filhos", Categoria.Despesa)]
        [DataRow("Educação", Categoria.Despesa)]
        [DataRow("Obrigações bancárias", Categoria.Despesa)]
        [DataRow("Entretenimento", Categoria.Despesa)]
        [DataRow("Cuidados pessoais", Categoria.Despesa)]
        [DataRow("Animais domésticos", Categoria.Despesa)]
        [DataRow("Presentes e doações", Categoria.Despesa)]
        [DataRow("Poupança/Investimentos", Categoria.Receita)]
        [DataRow("Salário", Categoria.Receita)]
        public void DeveCriarClassificacaoComSucesso(string nome, Categoria categoria)
        {
            var objeto = new Classificacao(usuario, new NomeClassificacaoPadrao(nome), categoria);
            Assert.IsNotNull(objeto.Id);
        }

        [TestMethod]
        [DataTestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeveFalharPorArgumentNullException()
        {
            new Classificacao(usuario, null, Categoria.Receita);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("")]
        [DataRow("P")]
        [DataRow("Po")]
        [DataRow("Pou")]
        [DataRow("Poup")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveFalharNaCriacaoDaClassificacao(string nome)
        {
            new Classificacao(usuario, new NomeClassificacaoPadrao(nome), Categoria.Receita);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("Moradia", Categoria.Despesa, "1", Frequencia.Anual)]
        public void DeveCriarClassificacaoFrequenciaComSucesso(string nome, Categoria categoria, string limiteEstipulado, Frequencia frequencia)
        {
            var objeto = new Classificacao(usuario, new NomeClassificacaoPadrao(nome), categoria, decimal.Parse(limiteEstipulado), frequencia);
            Assert.IsNotNull(objeto.Id);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("Moradia", Categoria.Despesa, "-1")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveFalharNaCriacaoDaClassificacaoParametroFrequenciaErrado(string nome, Categoria categoria, string limiteEstipulado)
        {
            new Classificacao(usuario, new NomeClassificacaoPadrao(nome), categoria, decimal.Parse(limiteEstipulado), null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeveFalharNaoInformadoUsuario()
        {
            new Classificacao(null, null, Categoria.Despesa, null, null);
        }
    }
}
