using System;

namespace CadastroEscola
{
    /// <summary>
    /// Classe ListaDeAlunos.
    /// </summary>
    /// <remarks>
    /// Contém métodos para criar, listar, inserir, remover, carregar de arquivo e salvar em arquivo.
    /// </remarks>
    public class ListaDeAlunos
    {
        /// <summary>
        /// Vetor dinâmico de alunos.
        /// </summary>
        public System.Collections.Generic.List<Aluno> vetor;

        /// <summary>
        /// Objeto auxiliar para leitura de dados pelo Console.
        /// </summary>
        private EntradaDeDados.Variaveis variaveis;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ListaDeAlunos"/>.
        /// </summary>
        public ListaDeAlunos()
        {
            this.vetor = new System.Collections.Generic.List<Aluno>();
            this.variaveis = new EntradaDeDados.Variaveis();
            this.Load();
        }

        /// <summary>
        /// Método que fornece um menu interativo ao usuário.
        /// </summary>
        public void Menu()
        {
            int opcao;

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

        /// <summary>
        /// Cria um novo aluno, solicitando ao usuário para digitar as informações.
        /// </summary>
        public void Create()
        {
            Aluno aluno;
            ListaDePeriodos listadeperiodos;
            Periodo periodo;

            aluno = new Aluno();
            listadeperiodos = new ListaDePeriodos();
            periodo = new Periodo();

            Console.WriteLine();

            aluno.DocumentoIdentificacao = this.variaveis.LeString("Documento de Identificação: ");
            if (this.Search(aluno.DocumentoIdentificacao) == -1)
            {
                aluno.NomeCompleto = this.variaveis.LeString("Nome Completo: ");
                
                // garantindo que o usuário digite M ou F para o sexo do Aluno
                do
                {
                    aluno.Sexo = char.ToUpper(this.variaveis.LeChar("Sexo: "));

                    if (aluno.Sexo != 'M' && aluno.Sexo != 'F')
                        Console.WriteLine("ERRO! Sexo só pode ser M ou F.");
                }
                while (aluno.Sexo != 'M' && aluno.Sexo != 'F');

                aluno.DataNascimento = this.variaveis.LeDateTime("Data de Nascimento: ");

                do
                {
                    periodo.Ano = this.variaveis.LeInt("Ano de Admissão: ");
                    periodo.Semestre = this.variaveis.LeInt("Semestre de Admissão: ");

                    if (listadeperiodos.Search(periodo.Ano, periodo.Semestre) == -1)
                        Console.WriteLine("ERRO! Período {0}/{1} não existe.");
                }
                while (listadeperiodos.Search(periodo.Ano, periodo.Semestre) == -1);
                aluno.PeriodoAdmissao = periodo;

                aluno.NumeroMatricula = this.vetor.Count + 1;

                this.vetor.Add(aluno);

                Console.WriteLine();
                Console.WriteLine("Aluno {0} cadastrado com sucesso!", aluno.NomeCompleto);
            }
            else
                Console.WriteLine("ERRO! Já existe um aluno com documento de identificação {0}.", aluno.DocumentoIdentificacao);
        }

        /// <summary>
        /// Lista todos os alunos cadastrados.
        /// </summary>
        public void Retrieve()
        {
            Console.WriteLine();

            Console.WriteLine("Número total de alunos cadastrados: {0}", this.vetor.Count);
            Console.WriteLine("Núm. Matrícula | Nome Completo | Sexo | Documento | Data Nascimento");

            foreach (Aluno x in this.vetor)
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}/{6}", x.NumeroMatricula, x.NomeCompleto, x.Sexo, x.DocumentoIdentificacao, x.DataNascimento, x.PeriodoAdmissao.Ano, x.PeriodoAdmissao.Semestre);
            Console.WriteLine();
        }

