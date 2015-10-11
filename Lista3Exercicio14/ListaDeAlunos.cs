// ListaDeAlunos.cs
using System;

namespace Lista3Exercicio14
{
	public class ListaDeAlunos
	{
		private System.Collections.Generic.List<Aluno> lista;

		public ListaDeAlunos()
		{
		}

		public void LeCadastroDoArquivo()
		{
			System.IO.BinaryReader leitor = null;
			Aluno a;
			int n;

			this.lista = new System.Collections.Generic.List<Aluno>();

			try
			{
				leitor = new System.IO.BinaryReader(new System.IO.FileStream("alunos.dat", System.IO.FileMode.Open));

				n = leitor.ReadInt32();
				for (int i = 0; i < n; i++)
				{
					a = new Aluno();
					a.nome = leitor.ReadString();
					a.idade = leitor.ReadInt32();
					a.sexo = leitor.ReadChar();

					this.lista.Add(a);
				}
			}
			catch (System.IO.FileNotFoundException)
			{
				Console.WriteLine("AVISO! Arquivo alunos.dat não foi encontrado. Cadastro começará vazio.");
				Console.ReadKey();
			}
			catch (System.Exception exc)
			{
				Console.WriteLine("ERRO! " + exc.Message);
				Console.ReadKey();
			}
			finally
			{
				if (leitor != null)
					leitor.Close();
			}
		}

		public void SalvarCadastroEmArquivo()
		{
			System.IO.BinaryWriter escritor = null;

			try
			{
				escritor = new System.IO.BinaryWriter(new System.IO.FileStream("alunos.dat", System.IO.FileMode.Create));

				escritor.Write(this.lista.Count);

				for (int i = 0; i < this.lista.Count; i++)
				{
					escritor.Write(this.lista[i].nome);
					escritor.Write(this.lista[i].idade);
					escritor.Write(this.lista[i].sexo);
				}
			}
			catch (System.Exception exc)
			{
				Console.WriteLine("ERRO! " + exc.Message);
				Console.ReadKey();
			}
			finally
			{
				if (escritor != null)
					escritor.Close();
			}
		}

		public void Listar()
		{
			Console.Clear();
			Console.WriteLine("Lista 3 Exercício 14");
			Console.WriteLine("----------------------------------");
			Console.WriteLine();

			Console.WriteLine("Listagem de alunos cadastrados: ");
			Console.WriteLine();

			if (this.lista.Count == 0)
				Console.WriteLine("Cadastro vazio!");
			else
			{
				for (int i = 0; i < this.lista.Count; i++)
					Console.WriteLine("Aluno: {0}, nome: {1}, idade: {2}, sexo: {3}", i+1, this.lista[i].nome, this.lista[i].idade, this.lista[i].sexo);
			}
		}

		public void Adicionar()
		{
			Aluno a;

			Console.Clear();
			Console.WriteLine("Lista 3 Exercício 14");
			Console.WriteLine("----------------------------------");
			Console.WriteLine();

			Console.WriteLine("Cadastro de novo aluno: ");
			Console.WriteLine();

			a = new Aluno();

			//TODO: tratar erros de digitação do usuário (idade, sexo)

			Console.Write("Digite o nome do aluno: ");
			a.nome = Console.ReadLine();

			Console.Write("Digite a idade do aluno: ");
			a.idade = int.Parse(Console.ReadLine());

			Console.Write("Digite o sexo do aluno (M/F): ");
			a.sexo = char.Parse(Console.ReadLine());

			//TODO: tratar caso em que o aluno já existe (pelo nome)
			this.lista.Add(a);

			Console.WriteLine();
			Console.WriteLine("Aluno {0} cadastrado com sucesso!", a.nome);
		}

		public void Editar()
		{
			int indice;
			string tmp;

			do
			{
				this.Listar();

				Console.WriteLine();
				Console.Write("Escolha um aluno: ");
				indice = int.Parse(Console.ReadLine());
				indice -= 1;

				if (indice < 0 || indice > this.lista.Count-1)
					Console.WriteLine("ERRO! Aluno {0} não existe. Favor digitar novamente. ", indice+1);
			}
			while (indice < 0 || indice > this.lista.Count-1);

			Console.WriteLine();

			//TODO: tratar erros de digitação do usuário (idade, sexo)
			//TODO: tratar caso em que o aluno já existe (pelo nome)

			Console.Write("Digite o novo nome [{0}]: ", this.lista[indice].nome);
			tmp = Console.ReadLine();
			if (tmp != "")
				this.lista[indice].nome = tmp;

			Console.Write("Digite a nova idade [{0}]: ", this.lista[indice].idade);
			tmp = Console.ReadLine();
			if (tmp != "")
				this.lista[indice].idade = int.Parse(tmp);

			Console.Write("Digite o novo sexo [{0}]: ", this.lista[indice].sexo);
			tmp = Console.ReadLine();
			if (tmp != "")
				this.lista[indice].sexo = char.Parse(tmp);

			Console.WriteLine();
			Console.WriteLine("Aluno {0} alterado com sucesso!", this.lista[indice].nome);
		}

		public void Remover()
		{
			int indice;
			string nome;

			do
			{
				this.Listar();

				Console.WriteLine();
				Console.Write("Escolha um aluno: ");
				indice = int.Parse(Console.ReadLine());
				indice -= 1;

				if (indice < 0 || indice > this.lista.Count-1)
					Console.WriteLine("ERRO! Aluno {0} não existe. Favor digitar novamente. ", indice+1);
			}
			while (indice < 0 || indice > this.lista.Count-1);

			nome = this.lista[indice].nome;

			this.lista.RemoveAt(indice);

			Console.WriteLine();
			Console.WriteLine("Aluno {0} removido com sucesso!", nome);
		}
	}
}