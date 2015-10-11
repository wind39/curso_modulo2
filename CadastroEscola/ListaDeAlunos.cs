using System;

namespace CadastroEscola
{
    public class ListaDeAlunos
    {
        public System.Collections.Generic.List<Aluno> vetor;
        private EntradaDeDados.Variaveis variaveis;

        public ListaDeAlunos()
        {
            this.vetor = new System.Collections.Generic.List<Aluno>();
            this.variaveis = new EntradaDeDados.Variaveis();
        }

        public void Menu()
        {
            int opcao;

            this.Load();

            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Alunos");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1) Criar novo aluno");
                Console.WriteLine("2) Listagem completa de alunos");
                Console.WriteLine("3) Editar um aluno existente");
                Console.WriteLine("4) Remover um aluno existente");
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
            Aluno aluno;

            aluno = new Aluno();

            Console.WriteLine();

            aluno.NomeCompleto = this.variaveis.LeString("Nome Completo: ");

            //TODO: tratar sexos inválidos (só pode ser M ou F)
            aluno.Sexo = this.variaveis.LeChar("Sexo: ");

            aluno.DocumentoIdentificacao = this.variaveis.LeString("Documento de Identificação: ");
            aluno.DataNascimento = this.variaveis.LeDateTime("Data de Nascimento: ");

            //TODO: solicitar periodo de admissao

            aluno.NumeroMatricula = this.vetor.Count + 1;

            this.vetor.Add(aluno);

            Console.WriteLine();
            Console.WriteLine("Aluno {0} cadastrado com sucesso!", aluno.NomeCompleto);
        }

        public void Retrieve()
        {
            Console.WriteLine();

            Console.WriteLine("Número total de alunos cadastrados: {0}", this.vetor.Count);
            Console.WriteLine("Núm. Matrícula | Nome Completo | Sexo | Documento | Data Nascimento");

            foreach (Aluno x in this.vetor)
                //TODO: mostrar periodo de admissao do aluno
                Console.WriteLine("{0} | {1} | {2} | {3} | {4}", x.NumeroMatricula, x.NomeCompleto, x.Sexo, x.DocumentoIdentificacao, x.DataNascimento);
            Console.WriteLine();
        }

        public void Update()
        {
            int matricula;
            int indice;

            this.Retrieve();

            do
            {
                Console.Write("Digite o número de matrícula do aluno a ser atualizado: ");
                matricula = int.Parse(Console.ReadLine());

                //TODO: verificar se aluno existe com código de busca
                if (matricula < 1 || matricula > this.vetor.Count)
                    Console.WriteLine("ERRO! Aluno não existente.");
            }
            while (matricula < 1 || matricula > this.vetor.Count);

            //TODO: código de busca retornaria o índice do aluno
            indice = matricula - 1;

            Console.WriteLine();

            vetor[indice].NomeCompleto = this.variaveis.LeString("Nome Completo: ");

            //TODO: tratar sexos inválidos (só pode ser M ou F)
            vetor[indice].Sexo = this.variaveis.LeChar("Sexo: ");

            vetor[indice].DocumentoIdentificacao = this.variaveis.LeString("Documento de Identificação: ");
            vetor[indice].DataNascimento = this.variaveis.LeDateTime("Data de Nascimento: ");

            //TODO: concluir metodo update
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
