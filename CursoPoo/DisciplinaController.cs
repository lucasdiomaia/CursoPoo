using System;

namespace CursoPoo
{
    public class DisciplinaController
    {
        Disciplina disciplina = new Disciplina("", 0, "", 0);
        //CursoController cursoController = new CursoController();

        public void cadastrarDisciplina()
        {
            Console.WriteLine("Digite o nome da disciplina: ");
            disciplina.NomeDiciplina = Console.ReadLine();
            Console.WriteLine("Digite a carga horária da disciplina: Utilize apenas números");
            disciplina.CargaHoraria = int.Parse(Console.ReadLine());

            if (Curso.Cursos.Count == 0)
            {
                Console.WriteLine("Não há cursos cadastrados");
                Console.WriteLine("Deseja cadastrar um curso? S/N");
                string opcao = Console.ReadLine();
                if (opcao.ToUpper() == "S".ToUpper())
                    //cursoController.cadastrarCurso();
                    Console.WriteLine("Cadastar novo curso"); // sumir com essa linha
                else
                    Console.WriteLine("Operação cancelada");
            }
            else
            {
                Console.WriteLine("Digite o código do curso: ");
                foreach (var item in Curso.Cursos)
                {
                    Console.WriteLine(item.IdCurso + " - " + item.NomeCurso);
                }

                disciplina.IdCurso = int.Parse(Console.ReadLine());
                if (Curso.Cursos.Exists(x => x.IdCurso == disciplina.IdCurso))
                {
                    Disciplina.Disciplinas.Add(disciplina);
                    Console.WriteLine("Disciplina cadastrada com sucesso");
                }
                else
                    Console.WriteLine("Curso não encontrado");
            }
        }
    }
}