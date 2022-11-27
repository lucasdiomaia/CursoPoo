using System;

namespace CursoPoo
{
    public class AlunoController
    {
        public void CadastrarAlunos(Aluno aluno)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno: ");
            aluno.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da matricula: ");
            aluno.NumeroDaMatricula = int.Parse(Console.ReadLine());
            Aluno.Alunos.Add(aluno);
            //return Aluno.Alunos;
        }

        public void ConsultarAlunos(Aluno aluno)
        {
            foreach (var qAluno in Aluno.Alunos)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Nome: " + qAluno.Nome);
                Console.WriteLine("Idade: " + qAluno.Idade);
                Console.WriteLine("Numero da matricula: " + qAluno.NumeroDaMatricula);
                Console.WriteLine("-------------------------");
            }
        }
    }
}