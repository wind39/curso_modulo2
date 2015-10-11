using System;

namespace Lista1Exercicio02
{
    public class Habitacao
    {
        public int area;
        public Porta porta;

        public Habitacao(int p_area, Porta p_porta)
        {
            this.area = p_area;
            this.porta = p_porta;
        }

        public void Mostrar()
        {
            Console.WriteLine("Eu sou uma habitação, minha área é {0} m2, e a cor da minha porta é {1}.", this.area, this.porta.cor);
        }
    }
}

