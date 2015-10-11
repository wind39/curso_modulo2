using System;

namespace CadastroEscola
{
    public class Turma
    {
        public int Codigo { get; set; }
        public Periodo PeriodoTurma { get; set; }
        public Professor ProfessorTurma { get; set; }
        public Disciplina DisciplinaTurma { get; set; }
        public Horario HorarioTurma { get; set; }

        public Turma()
        {
        }
    }
}

