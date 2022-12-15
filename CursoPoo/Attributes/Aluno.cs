using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class Aluno 

    {
        //atributos
        private string _nomeAluno;
        private int _idade;
        private int _idAluno;
        
        private static List<Curso> _cursos = new List<Curso>();
        private static List<Disciplina> _disciplinas = new List<Disciplina>();

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

        //metodos

        // public void CadastrarAluno(Aluno aluno)
        // {
        //     Alunos.Add(new Aluno(NomeAluno, Idade, Cpf, IdAluno, NomeDiciplina, CargaHoraria, IdDisciplina, NomeCurso,
        //         Turno, IdCurso));
        // }
    }
}