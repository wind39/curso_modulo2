using System;

namespace Lista1Exercicio05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AlbumDeFotos a;

            a = new AlbumDeFotos(80);

            Console.WriteLine("O exemplo abaixo não causa erro:");
            a.numeroDeFotos = 100;
            Console.WriteLine("Número atual de fotos = {0}", a.numeroDeFotos);

            Console.WriteLine();

            Console.WriteLine("O exemplo abaixo causa erro:");
            a.numeroDeFotos = 200;
            Console.WriteLine("Número atual de fotos = {0}", a.numeroDeFotos);

            Console.ReadKey();
        }
    }
}
