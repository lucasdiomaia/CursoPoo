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

        public Aluno(string nome, int idade, int numeroDaMatricula)
        {
            _nome = nome;
            _idade = idade;
            _numeroDaMatricula = numeroDaMatricula;
        }

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
    }
}