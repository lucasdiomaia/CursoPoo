using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class Curso
    {
        //atributos
        private string _nomeCurso;
        private int _turno;
        private int _idCurso = +1;


        private static List<Curso> _cursos = new List<Curso>();

        public Curso(string nomeCurso, int turno, int idCurso)
        {
            _nomeCurso = nomeCurso;
            _turno = turno;
            _idCurso = idCurso;
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


        public void CadastrarCurso()
        {
            Cursos.Add(new Curso(NomeCurso,Turno,IdCurso));
        }

        
    }
}