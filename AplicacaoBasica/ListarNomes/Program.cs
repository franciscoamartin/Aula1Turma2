using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoNomes.Controller;
using ProjetoNomes.Model;

namespace ListarNomes
{
    class Program
    {
        static NomeController nomeController = new NomeController();
        static void Main(string[] args)
        {
            Menu();
        }


        public static void CadastrarNomes()
        {
            Console.WriteLine("Digite o nome");
            var nomeCadastro = Console.ReadLine();

            nomeController.AddPessoas(new Nome()
            {
                Nomes = nomeCadastro,
            });
            Console.WriteLine("Cadastrado com sucesso");
            Console.WriteLine("Dê enter para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        private static void ListarNomes()
        {
            Console.WriteLine("Lista de Pessoas");
            nomeController.ListaNomes().ToList<Nome>().ForEach(x => Console.WriteLine($"{x.Id} - {x.Nomes}"));
            Console.WriteLine("Dê enter para voltar para menu");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }

        private static void Menu()
        {
            Console.WriteLine("Menu de Pessoas");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Listar Pessoas");
            Console.WriteLine("2 - Cadastrar nomes");
            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    ListarNomes();
                    break;
                case 2:
                    CadastrarNomes();
                    break;
            }
        }
    }
}
