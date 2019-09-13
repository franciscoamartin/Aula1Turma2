using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string entradaUsuario = Console.ReadLine();

            Console.WriteLine($"O tamanho deste nome é: {entradaUsuario.Length}");
            Console.ReadKey();



        }
    }
}
