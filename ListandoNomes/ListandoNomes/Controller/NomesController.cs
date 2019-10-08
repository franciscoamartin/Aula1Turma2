using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ListandoNomes.Model;

namespace ListandoNomes.Controller
{
    public class NomesController
    {
        NomeContextDB contextDB = new NomeContextDB();
        static NomesController pessoas = new NomesController();

        public IQueryable<NomePessoal> GetNomePessoal()
        {
            return contextDB.ListaDeNomes;
        }

        public void AddPessoas(NomePessoal pessoa)
        {
            contextDB.ListaDeNomes.Add(pessoa);
            contextDB.SaveChanges();
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Banco de Nomes");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Listar Nomes");
            Console.WriteLine("2 - Cadastrar Nome");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    Console.Clear();
                    ListarPessoas();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    CadastrarNomes();
                    Menu();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
            }
        }

        public void CadastrarNomes()
        {
            Console.WriteLine("Digite o nome");
            var nomeCadastro = Console.ReadLine();
            Console.WriteLine("Digite sua nacionalidade");
            var origemPessoa = Console.ReadLine();

            AddPessoas(new NomePessoal()
            {
                Nome = nomeCadastro,
                Origem = origemPessoa
            });
            Console.WriteLine("Cadastrado com sucesso");
            Console.WriteLine("Dê enter para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

        private static void ListarPessoas()
        {
            Console.WriteLine("Lista de Pessoas");
            pessoas.GetNomePessoal().ToList<NomePessoal>().ForEach(x => Console.WriteLine($"{x.Nome} - {x.Origem}"));
            Console.WriteLine("Dê enter para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
