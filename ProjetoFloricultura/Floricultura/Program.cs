using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFloricultura.Controller;
using ProjetoFloricultura.Model;

namespace Floricultura
{
    class Program
    {
        static FloresController floresController = new FloresController();
        static void Main(string[] args)
        {
            Menu();
        }


        public static void CadastrarFlores()
        {
            Console.WriteLine("Digite o nome");
            var nomeFlor = Console.ReadLine();

            Console.WriteLine("Digite a quantidade");
            var quantidadeCadastro = int.Parse(Console.ReadLine());

            floresController.AddFlores(new Flores()
            {
                Nome = nomeFlor,
                Quantidade = quantidadeCadastro
            });
            Console.WriteLine("Cadastrado com sucesso");
            Console.WriteLine("Dê enter para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }
        private static void ListarFlores()
        {
            Console.WriteLine("Lista de Pessoas");
            floresController.GetFlores().ToList<Flores>().ForEach(x => Console.WriteLine($"{x.Id} - {x.Nome} - {x.Quantidade}"));
            Console.WriteLine("Dê enter para voltar para menu");
            Console.ReadKey();
            Console.Clear();
            Menu();

        }

        private static void Menu()
        {
            Console.WriteLine("Menu Floricultura");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Listar Flores");
            Console.WriteLine("2 - Cadastrar Flores");
            Console.WriteLine("3 - Relatório Ordenado");
            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    ListarFlores();
                    break;
                case 2:
                    CadastrarFlores();
                    break;
                case 3:
                    OrdenarFlores();
                    break;
            }
        }

        private static void OrdenarFlores()
        {
            Console.WriteLine("Ordenado por maior a menor quantidade");

            //List<Flores> floresOrdenadasMaior = floresController.OrderByDescending(p => p.Altura).ThenBy(c => c.Idade).ToList();


            floresController.GetFlores().ToList<Flores>().ForEach(x => Console.WriteLine($"{x.Id} - {x.Nome} - {x.Quantidade}"));

        }
    }
}

