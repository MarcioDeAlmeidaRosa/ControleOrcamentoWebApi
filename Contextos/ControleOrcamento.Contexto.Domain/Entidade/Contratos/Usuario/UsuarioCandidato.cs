using ControleOrcamento.Contexto.Domain.ObjetosValor;

namespace ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario
{
    /// <summary>
    /// Representa as informações básicas de um usuário da aplicação
    /// </summary>
    public abstract class UsuarioCandidato : EntidadeBase
    {
        /// <summary>
        /// Representa o e-mail da conta do usuário da aplicaçãao
        /// </summary>
        public string Email { get; set; }
    }
}
