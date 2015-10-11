using System;

namespace EntradaDeDados
{
    public class Variaveis
    {
        public Variaveis()
        {
        }

        public int LeInt()
        {
            bool digitou_certo;
            int valor;

            do
            {
                Console.Write("Digite um número inteiro: ");
                digitou_certo = int.TryParse(Console.ReadLine(), out valor);

                if (!digitou_certo)
                    Console.WriteLine("Erro, valor digitado não é um número inteiro.");
            }
            while (!digitou_certo);

            return valor;
        }

        public int LeInt(string p_mensagem)
        {
            bool digitou_certo;
            int valor;

            do
            {
                Console.Write(p_mensagem);
                digitou_certo = int.TryParse(Console.ReadLine(), out valor);

                if (!digitou_certo)
                    Console.WriteLine("Erro, valor digitado não é um número inteiro.");
            }
            while (!digitou_certo);

            return valor;
        }

        public double LeDouble()
        {
            bool digitou_certo;
            double valor;

            do
            {
                Console.Write("Digite um número real: ");
                digitou_certo = double.TryParse(Console.ReadLine(), out valor);

                if (!digitou_certo)
                    Console.WriteLine("Erro, valor digitado não é um número real.");
            }
            while (!digitou_certo);

            return valor;
        }

        public double LeDouble(string p_mensagem)
        {
            bool digitou_certo;
            double valor;

            do
            {
                Console.Write(p_mensagem);
                digitou_certo = double.TryParse(Console.ReadLine(), out valor);

                if (!digitou_certo)
                    Console.WriteLine("Erro, valor digitado não é um número real.");
            }
            while (!digitou_certo);

            return valor;
        }

        public char LeChar()
        {
            bool digitou_certo;
            char valor;

            do
            {
                Console.Write("Digite um caractere: ");
                digitou_certo = char.TryParse(Console.ReadLine(), out valor);

                if (!digitou_certo)
                    Console.WriteLine("Erro, valor digitado não é um caractere.");
            }
            while (!digitou_certo);

            return valor;
        }

        public char LeChar(string p_mensagem)
        {
            bool digitou_certo;
            char valor;

            do
            {
                Console.Write(p_mensagem);
                digitou_certo = char.TryParse(Console.ReadLine(), out valor);

                if (!digitou_certo)
                    Console.WriteLine("Erro, valor digitado não é um caractere.");
            }
            while (!digitou_certo);

            return valor;
        }

        public string LeString()
        {
            Console.Write("Digite um texto: ");
            return Console.ReadLine();
        }

        public string LeString(string p_mensagem)
        {
            Console.Write(p_mensagem);
            return Console.ReadLine();
        }

        public DateTime LeDateTime()
        {
            bool digitou_certo;
            DateTime valor;

            do
            {
                Console.Write("Digite uma data/hora: ");
                digitou_certo = DateTime.TryParse(Console.ReadLine(), out valor);

                if (!digitou_certo)
                    Console.WriteLine("Erro, valor digitado não é uma data/hora.");
            }
            while (!digitou_certo);

            return valor;
        }

        public DateTime LeDateTime(string p_mensagem)
        {
            bool digitou_certo;
            DateTime valor;

            do
            {
                Console.Write(p_mensagem);
                digitou_certo = DateTime.TryParse(Console.ReadLine(), out valor);

                if (!digitou_certo)
                    Console.WriteLine("Erro, valor digitado não é uma data/hora.");
            }
            while (!digitou_certo);

            return valor;
        }
    }
}
