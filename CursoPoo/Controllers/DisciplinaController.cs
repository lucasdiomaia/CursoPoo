using System;
using CursoPoo.Model;

namespace CursoPoo.Controllers
{
    public class DisciplinaController
    {
        
        Disciplina disciplina = new Disciplina(string.Empty, 0, 0);
            public void CadastrarDisciplina()
            {
                disciplina.CadastrarDisciplina();
            }

            public void ConsultarDisciplina()
            {
                disciplina.ConsultarDisciplina();
            }

            public void RemoverDisciplina()
            {
                disciplina.RemoverDisciplina();
            }

            public void AtualizarDisciplina()
            {
                disciplina.AtualizarDisciplina();
            }
    }
}