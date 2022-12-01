namespace CursoPoo
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            Menu menu = new Menu();

            GerenciarAlunos gerenciarAlunos = new GerenciarAlunos();
            gerenciarAlunos.MenuAluno();
        }
    }
}