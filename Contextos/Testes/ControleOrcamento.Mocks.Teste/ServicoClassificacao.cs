using System;
using FizzWare.NBuilder;
using System.Collections.Generic;
using ControleOrcamento.ContextoClassificacao.Domain.Servicos;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;
using ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor;
using ControleOrcamento.ContextoClassificacao.Domain.Enums;

namespace ControleOrcamento.Mocks.Teste
{
    public class ServicoClassificacao : IServicoClassificacao
    {
        private readonly UsuarioBase usuario;

        public ServicoClassificacao()
        {
            usuario = new ServicoUsuario().BuscarPorId(Guid.NewGuid());
        }

#pragma warning disable CS0618 // Type or member is obsolete
        public Classificacao ClassificacaoDoUsuarioPorID(UsuarioBase usuario, Guid id) => Builder<Classificacao>
                .CreateNew()
                .WithConstructor(() => new Classificacao(
                           usuario,
                           new NomeClassificacaoPadrao(Faker.Name.FullName()),
                           Categoria.Despesa
                           )
                )
#pragma warning restore CS0618 // Type or member is obsolete
                .Build();

#pragma warning disable CS0618 // Type or member is obsolete
        public IList<Classificacao> ListaClassificacaoDoUsuario(UsuarioBase usuario) => Builder<Classificacao>
                .CreateListOfSize(100)
                .All()
                .WithConstructor(() => new Classificacao(
                           usuario,
                           new NomeClassificacaoPadrao(Faker.Name.FullName()),
                           Categoria.Despesa
                           )
                )
#pragma warning restore CS0618 // Type or member is obsolete
           .Build();
    }
}
