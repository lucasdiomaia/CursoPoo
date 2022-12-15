using System.Collections.Generic;

namespace CursoPoo
{
    internal class Program
    {
        public static void Main(string[] args)

        {
           // Menu menu = new Menu();

            
            
            // GerenciarAlunos gerenciarAlunos = new GerenciarAlunos();
            // AlunoController alunoController = new AlunoController();
            // CursoController cursoController = new CursoController();
            // DisciplinaController disciplinaController = new DisciplinaController();

            Curso curso = new Curso("", 0,0,new List<Disciplina>(),new List<Aluno>() );
            curso.CadastrarCurso();
            
            //menu.MenuPrincipal();
            
        }
    }
}