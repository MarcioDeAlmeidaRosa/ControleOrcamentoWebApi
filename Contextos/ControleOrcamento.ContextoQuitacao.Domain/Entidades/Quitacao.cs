using ControleOrcamento.Contexto.Domain.Entidade;
using ControleOrcamento.ContextoQuitacao.Domain.Enums;

namespace ControleOrcamento.ContextoQuitacao.Domain.Entidades
{
    /// <summary>
    /// Representa a forma de quitação de um lançamento da aplicação
    /// </summary>
    public abstract class Quitacao: EntidadeBase
    {
        /// <summary>
        /// Representa a drescrição para identificação do registro
        /// </summary>
        public string Descricao { get; private set; }

        /// <summary>
        /// Quando marcado como verdadeiro, o registro será considerado como padrão na inclusão dos lançamentos
        /// </summary>
        public bool Padrao { get; private set; }

        /// <summary>
        /// Representa a forma por onde foi feita a quitação
        /// </summary>
        public Meio Meio { get; private set; }
    }
}
