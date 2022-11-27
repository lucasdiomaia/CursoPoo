using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoPoo
{
    public class Aluno
    {
        //atributos
        private string _nome;
        private int _idade;
        private int _numeroDaMatricula;
        private static List<Aluno> _alunos = new List<Aluno>();


        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public int Idade
        {
            get => _idade;
            set => _idade = value;
        }

        public int NumeroDaMatricula
        {
            get => _numeroDaMatricula;
            set => _numeroDaMatricula = value;
        }

        public static List<Aluno> Alunos
        {
            get => _alunos;
            set => _alunos = value;
        }
    }
}