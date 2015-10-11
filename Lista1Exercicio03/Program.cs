using System;

namespace Lista1Exercicio03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Collections.Generic.List<Retangulo> vetor;

            vetor = new System.Collections.Generic.List<Retangulo>();

            // alimentando o vetor
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Preenchimento do retângulo {0}", i+1);

                vetor.Add(LeRetangulo());

                Console.WriteLine();
            }

            // mostrando todos os retangulos do vetor
            for (int i = 0; i < vetor.Count; i++)
            {
                Console.Write("Retângulo {0}: ", i+1);

                vetor[i].Mostrar();
            }

            Console.ReadKey();
        }

        public static Retangulo LeRetangulo()
        {
            Retangulo r;

            r = new Retangulo();

            Console.Write("Digite a altura: ");
            r.altura = int.Parse(Console.ReadLine());

            Console.Write("Digite a largura: ");
            r.largura = int.Parse(Console.ReadLine());

            return r;
        }
    }
}
