using System;

namespace Lista1Exercicio03
{
    public class Retangulo
    {
        public int altura, largura;

        public Retangulo()
        {
        }

        public Retangulo(int p_altura, int p_largura)
        {
            this.altura = p_altura;
            this.largura = p_largura;
        }

        public void Mostrar()
        {
            Console.WriteLine("Altura = {0}, largura = {1}", this.altura, this.largura);
        }
    }
}

