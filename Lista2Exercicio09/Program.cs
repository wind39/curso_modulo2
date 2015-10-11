using System;
using MinhaBiblioteca;

namespace Lista2Exercicio09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculadora c;
            double a, b;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            c = new Calculadora();

            Console.WriteLine("A soma de A e B = {0}", c.Soma(a, b));
            Console.WriteLine("A subtração de A e B = {0}", c.Subtracao(a, b));
            Console.WriteLine("A multiplicação de A e B = {0}", c.Multiplicacao(a, b));
            Console.WriteLine("A divisão de A e B = {0}", c.Divisao(a, b));

            Console.ReadKey();
        }
    }
}
