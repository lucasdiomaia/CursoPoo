using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CursoPoo
{
    public class AlunoController
    {
        public void CadastrarAlunos(Aluno aluno, GerenciarAlunos gerenciarAlunos)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno: ");
            aluno.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da matricula: ");
            aluno.NumeroDaMatricula = int.Parse(Console.ReadLine());
            gerenciarAlunos.Alunos= new List<Aluno>();
            
            Console.WriteLine("Aluno cadastrado com sucesso!");
            
        }

        public void ConsultarAlunos(Aluno aluno,GerenciarAlunos gerenciarAlunos)
        {
            foreach (var qAluno in gerenciarAlunos.Alunos)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Nome: " + qAluno.Nome);
                Console.WriteLine("Idade: " + qAluno.Idade);
                Console.WriteLine("Numero da matricula: " + qAluno.NumeroDaMatricula);
                Console.WriteLine("Aluno cadastrado com sucesso!");
                Console.WriteLine("-------------------------");
            }
        }

        public void RemoverAluno(Aluno aluno, GerenciarAlunos gerenciarAlunos)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("lista dos Alunos cadastrados");
                    foreach (var qAluno in  gerenciarAlunos.Alunos)
                    {
                        Console.WriteLine("Nome: " + qAluno.Nome + ", Matricula: " + qAluno.NumeroDaMatricula);
                    }

                    Console.WriteLine("Desejá remover um aluno? (1-Sim/2-Não)");
                    var resposta = int.Parse(Console.ReadLine());
                    if (resposta == 1)
                    {
                        Console.WriteLine("Digite o numero da matricula do aluno(a) que deseja remover: ");
                        int numeroDaMatricula = int.Parse(Console.ReadLine());
                        var alunoRemover = gerenciarAlunos.Alunos.FirstOrDefault(x => x.NumeroDaMatricula == numeroDaMatricula);
                        if (alunoRemover != null)
                        {
                            gerenciarAlunos.Alunos.Remove(alunoRemover);
                            Console.WriteLine("Aluno removido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Aluno não encontrado!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Operação cancelada");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro ao remover aluno");
                }
            }
        }

        public void AtualizarAluno(Aluno aluno, GerenciarAlunos gerenciarAlunos)
        {
            Console.WriteLine("Digite o nome do aluno que deseja atualizar: ");
            string name = Console.ReadLine();
            foreach (var qAluno in gerenciarAlunos.Alunos)
            {
                if (qAluno.Nome == name)
                {
                    Console.WriteLine("Digite o nome do aluno:");
                    qAluno.Nome = Console.ReadLine();
                    Console.WriteLine("Digite a idade do Aluno:");
                    qAluno.Idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o numero da matricula:");
                    qAluno.NumeroDaMatricula = int.Parse(Console.ReadLine());
                    Console.WriteLine("Aluno atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado");
                }
            }
        }
    }
}