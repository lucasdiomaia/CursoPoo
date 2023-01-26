using System;
using System.Linq;
using CursoPoo.Model.Entities;
using CursoPoo.Utils;

namespace CursoPoo.Model
{
    public class Curso
    {
        public Curso(string nomeCurso, int turno, int idDisciplina, int idCurso)
        {
            _nomeCurso = nomeCurso;
            _turno = turno;
            _idDisciplina = idDisciplina;
            _idCurso = idCurso;
        }

        //atributos
        private string _nomeCurso;
        private int _turno;
        private int _idCurso;
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

        public int CreateNewIdCurso()
        {
            if (0 == CursoDB.ListaCurso.Count)
            {
                return 1;
            }

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
                            CursoDB.ListaCurso.Add(new Curso(NomeCurso, Turno, IdDisciplina, CreateNewIdCurso()));
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
                    Console.WriteLine("-----------------Curso-----------------");
                    Console.WriteLine("Id: " + curso.IdCurso);
                    Console.WriteLine("Nome : " + curso.NomeCurso);
                    Console.WriteLine("Turno : " + curso.Turno);
                    Console.WriteLine("Id da disciplina: " + curso.IdDisciplina);
                    Console.WriteLine("Nome da disciplina: " + DisciplinaDB.ListaDisciplina
                        .Find(x => x.IdDisciplina == curso.IdDisciplina).NomeDiciplina);
                    Console.WriteLine("---------------------------------------");
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao consultar cursos: " + exception.Message);
                
            }
        }

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
                    Console.WriteLine("Cursos cadastrados: ");
                    ConsultarCurso();

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
                
            }
        }

        public void AtualizarCurso()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                if (CursoDB.ListaCurso.Count == 0)
                {
                    Console.WriteLine("Nao ha cursos cadastrados");
                    return;
                }

                if (DisciplinaDB.ListaDisciplina.Count == 0)
                {
                    Console.WriteLine("Nao ha disciplinas cadastradas");
                    return;
                }

                Console.WriteLine("Cursos cadastrados: ");
                ConsultarCurso();

                Console.WriteLine("Digite o ID do curso que deseja alterar: ");
                IdCurso = int.Parse(Console.ReadLine());
                if (CursoDB.ListaCurso.Exists(x => x.IdCurso == IdCurso))
                {
                    Console.WriteLine("Digite o novo nome do curso: ");
                    NomeCurso = Console.ReadLine();
                    Console.WriteLine("Digite o novo turno do curso: 1 - Manhã, 2 - Tarde, 3 - Noite");
                    Turno = int.Parse(Console.ReadLine());
                    if (Turno != (int)TurnoEnum.Manha || Turno != (int)TurnoEnum.Tarde ||
                        Turno != (int)TurnoEnum.Noite)
                    {
                        Console.WriteLine("Turno invalido");
                        return;
                    }

                    Console.WriteLine("Disciplinas cadastradas: ");
                    foreach (var disciplina in DisciplinaDB.ListaDisciplina)
                    {
                        Console.WriteLine("ID da disciplina: " + disciplina.IdDisciplina);
                        Console.WriteLine("Nome da disciplina: " + disciplina.NomeDiciplina);
                    }

                    Console.WriteLine("Digite o ID da disciplina que deseja adicionar para o curso: ");
                    IdDisciplina = int.Parse(Console.ReadLine());
                    if (DisciplinaDB.ListaDisciplina.Exists(x => x.IdDisciplina == IdDisciplina))
                    {
                        CursoDB.ListaCurso.Find(x => x.IdCurso == IdCurso).NomeCurso = NomeCurso;
                        CursoDB.ListaCurso.Find(x => x.IdCurso == IdCurso).Turno = Turno;
                        CursoDB.ListaCurso.Find(x => x.IdCurso == IdCurso).IdDisciplina = IdDisciplina;
                        Console.WriteLine("Curso alterado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("O ID da disciplina digitado nao existe");
                    }
                }
                else
                {
                    Console.WriteLine("O ID do curso digitado nao existe");
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao alterar curso: " + exception.Message);
                
            }
        }
    }
}