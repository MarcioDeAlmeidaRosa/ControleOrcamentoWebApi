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
#pragma warning disable CS0618 // Type or member is obsolete
        public UsuarioBase BuscarPorId(Guid guid) => Builder<UsuarioMaster>
                .CreateNew()
                .WithConstructor(() => new UsuarioMaster(
                           null,
                           new Email(Faker.Internet.Email()),
                           new NomePessoa(Faker.Name.First(), Faker.Name.Last())
                           )
                )
#pragma warning restore CS0618 // Type or member is obsolete
                .Build();
    }
}
