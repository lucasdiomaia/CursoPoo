using System;
using System.Linq;
using CursoPoo.Model.Entities;
using CursoPoo.Utils;

namespace CursoPoo.Model
{
    public class Curso
    {
        public Curso(string nomeCurso, int turno, int idDisciplina)
        {
            _nomeCurso = nomeCurso;
            _turno = turno;
            _idDisciplina = idDisciplina;
        }

        //atributos
        private string _nomeCurso;
        private int _turno;
        private int _idCurso = CreateNewIdCurso();
        private int _idDisciplina;


        public string NomeCurso
        {
            get => _nomeCurso;
            set => _nomeCurso = value;
        }

        public int Turno
        {
            get => _turno;
            set => _turno = value;
        }

        public int IdCurso
        {
            get => _idCurso;
            set => _idCurso = value;
        }

        public int IdDisciplina
        {
            get => _idDisciplina;
            set => _idDisciplina = value;
        }

        //metodos

        public static int CreateNewIdCurso()
        {
            int NextIdCurso = CursoDB.ListaCurso.Max(x => x.IdCurso) + 1;
            return NextIdCurso;
        }


        public void CadastrarCurso()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                Console.WriteLine("Digite o nome do curso: ");
                NomeCurso = Console.ReadLine();
                Console.WriteLine("Digite o turno do curso: 1 - Manhã, 2 - Tarde, 3 - Noite");
                Turno = int.Parse(Console.ReadLine());
                if (Turno == (int)TurnoEnum.Manha || Turno == (int)TurnoEnum.Tarde || Turno == (int)TurnoEnum.Noite)
                {
                    Console.WriteLine("Nessesario cadastrar pelo menos uma disciplina no curso");
                    Console.WriteLine("Diciplinas disponiveis: ");
                    foreach (var disciplina in DisciplinaDB.ListaDisciplina)
                    {
                        Console.WriteLine("ID: " + disciplina.IdDisciplina + " - " + disciplina.NomeDiciplina);
                    }

                    if (DisciplinaDB.ListaDisciplina.Count == 0)
                    {
                        Console.WriteLine("Nao ha disciplinas cadastradas");
                    }
                    else
                    {
                        Console.WriteLine("Digite o ID da disciplina que deseja adicionar ao curso: ");
                        IdDisciplina = int.Parse(Console.ReadLine());

                        if (DisciplinaDB.ListaDisciplina.Exists(x =>
                                x.IdDisciplina == IdDisciplina))
                        {
                            CursoDB.ListaCurso.Add(new Curso(NomeCurso, Turno, IdDisciplina));
                            Console.WriteLine("Curso cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("O ID da disciplina digitado nao existe");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("O turno informado nao existe");
                }
            }

            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao cadastrar curso: " + exception.Message);
                throw;
            }
        }

        public void ConsultarCurso()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                Console.WriteLine("Cursos cadastrados: ");
                foreach (var curso in CursoDB.ListaCurso)
                {
                    Console.WriteLine("ID: " + curso.IdCurso + " - " + curso.NomeCurso + " - " + curso.Turno);
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao consultar cursos: " + exception.Message);
                throw;
            }
        }

        //remover curso verificando se a lista esta vazia e se o curso existe
        public void RemoverCurso()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                if (CursoDB.ListaCurso.Count == 0)
                {
                    Console.WriteLine("Nao ha cursos cadastrados");
                }
                else
                {
                    Console.WriteLine("Digite o ID do curso que deseja remover: ");
                    IdCurso = int.Parse(Console.ReadLine());
                    if (CursoDB.ListaCurso.Exists(x => x.IdCurso == IdCurso))
                    {
                        CursoDB.ListaCurso.RemoveAll(x => x.IdCurso == IdCurso);
                        Console.WriteLine("Curso removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("O ID do curso digitado nao existe");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao remover curso: " + exception.Message);
                throw;
            }
        }

        //alterar curso verificando se a lista esta vazia e se o curso existe
        public void AtualizarCurso()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                if (CursoDB.ListaCurso.Count == 0)
                {
                    Console.WriteLine("Nao ha cursos cadastrados");
                }
                else
                {
                    ConsultarCurso();

                    Console.WriteLine("Digite o ID do curso que deseja alterar: ");
                    IdCurso = int.Parse(Console.ReadLine());
                    if (CursoDB.ListaCurso.Exists(x => x.IdCurso == IdCurso))
                    {
                        Console.WriteLine("Digite o novo nome do curso: ");
                        NomeCurso = Console.ReadLine();
                        Console.WriteLine("Digite o novo turno do curso: 1 - Manhã, 2 - Tarde, 3 - Noite");
                        Turno = int.Parse(Console.ReadLine());
                        if (Turno == (int)TurnoEnum.Manha || Turno == (int)TurnoEnum.Tarde ||
                            Turno == (int)TurnoEnum.Noite)
                        {
                            CursoDB.ListaCurso.Find(x => x.IdCurso == IdCurso).NomeCurso = NomeCurso;
                            CursoDB.ListaCurso.Find(x => x.IdCurso == IdCurso).Turno = Turno;
                            Console.WriteLine("Curso alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("O turno informado nao existe");
                        }
                    }
                    else
                    {
                        Console.WriteLine("O ID do curso digitado nao existe");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao alterar curso: " + exception.Message);
                throw;
            }
        }
    }
}