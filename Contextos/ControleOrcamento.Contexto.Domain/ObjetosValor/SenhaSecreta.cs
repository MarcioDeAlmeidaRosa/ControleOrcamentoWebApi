using Flunt.Validations;

namespace ControleOrcamento.Contexto.Domain.ObjetosValor
{
    /// <summary>
    /// Representa uma senha válida na aplicação
    /// </summary>
    public sealed class SenhaSecreta : ObjetoValor
    {
        /// <summary>
        /// Representa a senha válida
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// Cria uma senha válida
        /// </summary>
        /// <param name="senha"></param>
        public SenhaSecreta(string senha)
        {
            Senha = senha;
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Senha, 6, "SenhaSecreta.Senha", "A senha deve conter no mínimo 6 caracteres")
                .HasMaxLen(Senha, 30, "SenhaSecreta.Senha", "A senha deve conter no máximo 30 caracteres")
                .Matchs(Senha, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}", "SenhaSecreta.Senha", "A senha deve conter no mínimo 6 caracteres, pelo menos 1 letra e 1 número:")
            );
        }
    }
}
