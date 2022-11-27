using System;

namespace CursoPoo
{
    public class Menu
    {
        public void MenuPrincipal()
        {
            var loop = true;
            while (loop)
            {
                Console.WriteLine("-----------------------------------");
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
                            GerenciarAlunos gerenciarAlunos = new GerenciarAlunos();
                            gerenciarAlunos.MenuAluno();
                            break;
                        case 2:
                            Console.WriteLine("Gerenciar Disciplinas");
                            // GerenciarDiciplinas();
                            break;
                        case 3:
                            Console.WriteLine("Gerenciar Cursos");
                            // GerenciarCursos();
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
                    continue;
                }
            }
        }
    }
}