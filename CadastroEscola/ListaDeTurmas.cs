﻿using System;

namespace CadastroEscola
{
    public class ListaDeTurmas
    {
        public System.Collections.Generic.List<Turma> vetor;
        private EntradaDeDados.Variaveis variaveis;

        public ListaDeTurmas()
        {
            this.vetor = new System.Collections.Generic.List<Turma>();
            this.variaveis = new EntradaDeDados.Variaveis();
            this.Load();
        }

        public void Menu()
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Turmas");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1) Criar nova turma");
                Console.WriteLine("2) Listagem completa de turmas");
                Console.WriteLine("3) Editar uma turma existente");
                Console.WriteLine("4) Remover uma turma existente");
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

