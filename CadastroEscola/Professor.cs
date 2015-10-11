using System;

namespace CadastroEscola
{
    public class Professor : Pessoa
    {
        public int Codigo { get; set; }
        public System.Collections.Generic.List<Disciplina> DisciplinasLecionaveis;

        public Professor()
        {
        }
    }
}

