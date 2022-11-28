using System.Collections.Generic;

namespace CursoPoo
{
    public class Curso
    {
        List<Disciplina> _disciplinas = new List<Disciplina>();
        private string _nomeDoCurso;
        private string _turno;

        public Curso(string nomeDoCurso, string turno)
        {
            _nomeDoCurso = nomeDoCurso;
            _turno = turno;
        }

        public List<Disciplina> Disciplinas
        {
            get => _disciplinas;
            set => _disciplinas = value;
        }

        public string NomeDoCurso
        {
            get => _nomeDoCurso;
            set => _nomeDoCurso = value;
        }

        public string Turno
        {
            get => _turno;
            set => _turno = value;
        }
    }
}