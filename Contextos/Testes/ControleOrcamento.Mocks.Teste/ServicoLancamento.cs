using System;
using FizzWare.NBuilder;
using System.Collections.Generic;
using ControleOrcamento.ContextoClassificacao.Domain.Servicos;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;
using ControleOrcamento.ContextoClassificacao.Domain.ObjetosValor;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.Mocks.Teste
{
    public class ServicoLancamento : IServicoLancamento
    {
        private readonly UsuarioBase usuario;
        private readonly Classificacao classificacao;

        public ServicoLancamento()
        {
            usuario = new ServicoUsuario().BuscarPorId(Guid.NewGuid());
            classificacao = new ServicoClassificacao().ClassificacaoDoUsuarioPorID(usuario, Guid.NewGuid());
        }

#pragma warning disable CS0618 // Type or member is obsolete
        public IList<Lancamento> ListaLancamentoDoUsuario(UsuarioBase usuario) => Builder<Lancamento>
                .CreateListOfSize(100)
                .All()
                .WithConstructor(() =>
                    new Lancamento(
                               usuario,
                               new NomeLancamentoPadrao(Faker.Name.FullName()),
                               classificacao
                               )
                )
#pragma warning restore CS0618 // Type or member is obsolete
           .Build();
    }
}
