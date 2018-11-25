using System;
using ControleOrcamento.Mocks.Teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControleOrcamento.Contexto.Domain.ObjetosValor;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.Contexto.Domain.Teste.Entidade
{
    [TestClass]
    public class UsuarioAutenticacaoTeste
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
        [DataRow("marcio@gmail.com", "Marcio", "Rosa", "marcio@gmail.com", "asdfg1")]
        public void DeveCriarUsuarioComSucesso(string email, string nome, string sobrenome, string login, string senha)
        {
            var objeto = new UsuarioAutenticacao(usuario, new Email(email), new NomePessoa(nome, sobrenome), login, new SenhaSecreta(senha));
            Assert.IsNotNull(objeto.Id);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("marcio@gmail.com", "Marcio", "Rosa", "marcio@gmail.com", "123456")]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveLancarErroSenhaForaDoPadrao(string email, string nome, string sobrenome, string login, string senha)
        {
            new UsuarioAutenticacao(usuario, new Email(email), new NomePessoa(nome, sobrenome), login, new SenhaSecreta(senha));
        }
    }
}
