// Program.cs
using System;

namespace Lista3Exercicio14
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			ListaDeAlunos cadastro;
			int opcao;

			cadastro = new ListaDeAlunos();
			cadastro.LeCadastroDoArquivo();

			do
			{
				Console.Clear();
				Console.WriteLine("Lista 3 Exercício 14");
				Console.WriteLine("----------------------------------");
				Console.WriteLine();

				Console.WriteLine("1) Listar alunos cadastrados");
				Console.WriteLine("2) Cadastrar novo aluno");
				Console.WriteLine("3) Editar um aluno existente");
				Console.WriteLine("4) Remover um aluno existente");
				Console.WriteLine("5) Salvar cadastro atual e sair");
				Console.WriteLine("6) Sair sem salvar");

				Console.WriteLine();
				Console.Write("Digite a opção desejada: ");

				opcao = int.Parse(Console.ReadLine());

				switch (opcao)
				{
				case 1:
					cadastro.Listar();
					break;
				case 2:
					cadastro.Adicionar();
					break;
				case 3:
					cadastro.Editar();
					break;
				case 4:
					cadastro.Remover();
					break;
				case 5:
					cadastro.SalvarCadastroEmArquivo();
					break;
				case 6:
					break;
				default:
					Console.WriteLine("Erro! Opção inexistente.");
					break;
				}

				Console.ReadKey();
			}
			while (opcao != 5 && opcao != 6);
		}
	}
}