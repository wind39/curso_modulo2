using System;

namespace Lista1Exercicio05
{
    public class AlbumDeFotos
    {
        public int numeroTotalDePaginas { get; set; }

        public int numeroTotalDeFotos
        {
            get
            {
                return this.numeroTotalDePaginas * 2;
            }
        }

        private int _numeroDeFotos;
        public int numeroDeFotos
        {
            get
            {
                return this._numeroDeFotos;
            }
            set
            {
                if (value > this.numeroTotalDeFotos)
                    Console.WriteLine("ERRO: O número de fotos não deve exceder {0}.", this.numeroTotalDeFotos);
                else
                    this._numeroDeFotos = value;
            }
        }

        public AlbumDeFotos(int p_numeroTotalDePaginas)
        {
            this.numeroTotalDePaginas = p_numeroTotalDePaginas;
        }
    }
}

