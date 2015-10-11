using System;

namespace Lista1Exercicio01
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
        }

        public Aluno(string pnome, int pidade) : base(pnome, pidade)
        {
        }

        public void IrParaEscola()
        {
            Console.WriteLine("O aluno {0} está indo para escola.", this.nome);
        }
    }
}
