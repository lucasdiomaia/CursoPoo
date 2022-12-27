using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class Aluno

    {
        //atributos
        private string _nomeAluno;
        private int _idade;
        private int _cpf;
        private int _idAluno;
        private static List<Curso> _cursos = new List<Curso>();
        
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

        public int Cpf
        {
            get => _cpf;
            set => _cpf = value;
        }

        public int IdAluno
        {
            get => _idAluno;
            set => _idAluno = value;
        }

        public static  List<Curso> Cursos
        {
            get => _cursos;
            set => _cursos = value;
        }
        
        //construtor
        public Aluno(string nomeAluno, int idade, int cpf, int idAluno)
        {
            _nomeAluno = nomeAluno;
            _idade = idade;
            _cpf = cpf;
            _idAluno = idAluno;
        }
        
        //metodos

        public void CadastrarAluno()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                Console.WriteLine();

                Console.WriteLine("Digite o nome do aluno");
                NomeAluno = Console.ReadLine();
                Console.WriteLine("Digite a idade do aluno");
                Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o cpf do aluno");
                Cpf = int.Parse(Console.ReadLine());

                Console.WriteLine("Cursos disponiveis:");
                foreach (var curso in Cursos)
                {
                    Console.WriteLine(curso.IdCurso + " - " + curso.NomeCurso);
                }
                
                
               
            }
            catch (Exception erro)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao cadastrar aluno: " + erro.Message);
            }
        }
        
        
        
    }
}