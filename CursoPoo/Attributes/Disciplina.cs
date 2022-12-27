using System;
using System.Collections.Generic;

namespace CursoPoo
{
    public class Disciplina
    {
        //atributos
        private string _nomeDiciplina;
        private int _cargaHoraria;
        private int _idDisciplina;
        private static List<Aluno> _alunos = new List<Aluno>();


        public int IdDisciplina
        {
            get => _idDisciplina;
            set => _idDisciplina = value;
        }

        public string NomeDiciplina
        {
            get => _nomeDiciplina;
            set => _nomeDiciplina = value;
        }

        public int CargaHoraria
        {
            get => _cargaHoraria;
            set => _cargaHoraria = (int)value;
        }

        public List<Aluno> Alunos
        {
            get => _alunos;
            set => _alunos = value;
        }

        //construtor
        public Disciplina(string nomeDiciplina, int cargaHoraria, int idDisciplina)
        {
            _nomeDiciplina = nomeDiciplina;
            _cargaHoraria = cargaHoraria;
            _idDisciplina = idDisciplina;
        }
        
        //metodos
        //cadastrar disciplina
        public void CadastrarDisciplina()
        {
            Console.WriteLine("Digite o nome da disciplina: ");
            _nomeDiciplina = Console.ReadLine();
            Console.WriteLine("Digite a carga horaria da disciplina: ");
            _cargaHoraria = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o id da disciplina: ");
            _idDisciplina = int.Parse(Console.ReadLine());
            
            
        }

        
    }
}