using System;

namespace CadastroEscola
{
    public class ListaDeProfessores
    {
        public System.Collections.Generic.List<Professor> vetor;

        public ListaDeProfessores()
        {
            this.vetor = new System.Collections.Generic.List<Professor>();
        }

        public void Menu()
        {
            int opcao;

            this.Load();

            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Professores");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1) Criar novo professor");
                Console.WriteLine("2) Listagem completa de professores");
                Console.WriteLine("3) Editar um professor existente");
                Console.WriteLine("4) Remover um professor existente");
                Console.WriteLine("5) Salvar");
                Console.WriteLine("0) Sair");
                Console.WriteLine();
                Console.Write("Digite a opção desejada: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        this.Create();
                        break;
                    case 2:
                        this.Retrieve();
                        break;
                    case 3:
                        this.Update();
                        break;
                    case 4:
                        this.Delete();
                        break;
                    case 5:
                        this.Save();
                        break;
                    default:
                        Console.WriteLine("ERRO! Opção {0} inválida.", opcao);
                        break;
                }
                Console.ReadKey();
            }
            while (opcao != 0);
        }

        public void Create()
        {
        }

        public void Retrieve()
        {
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }

        public void Load()
        {
        }

        public void Save()
        {
        }
    }
}

