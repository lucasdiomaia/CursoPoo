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
        
        private static List<Disciplina> _disciplinas = new List<Disciplina>();

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

        public List<Disciplina> Disciplinas
        {
            get => _disciplinas;
            set => _disciplinas = value;
        }

        //construtor
        
        public Curso(string nomeCurso, int turno, int idCurso)
        {
            _nomeCurso = nomeCurso;
            _turno = turno;
            _idCurso = idCurso;
        }

        //metodos
        public void CadastrarCurso()
        {
            
            
        }
    }
}