        /// <summary>
        /// Atualiza as informações de um aluno existente.
        /// </summary>
        public void Update()
        {
            int matricula;
            int indice;
            ListaDePeriodos listadeperiodos;
            Periodo periodo;

            this.Retrieve();

            do
            {
                Console.Write("Digite o número de matrícula do aluno a ser atualizado: ");
                matricula = int.Parse(Console.ReadLine());

                indice = this.Search(matricula);
                if (indice == -1)
                    Console.WriteLine("ERRO! Aluno não existente.");
            }
            while (indice == -1);

            listadeperiodos = new ListaDePeriodos();
            periodo = new Periodo();

            Console.WriteLine();

            do
            {
                vetor[indice].DocumentoIdentificacao = this.variaveis.LeString("Documento de Identificação: ");

                if (this.Search(vetor[indice].DocumentoIdentificacao) != -1 && this.Search(vetor[indice].DocumentoIdentificacao) != indice)
                    Console.WriteLine("ERRO! Outro aluno já existe com esse documento de identificação.");
            }
            while (this.Search(vetor[indice].DocumentoIdentificacao) != -1 && this.Search(vetor[indice].DocumentoIdentificacao) != indice);

            vetor[indice].NomeCompleto = this.variaveis.LeString("Nome Completo: ");

            do
            {
                vetor[indice].Sexo = char.ToUpper(this.variaveis.LeChar("Sexo: "));

                if (vetor[indice].Sexo != 'M' && vetor[indice].Sexo != 'F')
                    Console.WriteLine("ERRO! Sexo só pode ser M ou F.");
            }
            while (vetor[indice].Sexo != 'M' && vetor[indice].Sexo != 'F');

            vetor[indice].DataNascimento = this.variaveis.LeDateTime("Data de Nascimento: ");

            do
            {
                periodo.Ano = this.variaveis.LeInt("Ano de Admissão: ");
                periodo.Semestre = this.variaveis.LeInt("Semestre de Admissão: ");

                if (listadeperiodos.Search(periodo.Ano, periodo.Semestre) == -1)
                    Console.WriteLine("ERRO! Período {0}/{1} não existe.");
            }
            while (listadeperiodos.Search(periodo.Ano, periodo.Semestre) == -1);
            vetor[indice].PeriodoAdmissao = periodo;

            Console.WriteLine();
            Console.WriteLine("Aluno {0} atualizado com sucesso!", vetor[indice].NomeCompleto);
        }

        /// <summary>
        /// Exclui um aluno.
        /// </summary>
        public void Delete()
        {
        }

        /// <summary>
        /// Carrega do arquivo todos os alunos cadastrados para dentro do vetor.
        /// </summary>
        public void Load()
        {
        }

        /// <summary>
        /// Salva em arquivo todos os alunos que estão no vetor.
        /// </summary>
        public void Save()
        {
        }

        /// <summary>
        /// Método de busca por Documento de Identificação.
        /// </summary>
        /// <param name="pDocumentoIdentificacao">Documento de Identificação do aluno.</param>
        /// <returns>Índice do aluno que possui o Documento de Identificação; -1 caso nenhum aluno possua o Documento de Identificação.</returns>
        public int Search(string pDocumentoIdentificacao)
        {
            bool achou = false;
            int k = 0;

            while (k < this.vetor.Count && !achou)
            {
                if (this.vetor[k].DocumentoIdentificacao == pDocumentoIdentificacao)
                    achou = true;
                else
                    k++;
            }

            if (achou)
                return k;
            else
                return -1;
        }

        /// <summary>
        /// Método de busca por Número de Matrícula.
        /// </summary>
        /// <param name="pDocumentoIdentificacao">Número de Matrícula do aluno.</param>
        /// <returns>Índice do aluno que possui o Número de Matrícula; -1 caso nenhum aluno possua o Número de Matrícula.</returns>
        public int Search(int pNumeroMatricula)
        {
            bool achou = false;
            int k = 0;

            while (k < this.vetor.Count && !achou)
            {
                if (this.vetor[k].NumeroMatricula == pNumeroMatricula)
                    achou = true;
                else
                    k++;
            }

            if (achou)
                return k;
            else
                return -1;
        }
    }
}
