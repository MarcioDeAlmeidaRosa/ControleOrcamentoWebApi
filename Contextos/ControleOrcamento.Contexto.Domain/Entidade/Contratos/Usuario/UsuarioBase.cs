using ControleOrcamento.Contexto.Domain.ObjetosValor;

namespace ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario
{
    /// <summary>
    /// Representa um usuário registrado na aplicação
    /// </summary>
    public abstract class UsuarioBase : UsuarioCandidato
    {
        /// <summary>
        /// Representa o nome do usuário da aplicação
        /// </summary>
        public NomePessoa Nome { get; set; }
    }
}
