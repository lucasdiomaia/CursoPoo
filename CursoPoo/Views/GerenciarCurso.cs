// using System;
// using System.Collections.Generic;
//
// namespace CursoPoo
// {
//     public class GerenciarCurso
//     {
//         public void GerenciarCursos()
//         {
//             CursoController cursoController = new CursoController();
//
//             Console.ForegroundColor = ConsoleColor.Red;
//
//
//             bool loop = true;
//             while (loop)
//             {
//                 Console.WriteLine("-----------------------------------");
//                 Console.WriteLine("1 - Cadastrar Curso");
//                 Console.WriteLine("2 - Consultar Curso");
//                 Console.WriteLine("3 - Remover Curso");
//                 Console.WriteLine("4 - Atualziar Curso");
//                 Console.WriteLine("5 - Voltar");
//                 Console.WriteLine("Digite a opção desejada: ");
//                 Console.WriteLine("-----------------------------------");
//
//                 try
//                 {
//                     var opcao = int.Parse(Console.ReadLine());
//                     switch (opcao)
//                     {
//                         case 1:
//                             Console.WriteLine("1 - Cadastrar Curso");
//                             cursoController.CadastrarCurso();
//                             break;
//
//                         case 2:
//                             Console.WriteLine("2 - Consultar Curso");
//                             cursoController.ConsultarCurso();
//                             break;
//
//                         case 3:
//                             Console.WriteLine("3 - Remover Curso");
//                             cursoController.RemoverCurso();
//                             break;
//
//                         case 4:
//                             Console.WriteLine("4 - Atualziar Curso");
//                             cursoController.AtualizarCurso();
//                             break;
//
//                         case 5:
//                             Console.WriteLine("5 - Voltar");
//
//                             loop = false;
//                             break;
//                         default:
//                             Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
//                             break;
//                     }
//                 }
//                 catch (Exception)
//                 {
//                     Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
//                 }
//             }
//         }
//     }
// }