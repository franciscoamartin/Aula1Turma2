using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Controller;
using CatalogoCelulares.Model;

namespace CellDu
{
    class Program
    {
        static CelularController celularController = new CelularController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;
            while (opcao != 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("2 - Listar Celulares");
                Console.WriteLine("3 - Atualizar Celulares");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;
                    case 2:
                        ListarCelular();
                        break;
                    case 3:
                        AtualizarCelular();
                        break;
                    case 4:
                        DesativarCelular();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true); //true para informar que nao deve aparecer na tela o valor pressionado
            }
        }

        //inserir
        public static void InserirCelular()
        {
            Console.WriteLine("--- Inserir Celular ---");
            Console.WriteLine("Informe o Marca do celular");
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");
            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do celular");
            var preco = double.Parse(Console.ReadLine());

            var resultado = celularController.InserirCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });
            if (resultado)
            {
                Console.WriteLine("Cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar aparelho!");
            }
        }
        //atualizar

        public static void AtualizarCelular()
        {
            Console.WriteLine("--- Atualizar Celular ---");

            ListarCelular();

            Console.WriteLine("Informe o Id para alterar registro");

            var celularId = int.Parse(Console.ReadLine());

            //obtemos no BD o item completo que vamos atualizar
            var celular = celularController.GetCelulars().FirstOrDefault(x => x.Id == celularId); //obtemos os celulares e a regra via Id

            if (celular == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }


            Console.WriteLine("Informe o Marca do celular");
            celular.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo do celular");
            celular.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor do celular");
            celular.Preco = double.Parse(Console.ReadLine());

            var resultado = celularController.AtualizarCelular(celular);
            if (resultado)
            {
                Console.WriteLine("Celular atualizado com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao atualizar aparelho");
            }

        }
        //listar
        public static void ListarCelular()
        {
            celularController.GetCelulars().ToList<Celular>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Preco}"));

        }
        //remover
        public static void DesativarCelular()
        {
            Console.WriteLine("--- Desativar Celular ---");

            celularController.GetCelulars().ToList<Celular>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Preco}"));

            Console.WriteLine("Informe o Id para desativar registro");

            var celularId = int.Parse(Console.ReadLine());

            var resultado = celularController.RemoverCelular(celularId);

            if (resultado)
            {
                Console.WriteLine("Celular removido com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao remover celular");
            }
        }
    }
}
