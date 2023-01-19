﻿using System;
using System.Linq;
using CursoPoo.Model.Entities;

namespace CursoPoo.Model
{
    public class Disciplina
    {
        public Disciplina(string nomeDiciplina, int cargaHoraria)
        {
            _nomeDiciplina = nomeDiciplina;
            _cargaHoraria = cargaHoraria;
        }

        //atributos
        private string _nomeDiciplina;
        private int _cargaHoraria;
        private int _idDisciplina = CreateNewDisciplina();

        public int IdDisciplina
        {
            get => _idDisciplina;
            set => _idDisciplina = value;
        }

        public string NomeDiciplina
        {
            get => _nomeDiciplina;
            set => _nomeDiciplina = value;
        }

        public int CargaHoraria
        {
            get => _cargaHoraria;
            set => _cargaHoraria = value;
        }

        //metodos

        public static int CreateNewDisciplina()
        {
            int NextIdDiciplina = DisciplinaDB.ListaDisciplina.Max(x => x.IdDisciplina) + 1;
            return NextIdDiciplina;
        }

        public void CadastrarDisciplina()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            try
            {
                while (true)
                {
                    Console.WriteLine("Digite o nome da disciplina: ");
                    NomeDiciplina = Console.ReadLine();
                    Console.WriteLine("Digite a carga horaria da disciplina: ");
                    CargaHoraria = int.Parse(Console.ReadLine());

                    DisciplinaDB.ListaDisciplina.Add(new Disciplina(NomeDiciplina, CargaHoraria));
                    Console.WriteLine("Disciplina cadastrada com sucesso!");

                    Console.WriteLine("Deseja cadastrar mais uma disciplina? (S/N)");
                    string opcao = Console.ReadLine();
                    if ("S" != opcao.ToUpper())
                    {
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao cadastrar disciplina: " + exception.Message);
                throw;
            }
        }

        public void ConsultarDisciplina()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            try
            {
                if (0 == DisciplinaDB.ListaDisciplina.Count)
                {
                    Console.WriteLine("Nenhuma disciplina cadastrada!");
                    Console.WriteLine("Para consultar as disciplinas, cadastre ao menos uma disciplina!");
                    return;
                }

                Console.WriteLine("Disciplinas cadastradas: ");
                foreach (var disciplina in DisciplinaDB.ListaDisciplina)
                {
                    Console.WriteLine("Id: " + disciplina.IdDisciplina);
                    Console.WriteLine("Nome: " + disciplina.NomeDiciplina);
                    Console.WriteLine("Carga Horaria: " + disciplina.CargaHoraria);
                    Console.WriteLine("------------------------------------------------");
                }
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao consultar disciplinas: " + exception.Message);
                throw;
            }
        }

        public void RemoverDisciplina()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            try
            {
                if (0 == DisciplinaDB.ListaDisciplina.Count)
                {
                    Console.WriteLine("Nenhuma disciplina cadastrada!");
                    Console.WriteLine(
                        "Para remover uma disciplina, é necessário que exista pelo menos uma disciplina cadastrada!");
                    return;
                }

                ConsultarDisciplina();

                Console.WriteLine("Digite o id da disciplina que deseja remover: ");
                int idDisciplina = int.Parse(Console.ReadLine());
                if (DisciplinaDB.ListaDisciplina.Exists(x => x.IdDisciplina == idDisciplina))
                {
                    DisciplinaDB.ListaDisciplina.RemoveAll(x => x.IdDisciplina == idDisciplina);
                    Console.WriteLine("Disciplina removida com sucesso!");
                }
                else

                    Console.WriteLine("Disciplina não encontrada!");
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao remover disciplina: " + exception.Message);
                throw;
            }
        }

        public void AtualizarDisciplina()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            try
            {
                if (0 == DisciplinaDB.ListaDisciplina.Count)
                {
                    Console.WriteLine("Nenhuma disciplina cadastrada!");
                    Console.WriteLine(
                        "Para atualizar uma disciplina, é necessário que exista pelo menos uma disciplina cadastrada!");
                }

                ConsultarDisciplina();
                Console.WriteLine("Digite o id da disciplina que deseja atualizar: ");
                IdDisciplina = int.Parse(Console.ReadLine());

                if (DisciplinaDB.ListaDisciplina.Exists(x => x.IdDisciplina == IdDisciplina))
                {
                    Console.WriteLine("Digite o novo nome da disciplina: ");
                    NomeDiciplina = Console.ReadLine();
                    Console.WriteLine("Digite a nova carga horaria da disciplina: ");
                    CargaHoraria = int.Parse(Console.ReadLine());
                    DisciplinaDB.ListaDisciplina.Find(x => x.IdDisciplina == IdDisciplina).NomeDiciplina =
                        NomeDiciplina;
                    DisciplinaDB.ListaDisciplina.Find(x => x.IdDisciplina == IdDisciplina).CargaHoraria = CargaHoraria;
                    Console.WriteLine("Disciplina atualizada com sucesso!");
                }
                else

                    Console.WriteLine("Disciplina não encontrada!");
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro ao atualizar disciplina: " + exception.Message);
                throw;
            }
        }
    }
}