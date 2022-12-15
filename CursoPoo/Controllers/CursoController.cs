// using System;
// using System.Data.SqlTypes;
// using System.Globalization;
//
// namespace CursoPoo
// {
//     public class CursoController
//     {
//         Curso curso = new Curso("", 0, 0);
//
//         public void CadastrarCurso()
//         {
//             Console.ForegroundColor = ConsoleColor.Yellow;
//
//             while (true)
//             {
//                 try
//                 {
//                     Console.WriteLine("Digite o Nome do curso");
//                     curso.NomeCurso = Console.ReadLine();
//
//                     Console.WriteLine("Digite o numero do turno: 1-Manhã / 2-Tarde / 3 - Noite");
//                     curso.Turno = int.Parse(Console.ReadLine());
//                     if (curso.Turno == (int)TurnoEnum.Manha || curso.Turno == (int)TurnoEnum.Tarde ||
//                         curso.Turno == (int)TurnoEnum.Noite)
//                     {
//                         Console.WriteLine("Deseja cadastar o curso? S/N");
//                         string opcao = Console.ReadLine();
//                         if (opcao.ToUpper() == "S")
//                         {
//                             curso.IdCurso = Curso.Cursos.Count + 1;
//                             curso.CadastrarCurso();
//                             Console.WriteLine("Curso cadastrado com sucesso");
//                             break;
//                         }
//                         else
//                         {
//                             Console.WriteLine("Cadastro cancelado");
//                             break;
//                         }
//                     }
//                     else
//                     {
//                         Console.WriteLine("Turno inválido");
//                     }
//                 }
//
//                 catch (Exception erro)
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine("Erro ao cadastrar curso:" + erro.Message);
//                 }
//             }
//         }
//
//         public void ConsultarCurso()
//         {
//             while (true)
//             {
//                 Console.ForegroundColor = ConsoleColor.Green;
//                 try
//                 {
//                     Console.WriteLine("Cursos disponíveis");
//                     foreach (var item in Curso.Cursos)
//                     {
//                         Console.WriteLine("Id: " + item.IdCurso + " - Nome: " + item.NomeCurso + " - Turno: " +
//                                           item.Turno);
//                         Console.WriteLine("Disciplinas cadastradas para o curso:" + item.NomeCurso);
//                         foreach (var q in Disciplina.Disciplinas == null ? null : Disciplina.Disciplinas)
//                         {
//                             if (q.IdCurso == item.IdCurso)
//                             {
//                                 Console.WriteLine("Id: " + q.IdDisciplina + " - Nome: " + q.NomeDiciplina +
//                                                   " - Carga Horária: " + q.CargaHoraria);
//                             }
//                             else
//                             {
//                                 Console.WriteLine("Não há disciplinas cadastradas para o curso:" + item.NomeCurso);
//                             }
//                         }
//
//                         Console.WriteLine("-------------------------------------");
//                     }
//
//                     Console.WriteLine("Fim da lista de cursos");
//                     Console.WriteLine("Deseja consoltar os cursos novamente? S/N");
//                     var opcao = Console.ReadLine();
//                     if (opcao.ToUpper() != "S")
//                     {
//                         break;
//                     }
//                 }
//                 catch (Exception e)
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine("Erro ao consultar curso:" + e.Message);
//                 }
//             }
//         }
//
//         public void RemoverCurso()
//         {
//             try
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("cursos disponíveis");
//                 foreach (var curso in Curso.Cursos)
//                 {
//                     Console.WriteLine("Id: " + curso.IdCurso + " - Nome: " + curso.NomeCurso + " - Turno: " +
//                                       curso.Turno);
//                 }
//
//                 Console.WriteLine("Digite o Id do curso que deseja remover");
//                 curso.IdCurso = int.Parse(Console.ReadLine() ?? string.Empty);
//                 if (Disciplina.Disciplinas.Exists(x => x.IdCurso == curso.IdCurso))
//                 {
//                     Console.WriteLine("Não é possível remover o curso, pois existem disciplinas cadastradas");
//                     Console.WriteLine(
//                         "Para remover o curso, primeiro deve remova as disciplinas e os alunos cadastrados no curso.");
//                 }
//                 else if (Aluno.Alunos.Exists(x => x.IdCurso == curso.IdCurso))
//                 {
//                     Console.WriteLine("Não é possível remover o curso pois existem alunos cadastrados no curso");
//                     Console.WriteLine(
//                         "Para remover o curso, primeiro remova as disciplinas e os alunos cadastrados no curso.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Deseja remover o curso? S/N");
//                     var opcao = Console.ReadLine();
//                     if (opcao.ToUpper() == "S")
//                     {
//                         Curso.Cursos.Remove(Curso.Cursos.Find(x => x.IdCurso == curso.IdCurso));
//                         Console.WriteLine("Curso removido com sucesso");
//                     }
//                     else
//                         Console.WriteLine("O curso não foi removido");
//                 }
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine("Erro ao remover curso:" + e.Message);
//             }
//         }
//
//         public void AtualizarCurso()
//         {
//             Console.ForegroundColor = ConsoleColor.Magenta;
//             if (Disciplina.Disciplinas.Count == 0)
//                 Console.WriteLine("Não há cursos cadastrados");
//             else
//             {
//                 Console.WriteLine("Cursos disponíveis");
//
//                 foreach (var curso in Curso.Cursos)
//                 {
//                     Console.WriteLine("Id: " + curso.IdCurso + " - Nome: " + curso.NomeCurso + " - Turno: " +
//                                       curso.Turno);
//                 }
//
//                 Console.WriteLine("Digite o Id do curso que deseja atualizar");
//                 curso.IdCurso = int.Parse(Console.ReadLine() ?? string.Empty);
//                 Console.WriteLine("Digite o novo nome do curso");
//                 curso.NomeCurso = Console.ReadLine();
//                 Console.WriteLine("Digite o novo turno: 1-Manhã / 2-Tarde / 3 - Noite");
//                 curso.Turno = int.Parse(Console.ReadLine());
//                 if (curso.Turno == (int)TurnoEnum.Manha || curso.Turno == (int)TurnoEnum.Tarde ||
//                     curso.Turno == (int)TurnoEnum.Noite)
//                 {
//                     Curso.Cursos.Find(x => x.IdCurso == curso.IdCurso).NomeCurso = curso.NomeCurso;
//                     Curso.Cursos.Find(x => x.IdCurso == curso.IdCurso).Turno = curso.Turno;
//                     Disciplina.Disciplinas.Find(x => x.IdCurso == curso.IdCurso).NomeCurso = curso.NomeCurso;
//                     Disciplina.Disciplinas.Find(x => x.IdCurso == curso.IdCurso).Turno = curso.Turno;
//                     Aluno.Alunos.Find(x => x.IdCurso == curso.IdCurso).NomeCurso = curso.NomeCurso;
//                     Aluno.Alunos.Find(x => x.IdCurso == curso.IdCurso).Turno = curso.Turno;
//                     Console.WriteLine("Curso atualizado com sucesso");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Digite um turno válido");
//                 }
//             }
//         }
//     }
// }