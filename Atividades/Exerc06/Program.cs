using System;

namespace Exerc06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto: ");
            var content = Console.ReadLine();

            var trocar = content.Replace("banana", "laranja");
            Console.WriteLine(trocar);
            Console.ReadKey();

        }
    }
}
    

