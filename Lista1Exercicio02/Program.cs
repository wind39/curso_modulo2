using System;

namespace Lista1Exercicio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Morador m;

            m = new Morador("William", 27, new Apartamento(new Porta("marrom")));
            m.Mostrar();

            Console.ReadKey();
        }
    }
}
