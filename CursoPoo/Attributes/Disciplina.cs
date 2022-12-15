using System.Collections.Generic;

namespace CursoPoo
{
    public class Disciplina
    {
        //atributos
        private string _nomeDiciplina;
        private int _cargaHoraria;
        private int _idDisciplina;

        private List<Aluno> _alunos = new List<Aluno>();
        private List<Disciplina> _disciplinas = new List<Disciplina>();


        public int IdDisciplina
        {
            get => _idDisciplina;
            set => _idDisciplina = value;
        }

        public string NomeDiciplina
        {
            get => _nomeDiciplina;
            set => _nomeDiciplina = value;
        }

        public int CargaHoraria
        {
            get => _cargaHoraria;
            set => _cargaHoraria = (int)value;
        }
        
        //metodos

        // public void CadastrarDisciplina()
        // {
        //     Disciplinas.Add(new Disciplina(NomeDiciplina, CargaHoraria, IdDisciplina, NomeCurso, Turno, IdCurso));
        // }
    }
}