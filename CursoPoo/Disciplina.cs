using System.Collections.Generic;

namespace CursoPoo
{
    public class Disciplina : Curso
    {
        //atributos
        private string _nomeDiciplina;
        private int _cargaHoraria;
        private int _idDisciplina;


        private static List<Disciplina> _disciplinas = new List<Disciplina>();

        public Disciplina(string nomeDiciplina, int cargaHoraria, string nomeCurso, int turno) : base(nomeCurso, turno)
        {
            _nomeDiciplina = nomeDiciplina;
            _cargaHoraria = (int)cargaHoraria;
            _idDisciplina = _disciplinas.Count + 1;
        }

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

        public static List<Disciplina> Disciplinas
        {
            get => _disciplinas;
            set => _disciplinas = value;
        }

        //metodos

        public void CadastrarDisciplina()
        {
            Disciplinas.Add(new Disciplina(NomeDiciplina, CargaHoraria, NomeCurso, Turno));
        }


        public void EditarDisciplina(string nomeDisciplina, string novoNomeDisciplina, int novaCargaHoraria)
        {
            Disciplinas.Find(x => x.NomeDiciplina == nomeDisciplina).NomeDiciplina = novoNomeDisciplina;
            Disciplinas.Find(x => x.NomeDiciplina == nomeDisciplina).CargaHoraria = novaCargaHoraria;
        }

        public void RemoverDisciplina(string nomeDisciplina)
        {
            Disciplinas.RemoveAll(x => x.NomeDiciplina == nomeDisciplina);
        }
    }
}