using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.Contexto.Domain.ObjetosValor;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.Contexto.Domain.Teste.Entidade
{
    [TestClass]
    public class UsuarioAutenticacaoTeste
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("marcio@gmail.com", "Marcio", "Rosa", "marcio@gmail.com", "asdfg1")]
        public void DeveCriarUsuarioComSucesso(string email, string nome, string sobrenome, string login, string senha)
        {
            var usuario = new UsuarioAutenticacao(new Email(email), new NomePessoa(nome, sobrenome), login, new SenhaSecreta(senha));
            Assert.IsNotNull(usuario.Id);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("marcio@gmail.com", "Marcio", "Rosa", "marcio@gmail.com", "123456")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveLancarErroSenhaForaDoPadrao(string email, string nome, string sobrenome, string login, string senha)
        {
            new UsuarioAutenticacao(new Email(email), new NomePessoa(nome, sobrenome), login, new SenhaSecreta(senha));
        }
    }
}
