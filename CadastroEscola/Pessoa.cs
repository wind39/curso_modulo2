using System;

namespace CadastroEscola
{
    public class Pessoa
    {
        public string NomeCompleto { get; set; }
        public char Sexo { get; set; }
        public string DocumentoIdentificacao { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {
        }
    }
}

