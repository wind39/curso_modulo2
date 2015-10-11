using System;
using System.Collections.Generic;
using EntradaDeDados;

namespace Lista2Exercicio10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Variaveis variaveis;
            int i;
            double d;
            char c;
            string s;
            DateTime t;
            Vetores vetores;
            int[] vei;
            double[] ved;
            char[] vec;
            string[] ves;
            DateTime[] vet;
            List<int> vdi;
            List<double> vdd;
            List<char> vdc;
            List<string> vds;
            List<DateTime> vdt;

            variaveis = new Variaveis();
            vetores = new Vetores();

            Console.WriteLine("Exemplo de uso da biblioteca EntradaDeDados para variáveis:");
            Console.WriteLine();
            i = variaveis.LeInt();
            Console.WriteLine();
            d = variaveis.LeDouble();
            Console.WriteLine();
            c = variaveis.LeChar();
            Console.WriteLine();
            s = variaveis.LeString();
            Console.WriteLine();
            t = variaveis.LeDateTime();
            Console.WriteLine();

            Console.WriteLine("Exemplo de uso da biblioteca EntradaDeDados para vetores estáticos:");
            Console.WriteLine();
            Console.WriteLine("Vetor de int: ");
            vei = vetores.LeVetorEstaticoInt();
            Console.WriteLine();
            Console.WriteLine("Vetor de double: ");
            ved = vetores.LeVetorEstaticoDouble();
            Console.WriteLine();
            Console.WriteLine("Vetor de char: ");
            vec = vetores.LeVetorEstaticoChar();
            Console.WriteLine();
            Console.WriteLine("Vetor de string: ");
            ves = vetores.LeVetorEstaticoString();
            Console.WriteLine();
            Console.WriteLine("Vetor de DateTime: ");
            vet = vetores.LeVetorEstaticoDateTime();
            Console.WriteLine();

            Console.WriteLine("Exemplo de uso da biblioteca EntradaDeDados para vetores dinâmicos:");
            Console.WriteLine();
            Console.WriteLine("Vetor de int: ");
            vdi = vetores.LeVetorDinamicoInt();
            Console.WriteLine();
            Console.WriteLine("Vetor de double: ");
            vdd = vetores.LeVetorDinamicoDouble();
            Console.WriteLine();
            Console.WriteLine("Vetor de char: ");
            vdc = vetores.LeVetorDinamicoChar();
            Console.WriteLine();
            Console.WriteLine("Vetor de string: ");
            vds = vetores.LeVetorDinamicoString();
            Console.WriteLine();
            Console.WriteLine("Vetor de DateTime: ");
            vdt = vetores.LeVetorDinamicoDateTime();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
