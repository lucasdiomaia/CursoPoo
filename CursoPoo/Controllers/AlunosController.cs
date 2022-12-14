using System;
using System.Collections.Generic;


namespace CursoPoo
{
    public class AlunosController
    {
        Aluno aluno = new Aluno();

        public void AlunoController(int opcao)
        {
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