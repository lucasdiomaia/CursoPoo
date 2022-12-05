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

        public Aluno(string nomeAluno, int idade, int matricula, string nomeDiciplina, int cargaHoraria,
            string nomeCurso, int turno)
            : base(nomeDiciplina: nomeDiciplina, cargaHoraria, nomeCurso, turno)
        {
            NomeDiciplina = nomeDiciplina;
            CargaHoraria = cargaHoraria;
            _nomeAluno = nomeAluno;
            _idade = idade;
            _matricula = matricula;
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

        public int Matricula
        {
            get => _matricula;
            set => _matricula = value;
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
            Alunos.Add(new Aluno(NomeAluno, Idade, Matricula, NomeDiciplina, CargaHoraria, NomeCurso, Turno));
        }
    }
}