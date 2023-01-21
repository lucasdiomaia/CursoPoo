using System;
using CursoPoo.Model;

namespace CursoPoo.Controllers
{
    public class CursosController
    {
        

        public void CursoController(int opcao)
        {
            Curso curso = new Curso(string.Empty, 0, 0);
            try
            {
                switch (opcao)
                {
                    case 1:
                        curso.CadastrarCurso();
                        break;

                    case 2:
                        curso.ConsultarCurso();
                        break;

                    case 3:
                        curso.RemoverCurso();
                        break;

                    case 4:
                        curso.AtualizarCurso();
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