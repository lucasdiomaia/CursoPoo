using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;


namespace CursoPoo
{
    public class AlunoController
    {
        public void CadastrarAluno()
        {
            Aluno aluno = new Aluno(String.Empty, 0, 0, string.Empty, 0, String.Empty, 0);

            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                Console.WriteLine("Digite o nome do aluno");
                aluno.NomeAluno = Console.ReadLine();
                Console.WriteLine("Digite a idade do aluno");
                aluno.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("digite a matricula do aluno");
                aluno.Matricula = int.Parse(Console.ReadLine());
                //verificar se exeste a diciplina no banco de dados
                // do
                // {
                //     Console.WriteLine("Digite o turno do aluno");
                //     aluno.Turno = int.Parse(Console.ReadLine());
                // } while (aluno.Turno != 1 && aluno.Turno != 2 && aluno.Turno != 3);


                //adicionar um switch case para as cargas horarias

                aluno.CadastrarAluno(aluno);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                CadastrarAluno();
            }
        }


        public void ConsultarAluno()
        {
            Console.WriteLine("digite qual opção deseja consultar");
            Console.WriteLine("1 - Consultar todos os alunos");
            Console.WriteLine("2 - Consultar por nome");
            Console.WriteLine("3 - Consultar por disciplina");

            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Alunos cadastrados");
                    foreach (var qAluno in Aluno.Alunos)
                    {
                        Console.WriteLine("Nome: " + qAluno.NomeAluno);

                        Console.WriteLine("Curso: " + qAluno.NomeCurso);
                        Console.WriteLine("Turno: " + qAluno.Turno);
                        Console.WriteLine("Disciplina: " + qAluno.NomeDiciplina);
                        Console.WriteLine("Carga Horaria: " + qAluno.CargaHoraria);
                    }

                    break;
                case 2:
                    Console.WriteLine("Digite o nome do aluno");
                    var buscarAluno = Console.ReadLine();
                    var alunoDefinido =
                        Aluno.Alunos.FirstOrDefault(x => x.NomeAluno.ToUpper() == buscarAluno.ToUpper());
                    if (alunoDefinido == null)
                    {
                        Console.WriteLine("Aluno não encontrado");
                    }
                    else
                    {
                        Console.WriteLine(alunoDefinido);
                    }

                    break;
                case 3:
                    Console.WriteLine("Digite a disciplina");
                    var buscarDisciplina = Console.ReadLine();
                    var disciplinaDefinida =
                        Aluno.Alunos.FirstOrDefault(x => x.NomeDiciplina.ToUpper() == buscarDisciplina.ToUpper());
                    if (disciplinaDefinida == null)
                    {
                        Console.WriteLine("Disciplina não encontrada");
                    }
                    else
                    {
                        Console.WriteLine(disciplinaDefinida);
                    }

                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }

        public void EditarAluno()
        {
            Console.WriteLine("Digite o nome do aluno");
            var buscarAluno = Console.ReadLine();
            var alunoDefinido =
                Aluno.Alunos.FirstOrDefault(x => x.NomeAluno.ToUpper() == buscarAluno.ToUpper());
            if (alunoDefinido == null)
            {
                Console.WriteLine("Aluno não encontrado");
            }
            else
            {
                Console.WriteLine("Digite o novo nome do aluno");
                alunoDefinido.NomeAluno = Console.ReadLine();
                Console.WriteLine("Digite a nova idade do aluno");
                alunoDefinido.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova matricula do aluno");
                alunoDefinido.Matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo curso do aluno");
                alunoDefinido.NomeCurso = Console.ReadLine();
                Console.WriteLine("Digite o novo turno do aluno");
                alunoDefinido.Turno = int.Parse(Console.ReadLine());
            }
        }

        public void ExcluirAlunoPorMatricula()
        {
            Console.WriteLine("Digite a matricula do aluno");
            var buscarAluno = int.Parse(Console.ReadLine());
            var alunoDefinido =
                Aluno.Alunos.FirstOrDefault(x => x.Matricula == buscarAluno);
            if (alunoDefinido == null)
            {
                Console.WriteLine("Aluno não encontrado");
            }
            else
            {
                Aluno.Alunos.Remove(alunoDefinido);
            }
        }
    }
}