using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class DiciplinasController
    {
        
        public void DiciplinaController(int opcao)
        { Disciplina disciplina = new Disciplina();
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