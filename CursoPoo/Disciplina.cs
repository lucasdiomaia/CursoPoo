using System.Collections.Generic;

namespace CursoPoo
{
    public class Disciplina
    {
        public string NomeDiciplina { get; set; }
        public int CargaHoraria { get; set; }
        public static List<Disciplina> Disciplinas { get; set; }
    }
}