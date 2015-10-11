using System;

namespace CadastroEscola
{
    public class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Ementa { get; set; }
        public System.Collections.Generic.List<Disciplina> PreRequisitos;

        public Disciplina()
        {
        }
    }
}

