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
        [DataRow("marcio@gmail.com", "asdfg1")]
        public void DeveCriarUsuarioComSucesso(string login, string senha)
        {
            var usuario = new UsuarioAutenticacao(login, new SenhaSecreta(senha));
            Assert.IsNotNull(usuario.Id);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("marcio@gmail.com", "123456")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveLancarErroSenhaForaDoPadrao(string login, string senha)
        {
            var usuario = new UsuarioAutenticacao(login, new SenhaSecreta(senha));
        }
    }
}
