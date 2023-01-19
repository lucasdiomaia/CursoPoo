using System;
using CursoPoo.Controllers;

namespace CursoPoo.Views
{
    public class Menu
    {
        internal void MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var loop = true;
            while (loop)
            {
                Console.WriteLine("--------------Menu Principal--------------");
                Console.WriteLine("1 - Gerenciar Alunos");
                Console.WriteLine("2 - Gerenciar Disciplinas");
                Console.WriteLine("3 - Gerenciar Cursos");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("-----------------------------------");

                try
                {
                    var opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Gerenciar Alunos");
                            GerenciarAluno();
                            break;
                        case 2:
                            Console.WriteLine("Gerenciar Disciplinas");
                            GerenciarDisciplina();
                            break;
                        case 3:
                            Console.WriteLine("Gerenciar Cursos");
                            GerenciarCurso();
                            break;
                        case 4:
                            Console.WriteLine("Saindo...");
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida, coloque um número de 1 a 4");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida, coloque um número de 1 a 4");
                }
            }
        }

        public void GerenciarCurso()
        {
            CursosController cursoController = new CursosController();
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1 - Cadastrar Curso");
                Console.WriteLine("2 - Consultar Curso");
                Console.WriteLine("3 - Remover Curso");
                Console.WriteLine("4 - Atualziar Curso");
                Console.WriteLine("5 - Voltar");
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("-----------------------------------");

                try
                {
                    var opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("1 - Cadastrar Curso");
                            cursoController.CursoController(opcao);
                            break;

                        case 2:
                            Console.WriteLine("2 - Consultar Curso");
                            cursoController.CursoController(opcao);
                            break;

                        case 3:
                            Console.WriteLine("3 - Remover Curso");
                            cursoController.CursoController(opcao);
                            break;

                        case 4:
                            Console.WriteLine("4 - Atualziar Curso");
                            cursoController.CursoController(opcao);
                            break;

                        case 5:
                            Console.WriteLine("5 - Voltar");
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
                }
            }
        }

        public void GerenciarDisciplina()
        {
            DiciplinasController disciplinaController = new DiciplinasController();

            Console.ForegroundColor = ConsoleColor.Magenta;

            var loop = true;
            while (loop)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1 - Cadastrar Diciplina");
                Console.WriteLine("2 - Consultar Diciplina");
                Console.WriteLine("3 - Remover Diciplina");
                Console.WriteLine("4 - Atualziar Diciplina");
                Console.WriteLine("5 - Voltar");
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("-----------------------------------");

                try
                {
                    var opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("1 - Cadastrar Diciplina");
                            disciplinaController.DiciplinaController(opcao);
                            break;

                        case 2:
                            Console.WriteLine("2 - Consultar Diciplina");
                            disciplinaController.DiciplinaController(opcao);
                            break;

                        case 3:
                            Console.WriteLine("3 - Remover Diciplina");
                            disciplinaController.DiciplinaController(opcao);
                            break;

                        case 4:
                            Console.WriteLine("4 - Atualziar Diciplina");
                            disciplinaController.DiciplinaController(opcao);
                            break;

                        case 5:
                            Console.WriteLine("5 - Voltar");

                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
                }
            }
        }

        public void GerenciarAluno()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            AlunosController alunoController = new AlunosController();
            var loopaluno = true;
            while (loopaluno)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Consultar Aluno");
                Console.WriteLine("3 - Remover Aluno");
                Console.WriteLine("4 - Atualziar Aluno");
                Console.WriteLine("5 - Voltar");
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("-----------------------------------");

                try
                {
                    var opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("1 - Cadastrar Aluno");
                            alunoController.AlunoController(opcao);
                            break;

                        case 2:
                            Console.WriteLine("2 - Consultar Aluno");
                            alunoController.AlunoController(opcao);
                            break;

                        case 3:
                            Console.WriteLine("3 - Remover Aluno");
                            alunoController.AlunoController(opcao);
                            break;

                        case 4:
                            Console.WriteLine("4 - Atualziar Aluno");
                            alunoController.AlunoController(opcao);
                            break;

                        case 5:
                            Console.WriteLine("5 - Voltar");

                            loopaluno = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
                }
            }
        }
    }
}