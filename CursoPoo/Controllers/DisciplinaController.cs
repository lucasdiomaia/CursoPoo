using System;

namespace CursoPoo
{
    public class DisciplinaController
    {
        Disciplina disciplina = new Disciplina("", 0, 0,"", 0, 0);
        //CursoController cursoController = new CursoController();

        public void CadastrarDisciplina()
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
                Console.WriteLine("Escolha um curso para a disciplina: ");
                Console.WriteLine("Cursos disponíveis:");
                foreach (var item in Curso.Cursos)
                {
                    Console.WriteLine(item.IdCurso + " - " + item.NomeCurso);
                }
                Console.WriteLine("Digite o código do curso: ");
                disciplina.IdCurso = int.Parse(Console.ReadLine());
                if (Curso.Cursos.Exists(x => x.IdCurso == disciplina.IdCurso))
                {//extrarir o nome do curso e turno
                    disciplina.NomeCurso = Curso.Cursos.Find(x => x.IdCurso == disciplina.IdCurso).NomeCurso;
                    disciplina.Turno = Curso.Cursos.Find(x => x.IdCurso == disciplina.IdCurso).Turno;
                    disciplina.IdCurso= Curso.Cursos.Find(x => x.IdCurso == disciplina.IdCurso).IdCurso;
                    disciplina.IdDisciplina= Disciplina.Disciplinas.Count + 1;
                    disciplina.CadastrarDisciplina();
                    Console.WriteLine("Disciplina cadastrada com sucesso");
                }
                else
                    Console.WriteLine("Curso não encontrado");
            }
        }
    }
}