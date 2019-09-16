using System;

namespace Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string entradaUsuario = Console.ReadLine();
            var textoFinal = entradaUsuario.Replace(" ", "");
            Console.WriteLine($"A quantidade de caracteres é: {textoFinal.Length}");
            Console.ReadKey();

        }
    }
}
