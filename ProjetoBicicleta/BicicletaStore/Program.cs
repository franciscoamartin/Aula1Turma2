using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBicicleta.Model;
using ProjetoBicicleta.Controller;

namespace BicicletaStore
{
    class Program
    {
        static BicicletaController bicicletaController = new BicicletaController();
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {

            var opcao = int.MinValue;
            while (opcao != 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Bicicleta");
                Console.WriteLine("2 - Listar Bicicletas");
                Console.WriteLine("3 - Atualizar Bicicleta");
                Console.WriteLine("4 - Remover Bicicleta");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        InserirBicicleta();
                        break;
                    case 2:
                        ListarBicicleta();
                        break;
                    case 3:
                        AtualizarBicicleta();
                        break;
                    case 4:
                        DesativarBicicleta();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true);
            }
        }

        private static void DesativarBicicleta()
        {
            Console.WriteLine("--- Desativar Bicicleta ---");

            bicicletaController.ListarBicicletas().ToList<Bicicleta>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Valor}"));

            Console.WriteLine("Informe o Id para desativar registro");

            var bicicletaId = int.Parse(Console.ReadLine());

            var resultado = bicicletaController.RemoverBicicleta(bicicletaId);

            if (resultado)
            {
                Console.WriteLine("Bicicleta removida com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao remover bicicleta");
            }
        }

        private static void AtualizarBicicleta()
        {
            Console.WriteLine("--- Atualizar Bicicleta ---");

            bicicletaController.ListarBicicletas().ToList<Bicicleta>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Valor}"));

            Console.WriteLine("Informe o Id para alterar registro");

            var bicicletaId = int.Parse(Console.ReadLine());

            //obtemos no BD o item completo que vamos atualizar
            var bicicleta = bicicletaController.ListarBicicletas().FirstOrDefault(x => x.Id == bicicletaId); //obtemos os celulares e a regra via Id

            if (bicicleta == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }

            Console.WriteLine("Informe o Marca da Bicicleta");
            bicicleta.Marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo da Bicicleta");
            bicicleta.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o Valor da Bicicleta");
            bicicleta.Valor = double.Parse(Console.ReadLine());

            var resultado = bicicletaController.AtualizarBicicleta(bicicleta);
            if (resultado)
            {
                Console.WriteLine("Bicicleta atualizada com sucesso");
            }
            else
            {
                Console.WriteLine("Erro ao atualizar bicicleta");
            }
        }

        private static void ListarBicicleta()
        {
            Console.WriteLine("Lista de Bicicletas: ");
            bicicletaController.ListarBicicletas().ToList<Bicicleta>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: {x.Modelo} Preço: {x.Valor}"));
        }

        private static void InserirBicicleta()
        {
            Console.WriteLine("--- Inserir Bicicleta ---");
            Console.WriteLine("Informe o modelo da bicicleta");
            var modeloBicicleta = Console.ReadLine();

            Console.WriteLine("Informe a marca da bicicleta");
            var marcaBicicleta = Console.ReadLine();

            Console.WriteLine("Informe o Valor da bicicleta");
            var precoBicicleta = double.Parse(Console.ReadLine());

            var resultado = bicicletaController.AddBicicleta(new Bicicleta()
            {
                Modelo = modeloBicicleta,
                Marca = marcaBicicleta,
                Valor = precoBicicleta
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


    }
}
