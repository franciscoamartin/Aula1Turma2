using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Boa vindas!");
            Console.WriteLine("-----------");
            Console.WriteLine("Digite seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine($"Seja bem vindo {nome}");
            Console.ReadKey();
        }
    }
}
