using System;
using FizzWare.NBuilder;
using ControleOrcamento.ContextoUsuario.Domain.Servicos;
using ControleOrcamento.ContextoUsuario.Domain.Entidades;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;
using ControleOrcamento.Contexto.Domain.ObjetosValor;

namespace ControleOrcamento.Mocks.Teste
{
    public class ServicoUsuario : IServicoUsuario
    {
        public UsuarioBase BuscarPorId(Guid guid)
        {
            return Builder<UsuarioMaster>.CreateNew()
                .WithConstructor(() => new UsuarioMaster(
                           null,
                           new Email(Faker.Internet.Email()),
                           new NomePessoa(Faker.Name.First(), Faker.Name.Last())
                           )
                )
                //.With(c => c.Nome = new Contexto.Domain.ObjetosValor.NomePessoa(Faker.Name.First(), Faker.Name.Last()))
                .Build();
        }
    }
}
