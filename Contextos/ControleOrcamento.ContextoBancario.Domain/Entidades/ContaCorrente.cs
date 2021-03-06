﻿using ControleOrcamento.Contexto.Domain.Entidade;
using ControleOrcamento.Contexto.Domain.Entidade.Contratos.Usuario;
using ControleOrcamento.ContextoBancario.Domain.Enums;
using ControleOrcamento.ContextoBancario.Domain.Servicos;
using System;

namespace ControleOrcamento.ContextoBancario.Domain.Entidades
{
    /// <summary>
    /// Representa uma conta corrente no mundo real
    /// </summary>
    public sealed class ContaCorrente : EntidadeBase, IServicoContaCorrente
    {
        /// <summary>
        /// Representa a agência bancária da conta corrente no mundo real
        /// </summary>
        public Agencia Agencia { get; private set; }

        /// <summary>
        /// Representa o número da conta corrente no mundo real
        /// </summary>
        public string Numero { get; private set; }

        /// <summary>
        /// Representa o DV da conta corrente no mundo real
        /// </summary>
        public string DV { get; private set; }

        /// <summary>
        /// Quando verdadeiro a conta principal do usuário para lançamentos automáticos
        /// </summary>
        public string EhPrincipal { get; set; }

        /// <summary>
        /// Quando verdadeiro a aplicação controla o saldo da 
        /// conta do usuário com os lançamentos de débitos/créditos
        /// </summary>
        public bool ControlaSaldo { get; set; }

        /// <summary>
        /// Representa o tipo de conta do usuário da aplicação
        /// </summary>
        public TipoContaCorrente Tipo { get; set; }

        /// <summary>
        /// Representa o valor do saldo da conta corrente no mundo real
        /// </summary>
        public decimal Saldo { get; private set; }

        /// <summary>
        /// Representa o valor do limite da conta corrente no mundo real
        /// </summary>
        public decimal Limite { get; private set; }

        /// <summary>
        /// Cria nova conta corrente garantindo seu estado válido
        /// </summary>
        /// <param name="usuarioCriacao">Usuário responsável pelo registro</param>
        /// <param name="agencia">Agência da conta corrente</param>
        /// <param name="numero">Número da conta corrente</param>
        /// <param name="dv">DV da conta corrente</param>
        /// <param name="tipo">Tipo da conta corrente</param>
        /// <param name="saldo">Saldo da conta corrente</param>
        /// <param name="limite">Limite da conta corrente</param>
        /// <exception cref="ArgumentNullException">Lançado quando não for informado qualquer das propriedades:
        /// <paramref name="usuarioCriacao"/>
        /// <paramref name="agencia"/>
        /// <paramref name="numero"/>
        /// <paramref name="dv"/>
        /// <paramref name="tipo"/>
        /// <paramref name="saldo"/>
        /// <paramref name="limite"/>
        /// </exception>
        public ContaCorrente(UsuarioBase usuarioCriacao, Agencia agencia, string numero, string dv, TipoContaCorrente? tipo, decimal? saldo, decimal? limite)
        {
            UsuarioCriacao = usuarioCriacao ?? throw new ArgumentNullException(nameof(usuarioCriacao), "Não informado usuário do registro");
            Agencia = agencia ?? throw new ArgumentNullException(nameof(agencia), "Não informada agência da conta corrente");
            Numero = numero ?? throw new ArgumentNullException(nameof(numero), "Não informado número da conta corrente");
            DV = dv ?? throw new ArgumentNullException(nameof(dv), "Não informado o DV da conta corrente");
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo), "Não informado o tipo da conta corrente");
            saldo = saldo ?? throw new ArgumentNullException(nameof(saldo), "Não informado o saldo da conta corrente");
            limite = limite ?? throw new ArgumentNullException(nameof(limite), "Não informado o limite da conta corrente");
        }

        /// <summary>
        /// Construtor necessário para o ORM
        /// </summary>
        [Obsolete("Método obsoleto, necessário somente para funcionamento do ORM")]
        public ContaCorrente()
        {

        }

        /// <summary>
        /// Responsável por efetuar depósito na conta corrente
        /// </summary>
        /// <param name="valor">Valor que será depositado na conta corrente</param>
        /// <exception cref="ArgumentException">Lançada exception quando o valor informado no parâmetro 
        /// <paramref name="valor"/> não for válido, somente é aceito valor maior que 0.
        /// </exception>
        public void Depositar(decimal valor)
        {
            if (!ControlaSaldo) return;

            if (valor <= 0)
            {
                throw new ArgumentException("Valor para depósito não é válido", nameof(valor));
            }
            Saldo += valor;
        }

        /// <summary>
        /// Resmposável por efetuar saque na conta corrente
        /// </summary>
        /// <param name="valor">Valor que será sacado na conta corrente</param>
        /// <exception cref="ArgumentException">Lançada exception quando o valor informado no parâmetro 
        /// <paramref name="valor"/> não for válido, somente é aceito valor maior que 0.
        /// </exception>
        public void Sacar(decimal valor)
        {
            if (!ControlaSaldo) return;

            if (valor <= 0)
            {
                throw new ArgumentException("Valor para saque não é válido", nameof(valor));
            }

            if (Limite >= ((Saldo - valor) * -1))
            {
                //TODO: criar uma exception específica para esta regra
                throw new Exception("Não existe saldo na conta corrente para sacar");
            }
            Saldo -= valor;
        }
    }
}
