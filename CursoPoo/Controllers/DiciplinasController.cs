using System;
using CursoPoo.Model;

namespace CursoPoo.Controllers
{
    public class DiciplinasController
    {
        Disciplina disciplina = new Disciplina(String.Empty, 0);

        public void DiciplinaController(int opcao)
        {
            try
            {
                switch (opcao)
                {
                    case 1:
                        disciplina.CadastrarDisciplina();
                        break;

                    case 2:
                        disciplina.ConsultarDisciplina();
                        break;

                    case 3:
                        disciplina.RemoverDisciplina();
                        break;

                    case 4:
                        disciplina.AtualizarDisciplina();
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