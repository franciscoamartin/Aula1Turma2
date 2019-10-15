using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class AlunoController
    {
        EntityContexDB contexDB = new EntityContexDB(); // instanciamento da classe
        static AlunoController aluno = new AlunoController();

        public IQueryable<Aluno> GetAlunos()
        {
            return contexDB.ListaDeAlunos; // retorna os alunos 
        }
        public void AddAluno(Aluno aluno)
        {
            contexDB.ListaDeAlunos.Add(aluno);
            contexDB.SaveChanges();
        }

        public void MenuSistema()
        {
            Console.Clear();
            Console.WriteLine("Menu Sistema Alunos");
            Console.WriteLine();
            Console.WriteLine("1 - Adicionar Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    Console.Clear();
                    AddNovoAluno();
                    MenuSistema();
                    break;
                case 2:
                    Console.Clear();
                    ListarAlunos();
                    MenuSistema();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
            }
        }

        private static void AddNovoAluno()
        {
            Console.WriteLine("Adicione o nome do aluno: ");
            var addNovoAluno = Console.ReadLine();
            Console.WriteLine("Adicione a idade: ");
            var addIdadeAluno = int.Parse(Console.ReadLine());
            aluno.AddAluno(new Aluno() { Nome = addNovoAluno, Idade = addIdadeAluno });
            Console.WriteLine("Cadastrado com sucesso");
            Console.WriteLine("Dê enter para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

        private static void ListarAlunos()
        {
            Console.WriteLine("Lista de Alunos");
            aluno.GetAlunos().ToList<Aluno>().ForEach(x => Console.WriteLine($"{x.Nome} - {x.Idade}")); //obtemos a lista de pessoas.
            Console.WriteLine("Dê enter para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
