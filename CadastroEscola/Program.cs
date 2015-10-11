using System;

namespace CadastroEscola
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ListaDeAlunos alunos;
            ListaDeDisciplinas disciplinas;
            ListaDeHorarios horarios;
            ListaDeMatriculas matriculas;
            ListaDePeriodos periodos;
            ListaDeProfessores professores;
            ListaDeTurmas turmas;
            int opcao;

            alunos = new ListaDeAlunos();
            disciplinas = new ListaDeDisciplinas();
            horarios = new ListaDeHorarios();
            matriculas = new ListaDeMatriculas();
            periodos = new ListaDePeriodos();
            professores = new ListaDeProfessores();
            turmas = new ListaDeTurmas();

            do
            {
                Console.Clear();
                Console.WriteLine("CADASTRO DA ESCOLA");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1) Cadastro de Alunos");
                Console.WriteLine("2) Cadastro de Professores");
                Console.WriteLine("3) Cadastro de Disciplinas");
                Console.WriteLine("4) Cadastro de Períodos");
                Console.WriteLine("5) Cadastro de Horários");
                Console.WriteLine("6) Cadastro de Turmas");
                Console.WriteLine("7) Cadastro de Matrículas");
                Console.WriteLine("0) Encerrar programa");
                Console.WriteLine();
                Console.Write("Digite a opção desejada: ");

                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 0:
                        break;
                    case 1:
                        alunos.Menu();
                        break;
                    case 2:
                        professores.Menu();
                        break;
                    case 3:
                        disciplinas.Menu();
                        break;
                    case 4:
                        periodos.Menu();
                        break;
                    case 5:
                        horarios.Menu();
                        break;
                    case 6:
                        turmas.Menu();
                        break;
                    case 7:
                        matriculas.Menu();
                        break;
                    default:
                        Console.WriteLine("ERRO! Opção {0} inválida.", opcao);
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}
