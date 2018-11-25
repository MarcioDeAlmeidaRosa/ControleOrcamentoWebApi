using System;
using ControleOrcamento.Contexto.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.ContextoClassificacao.Domain.Enums;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;
using ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor;

namespace ControleOrcamento.ContextoClassificacao.Domain.Teste.Entidade
{
    [TestClass]
    public class ClassificacaoTeste
    {
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
        public void DeveCriarClassificacaoComSucesso(string descricao, Categoria classificacao)
        {
            var usuario = new Classificacao(new NomeClassificacao(descricao), classificacao);
            Assert.IsNotNull(usuario.Id);
        }

        [TestMethod]
        [DataTestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeveFalharPorArgumentNullException()
        {
            new Classificacao(null, Categoria.Receita);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("")]
        [DataRow("P")]
        [DataRow("Po")]
        [DataRow("Pou")]
        [DataRow("Poup")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveFalharNaCriacaoDaClassificacao(string descricao)
        {
            new Classificacao(new NomeClassificacao(descricao), Categoria.Receita);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("Moradia", Categoria.Despesa, "1", Frequencia.Anual)]
        public void DeveCriarClassificacaoFrequenciaComSucesso(string descricao, Categoria classificacao, string limiteEstipulado, Frequencia frequencia)
        {
            var usuario = new Classificacao(new NomeClassificacao(descricao), classificacao, decimal.Parse(limiteEstipulado), frequencia);
            Assert.IsNotNull(usuario.Id);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("Moradia", Categoria.Despesa, "-1")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveFalharNaCriacaoDaClassificacaoParametroFrequenciaErrado(string descricao, Categoria classificacao, string limiteEstipulado)
        {
            new Classificacao(new NomeClassificacao(descricao), classificacao, decimal.Parse(limiteEstipulado), null);
        }
    }
}
