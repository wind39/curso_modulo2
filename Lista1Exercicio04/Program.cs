using System;

namespace Lista1Exercicio04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Collections.Generic.List<Ponto3D> vetor;
            Ponto3D p;
            int n;

            vetor = new System.Collections.Generic.List<Ponto3D>();

            Console.Write("Quantos pontos serão criados? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                p = new Ponto3D();

                Console.Write("Digite o valor X do ponto {0}: ", i);
                p.x = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor Y do ponto {0}: ", i);
                p.y = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor Z do ponto {0}: ", i);
                p.z = int.Parse(Console.ReadLine());

                vetor.Add(p);

                Console.Write("O ponto que você digitou foi: ");
                vetor[i].Mostrar();

                Console.WriteLine();
            }

            for (int i = 1; i < n; i++)
                Console.WriteLine("A distância entre o ponto 0 e o ponto {0} é {1}", i, vetor[0].Distancia(vetor[i]));

            Console.ReadKey();
        }
    }
}
