using System;

namespace Lista1Exercicio02
{
    public class Porta
    {
        public string cor;

        public Porta(string p_cor)
        {
            this.cor = p_cor;
        }

        public void Mostrar()
        {
            Console.WriteLine("Eu sou uma porta, minha cor é {0}.", this.cor);
        }
    }
}

