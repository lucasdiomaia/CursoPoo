using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class Aluno
    {
        public Aluno(string nomeAluno, int idade, int matricula)
        {
            NomeAluno = nomeAluno;
            Idade = idade;
            Matricula = matricula;
        }


        public string NomeAluno { get; set; }

        public int Idade { get; set; }
        public int Matricula { get; set; }
        public static List<Aluno> Alunos = new List<Aluno>();


        public void CadastrarAluno()

        {
            Alunos.Add(new Aluno(NomeAluno, Idade, Matricula));
        }

        public void removerAluno()
        {
            Alunos.Remove(new Aluno(NomeAluno, Idade, Matricula));
        }

        public List<Aluno> ListarAlunos()
        {
            var lista = Alunos;
            return Alunos;
        }
    }
}