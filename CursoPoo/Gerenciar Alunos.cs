using System;

namespace CursoPoo
{
    public class GerenciarAlunos
    {
        //atributos


        public void MenuAluno()
        {
            AlunoController menuAluno = new AlunoController();
            Aluno aluno = new Aluno();

            var loopaluno = true;
            while (loopaluno)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Consultar Aluno");
                Console.WriteLine("3 - Remover Aluno");
                Console.WriteLine("4 - Atualziar Aluno");
                Console.WriteLine("5 - Voltar");
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("-----------------------------------");

                try
                {
                    var opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("1 - Cadastrar Aluno");
                            menuAluno.CadastrarAlunos(aluno);

                            break;
                        case 2:
                            Console.WriteLine("2 - Consultar Aluno");
                        {
                            menuAluno.ConsultarAlunos(aluno /*alunos: new List<Aluno>()*/);
                        }
                            break;
                        case 3:
                            Console.WriteLine("3 - Remover Aluno");
                            // GerenciarCursos();
                            break;
                        case 4:
                            Console.WriteLine("4 - Atualziar Aluno");
                            break;

                        case 5:
                            Console.WriteLine("5 - Voltar");

                            loopaluno = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção inválida, coloque um número de 1 a 5");
                    continue;
                }
            }
        }
    }
}