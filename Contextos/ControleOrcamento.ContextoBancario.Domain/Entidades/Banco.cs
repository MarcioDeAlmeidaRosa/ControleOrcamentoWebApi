﻿using ControleOrcamento.Contexto.Domain.Entidade;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;
using System;

namespace ControleOrcamento.ContextoBancario.Domain.Entidades
{
    /// <summary>
    /// Representa um banco no mundo real
    /// </summary>
    public sealed class Banco : EntidadeBase
    {
        /// <summary>
        /// Representa o número do banco no mundo real
        /// </summary>
        public string Numero { get; private set; }

        /// <summary>
        /// Representa o nome do banco no mundo real
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Cria novo banco garantindo seu estado válido
        /// </summary>
        /// <param name="usuarioCriacao">Usuário responsável pelo registro</param>
        /// <param name="numero">Número do banco</param>
        /// <param name="nome">Nome do banco</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado qualquer das propriedades:
        /// <paramref name="usuarioCriacao"/>
        /// <paramref name="numero"/>
        /// <paramref name="nome"/>
        /// </exception>
        public Banco(UsuarioBase usuarioCriacao, string numero, string nome)
        {
            UsuarioCriacao = usuarioCriacao ?? throw new ArgumentNullException(nameof(usuarioCriacao), "Não informado usuário do registro");
            Numero = numero ?? throw new ArgumentNullException(nameof(numero), "Não informado número do banco");
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), "Não informado nome do banco");
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public Banco()
        {

        }
    }
}
