﻿namespace ProjetoFinalPOOI
{
    internal class Cliente : Pessoa
    {
        public int Pontuacao { get; set; } = 100;
        public string Obs { get; }
        public CartaoCredito CartaoCredito { get; }
        public Cliente(string nome, DateOnly dataNascimento, long cpf, string endereco, string telefone, long cnh, string obs, CartaoCredito cartaoCredito) : base(nome, dataNascimento, cpf, endereco, telefone, cnh)
        {
            this.Obs = obs;
            CartaoCredito = cartaoCredito;
        }
        public static new Cliente Ler()
        {
            var pessoa = Pessoa.Ler();
            var obs = LerObs();
            var cartao = CartaoCredito.Ler();
            return new Cliente(pessoa.Nome, pessoa.DataNascimento, pessoa.Cpf, pessoa.Endereco, pessoa.Telefone, pessoa.Cnh, obs, cartao);
        }
        private static string LerObs()
        {
            Console.Write("Observação: ");
            return Console.ReadLine();
        }
    }
}