namespace CursoPoo
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            Menu menu = new Menu();
            
            AlunoController alunoController = new AlunoController();
            GerenciarAlunos gerenciarAlunos = new GerenciarAlunos();
            alunoController.CadastrarAlunos(aluno,gerenciarAlunos);
            
            alunoController.CadastrarAlunos(aluno,gerenciarAlunos);
            
            alunoController.ConsultarAlunos(aluno,gerenciarAlunos);
            alunoController.RemoverAluno(aluno,gerenciarAlunos);
            
            menu.MenuPrincipal();
        }

      
    }
}