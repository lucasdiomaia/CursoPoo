using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class Curso
    {
        //atributos
        private string _nomeCurso;
        private int _turno;
        private int _idCurso;

        private static List<Aluno> Alunos = new List<Aluno>();
        private static List<Disciplina> Disciplinas = new List<Disciplina>();


        public string NomeCurso
        {
            get => _nomeCurso;
            set => _nomeCurso = value;
        }

        public int Turno
        {
            get => _turno;
            set => _turno = value;
        }

        public int IdCurso
        {
            get => _idCurso;
            set => _idCurso = value;
        }

        public static List<Aluno> Alunos1
        {
            get => Alunos;
            set => Alunos = value;
        }

        public static List<Disciplina> Disciplinas1
        {
            get => Disciplinas;
            set => Disciplinas = value;
        }

        public Curso(string nomeCurso, int turno, int idCurso, List<Disciplina> disciplinas, List<Aluno> alunos)
        {
            NomeCurso = nomeCurso;
            Turno = turno;
            IdCurso = idCurso;
            Disciplinas = disciplinas;
            Alunos = alunos;
        }


        public void CadastrarCurso()
        {
            Console.WriteLine("Digite o nome do curso: ");
            NomeCurso = Console.ReadLine();
            Console.WriteLine("Digite o turno do curso: ");
            Turno = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o id do curso: ");
            IdCurso = int.Parse(Console.ReadLine());
            
            Curso curso = new Curso(NomeCurso, Turno, IdCurso, Disciplinas, Alunos);
            
            
        }
    }
}