using System;

namespace Lista1Exercicio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pessoa p;
            Aluno aluno;
            Professor prof;

            // primeira parte
            p = new Pessoa("William", 27);
            p.Cumprimentar();
            p.DizerIdade();
            Console.WriteLine();

            // segunda parte
            aluno = new Aluno("José", 21);
            aluno.IrParaEscola();
            aluno.Cumprimentar();
            aluno.DizerIdade();
            Console.WriteLine();

            // terceira parte
            prof = new Professor("Marcos", 35);
            prof.Cumprimentar();
            prof.DizerIdade();
            prof.Explicar("programação em C#");

            Console.ReadKey();
        }
    }
}
