using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeitorDados.Model;
using LeitorDados.Controller;

namespace LeituraDeDadosExterno
{
    class Program
    {

        static CarrosController carrosController = new CarrosController();

        static void Main(string[] args)
        {

            Console.WriteLine("Leitor de Carros");
            MenuPrincipal();
            Console.ReadKey();

        }

        public static void MenuPrincipal()
        {
            var menuEscolhido = int.MinValue;
            //Aqui definimos se for diferente de 0 mantemos o sistema aberto se não finalizamos
            while (menuEscolhido != 0)
            {
                Console.Clear();

                //Mostra as opções de menu dentro do nosso sistema.
                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar Carros");
                Console.WriteLine("2 - Filtrar por data");

                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //Executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        //Realiza a chamada do menu de listagem de carros
                        MostrarCarros();
                        break;
                    case 2:
                        //Realiza a chamada do menu de filtro por data
                        FiltrarCarros();
                        break;
                }
            }
        }

        private static void FiltrarCarros()
        {
            throw new NotImplementedException();
        }

        private static void MostrarCarros()
        {
            carrosController.RetornaListaDeCarros().ForEach(i =>
                        //Para cada livro cadastrado temos a demostração no console por esta parte
                        Console.WriteLine($"Id {i.Id} Nome do livro:{i.Carro}"));

            Console.ReadKey();
        }
    }
}
