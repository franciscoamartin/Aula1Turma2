using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBicicleta.Controller;
using ProjetoBicicleta.Model;

namespace BicicletaStore
{
    class Program
    {
        static BicicletaController bicicletaController = new BicicletaController();
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu de Bicicleta");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Listar Bicicletas");
            Console.WriteLine("2 - Cadastrar Bicicletas");
            Console.WriteLine("3 - Atualizar Bicicleta");
            Console.WriteLine("4 - Deletar Bicicleta");
            Console.WriteLine("5 - Ordenar por valor Maior para Menor");
            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    ListarBicicletas();
                    break;
                case 2:
                    CadastrarBicicleta();
                    break;
                case 3:
                    AtualizarBicicleta();
                    break;
                case 4:
                    RemoverBicicleta();
                    break;
                case 5:
                    OrdenarBicicletaMaiorParaMenor();
                    break;

            }
        }

        /// <summary>
        /// metodo ordenar lista e exportar para arquivo txt via Stream IO
        /// </summary>
        private static void OrdenarBicicletaMaiorParaMenor()
        {
            StringBuilder sb = new StringBuilder();

            bicicletaController.ListarBicicletas().OrderByDescending(x => x.Valor).ToList().ForEach(x => Console.WriteLine(($"ID: {x.Id} MARCA: {x.Marca} MODELO: {x.Modelo} VALOR: {x.Valor.ToString("C")} ")));
            Console.WriteLine("Valor total: ");
            Console.WriteLine(bicicletaController.ListarBicicletas().Sum(x => x.Valor));

            Console.WriteLine("Você quer exportar os dados S/N");
            char respostaExportacao = char.Parse(Console.ReadLine());

            if (respostaExportacao == 'S' || respostaExportacao == 's')
            {
                bicicletaController.ListarBicicletas().OrderByDescending(x => x.Valor).ToList().ForEach(x => sb.AppendLine($"ID: {x.Id} MARCA: {x.Marca} MODELO: {x.Modelo} VALOR: {x.Valor.ToString("C")} "));
                sb.AppendLine("Valor total: ");
                sb.AppendLine(bicicletaController.ListarBicicletas().Sum(x => x.Valor).ToString());

                File.WriteAllText(@"C:\Users\900103\Desktop\ARQUIVO_EXPORTAR\dados.txt", sb.ToString());
                Console.WriteLine("Exportado com sucesso");
                Console.WriteLine();
                Console.WriteLine("Dê enter para voltar para menu");
                Console.ReadKey();
                Menu();
            }
            else
            {
                Console.WriteLine("Dê enter para voltar ao menu");
                Console.ReadKey();
                Menu();
            }

        }



        private static void RemoverBicicleta()
        {
            Console.WriteLine("Remover Bicicleta");
            Console.WriteLine();

            bicicletaController.ListarBicicletas().ToList<Bicicleta>().ForEach(x => Console.WriteLine($"ID: {x.Id} MARCA: {x.Marca} MODELO: {x.Modelo} VALOR: {x.Valor.ToString("C")} "));
            Console.WriteLine("Digite o id para remover a bicicleta");

            var idEscolhido = int.Parse(Console.ReadLine());

            bicicletaController.RemoverBicicleta(idEscolhido);
            Console.WriteLine("Bicicleta Removida com sucesso.");
            Console.WriteLine();
            Console.WriteLine("Dê enter para voltar ao menu");
            Console.ReadKey();
            Menu();


        }

        private static void AtualizarBicicleta()
        {
            Console.WriteLine("Atualizar Bicicleta");
            Console.WriteLine();

            bicicletaController.ListarBicicletas().ToList<Bicicleta>().ForEach(x => Console.WriteLine($"ID: {x.Id} MARCA: {x.Marca} MODELO: {x.Modelo} VALOR: {x.Valor.ToString("C")} "));
            Console.WriteLine("Digite o id para atualizar a bicicleta");

            var idEscolhido = int.Parse(Console.ReadLine());

            var atualizar = bicicletaController.ListarBicicletas().FirstOrDefault(x => x.Id == idEscolhido);
            if (atualizar == null)
            {
                Console.WriteLine("Id inválido");
                return;
            }
            Console.WriteLine("Informe a marca para atualizar");
            atualizar.Marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo para atualizar");
            atualizar.Modelo = Console.ReadLine();

            Console.WriteLine("Informe o valor para atualizar");
            atualizar.Valor = double.Parse(Console.ReadLine());

            var resultado = bicicletaController.AtualizarBicicleta(atualizar);

            atualizar.Ativo = false;

            Console.WriteLine("Atualizado com sucesso");
            Console.WriteLine("Dê enter para voltar ao menu");
            Console.ReadKey();
            Menu();

        }


        public static void CadastrarBicicleta()
        {
            Console.WriteLine("Digite a marca da bicicleta");
            var marcaCadastro = Console.ReadLine();

            Console.WriteLine("Digite a modelo da bicicleta");
            var modeloCadastro = Console.ReadLine();

            Console.WriteLine("Digite o valor da bicicleta");
            var valorCadastro = double.Parse(Console.ReadLine());

            var resultado = bicicletaController.AddBicicleta(new Bicicleta()
            {
                Marca = marcaCadastro,
                Modelo = modeloCadastro,
                Valor = valorCadastro
            });

            if (resultado)
            {
                Console.WriteLine("Cadastrado com sucesso");
                Console.WriteLine();
                Console.WriteLine("Digite enter para voltar ao menu");
                Console.ReadKey();
                Menu();
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar produto.");
                Console.WriteLine();
                Console.WriteLine("Digite enter para voltar ao menu");
                Console.ReadKey();
                Menu();
            }
        }


        public static void ListarBicicletas()
        {
            Console.WriteLine("Lista de Bicicletas");
            Console.WriteLine();
            bicicletaController.ListarBicicletas().ToList<Bicicleta>().ForEach(x => Console.WriteLine($"ID: {x.Id} MARCA: {x.Marca} MODELO: {x.Modelo} VALOR: {x.Valor.ToString("C")} "));
            Console.WriteLine();
            Console.WriteLine("Dê enter para voltar ao menu");
            Console.ReadKey();
            Menu();
        }
    }
}
