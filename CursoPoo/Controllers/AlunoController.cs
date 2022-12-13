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
        Aluno aluno = new Aluno(String.Empty, 0, 0, 0, string.Empty, 0, 0, String.Empty, 0, 0);

        public void CadastrarAluno()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                Console.WriteLine();

                Console.WriteLine("Digite o nome do aluno");
                aluno.NomeAluno = Console.ReadLine();
                Console.WriteLine("Digite a idade do aluno");
                aluno.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o cpf do aluno");
                aluno.Cpf = int.Parse(Console.ReadLine());

                Console.WriteLine("Cursos disponiveis:");
                foreach (var curso in Curso.Cursos)
                {
                    Console.WriteLine(curso.IdCurso + " - " + curso.NomeCurso);
                }

                Console.WriteLine("Digite o codigo do curso que deseja se matricular");
                aluno.IdCurso = Int32.Parse(Console.ReadLine());
                if (Curso.Cursos.Exists(x => x.IdCurso == aluno.IdCurso))
                {
                    aluno.NomeCurso = Curso.Cursos.Find(x => x.IdCurso == aluno.IdCurso).NomeCurso;
                    aluno.Turno = Curso.Cursos.Find(x => x.IdCurso == aluno.IdCurso).Turno;

                    Console.WriteLine("Disciplinas disponiveis para o curso " + aluno.NomeCurso + ":");
                    foreach (var disciplina in Disciplina.Disciplinas.FindAll(x => x.IdCurso == aluno.IdCurso))
                    {
                        Console.WriteLine(disciplina.IdDisciplina + " - " + disciplina.NomeDiciplina);
                    }

                    Console.WriteLine("Digite o codigo da disciplinas disponiveis que deseja se matricular");
                    aluno.IdDisciplina = Int32.Parse(Console.ReadLine());
                    if (Disciplina.Disciplinas.Exists(x =>
                            x.IdDisciplina == aluno.IdDisciplina && x.IdCurso == aluno.IdCurso))
                    {
                        aluno.NomeDiciplina =
                            Disciplina.Disciplinas.Find(x => x.IdCurso == aluno.IdCurso).NomeDiciplina;
                        aluno.CargaHoraria = Disciplina.Disciplinas.Find(x => x.IdCurso == aluno.IdCurso).CargaHoraria;
                        Console.WriteLine("Deseja cadastrar esse aluno? Digite: S ou N");
                        var confirmacao = Console.ReadLine();
                        if (confirmacao.ToUpper() == "S")
                        {
                            aluno.CadastrarAluno(aluno);
                            Console.WriteLine("Aluno cadastrado com sucesso");
                        }
                        else
                            Console.WriteLine("Cadastro cancelado");
                    }
                    else
                        Console.WriteLine("Disciplina não encontrada");
                }
                else
                    Console.WriteLine("Curso não encontrado");
            }
            catch (Exception e)
            {
                Console.WriteLine("erro ao cadastrar aluno tem novamente!");

                CadastrarAluno();
            }
        }
    }
}