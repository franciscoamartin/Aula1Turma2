using System;
using System.Collections.Generic;
using static CrazyProjects.Program;
using System.Globalization;

namespace CrazyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine("Bem Vindo ao Crazy Project");
            Console.WriteLine();
            Console.WriteLine("Digite um número do Menu abaixo");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Visualizar uma árvore (1)");
            Console.WriteLine("Calcular área do quadrado (2)");
            Console.WriteLine("Listar Cervejas da AMBEV (3)");
            Console.WriteLine("Listar as Marcas de Carro (4)");
            Console.WriteLine("Sair do programa (5)");
            int resultado = int.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1:
                    Iniciar();   
                    //ArvoreFixa();
                    break;
                case 2:
                    Console.WriteLine("Digite um valor para calcular a área do quadrado: ");
                    CalcularQuadrado(double.Parse(Console.ReadLine()));
                    break;
                case 3:
                    ListaCervejas();
                    break;
                case 4:
                    MarcaDeCarros();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Digite um valor válido");
                    break;
            }
        }

        private static void ArvoreFixa()
        {
            Console.WriteLine("        *");
            Console.WriteLine("       ***");
            Console.WriteLine("      *****");
            Console.WriteLine("     ********");
            Console.WriteLine("    *********");
            Console.WriteLine("  *************");
            Console.WriteLine(" ****************");
            Console.WriteLine("******************");
            Console.WriteLine("      **");
            Console.WriteLine("      **");
            Console.WriteLine("      **");
            Console.WriteLine("      **");
            Console.WriteLine("      **");

        }
        private static void Arvore()
        {
            Iniciar();
        }

        private static void ListaCervejas()
        {
            List<string> cervejas = new List<string> { "Skol", "Brahma", "Antarctica", "Patagonia", "Stella Artois", "Skol", "Polar" };
            Console.WriteLine("Marcas de Cervejas AMBEV: ");

            foreach (var item in cervejas)

                Console.WriteLine(item);
            Console.WriteLine("--------------------------");
        }

        private static void CalcularQuadrado(double square)
        {
            square = square * square;
            Console.WriteLine("Resultado da área do quadrado: " + square);
            Console.WriteLine("--------------------------");
        }

        private static void MarcaDeCarros()
        {
            Console.WriteLine("Marca dos principais Carros: ");

            List<string> marcas = new List<string> { "Ford", "Tesla", "Volvo", "Fiat", "Kia", "Honda" };

            foreach (var item in marcas)

                Console.WriteLine(item);
            Console.WriteLine("--------------------------");
        }
    }
}

