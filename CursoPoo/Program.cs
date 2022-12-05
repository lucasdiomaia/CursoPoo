namespace CursoPoo
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            Menu menu = new Menu();

            GerenciarAlunos gerenciarAlunos = new GerenciarAlunos();
            AlunoController alunoController = new AlunoController();

            alunoController.CadastrarAluno();
            alunoController.CadastrarAluno();
            alunoController.ConsultarAluno();
            alunoController.EditarAluno();
            alunoController.ExcluirAlunoPorMatricula();
            alunoController.ConsultarAluno();
        }
    }
}