using System;
using CursoPoo.Model;

namespace CursoPoo.Controllers
{
    public class AlunosController
    {
        public void AlunoController(int opcao)
        {
            Aluno aluno = new Aluno(string.Empty, 0, 0, 0);
            try
            {
                switch (opcao)
                {
                    case 1:
                        aluno.CadastrarAluno();
                        break;

                    case 2:
                        aluno.ConsultarAluno();
                        break;

                    case 3:
                        aluno.RemoverAluno();
                        break;

                    case 4:
                        aluno.AtualizarAluno();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao executar ação");
            }
        }
    }
}