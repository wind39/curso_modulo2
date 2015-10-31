using System;

namespace CadastroEscola
{
    /// <summary>
    /// Classe Aluno.
    /// </summary>
    public class Aluno : Pessoa
    {
        /// <summary>
        /// Número de matrícula. Único para cada aluno.
        /// </summary>
        public int NumeroMatricula { get; set; }

        /// <summary>
        /// Período de admissão. Classe <see cref="Periodo"/>.
        /// </summary>
        public Periodo PeriodoAdmissao { get; set; }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="CadastroEscola.Aluno"/>.
        /// </summary>
        public Aluno()
        {
        }
    }
}

