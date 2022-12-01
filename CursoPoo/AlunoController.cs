using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;


namespace CursoPoo
{
    public class AlunoController
    {
        public void CadastrarAluno()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var aluno = new Aluno("", 0, 0);

            Console.WriteLine("Digite o nome do aluno");
            aluno.NomeAluno = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno");
            aluno.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a matricula do aluno");
            aluno.Matricula = int.Parse(Console.ReadLine());

            aluno.CadastrarAluno();
        }

        public void ConsultarAluno()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //pegar dados de uma lista statica
            var lista = Aluno.Alunos;
            foreach (var qaluno in lista)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine(" Nome do aluno: " + qaluno.NomeAluno);
                Console.WriteLine(" Idade do aluno: " + qaluno.Idade);
                Console.WriteLine(" Matricula do aluno: " + qaluno.Matricula);
                Console.WriteLine("-------------------------------");
            }
        }
    }
}