using System;
using CursoPoo.Controllers;

namespace CursoPoo.Views
{
    public class Menu
    {
        internal void MenuPrincipal()
        {
            
            var loop = true;
            while (loop)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
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
                catch (Exception exception)
                {
                    Console.WriteLine("Erro ao selecionar a opção: " + exception.Message);
                }
            }
        }

        public void GerenciarCurso()
        {
            CursoController cursoController = new CursoController();
            
            bool loop = true;
            while (loop)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                            cursoController.CadastrarCurso();
                            break;

                        case 2:
                            Console.WriteLine("2 - Consultar Curso");
                            cursoController.ConsultarCurso();
                            break;

                        case 3:
                            Console.WriteLine("3 - Remover Curso");
                            cursoController.RemoverCurso();
                            break;

                        case 4:
                            Console.WriteLine("4 - Atualziar Curso");
                            cursoController.AtualizarCurso();
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
                catch (Exception exception)
                {
                    Console.WriteLine("Erro ao selecionar a opção: " + exception.Message);
                }
            }
        }

        public void GerenciarDisciplina()
        {
            DisciplinaController disciplinaController = new DisciplinaController();

            

            var loop = true;
            while (loop)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
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
                            disciplinaController.CadastrarDisciplina();
                            break;

                        case 2:
                            Console.WriteLine("2 - Consultar Diciplina");
                            disciplinaController.ConsultarDisciplina();
                            break;

                        case 3:
                            Console.WriteLine("3 - Remover Diciplina");
                            disciplinaController.RemoverDisciplina();
                            break;

                        case 4:
                            Console.WriteLine("4 - Atualziar Diciplina");
                            disciplinaController.AtualizarDisciplina();
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
                catch (Exception exception)
                {
                    Console.WriteLine("Erro ao selecionar a opção: " + exception.Message);
                }
            }
        }

        public void GerenciarAluno()
        {
            
            AlunoController alunoController = new AlunoController();
            var loopaluno = true;
            while (loopaluno)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
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
                            alunoController.CadastrarAluno();
                            break;

                        case 2:
                            Console.WriteLine("2 - Consultar Aluno");
                            alunoController.ConsultarAluno();
                            break;

                        case 3:
                            Console.WriteLine("3 - Remover Aluno");
                            alunoController.RemoverAluno();
                            break;

                        case 4:
                            Console.WriteLine("4 - Atualziar Aluno");
                            alunoController.AtualizarAluno();
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
                catch (Exception exception)
                {
                    Console.WriteLine("Erro ao selecionar a opção: " + exception.Message);
                }
            }
        }
    }
}