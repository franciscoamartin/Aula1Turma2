using System;
using MinhaBiblioteca;
using System.Globalization;
using static CrazyProjects.Program;
using System.Threading;

namespace InformacoesObtidas
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
            Console.ReadKey();
        }

        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu: ");
            Console.WriteLine("1 - Cálculo de área");
            Console.WriteLine("2 - Mostrar animação");
            Console.WriteLine("3 - Listar Cervejas");
            Console.WriteLine("4 - Listar Marca Carros");
            Console.WriteLine("5 - Sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch (menuEscolhido)
            {
                case 1:
                    CalculoArea();
                    Console.ReadKey();
                    Console.Clear();
                    MenuSistema();
                    break;
                case 2:
                    Iniciar();
                    Console.Clear();
                    MenuSistema();
                    break;
                case 3:
                    ListaCervejas.Cervejas();
                    break;
                case 4:
                    ListaCarros.ListarCarros();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(400);
                    Environment.Exit(0); break;
                default:
                    Console.WriteLine("Escolha um valor válido!");
                    break;
            }
        }
        //private static void Arvore()
        //{
        //    Iniciar();
        //}

        public static void CalculoArea()
        {
            Console.WriteLine("Informe o lado do quadrado: ");
            var ladoQuadrado = double.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"Minha area é {bibliotecaCalculos.CalculaAreaDoQuadrado(ladoQuadrado).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Enter para voltar ao Menu");
        }
        
    }
}
