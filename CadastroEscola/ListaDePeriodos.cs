using System;

namespace CadastroEscola
{
    public class ListaDePeriodos
    {
        public System.Collections.Generic.List<Periodo> vetor;
        private EntradaDeDados.Variaveis variaveis;

        public ListaDePeriodos()
        {
            this.vetor = new System.Collections.Generic.List<Periodo>();
            this.variaveis = new EntradaDeDados.Variaveis();
            this.Load();
        }

        public void Menu()
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Períodos");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1) Criar novo período");
                Console.WriteLine("2) Listagem completa de períodos");
                Console.WriteLine("3) Remover um período existente");
                Console.WriteLine("4) Salvar");
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
                        this.Delete();
                        break;
                    case 4:
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
            Periodo periodo;

            periodo = new Periodo();

            Console.WriteLine();

            periodo.Ano = this.variaveis.LeInt("Ano: ");

            do
            {
                periodo.Semestre = this.variaveis.LeInt("Semestre: ");

                if (periodo.Semestre != 1 && periodo.Semestre != 2)
                    Console.WriteLine("ERRO! Semestre só pode ser igual a 1 ou 2.");
            }
            while (periodo.Semestre != 1 && periodo.Semestre != 2);

            if (Search(periodo.Ano, periodo.Semestre) == -1)
            {
                this.vetor.Add(periodo);
                Console.WriteLine();
                Console.WriteLine("Período {0}/{1} cadastrado com sucesso!", periodo.Ano, periodo.Semestre);
            }
            else
                Console.WriteLine("ERRO! Período já foi cadastrado.");
        }

        public void Retrieve()
        {
            Console.WriteLine();

            Console.WriteLine("Número total de períodos cadastrados: {0}", this.vetor.Count);
            Console.WriteLine("Ano | Semestre");

            foreach (Periodo x in this.vetor)
                Console.WriteLine("{0} | {1}", x.Ano, x.Semestre);
            Console.WriteLine();
        }

        public void Update()
        {
        }

        public void Delete()
        {
            Periodo periodo;
            int indice;

            Console.WriteLine();

            if (this.vetor.Count > 0)
            {
                this.Retrieve();

                periodo = new Periodo();

                do
                {
                    periodo.Ano = this.variaveis.LeInt("Ano de Admissão: ");
                    periodo.Semestre = this.variaveis.LeInt("Semestre de Admissão: ");

                    indice = this.Search(periodo.Ano, periodo.Semestre);

                    if (indice == -1)
                        Console.WriteLine("ERRO! Período {0}/{1} não existe.");
                }
                while (indice == -1);

                this.vetor.RemoveAt(indice);
                Console.WriteLine();
                Console.WriteLine("Período {0}/{1} removido com sucesso!", periodo.Ano, periodo.Semestre);
            }
            else
                Console.WriteLine("Nenhum período foi cadastrado.");
        }

        public void Load()
        {
        }

        public void Save()
        {
        }

        public int Search(int pAno, int pSemestre)
        {
            bool achou = false;
            int k = 0;

            while (k < this.vetor.Count && !achou)
            {
                if (this.vetor[k].Ano == pAno && this.vetor[k].Semestre == pSemestre)
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

