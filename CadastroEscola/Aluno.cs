using System;

namespace CadastroEscola
{
    public class Aluno : Pessoa
    {
        public int NumeroMatricula { get; set; }
        public Periodo PeriodoAdmissao { get; set; }

        public Aluno()
        {
        }
    }
}

