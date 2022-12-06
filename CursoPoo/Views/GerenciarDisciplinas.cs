using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class GerenciarDiciplinas
    {
        public void GerenciarDisciplina()
        {
            Console.ForegroundColor = ConsoleColor.Red;


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

                            break;

                        case 2:
                            Console.WriteLine("2 - Consultar Diciplina");

                            break;

                        case 3:
                            Console.WriteLine("3 - Remover Diciplina");
                            // GerenciarCursos();
                            break;

                        case 4:
                            Console.WriteLine("4 - Atualziar Diciplina");
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
    }
}