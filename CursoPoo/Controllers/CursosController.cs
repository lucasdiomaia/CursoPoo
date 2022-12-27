using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class CursosController
    {
        Curso curso = new Curso();

        public void CursoController(int opcao)
        {
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

}