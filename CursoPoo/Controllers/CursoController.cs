using System;
using CursoPoo.Model;

namespace CursoPoo.Controllers
{
    public class CursoController
    {
        Curso curso = new Curso(string.Empty, 0, 0, 0);

        public void CadastrarCurso()
        {
            curso.CadastrarCurso();
        }

        public void ConsultarCurso()
        {
            curso.ConsultarCurso();
        }

        public void RemoverCurso()
        {
            curso.RemoverCurso();
        }

        public void AtualizarCurso()
        {
            curso.AtualizarCurso();
        }
    }
}