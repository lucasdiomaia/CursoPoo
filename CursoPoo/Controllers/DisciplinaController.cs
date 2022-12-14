using System;

namespace CursoPoo
{
    public class DisciplinaController
    {
        Disciplina disciplina = new Disciplina("", 0, 0, "", 0, 0);

        public void CadastrarDisciplina()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite o nome da disciplina: ");
                disciplina.NomeDiciplina = Console.ReadLine();
                Console.WriteLine("Digite a carga horária da disciplina: (apenas números)");
                disciplina.CargaHoraria = int.Parse(Console.ReadLine());

                if (Curso.Cursos.Count == 0)
                    Console.WriteLine("Não há cursos cadastrados.");
                else
                {
                    Console.WriteLine("Escolha um curso para a disciplina: ");
                    Console.WriteLine("Cursos disponíveis:");
                    foreach (var item in Curso.Cursos)
                    {
                        Console.WriteLine(item.IdCurso + " - " + item.NomeCurso);
                    }

                    Console.WriteLine("Digite o código do curso: ");
                    disciplina.IdCurso = int.Parse(Console.ReadLine());
                    if (Curso.Cursos.Exists(x => x.IdCurso == disciplina.IdCurso))
                    {
                        Console.WriteLine("Deseja cadastar o curso? S/N");
                        string opcao = Console.ReadLine();
                        if (opcao.ToUpper() == "S")
                        {
                            disciplina.NomeCurso = Curso.Cursos.Find(x => x.IdCurso == disciplina.IdCurso).NomeCurso;
                            disciplina.Turno = Curso.Cursos.Find(x => x.IdCurso == disciplina.IdCurso).Turno;
                            disciplina.IdDisciplina = Disciplina.Disciplinas.Count + 1;
                            disciplina.CadastrarDisciplina();
                            Console.WriteLine("Disciplina cadastrada com sucesso.");
                        }
                        else
                            Console.WriteLine("Cadastro cancelado.");
                    }
                    else
                        Console.WriteLine("Curso não encontrado");
                }
            }
            catch (Exception erro)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao cadastrar disciplina: " + erro.Message);
            }
        }

        public void ConsultarDisciplina()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                while (true)
                {
                    Console.WriteLine("Disciplinas disponíveis.");

                    foreach (var item in Disciplina.Disciplinas)
                    {
                        Console.WriteLine(item.IdDisciplina + " - " + item.NomeDiciplina);
                    }

                    Console.WriteLine("Digite o código da disciplina para consultar: ");
                    disciplina.IdDisciplina = int.Parse(Console.ReadLine());

                    if (Disciplina.Disciplinas.Exists(x => x.IdDisciplina == disciplina.IdDisciplina))
                    {
                        disciplina = Disciplina.Disciplinas.Find(x => x.IdDisciplina == disciplina.IdDisciplina);
                        Console.WriteLine("Id da disciplina: " + disciplina.IdDisciplina);
                        Console.WriteLine("Nome da disciplina: " + disciplina.NomeDiciplina);
                        Console.WriteLine("Carga horária: " + disciplina.CargaHoraria);
                        Console.WriteLine("ID do curso: " + disciplina.IdCurso);
                        Console.WriteLine("Curso: " + disciplina.NomeCurso);
                        Console.WriteLine("Turno: " + disciplina.Turno);
                        Console.WriteLine("Deseja consultar outra disciplina? S/N");
                        string opcao = Console.ReadLine();
                        if (opcao.ToUpper() != "S")
                            break;
                    }
                    else
                    {
                        Console.WriteLine("Disciplina não encontrada.");
                        Console.WriteLine("Deseja consultar outra disciplina? S/N");
                        string opcao = Console.ReadLine();
                        if (opcao.ToUpper() != "S")
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao consultar curso:" + e.Message);
            }
        }


        public void RemoverDisciplina()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (Disciplina.Disciplinas.Count == 0)
                    Console.WriteLine("Não há disciplinas cadastradas.");
                else
                {
                    Console.WriteLine("Disciplina disponíveis");
                    foreach (var Disciplina in Disciplina.Disciplinas)
                    {
                        Console.WriteLine(Disciplina.IdDisciplina + " - " + Disciplina.NomeDiciplina);
                    }

                    Console.WriteLine("Digite o Id do disciplina que deseja remover");
                    disciplina.IdDisciplina = int.Parse(Console.ReadLine() ?? string.Empty);
                    if (Disciplina.Disciplinas.Exists(x => x.IdDisciplina != disciplina.IdDisciplina))
                    {
                        Console.WriteLine("Diciplina não encontrada");
                    }
                    else if (Aluno.Alunos.Exists(x => x.IdDisciplina == disciplina.IdDisciplina))
                    {
                        Console.WriteLine("Não é possível remover a disciplina, pois existem alunos cadastrados");
                        Console.WriteLine(
                            "Para remover a disciplina, primeiro remova os alunos cadastrados na diciplina.");
                    }
                    else
                    {
                        Console.WriteLine("Deseja remover a disciplina? S/N");
                        var opcao = Console.ReadLine();
                        if (opcao.ToUpper() == "S")
                        {
                            Disciplina.Disciplinas.Remove(
                                Disciplina.Disciplinas.Find(x => x.IdDisciplina == disciplina.IdDisciplina));
                            Console.WriteLine("Disciplina removido com sucesso");
                        }
                        else
                            Console.WriteLine("A disciplina não foi removido");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao remover disciplina: " + e.Message);
            }
        }
        
        
    }
}