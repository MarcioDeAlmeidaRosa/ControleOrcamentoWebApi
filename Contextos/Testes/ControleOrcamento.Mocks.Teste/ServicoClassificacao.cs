using FizzWare.NBuilder;
using System.Collections.Generic;
using ControleOrcamento.ContextoClassificacao.Domain.Servicos;
using ControleOrcamento.ContextoClassificacao.Domain.Entidades;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;

namespace ControleOrcamento.Mocks.Teste
{
    public class ServicoClassificacao : IServicoClassificacao
    {
        public IList<Classificacao> ListaClassificacaoPorUsuario(UsuarioBase usuario)
        {
            return Builder<Classificacao>.CreateListOfSize(100).All()
            //.With(c => c.FirstName = Faker.Name.First())
            //.With(c => c.LastName = Faker.Name.Last())
            //.With(c => c.EmailAddress = Faker.Internet.Email())
            //.With(c => c.TelephoneNumber = Faker.Phone.Number())
           .Build();
        }
    }
}
