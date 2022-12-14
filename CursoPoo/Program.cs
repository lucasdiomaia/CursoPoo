namespace CursoPoo
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            Menu menu = new Menu();

            GerenciarAlunos gerenciarAlunos = new GerenciarAlunos();
            AlunoController alunoController = new AlunoController();
            CursoController cursoController = new CursoController();
            DisciplinaController disciplinaController = new DisciplinaController();
            
            menu.MenuPrincipal();
            
        }
    }
}