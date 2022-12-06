using System;
using System.Data.SqlTypes;

namespace CursoPoo
{
    public class CursoController
    {
        public void CadastrarCurso()
        {
            Curso curso = new Curso("", 0,0);
            while (true)
            {
                try
                {
                    Console.WriteLine("Digite o Nome do curso");
                    curso.NomeCurso = Console.ReadLine();
                    
                    Console.WriteLine("Digite o numero do turno: 1-Manhã / 2-Tarde / 3 - Noite");
                    curso.Turno = int.Parse(Console.ReadLine());
                    if (curso.Turno == (int)TurnoEnum.Manha || curso.Turno == (int)TurnoEnum.Tarde || curso.Turno == (int)TurnoEnum.Noite)
                    {
                        curso.IdCurso= Curso.Cursos.Count + 1;
                        curso.CadastrarCurso();
                        Console.WriteLine("Curso cadastrado com sucesso");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite um turno válido");
                    }
                }
            
                catch (Exception)
                {
                    Console.WriteLine("Não foi possível cadastrar curso, tente novamente!");
                    
                }
            }
        }
    }
}