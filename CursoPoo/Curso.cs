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


        private static List<Curso> _cursos = new List<Curso>();

        public Curso(string nomeCurso, int turno)
        {
            _nomeCurso = nomeCurso;
            _turno = turno;
            _idCurso = _cursos.Count + 1;
        }

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

        public static List<Curso> Cursos
        {
            get => _cursos;
            set => _cursos = value;
        }


        public static void CadastrarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

        public void ListarCursos()
        {
            foreach (var curso in Cursos)
            {
                Console.WriteLine($"Nome do curso: {curso.NomeCurso} - Turno: {curso.Turno}");
            }
        }
    }
}