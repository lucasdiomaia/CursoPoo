using System.Collections.Generic;

namespace CursoPoo
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public string Turno { get; set; }
        public static List<Curso> Cursos { get; set; }
    }
}