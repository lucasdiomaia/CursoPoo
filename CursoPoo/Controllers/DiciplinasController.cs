using System;
using CursoPoo.Model;

namespace CursoPoo.Controllers
{
    public class DiciplinasController
    {
        public void DiciplinaController(int opcao)
        {
            var disciplina = new Disciplina(string.Empty, 0, 0);
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