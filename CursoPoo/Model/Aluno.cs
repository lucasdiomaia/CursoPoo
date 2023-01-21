using System;
using System.Linq;
using System.Linq.Expressions;
using CursoPoo.Model.Entities;

namespace CursoPoo.Model
{
    public class Aluno
    {
        public Aluno(string nomeAluno, int idade, int cpf, int idCurso)
        {
            _nomeAluno = nomeAluno;
            _idade = idade;
            _cpf = cpf;
            _idCurso = idCurso;
            _idAluno = CreateNewIdAluno();
        }

        //atributos
        private string _nomeAluno;
        private int _idade;
        private int _cpf;
        private int _idCurso;
        private int _idAluno;


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

        public int IdCurso
        {
            get => _idCurso;
            set => _idCurso = value;
        }

        //metodos

        public int CreateNewIdAluno()
        {
            if (AlunoDB.ListaAlunos.Count == 0)
            {
                return 1;
            }

            int NextIdAluno = AlunoDB.ListaAlunos.Max(x => x.IdAluno) + 1;
            return NextIdAluno;
        }

        public void CadastrarAluno()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            try
            {
                Console.WriteLine("Digite o nome do aluno");
                NomeAluno = Console.ReadLine();
                Console.WriteLine("Digite a idade do aluno");
                Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o cpf do aluno");
                Cpf = int.Parse(Console.ReadLine());

                if (0 == CursoDB.ListaCurso.Count)
                {
                    Console.WriteLine("Nenhum curso cadastrado");
                    Console.WriteLine("Antes de cadastrar um aluno, cadastre um curso");
                    return;
                }

                Console.WriteLine("Cursos disponiveis:");

                foreach (var curso in CursoDB.ListaCurso)

                    Console.WriteLine(curso.IdCurso + " - " + curso.NomeCurso);


                Console.WriteLine("Digite o id do curso que deseja se matricular");
                IdCurso = int.Parse(Console.ReadLine());


                if (CursoDB.ListaCurso.Exists(x => x.IdCurso == IdCurso))
                {
                    AlunoDB.ListaAlunos.Add(new Aluno(NomeAluno, Idade, Cpf, IdCurso));
                    Console.WriteLine("Aluno cadastrado com sucesso");
                }
                else
                    Console.WriteLine("Curso não encontrado");
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao cadastrar aluno: " + exception.Message);
            }
        }

        public void ConsultarAluno()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            try
            {
                if (0 == AlunoDB.ListaAlunos.Count)
                {
                    Console.WriteLine("Nenhum aluno cadastrado");
                    return;
                }

                foreach (var aluno in AlunoDB.ListaAlunos)
                {
                    Console.WriteLine("Id do aluno: " + aluno.IdAluno);
                    Console.WriteLine("Nome do aluno: " + aluno.NomeAluno);
                    Console.WriteLine("Idade do aluno: " + aluno.Idade);
                    Console.WriteLine("Cpf do aluno: " + aluno.Cpf);
                    Console.WriteLine("Id do curso: " + aluno.IdCurso);
                    Console.WriteLine("Nome do curso: " +
                                      CursoDB.ListaCurso.Find(x => x.IdCurso == aluno.IdCurso).NomeCurso);
                    Console.WriteLine("------------------------------------------------");
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao consultar alunos" + exception.Message);
            }
        }

        public void RemoverAluno()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            try
            {
                Console.WriteLine("Alunos cadastrados:");
                if (0 == AlunoDB.ListaAlunos.Count)
                {
                    Console.WriteLine("Nenhum aluno cadastrado");
                    Console.WriteLine("Nessesario ter um aluno cadastrado para remover");
                    return;
                }

                ConsultarAluno();
                Console.WriteLine("Digite o id do aluno que deseja remover");
                IdAluno = int.Parse(Console.ReadLine());
                if (AlunoDB.ListaAlunos.Exists(x => x.IdAluno == IdAluno))
                {
                    AlunoDB.ListaAlunos.Remove(AlunoDB.ListaAlunos.Find(x => x.IdAluno == IdAluno));
                    Console.WriteLine("Aluno removido com sucesso");
                }
                else
                    Console.WriteLine("Aluno não encontrado");
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao remover aluno" + exception.Message);
            }
        }

        public void AtualizarAluno()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            try
            {
                Console.WriteLine("Alunos cadastrados:");
                if (0 == AlunoDB.ListaAlunos.Count)
                {
                    Console.WriteLine("Nenhum aluno cadastrado");
                    Console.WriteLine("Nessesario ter um aluno cadastrado para atualizar");
                    return;
                }

                ConsultarAluno();
                Console.WriteLine("Digite o id do aluno que deseja atualizar");
                IdAluno = int.Parse(Console.ReadLine());
                if (AlunoDB.ListaAlunos.Exists(x => x.IdAluno == IdAluno))
                {
                    Console.WriteLine("Digite o nome do aluno");
                    NomeAluno = Console.ReadLine();
                    Console.WriteLine("Digite a idade do aluno");
                    Idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o cpf do aluno");
                    Cpf = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cursos disponiveis:");

                    foreach (var curso in CursoDB.ListaCurso)
                        Console.WriteLine(curso.IdCurso + " - " + curso.NomeCurso);

                    Console.WriteLine("Digite o id do curso que deseja se matricular");
                    IdCurso = int.Parse(Console.ReadLine());
                    if (CursoDB.ListaCurso.Exists(x => x.IdCurso == IdCurso))
                    {
                        AlunoDB.ListaAlunos.Find(x => x.IdAluno == IdAluno).NomeAluno = NomeAluno;
                        AlunoDB.ListaAlunos.Find(x => x.IdAluno == IdAluno).Idade = Idade;
                        AlunoDB.ListaAlunos.Find(x => x.IdAluno == IdAluno).Cpf = Cpf;
                        AlunoDB.ListaAlunos.Find(x => x.IdAluno == IdAluno).IdCurso = IdCurso;
                        Console.WriteLine("Aluno atualizado com sucesso");
                    }
                    else
                        Console.WriteLine("Curso não encontrado");
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao atualizar aluno" + exception.Message);
            }
        }
    }
}