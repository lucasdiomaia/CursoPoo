using System.Collections.Generic;

namespace CursoPoo
{
    public class Disciplina
    {
        private List<Aluno> alunos = new List<Aluno>();
        private string _nomediciplina;
        private int _cargaHoraria;
        private int _nota;

        public List<Aluno> Alunos
        {
            get => alunos;
            set => alunos = value;
        }

        public string Nomediciplina
        {
            get => _nomediciplina;
            set => _nomediciplina = value;
        }

        public int CargaHoraria
        {
            get => _cargaHoraria;
            set => _cargaHoraria = value;
        }

        public int Nota
        {
            get => _nota;
            set => _nota = value;
        }

        public Disciplina(string nomediciplina, int cargaHoraria, int nota)
        {
            _nomediciplina = nomediciplina;
            _cargaHoraria = cargaHoraria;
            _nota = nota;
        }
    }
}