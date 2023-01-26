using System;
using CursoPoo.Model;

namespace CursoPoo.Controllers
{
    public class AlunoController
    {
        Aluno aluno = new Aluno(string.Empty, 0, 0, 0, 0);
        public void CadastrarAluno()
        {
            aluno.CadastrarAluno();
        }

        public void ConsultarAluno()
        {
            aluno.ConsultarAluno();
        }

        public void RemoverAluno()
        {
            aluno.RemoverAluno();
        }

        public void AtualizarAluno()
        {
            aluno.AtualizarAluno();
        }
    }
}