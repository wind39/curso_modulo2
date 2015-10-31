﻿using System;

namespace CadastroEscola
{
    public class ListaDeDisciplinas
    {
        public System.Collections.Generic.List<Disciplina> vetor;
        private EntradaDeDados.Variaveis variaveis;

        public ListaDeDisciplinas()
        {
            this.vetor = new System.Collections.Generic.List<Disciplina>();
            this.variaveis = new EntradaDeDados.Variaveis();
            this.Load();
        }

        public void Menu()
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Disciplinas");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1) Criar nova disciplina");
                Console.WriteLine("2) Listagem completa de disciplinas");
                Console.WriteLine("3) Editar uma disciplina existente");
                Console.WriteLine("4) Remover uma disciplina existente");
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

