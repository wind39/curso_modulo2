using System;

namespace Lista1Exercicio02
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa()
        {   
        }

        public Pessoa(string pnome, int pidade)
        {
            this.nome = pnome;
            this.idade = pidade;
        }

        public void Cumprimentar()
        {
            Console.WriteLine("Olá, meu nome é {0}.", this.nome);
        }

        public void DizerIdade()
        {
            Console.WriteLine("Tenho {0} anos de idade.", this.idade);
        }
    }
}

