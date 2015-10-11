using System;
using System.Collections.Generic;

namespace EntradaDeDados
{
    public class Vetores
    {
        private Variaveis variaveis;

        public Vetores()
        {
            this.variaveis = new Variaveis();
        }

        public int[] LeVetorEstaticoInt()
        {
            int[] vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new int[n];

            for (int i = 0; i < n; i++)
                vetor[i] = this.variaveis.LeInt("Digite o elemento " + i.ToString() + ": ");

            return vetor;
        }

        public double[] LeVetorEstaticoDouble()
        {
            double[] vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new double[n];

            for (int i = 0; i < n; i++)
                vetor[i] = this.variaveis.LeDouble("Digite o elemento " + i.ToString() + ": ");

            return vetor;
        }

        public char[] LeVetorEstaticoChar()
        {
            char[] vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new char[n];

            for (int i = 0; i < n; i++)
                vetor[i] = this.variaveis.LeChar("Digite o elemento " + i.ToString() + ": ");

            return vetor;
        }

        public string[] LeVetorEstaticoString()
        {
            string[] vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new string[n];

            for (int i = 0; i < n; i++)
                vetor[i] = this.variaveis.LeString("Digite o elemento " + i.ToString() + ": ");

            return vetor;
        }

        public DateTime[] LeVetorEstaticoDateTime()
        {
            DateTime[] vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new DateTime[n];

            for (int i = 0; i < n; i++)
                vetor[i] = this.variaveis.LeDateTime("Digite o elemento " + i.ToString() + ": ");

            return vetor;
        }

        public List<int> LeVetorDinamicoInt()
        {
            List<int> vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new List<int>();

            for (int i = 0; i < n; i++)
                vetor.Add(this.variaveis.LeInt("Digite o elemento " + i.ToString() + ": "));

            return vetor;
        }

        public List<double> LeVetorDinamicoDouble()
        {
            List<double> vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new List<double>();

            for (int i = 0; i < n; i++)
                vetor.Add(this.variaveis.LeDouble("Digite o elemento " + i.ToString() + ": "));

            return vetor;
        }

        public List<char> LeVetorDinamicoChar()
        {
            List<char> vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new List<char>();

            for (int i = 0; i < n; i++)
                vetor.Add(this.variaveis.LeChar("Digite o elemento " + i.ToString() + ": "));

            return vetor;
        }

        public List<string> LeVetorDinamicoString()
        {
            List<string> vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new List<string>();

            for (int i = 0; i < n; i++)
                vetor.Add(this.variaveis.LeString("Digite o elemento " + i.ToString() + ": "));

            return vetor;
        }

        public List<DateTime> LeVetorDinamicoDateTime()
        {
            List<DateTime> vetor;
            int n;

            n = this.variaveis.LeInt("Digite o número de elementos do vetor: ");

            vetor = new List<DateTime>();

            for (int i = 0; i < n; i++)
                vetor.Add(this.variaveis.LeDateTime("Digite o elemento " + i.ToString() + ": "));

            return vetor;
        }
    }
}
