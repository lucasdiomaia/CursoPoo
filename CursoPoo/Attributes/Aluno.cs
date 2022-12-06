using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class Aluno : Disciplina

    {
        //atributos
        private string _nomeAluno;
        private int _idade;
        private int _matricula;
        private int _idAluno;


        private static List<Aluno> _alunos = new List<Aluno>();

        public Aluno(string nomeAluno, int idade,int idAluno,string nomeDiciplina, int cargaHoraria,int idDisciplina,
            string nomeCurso, int turno, int idCurso )
            : base(nomeDiciplina, cargaHoraria,idDisciplina, nomeCurso, turno, idCurso )
        {
            NomeDiciplina = nomeDiciplina;
            CargaHoraria = cargaHoraria;
            _nomeAluno = nomeAluno;
            _idade = idade;
            
            _idAluno = _alunos.Count + 1;
        }
        //visibilidade


        public string NomeAluno
        {
            get => _nomeAluno;
            set => _nomeAluno = value;
        }

        public int Idade
        {
            get => _idade;
            set => _idade = value;
        }

        public int IdAluno
        {
            get => _idAluno;
            set => _idAluno = value;
        }

        public static List<Aluno> Alunos
        {
            get => _alunos;
            set => _alunos = value;
        }

        //metodos

        public void CadastrarAluno(Aluno aluno)
        {
            Alunos.Add(new Aluno(NomeAluno, Idade, IdAluno, NomeDiciplina, CargaHoraria,IdDisciplina, NomeCurso, Turno, IdCurso));
        }
    }
}