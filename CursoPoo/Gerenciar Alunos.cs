using System;
using System.Collections.Generic;


namespace CursoPoo
{
    public class GerenciarAlunos
    {
        public void MenuAluno()
        {Console.ForegroundColor = ConsoleColor.Blue;
            AlunoController alunoController = new AlunoController();
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
                            alunoController.CadastrarAluno();
                            break;

                        case 2:
                            Console.WriteLine("2 - Consultar Aluno");
                            alunoController.ConsultarAluno();
                            break;

                        case 3:
                            Console.WriteLine("3 - Remover Aluno");
                            // GerenciarCursos();
                            break;

                        case 4:
                            Console.WriteLine("4 - Atualziar Aluno");
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