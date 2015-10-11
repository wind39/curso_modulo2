using System;

namespace MinhaBiblioteca
{
    public class Calculadora
    {
        public Calculadora()
        {
        }

        public double Soma(double a, double b)
        {
            return a + b;
        }

        public double Subtracao(double a, double b)
        {
            return a - b;
        }

        public double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        public double Divisao(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Calculadora.Divisao: Denominador não pode ser igual a zero!");
                return 0.0;
            }
        }
    }
}
